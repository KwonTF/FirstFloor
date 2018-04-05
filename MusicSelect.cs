using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class MusicSelect : MonoBehaviour {
    public static int stagenum;

    public VideoPlayer background;
    public RawImage screen;

    public RawImage normal;
    public RawImage hard;
    public RawImage extreme;

    public Texture normal_sel;
    public Texture hard_sel;
    public Texture extreme_sel;
    public Texture default_sel;

    public Text point;
    public Text point_1;
    public Text point_2;
    public Text point1;
    public Text point2;
    public Text level;
    public Text level_1;
    public Text level_2;
    public Text level1;
    public Text level2;
    public AudioSource backBG;

    int currentPoint = 0;
    int currentDifficulty = 0;
    public Data dataCenter;
    //DB at Data.Musics 
    void Start()
    {
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.DownArrow)){
            if (dataCenter.Musics.Count > (currentPoint + 1))
            {
                currentPoint++;
                init();
            }
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (currentPoint - 1 >= 0)
            {
                currentPoint--;
                init();
            }
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if(currentDifficulty > 0)
            {
                currentDifficulty--;
                init();
            }
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if(currentDifficulty < 2)
            {
                currentDifficulty++;
                init();
            }
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            GameStart(backBG.clip);
        }
    }
    public void init()
    {
        background.clip = dataCenter.Musics[currentPoint].bga_blur;
        screen.texture = dataCenter.Musics[currentPoint].list[currentDifficulty].catchParase;
        point.text = dataCenter.Musics[currentPoint].name;
        level.text = dataCenter.Musics[currentPoint].list[currentDifficulty].level.ToString();
        if(currentPoint - 2 < 0)
        {
            point_2.text = "-----";
            level_2.text = "--";
            if(currentPoint -1 < 0)
            {
                point_1.text = "-----";
                level_1.text = "--";
            }
            else
            {
                point_1.text = dataCenter.Musics[currentPoint - 1].name;
                level_1.text = dataCenter.Musics[currentPoint - 1].list[currentDifficulty].level.ToString();
            }
        }
        else
        {
            point_1.text = dataCenter.Musics[currentPoint - 1].name;
            level_1.text = dataCenter.Musics[currentPoint - 1].list[currentDifficulty].level.ToString();
            point_2.text = dataCenter.Musics[currentPoint - 2].name;
            level_2.text = dataCenter.Musics[currentPoint - 2].list[currentDifficulty].level.ToString();
        }
        if (dataCenter.Musics.Count < (currentPoint + 1) + 2)
        {
            point2.text = "-----";
            level2.text = "--";
            if (dataCenter.Musics.Count < (currentPoint + 1) + 1)
            {
                point1.text = "-----";
                level1.text = "--";
            }
            else
            {
                point1.text = dataCenter.Musics[currentPoint + 1].name;
                level1.text = dataCenter.Musics[currentPoint + 1].list[currentDifficulty].level.ToString();
            }
        }
        else
        {
            point1.text = dataCenter.Musics[currentPoint + 1].name;
            level1.text = dataCenter.Musics[currentPoint + 1].list[currentDifficulty].level.ToString();
            point2.text = dataCenter.Musics[currentPoint + 2].name;
            level2.text = dataCenter.Musics[currentPoint + 2].list[currentDifficulty].level.ToString();

        }
        backBG.clip = dataCenter.Musics[currentPoint].music;
        switch (currentDifficulty)
        {
            case 0:
                normal.texture = normal_sel;
                hard.texture = default_sel;
                extreme.texture = default_sel;
                break;
            case 1:
                normal.texture = default_sel;
                hard.texture = hard_sel;
                extreme.texture = default_sel;
                break;
            case 2:
                normal.texture = default_sel;
                hard.texture = default_sel;
                extreme.texture = extreme_sel;
                break;
        }
        backBG.Play();
    }
    public void GameStart(AudioClip MusicSelected)
    {
        MusicPlayer.SelectedMusic = MusicSelected;
        MusicPlayer.pattern = dataCenter.Musics[currentPoint].list[currentDifficulty].Notes;
        MusicPlayer.videoClip = dataCenter.Musics[currentPoint].bga;
        MusicPlayer.notesNum = dataCenter.Musics[currentPoint].list[currentDifficulty].max_combo;
        Result.music = dataCenter.Musics[currentPoint].name;
        Result.difficult = dataCenter.Musics[currentPoint].list[currentDifficulty].Difficulty;
        Result.texture = dataCenter.Musics[currentPoint].list[currentDifficulty].catchParase;
        Result.back = dataCenter.Musics[currentPoint].bga_blur;
        Result.toResult = dataCenter.Musics[currentPoint].list[currentDifficulty];
        SceneManager.LoadScene("GameScene");
    }
}
