using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoteCreate : MonoBehaviour {
    public static int combo = 0;
    public static int max_combo = 0;
    public static int perfect_num = 0;
    public static int great_num = 0;
    public static int nice_num = 0;
    public static int bad_num = 0;
    public static int miss_num = 0;
    public static int score = 0;
    public static float accuracy = 0.00f;
    static float accStack;
    
    static float lifeReducer;
    public static float life;

    static int missStack;
    public MusicPlayer musicPlayer;
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
    public List<Data.NoteInfo> noteTime = new List<Data.NoteInfo>();
    public Queue<GameObject> notes = new Queue<GameObject>();

    public GameObject Acc;
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
        //noteTime.Sort() 
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
        if (ModeSelector.Urban)
        {
            score = UrbanWait.score;
            combo = UrbanWait.combo;
            max_combo = UrbanWait.max_combo;
            life = UrbanWait.life_getter;

        }
    }
	public void init()
    {
        noteTime.Sort(delegate (Data.NoteInfo a, Data.NoteInfo b) {
            if (a.hitTime > b.hitTime) return 1;
            else if (a.hitTime < b.hitTime) return -1;
            else return 0;
        });
        temptime = 0;
        while (!(noteTime.Count == 0))
        {
            GameObject obj;
            obj = Instantiate(Note, Parent.transform);
            obj.GetComponent<NoteDrop>().hitTime = noteTime[0].hitTime +3;//delay+sync;
            obj.GetComponent<NoteDrop>().isLong = noteTime[0].isLong;
            obj.GetComponent<NoteDrop>().endTime = noteTime[0].endTime + 3;
            noteTime.RemoveAt(0);
            notes.Enqueue(obj);
        }
        lifeReducer = 100 / MusicPlayer.notesNum;
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
            if (temptime - tempNote.hitTime > 0.1)
            {
                Debug.Log("Miss (Time out)");
                Destroy(notes.Dequeue());
                miss_num++;
                combo = 0;
                accCal(0.0f);
                life -= (lifeReducer+missStack);
                missStack++;
                AccEff(0);
            }
            else if (tempNote.hitTime - temptime < 0.01 && MusicSelect.devMode)
            {
                Debug.Log("Perfect Auto");
                effector.GetComponent<ParticleSystem>().Play();
                Destroy(notes.Dequeue());
                perfect_num++;
                comboUpdate();
                accCal(100.0f);
                missStack = 0;
                AccEff(4);
            }
            if (Input.GetKeyDown(keyCode))
            {
                float calcTime = Mathf.Abs(tempNote.hitTime - temptime);
                if (0.09<calcTime &&calcTime<=0.1)
                {
                    Debug.Log("Bad:" + calcTime);
                    Destroy(notes.Dequeue());
                    bad_num++;
                    combo = 0;
                    accCal(30.0f);
                    life -= (lifeReducer+missStack) * 0.7f;
                    AccEff(1);
                }
                else if(0.08 <calcTime && calcTime <=0.09)
                {
                    Debug.Log("Good:" + calcTime);
                    Destroy(notes.Dequeue());
                    nice_num++;
                    comboUpdate();
                    accCal(50.0f);
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
                    accCal(70.0f);
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
                    accCal(100.0f);
                    missStack = 0;
                    AccEff(4);
                }
            }
        }
        //long note
        else if (tempNote.isLong)
        {
            if (temptime - tempNote.hitTime > 0.07 && longHold == null)
            {
                Debug.Log("Miss (Time out)");
                Destroy(notes.Dequeue());
                combo = 0;
                miss_num++;
                accCal(0.0f);
                life -= (lifeReducer+missStack)*2;
                missStack++;
                AccEff(0);

            }
            else if ((tempNote.hitTime - temptime < 0.01 && MusicSelect.devMode)&& longHold == null)
            {
                Debug.Log("Perfect: auto");
                longHold = "Perfect";
                comboUpdate();
                perfect_num++;
                accCal(100.0f);
                missStack = 0;
                AccEff(4);
                if (longHold != null)
                {
                    InvokeRepeating("longHolding", 0.1f, 0.1f);
                }
            }
            if (Input.GetKeyDown(keyCode)&& longHold == null)
            {
                float calcTime = Mathf.Abs(tempNote.hitTime - temptime);
                if (0.06 < calcTime && calcTime <= 0.07)
                {
                    Debug.Log("Bad:" + calcTime);
                    longHold = "Bad";
                    bad_num++;
                    combo = 0;
                    accCal(30.0f);
                    life -= (lifeReducer+missStack) * 0.7f;
                    AccEff(1);

                }
                else if (0.05 < calcTime && calcTime <= 0.06)
                {
                    Debug.Log("Good:" + calcTime);
                    longHold = "Good";
                    nice_num++;
                    comboUpdate();
                    accCal(50.0f);
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
                    accCal(70.0f);
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
                    accCal(100.0f);
                    missStack = 0;
                    AccEff(4);
                }
                if(longHold != null)
                {
                    InvokeRepeating("longHolding",0.1f,0.1f);
                }
            }
            if (temptime - tempNote.endTime > 0.1 && longHold!=null)
            {
                Debug.Log("Miss (Hold too Long)");
                Destroy(notes.Dequeue());
                CancelInvoke("longHolding");
                combo = 0;
                accCal(0.0f);
                miss_num++;
                life -= lifeReducer+missStack;
                missStack++;
                AccEff(0);
                longHold = null;
                return;
            }
            else if ((tempNote.endTime - temptime < 0.01 &&MusicSelect.devMode)&& longHold != null)
            {
                Debug.Log("Perfect:auto" );
                effector.GetComponent<ParticleSystem>().Play();
                Destroy(notes.Dequeue());
                perfect_num++;
                comboUpdate();
                missStack = 0;
                accCal(100.0f);
                AccEff(4);
                CancelInvoke("longHolding");
                longHold = null;
                return;
            }
            else if (Input.GetKeyUp(keyCode) && longHold != null)
            {
                if (tempNote.endTime - temptime > 0.09)
                {
                    Debug.Log("Miss (Early)");
                    Destroy(notes.Dequeue());
                    combo = 0;
                    miss_num++;
                    accCal(0.0f);
                    life -= lifeReducer+missStack;
                    missStack++;
                    AccEff(0);
                }
                float calcTime = Mathf.Abs(tempNote.endTime - temptime);
                if (0.09 < calcTime && calcTime <= 0.08)
                {
                    Debug.Log("Bad:" + calcTime);
                    Destroy(notes.Dequeue());
                    bad_num++;
                    combo = 0;
                    accCal(30.0f);
                    life -= (lifeReducer+missStack) * 0.7f;
                    AccEff(1);
                }
                else if (0.08 < calcTime && calcTime <= 0.07)
                {
                    Debug.Log("Good:" + calcTime);
                    Destroy(notes.Dequeue());
                    nice_num++;
                    comboUpdate();
                    accCal(50.0f);
                    life -= lifeReducer * 0.5f;
                    missStack = 0;
                    AccEff(2);
                }
                else if (0.07 < calcTime && calcTime <= 0.06)
                {
                    Debug.Log("Great:" + calcTime);
                    effector.GetComponent<ParticleSystem>().Play();
                    Destroy(notes.Dequeue());
                    great_num++;
                    comboUpdate();
                    accCal(70.0f);
                    life -= lifeReducer * 0.3f;
                    missStack = 0;
                    AccEff(3);
                }
                else if (calcTime <= 0.06 )
                {
                    Debug.Log("Perfect:" + calcTime);
                    effector.GetComponent<ParticleSystem>().Play();
                    Destroy(notes.Dequeue());
                    perfect_num++;
                    comboUpdate();
                    missStack = 0;
                    accCal(100.0f);
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
        }
    }
    void accCal(float percentage)
    {
        accStack += percentage;
        accuracy = accStack / (float)MusicPlayer.notesNum;
        score += (int)(200.0f*(percentage / 100.0f)*(1.0f+combo/100.0f));
    }
    void comboUpdate()
    {
        combo++;
        if(combo > max_combo)
        {
            max_combo = combo;
        }

        musicPlayer.comboEff();
    }
    void AccEff(int acc)
    {
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
    }
}
