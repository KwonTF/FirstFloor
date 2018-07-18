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
    public Text composer;
    public Text visualizer;
    int currentPoint = 0;
    int currentDifficulty = 0;
    public Data dataCenter;
    public Text stagenumtext;
    public static bool devMode;
    public Text speedText;
    public RawImage fader;

    public RawImage devdev;
    public Texture devon;
    public Texture devoff;

    private float speed;
    //DB at Data.Musics 
    void Start()
    {
        devMode = false;
        switch(stagenum){
            case 1:
                stagenumtext.text = "1st Stage";
                break;
            case 2:
                stagenumtext.text = "2nd Stage";
                break;
            case 3:
                stagenumtext.text = "3rd Stage";
                break;
            default:
                break;
        }
        speed = 5.0f;
        speedText.text = speed.ToString("N1")+"x";
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow)) {
            if (dataCenter.Musics.Count > (currentPoint + 1))
            {
                currentPoint++;
                init();
                backBG.Play();
            }
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (currentPoint - 1 >= 0)
            {
                currentPoint--;
                init();
                backBG.Play();
            }
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (currentDifficulty > 0)
            {
                currentDifficulty--;
                init();
            }
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (currentDifficulty < 2)
            {
                currentDifficulty++;
                init();
            }
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            GameStart(backBG.clip);
        }
        else if (Input.GetKeyDown(KeyCode.Q) || Input.GetKeyDown(KeyCode.P))
        {
            if (speed >= 10.0f)
            {
                speed = 10.0f;
            }
            else
            {
                speed += 0.1f;
            }
            speedText.text = speed.ToString("N1") + "x";
        }
        else if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.Semicolon))
        {
            if (speed <= 1.0f)
            {
                speed = 1.0f;
            }
            else
            {
                speed -= 0.1f;
            }
            speedText.text = speed.ToString("N1")+"x";
        }
        else if (Input.GetKeyDown(KeyCode.F2))
        {
            devMode = !devMode;
            devDev(devMode);
        }
    }
    public void init()
    {
        background.clip = dataCenter.Musics[currentPoint].bga_blur;
        screen.texture = dataCenter.Musics[currentPoint].list[currentDifficulty].catchParase;
        point.text = dataCenter.Musics[currentPoint].name;
        level.text = dataCenter.Musics[currentPoint].list[currentDifficulty].level.ToString();
        composer.text = dataCenter.Musics[currentPoint].composer;
        visualizer.text = dataCenter.Musics[currentPoint].visualizer;
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
    }
    public void GameStart(AudioClip MusicSelected)
    {
        switch(dataCenter.Musics[currentPoint].key)
        {
            case 0:
                dataCenter.immortal.getNote(dataCenter.Musics[currentPoint].list[currentDifficulty]);
                break;
            case 1:
                dataCenter.kamui.getNote(dataCenter.Musics[currentPoint].list[currentDifficulty]);
                break;
            case 2:
                dataCenter.motivity.getNote(dataCenter.Musics[currentPoint].list[currentDifficulty]);
                break;
            case 3:
                dataCenter.whiteblue.getNote(dataCenter.Musics[currentPoint].list[currentDifficulty]);
                break;
            case 4:
                dataCenter.brandnew_Days.getNote(dataCenter.Musics[currentPoint].list[currentDifficulty]);
                break;
            case 5:
                dataCenter.sapphire.getNote(dataCenter.Musics[currentPoint].list[currentDifficulty]);
                break;
            case 6:
                dataCenter.talesRemix.getNote(dataCenter.Musics[currentPoint].list[currentDifficulty]);
                break;
            case 7:
                dataCenter.entire.getNote(dataCenter.Musics[currentPoint].list[currentDifficulty]);
                break;
            case 8:
                dataCenter.lazyDays.getNote(dataCenter.Musics[currentPoint].list[currentDifficulty]);
                break;
            case 9:
                dataCenter.deborah.getNote(dataCenter.Musics[currentPoint].list[currentDifficulty]);
                break;
            case 10:
                dataCenter.aLie_Deep.getNote(dataCenter.Musics[currentPoint].list[currentDifficulty]);
                break;
            case 11:
                dataCenter.For_Seasons_AGM.getNote(dataCenter.Musics[currentPoint].list[currentDifficulty]);
                break;
            case 12:
                dataCenter.waiting_Sun.getNote(dataCenter.Musics[currentPoint].list[currentDifficulty]);
                break;
            case 13:
                dataCenter.houseplan.getNote(dataCenter.Musics[currentPoint].list[currentDifficulty]);
                break;
            case 14:
                dataCenter.nothing.getNote(dataCenter.Musics[currentPoint].list[currentDifficulty]);
                break;
            case 15:
                dataCenter.liquid_Cube.getNote(dataCenter.Musics[currentPoint].list[currentDifficulty]);
                break;
            case 16:
                dataCenter.How_To_Enjoy.getNote(dataCenter.Musics[currentPoint].list[currentDifficulty]);
                break;
            case 17:
                dataCenter.tracking_Down.getNote(dataCenter.Musics[currentPoint].list[currentDifficulty]);
                break;
            case 18:
                dataCenter.enjoy_.getNote(dataCenter.Musics[currentPoint].list[currentDifficulty]);
                break;
            case 19:
                dataCenter.heaven_Tonight.getNote(dataCenter.Musics[currentPoint].list[currentDifficulty]);
                break;
            case 20:
                dataCenter.love_.getNote(dataCenter.Musics[currentPoint].list[currentDifficulty]);
                break;
            case 100:
                dataCenter.test.getNote(dataCenter.Musics[currentPoint].list[currentDifficulty]);
                break;
            default:
                break;
        }
        MusicPlayer.SelectedMusic = MusicSelected;
        MusicPlayer.pattern = dataCenter.Musics[currentPoint].list[currentDifficulty].Notes;
        MusicPlayer.videoClip = dataCenter.Musics[currentPoint].bga;
        MusicPlayer.notesNum = dataCenter.Musics[currentPoint].list[currentDifficulty].max_combo;
        MusicPlayer.info = dataCenter.Musics[currentPoint];
        MusicPlayer.diff = dataCenter.Musics[currentPoint].list[currentDifficulty].Difficulty;
        Result.music = dataCenter.Musics[currentPoint].name;
        Result.difficult = dataCenter.Musics[currentPoint].list[currentDifficulty].Difficulty;
        Result.texture = dataCenter.Musics[currentPoint].list[currentDifficulty].catchParase;
        Result.back = dataCenter.Musics[currentPoint].bga_blur;
        Result.toResult = dataCenter.Musics[currentPoint].list[currentDifficulty];
        NoteDrop.Speed = speed;
        InvokeRepeating("dissolve", 0f, 0.05f);
    }
    public void musicRemotePlay()
    {
        backBG.Play();
    }
    void dissolve()
    {
        if (fader.color.a < 2.5f)
        {
            Color temp = fader.color;
            temp.a += 0.1f;
            fader.color = temp;
        }
        else
        {
            toSelect("GameScene");
        }
    }
    public void toSelect(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void devDev(bool input)
    {
        CancelInvoke("devEff");
        if (input)
        {
            devdev.texture = devon;
        }
        else
        {
            devdev.texture = devoff;
        }
        devdev.color = new Color(1.0f, 1.0f, 1.0f, 2.5f);
        InvokeRepeating("devEff", 0.0f, 0.1f);
    }
    public void devEff()
    {
        Color temp = devdev.color;
        temp = new Color(temp.r, temp.g, temp.b, temp.a - 0.5f);
        devdev.color = temp;
        if(temp.a <= 0.0f)
        {
            CancelInvoke("devEff");
        }
    }
}
