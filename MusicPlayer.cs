using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
public class MusicPlayer : MonoBehaviour {
    public static AudioClip SelectedMusic;
    public static List<Data.NoteInfo> pattern;
    public static VideoClip videoClip;
    public static Data.MusicInfo info;
    public static string diff;
    bool bonusUsed;
    public static bool bonusActivated;
    public HiddenControl hidfunc;

    public NoteCreate s;
    public NoteCreate l;
    //List<Data.NoteInfo> s;
    public NoteCreate d;
    public NoteCreate f;
    public NoteCreate j;
    public NoteCreate k;
    public NoteCreate q;
    public NoteCreate p;
    public NoteCreate a;
    public NoteCreate semicolmn;
    public NoteCreate space;
    public static int notesNum;

    public Text combo;
    public GameObject comboNum;
    public GameObject lifebar;
    public GameObject Acc;
    Vector2 lifeorigin;

    public Text Score;
    public Text MaxCombo;
    //tempdata
    Vector3 opos;
    Vector3 temppos;
    Color ocol;
    Color tempcol;
    Vector2 Accsize;
    Vector2 accstemp;
    Color acccoltemp;
    public RawImage fader;
    public RawImage bonusImage;

    int cType;
    Color cTemp;
    public Texture cAct;
    public RawImage bon;
    // Use this for initialization 6309
    void Start () {
        bonusUsed = false;
        bonusActivated = false;
        int missing = 0;
       foreach(Data.NoteInfo note in pattern)
        {
            switch (note.notePos)
            {
                case "s":
                    s.noteTime.Add(note);
                    break;
                case "d":
                    d.noteTime.Add(note);
                    break;
                case "f":
                    f.noteTime.Add(note);
                    break;
                case "j":
                    j.noteTime.Add(note);
                    break;
                case "k":
                    k.noteTime.Add(note);
                    break;
                case "l":
                    l.noteTime.Add(note);
                    break;
                case "q":
                    q.noteTime.Add(note);
                    break;
                case "a":
                    a.noteTime.Add(note);
                    break;
                case "p":
                    p.noteTime.Add(note);
                    break;
                case ";":
                    semicolmn.noteTime.Add(note);
                    break;
                case "space":
                    space.noteTime.Add(note);
                    break;
                default:
                    Debug.Log("Missing note Detected!: Around "+missing.ToString());
                    break;
            }
            missing++;
        }
        GetComponent<AudioSource>().clip = SelectedMusic;
        s.init();
        d.init();
        f.init();
        j.init();
        k.init();
        l.init();
        q.init();
        a.init();
        p.init();
        
        semicolmn.init();
        space.init();
        Invoke("start", 3.0f);
        GetComponent<VideoPlayer>().clip = videoClip;
        lifeorigin = lifebar.GetComponent<RectTransform>().sizeDelta;
        hidfunc.init(info,diff);
        //Effect Refactoring
        opos = comboNum.GetComponent<RectTransform>().position;
        opos.y = opos.y - 30;
        ocol = new Color(1f, 1f, 1f, 0.4f);
        Acc.GetComponent<RawImage>().color = new Color(1f, 1f, 1f, 0f);
        Accsize = Acc.GetComponent<RectTransform>().sizeDelta;
    }
	
