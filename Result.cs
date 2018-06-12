using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class Result : MonoBehaviour {
    public static int perfect;
    public static int great;
    public static int nice;
    public static int bad;
    public static int miss;

    public static int max_combo;
    public static int score;
    public static float accuracy;

    public static float life_getter;
    public static string music;
    public static string difficult;
    public static Texture texture;
    public static VideoClip back;
    public AudioSource audioSource;
    public static Data.Playdata toResult;

    public Text perfect_text;
    public Text great_text;
    public Text nice_text;
    public Text bad_text;
    public Text miss_text;

    public Text max_combo_text;
    public Text score_text;
    public Text accuracy_text;
    public Text music_text;
    public RawImage screen;
    public VideoPlayer player;

    public RawImage rank;

    public Texture S;
    public Texture A;
    public Texture B;
    public Texture C;
    public Texture D;
    public Texture F;

    public RawImage fader;
    string nextScene;
    // Use this for initialization
    void Start () {
        perfect_text.text = perfect.ToString();
        great_text.text = great.ToString();
        nice_text.text = nice.ToString();
        bad_text.text = bad.ToString();
        miss_text.text = miss.ToString();

        max_combo_text.text = max_combo.ToString();
        score_text.text = score.ToString();
        accuracy_text.text = accuracy.ToString("N2");
        music_text.text = music + "/" + difficult;
        screen.texture = texture;
        player.clip = back;
        if(accuracy >= 95)
        {
            rank.texture = S;
        }
        else if(accuracy <95 && accuracy >= 93)
        {
            rank.texture = A;
        }
        else if (accuracy < 93 && accuracy >= 90)
        {
            rank.texture = B;
        }
        else if (accuracy < 90 && accuracy >= 80)
        {
            rank.texture = C;
        }
        else if (accuracy < 80 && accuracy >= 70)
        {
            rank.texture = D;
        }
        else
        {
            rank.texture = F;
            
        }
        //if (!ModeSelector.Urban)
        //{
            TotalResult.TotalData totalData = new TotalResult.TotalData(toResult, music, score, accuracy, rank.texture);
            TotalResult.totalDatas.Add(totalData);
        //}
        if(accuracy < 30.0f || life_getter <= 0)
        {
            audioSource.Stop();
        }
        else
        {
            audioSource.Play();
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (accuracy < 30.0f || life_getter <= 0.0f)
            {
                nextScene = "GameOver";
            }
            else if (!ModeSelector.Urban) { 
                if (MusicSelect.stagenum >= 3)
                {
                    nextScene = "totalResult";
                }
                else
                {
                    nextScene = "MusicSelect";
                    MusicSelect.stagenum++;
                }
            }
            else if (ModeSelector.Urban)
            {
                if (UrbanWait.stageNum >= 3)
                {
                    nextScene = "UrbanTotal";
                }
                else
                {
                    nextScene = "UrbanWating";
                    UrbanWait.stageNum++;
                    UrbanWait.life_getter = life_getter;
                    UrbanWait.musicAcc.Add(accuracy);
                    UrbanWait.max_combo = max_combo;
                    UrbanWait.combo = NoteCreate.combo;
                    UrbanWait.score += score;
                    float temp = 0.00f;
                    foreach (float index in UrbanWait.musicAcc)
                    {
                        temp += index;
                    }
                    Debug.Log(temp);
                    UrbanWait.acc = temp / UrbanWait.musicAcc.Count;
                    Debug.Log(UrbanWait.acc);
                }
            }
            InvokeRepeating("dissolve", 0f, 0.05f);
        }
	}

    public void dissolve()
    {
        if (fader.color.a < 2.5f)
        {
            Color temp = fader.color;
            temp.a += 0.1f;
            fader.color = temp;
        }
        else
        {
            toSelect(nextScene);
        }
    }
    public void toSelect(string name)
    {
        SceneManager.LoadScene(name);
    }
}
