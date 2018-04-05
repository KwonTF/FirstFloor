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

    public static string music;
    public static string difficult;
    public static Texture texture;
    public static VideoClip back;

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
        TotalResult.TotalData totalData = new TotalResult.TotalData(toResult, music, score, accuracy, rank.texture);
        TotalResult.totalDatas.Add(totalData);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.anyKeyDown)
        {
            if (accuracy < 30.0f)
            {
                SceneManager.LoadScene("GameOver");
            }
            else if (MusicSelect.stagenum >= 3)
            {
                SceneManager.LoadScene("totalResult");
            }
            else
            {
                SceneManager.LoadScene("MusicSelect");
                MusicSelect.stagenum++;
            }
        }
	}
}