	// Update is called once per frame
	void Update () {
        Score.text = NoteCreate.score.ToString();
        MaxCombo.text = NoteCreate.max_combo.ToString();
        if (GetComponent<AudioSource>().time >= GetComponent<AudioSource>().clip.length || NoteCreate.life <= 0)
        {
            Result.max_combo = NoteCreate.max_combo;
            Result.miss = NoteCreate.miss_num;
            Result.bad = NoteCreate.bad_num;
            Result.nice = NoteCreate.nice_num;
            Result.great = NoteCreate.great_num;
            Result.perfect = NoteCreate.perfect_num;
            Result.score = NoteCreate.score;
            Result.accuracy = NoteCreate.accuracy;
            Result.life_getter = NoteCreate.life;
            InvokeRepeating("endGame", 0f, 0.05f);

        }
        lifebar.GetComponent<RectTransform>().sizeDelta = new Vector2(lifeorigin.x, lifeorigin.y * NoteCreate.life/100);

        if (!bonusUsed && NoteCreate.score >= 39765)
        {
            bon.color = new Color(2.5f, 2.5f, 2.5f, 2.3f);
            if (Input.GetKeyDown(KeyCode.T) || Input.GetKeyDown(KeyCode.Y))
            {
                bonusUsed = true;
                bonusActivated = true;
                Invoke("bonusEnded", 10.0f);
                bonusImage.color = new Color(2.5f, 0.0f, 0.0f, 2.3f);
                cType = 0;
                bon.texture = cAct;
            }
        }
        if (bonusActivated)
        {
            switch (cType)
            {
                case 0:
                    cTemp = bonusImage.color;
                    cTemp.g+=0.1f;
                    bonusImage.color = cTemp;
                    if(cTemp.g >= 2.5f)
                    {
                        cType++;
                    }
                    break;
                case 1:
                    cTemp = bonusImage.color;
                    cTemp.r -= 0.1f;
                    bonusImage.color = cTemp;
                    if (cTemp.r <= 0.0f)
                    {
                        cType++;
                    }
                    break;
                case 2:
                    cTemp = bonusImage.color;
                    cTemp.b += 0.1f;
                    bonusImage.color = cTemp;
                    if (cTemp.b >= 2.5f)
                    {
                        cType++;
                        Debug.Log("Cc");
                    }
                    break;
                case 3:
                    cTemp = bonusImage.color;
                    cTemp.g -= 0.1f;
                    bonusImage.color = cTemp;
                    if (cTemp.g <= 0.0f)
                    {
                        cType++;
                    }
                    break;
                case 4:
                    cTemp = bonusImage.color;
                    cTemp.r += 0.1f;
                    bonusImage.color = cTemp;
                    if (cTemp.r >= 2.5f)
                    {
                        cType++;
                    }
                    break;
                case 5:
                    cTemp = bonusImage.color;
                    cTemp.b -= 0.1f;
                    bonusImage.color = cTemp;
                    if (cTemp.b <= 0.0f)
                    {
                        cType = 0;
                    }
                    break;
            }
        }
	}
    public void bonusEnded()
    {
        bonusActivated = false;
        bonusImage.color = new Color(2.5f, 0.0f, 0.0f, 0.0f);
        bon.color = new Color(2.5f, 2.5f, 2.5f, 0.0f);
    }
    void start()
    {
        GetComponent<AudioSource>().Play();
        GetComponent<VideoPlayer>().Play();
    }
    //effect
    public void comboEff()
    {
        comboNum.GetComponent<Text>().text = NoteCreate.combo.ToString();
        CancelInvoke("dissolve");
        CancelInvoke("motionEff");
        Color temp;
        if (combo.color.a != 0.6f)
        {
            temp = combo.color;
            temp.a = 0.6f;
            combo.color = temp;
        }
        temppos = opos;
        tempcol = ocol;
        comboNum.GetComponent<RectTransform>().position = temppos;
        comboNum.GetComponent<Text>().color = tempcol;

        Acc.GetComponent<RawImage>().color = new Color(1f, 1f, 1f, 0.3f);
        Acc.GetComponent<RectTransform>().sizeDelta = Accsize;
        acccoltemp = Acc.GetComponent<RawImage>().color;
        accstemp = Acc.GetComponent<RectTransform>().sizeDelta;

        InvokeRepeating("motionEff", 0, 0.05f);
        Invoke("dissolve",1.0f);
    }
    public void motionEff()
    {
        //comnum
        temppos.y += 10;
        comboNum.GetComponent<RectTransform>().position = temppos;
        tempcol.a += 0.2f;
        comboNum.GetComponent<Text>().color = tempcol;
        //acc
        acccoltemp.a += 0.1f;
        accstemp.x += 10;
        accstemp.y += 3;
        Acc.GetComponent<RectTransform>().sizeDelta = accstemp;
        Acc.GetComponent<RawImage>().color = acccoltemp;
        if (temppos.y - opos.y >= 30)
        {
            CancelInvoke("motionEff");
        }
    }
    public void dissolve()
    {
        Color temp = combo.color;
        temp.a = 0.0f;
        //base 150
        combo.color = temp;
        //base 200
        comboNum.GetComponent<Text>().color = temp;
        //base 255
        Acc.GetComponent<RawImage>().color = new Color(1f, 1f, 1f, 0f);
    }

    public void endGame()
    {
        if (fader.color.a < 2.5f)
        {
            Color temp = fader.color;
            temp.a += 0.1f;
            fader.color = temp;
        }
        else
        {
            toSelect("Result");
        }
    }
    public void toSelect(string name)
    {
        SceneManager.LoadScene(name);
    }

}
