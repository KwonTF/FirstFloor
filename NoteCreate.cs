﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoteCreate : MonoBehaviour {
    static int combo = 0;
    public static int max_combo = 0;
    public static int perfect_num = 0;
    public static int great_num = 0;
    public static int nice_num = 0;
    public static int bad_num = 0;
    public static int miss_num = 0;
    public static int score = 0;
    public static float accuracy = 0.00f;
    public GameObject combo_num_vis;
    public GameObject combo_vis;

    Vector3 opos;
    Vector3 temppos;
    Color ocol;
    Color tempcol;
    static float accStack;
    
    static float lifeReducer;
    public static float life;

    static int missStack;

    /*For alpha notes
     * struct NoteInfo
    {
        public bool isLong;
        public float hitTime;
        public float endTime;
        public NoteInfo(bool p1, float p2, float p3)
        {
            isLong = p1;
            hitTime = p2;
            endTime = p3;
        }
    }*/
    public KeyCode keyCode;
    public GameObject Note;
    public GameObject Parent;
    public GameObject effector;
    private float temptime;
    string longHold = null;
    public Queue<Data.NoteInfo> noteTime = new Queue<Data.NoteInfo>();
    public Queue<GameObject> notes = new Queue<GameObject>();

    public GameObject Acc;
     Vector2 Accsize;
     Vector2 accstemp;
     Color acccoltemp;
    public Texture Best;
    public Texture Great;
    public Texture Good;
    public Texture Bad;
    public Texture Miss;

    // Use this for initialization
    void Start () {
        /*Initial alpha notes
         * NoteInfo tempnote = new NoteInfo(false, 2.0f , 0);
        NoteInfo tempnote2 = new NoteInfo(false, 2.3f, 0);
        NoteInfo tempLong = new NoteInfo(true, 2.6f, 3.6f);
        noteTime.Enqueue(tempnote);
        noteTime.Enqueue(tempnote2);
        noteTime.Enqueue(tempLong);*/
        life = 100;
        score = 0;
        accStack = 0.0f;
        missStack = 0;
        max_combo = 0;
        perfect_num = 0;
        great_num = 0;
        nice_num = 0;
        bad_num = 0;
        miss_num = 0;
        combo = 0;
    opos = combo_num_vis.GetComponent<RectTransform>().position;
        opos.y = opos.y - 30;
    }
	public void init()
    {
        temptime = 0;
        while (!(noteTime.Count == 0))
        {
            GameObject obj;
            obj = Instantiate(Note, Parent.transform);
            obj.GetComponent<NoteDrop>().hitTime = noteTime.Peek().hitTime +3+0.07f;//delay+sync;
            obj.GetComponent<NoteDrop>().isLong = noteTime.Peek().isLong;
            obj.GetComponent<NoteDrop>().endTime = noteTime.Dequeue().endTime + 3;
            notes.Enqueue(obj);
        }
        lifeReducer = 100 / MusicPlayer.notesNum;

        ocol = combo_num_vis.GetComponent<Text>().color;
        ocol.a = ocol.a - 0.6f;
        Acc.GetComponent<RawImage>().color = new Color(1f, 1f, 1f, 0f);
        Accsize = Acc.GetComponent<RectTransform>().sizeDelta;
    }
	// Update is called once per frame
	void Update () {
        temptime += Time.deltaTime;
        NoteDrop tempNote = null;
        //Call nextnote;
        if (notes.Count > 0 && notes.Peek() == null)
        {
            notes.Dequeue();
        }
        else if(notes.Count > 0 && notes.Peek() != null)
        {
            tempNote = notes.Peek().GetComponent<NoteDrop>();
        }
        else
        {
            tempNote = null;
            return;
        }
        if (tempNote == null)
        {
            return;
        }
        //Hit

        //Short Note
        if (!(tempNote.isLong))
        {
            if(temptime - tempNote.hitTime > 0.1)
            {
                Debug.Log("Miss (Time out)");
                Destroy(notes.Dequeue());
                miss_num++;
                combo = 0;
                accCal(0);
                life -= (lifeReducer+missStack);
                missStack++;
                AccEff(0);
            }
            if (Input.GetKeyDown(keyCode))
            {
                float calcTime = Mathf.Abs(tempNote.hitTime - temptime);
                if(0.09<calcTime &&calcTime<=0.1)
                {
                    Debug.Log("Bad:" + calcTime);
                    Destroy(notes.Dequeue());
                    bad_num++;
                    combo = 0;
                    accCal(30);
                    life -= (lifeReducer+missStack) * 0.7f;
                    AccEff(1);
                }
                else if(0.08 <calcTime && calcTime <=0.09)
                {
                    Debug.Log("Good:" + calcTime);
                    Destroy(notes.Dequeue());
                    nice_num++;
                    comboUpdate();
                    accCal(50);
                    life -= lifeReducer * 0.5f;
                    missStack = 0;
                    AccEff(2);
                }
                else if (0.06 < calcTime && calcTime <= 0.08)
                {
                    Debug.Log("Great:" + calcTime);
                    effector.GetComponent<ParticleSystem>().Play();
                    Destroy(notes.Dequeue());
                    great_num++;
                    comboUpdate();
                    accCal(70);
                    life -= lifeReducer * 0.3f;
                    missStack = 0;
                    AccEff(3);
                }
                else if (calcTime <= 0.06)
                {
                    Debug.Log("Perfect:" + calcTime);
                    effector.GetComponent<ParticleSystem>().Play();
                    Destroy(notes.Dequeue());
                    perfect_num++;
                    comboUpdate();
                    accCal(100);
                    missStack = 0;
                    AccEff(4);
                }
            }
        }
        else if (tempNote.isLong)
        {
            if (temptime - tempNote.hitTime > 0.07 && longHold == null)
            {
                Debug.Log("Miss (Time out)");
                Destroy(notes.Dequeue());
                combo = 0;
                miss_num++;
                accCal(0);
                life -= (lifeReducer+missStack)*2;
                missStack++;
                AccEff(0);

            }
            if (Input.GetKeyDown(keyCode) && longHold == null)
            {
                float calcTime = Mathf.Abs(tempNote.hitTime - temptime);
                if (0.06 < calcTime && calcTime <= 0.07)
                {
                    Debug.Log("Bad:" + calcTime);
                    longHold = "Bad";
                    bad_num++;
                    combo = 0;
                    accCal(30);
                    life -= (lifeReducer+missStack) * 0.7f;
                    AccEff(1);

                }
                else if (0.05 < calcTime && calcTime <= 0.06)
                {
                    Debug.Log("Good:" + calcTime);
                    longHold = "Good";
                    nice_num++;
                    comboUpdate();
                    accCal(50);
                    life -= lifeReducer * 0.5f;
                    missStack = 0;
                    AccEff(2);
                }
                else if (0.04 < calcTime && calcTime <= 0.05)
                {
                    Debug.Log("Great:" + calcTime);
                    longHold = "Great";
                    great_num++;
                    comboUpdate();
                    accCal(70);
                    life -= lifeReducer * 0.3f;
                    missStack = 0;
                    AccEff(3);
                }
                else if (calcTime <= 0.04)
                {
                    Debug.Log("Perfect:" + calcTime);
                    longHold = "Perfect";
                    comboUpdate();
                    perfect_num++;
                    accCal(100);
                    missStack = 0;
                    AccEff(4);
                }
                if(longHold != null)
                {
                    InvokeRepeating("longHolding",0.1f, 0.1f);
                }
            }
            if (temptime - tempNote.endTime > 0.07 && longHold!=null)
            {
                Debug.Log("Miss (Hold too Long)");
                Destroy(notes.Dequeue());
                CancelInvoke("longHolding");
                combo = 0;
                accCal(0);
                miss_num++;
                life -= lifeReducer+missStack;
                missStack++;
                AccEff(0);
                return;
            }
            else if (Input.GetKeyUp(keyCode) && longHold != null)
            {
                if (tempNote.endTime - temptime > 0.07)
                {
                    Debug.Log("Miss (Early)");
                    Destroy(notes.Dequeue());
                    combo = 0;
                    miss_num++;
                    accCal(0);
                    life -= lifeReducer+missStack;
                    missStack++;
                    AccEff(0);
                }
                float calcTime = Mathf.Abs(tempNote.endTime - temptime);
                if (0.06 < calcTime && calcTime <= 0.07)
                {
                    Debug.Log("Bad:" + calcTime);
                    Destroy(notes.Dequeue());
                    bad_num++;
                    combo = 0;
                    accCal(30);
                    life -= (lifeReducer+missStack) * 0.7f;
                    AccEff(1);
                }
                else if (0.05 < calcTime && calcTime <= 0.06)
                {
                    Debug.Log("Good:" + calcTime);
                    Destroy(notes.Dequeue());
                    nice_num++;
                    comboUpdate();
                    accCal(50);
                    life -= lifeReducer * 0.5f;
                    missStack = 0;
                    AccEff(2);
                }
                else if (0.04 < calcTime && calcTime <= 0.05)
                {
                    Debug.Log("Great:" + calcTime);
                    effector.GetComponent<ParticleSystem>().Play();
                    Destroy(notes.Dequeue());
                    great_num++;
                    comboUpdate();
                    accCal(70);
                    life -= lifeReducer * 0.3f;
                    missStack = 0;
                    AccEff(3);
                }
                else if (calcTime <= 0.04)
                {
                    Debug.Log("Perfect:" + calcTime);
                    effector.GetComponent<ParticleSystem>().Play();
                    Destroy(notes.Dequeue());
                    perfect_num++;
                    comboUpdate();
                    missStack = 0;
                    accCal(100);
                    AccEff(4);
                }
                CancelInvoke("longHolding");
                longHold = null;
            }
        }
	}
    void longHolding()
    {
        if(longHold != null)
        {
            effector.GetComponent<ParticleSystem>().Play();
            comboUpdate();
            AccEff(5);
            Debug.Log(longHold);
        }
    }
    void accCal(float percentage)
    {
        accStack += percentage;
        accuracy = accStack / (float)MusicPlayer.notesNum;
        score += (int)(200*(percentage / 100)*(1.0f+combo/100));
    }
    void comboUpdate()
    {
        combo++;
        if(combo > max_combo)
        {
            max_combo = combo;
        }
        combo_num_vis.GetComponent<Text>().text = combo.ToString();

        CancelInvoke("comboeffect");
        CancelInvoke("dissolve");
        Color temp = combo_num_vis.GetComponent<Text>().color;
        temp.a = 0.5f;
        combo_num_vis.GetComponent<Text>().color = temp;

        temp = combo_vis.GetComponent<Text>().color;
        temp.a = 0.6f;
        combo_vis.GetComponent<Text>().color = temp;


        temppos = opos;
        tempcol = ocol;
        combo_num_vis.GetComponent<RectTransform>().position = temppos;
        combo_num_vis.GetComponent<Text>().color = tempcol;
        InvokeRepeating("comboeffect", 0, 0.05f);
    }
    void comboeffect()
    {
        temppos.y += 10;
        combo_num_vis.GetComponent<RectTransform>().position = temppos;
        tempcol.a += 0.2f;
        combo_num_vis.GetComponent<Text>().color = tempcol;
        if (temppos.y - opos.y >= 30)
        {
            CancelInvoke("comboeffect");
            Invoke("dissolve", 2.0f);
        }
    }
    public void dissolve()
    {
        Color temp = combo_num_vis.GetComponent<Text>().color;
        temp.a = 0;
        combo_num_vis.GetComponent<Text>().color = temp;
        temp = combo_vis.GetComponent<Text>().color;
        temp.a = 0;
        combo_vis.GetComponent<Text>().color = temp;
        Acc.GetComponent<RawImage>().color = new Color(1f, 1f, 1f, 0f);
    }

    void AccEff(int acc)
    {
        CancelInvoke("AccEffOn");
        CancelInvoke("dissolve");
        Acc.GetComponent<RawImage>().color = new Color(1f, 1f, 1f, 0.3f);
        Acc.GetComponent<RectTransform>().sizeDelta = Accsize;
        acccoltemp = Acc.GetComponent<RawImage>().color;
        accstemp = Acc.GetComponent<RectTransform>().sizeDelta;
        switch (acc)
        {
            case 0:
                Acc.GetComponent<RawImage>().texture = Miss;
                break;
            case 1:
                Acc.GetComponent<RawImage>().texture = Bad;
                break;
            case 2:
                Acc.GetComponent<RawImage>().texture = Good;
                break;
            case 3:
                Acc.GetComponent<RawImage>().texture = Great;
                break;
            case 4:
                Acc.GetComponent<RawImage>().texture = Best;
                break;
            default:
                break;
        }
        InvokeRepeating("AccEffOn", 0, 0.05f);
    }
    void AccEffOn()
    {
        acccoltemp.a += 0.1f;
        accstemp.x += 10;
        accstemp.y += 3;
        Acc.GetComponent<RectTransform>().sizeDelta = accstemp;
        Acc.GetComponent<RawImage>().color = acccoltemp;
        if (acccoltemp.a >= 0.6f)
        {
            CancelInvoke("AccEffOn");
            Invoke("dissolve", 2.0f);
        }
    }
}
