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
    public Text comboNum;
    public GameObject lifebar;
    Vector2 lifeorigin;

    public Text Score;
    public Text MaxCombo;
    // Use this for initialization
    void Start () {
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
                    Debug.Log("Missing note Detected!");
                    break;
            }
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
        s.dissolve();
        hidfunc.init(info,diff);
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
            SceneManager.LoadScene("Result");

        }
        lifebar.GetComponent<RectTransform>().sizeDelta = new Vector2(lifeorigin.x, lifeorigin.y * NoteCreate.life/100);
	}

    void start()
    {
        GetComponent<AudioSource>().Play();
        GetComponent<VideoPlayer>().Play();
    }
}
