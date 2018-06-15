using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UrbanWait : MonoBehaviour {
    public static int stageNum;
    public static UrbanData.courseData courseData;
    public Text music1;
    public Text music2;
    public Text music3;
    public Text music4;
    public Text statusChecker;
    public RawImage courseImage;

    public Text courseNumber;
    public Text composer;
    public Text visualizer;

    public static int max_combo;
    public static int combo;
    public static int score;
    public static float acc;
    public static float life_getter;
    public static List<float> musicAcc;
    // Use this for initialization
    void Start () {
        Invoke("toGame", 5.0f);
        music1.text = courseData.musics[0].name+"/"+courseData.musics[0].list[courseData.musicLevels[0]].Difficulty;
        music2.text = courseData.musics[1].name + "/" + courseData.musics[0].list[courseData.musicLevels[1]].Difficulty;
        music3.text = courseData.musics[2].name + "/" + courseData.musics[0].list[courseData.musicLevels[2]].Difficulty;
        music4.text = courseData.musics[3].name + "/" + courseData.musics[0].list[courseData.musicLevels[3]].Difficulty;
        if(musicAcc.Count <= 0)
        {
            acc = 0.00f;
        }
        switch (stageNum)
        {
            case 0:
                courseNumber.text = "1st Stage";
                break;
            case 1:
                courseNumber.text = "2nd Stage";
                break;
            case 2:
                courseNumber.text = "3rd Stage";
                break;
            case 3:
                courseNumber.text = "Final Stage";
                break;
        }
        courseImage.texture = courseData.Courses[stageNum];
        statusChecker.text = "Score " + score.ToString() + ", Max Combo " + max_combo.ToString() + ", Combo " + combo.ToString() + ", Acc " + acc.ToString("N2") + ", Life " + life_getter.ToString("N2");
        composer.text = courseData.musics[stageNum].composer;
        visualizer.text = courseData.musics[stageNum].visualizer;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void toGame()
    {
        switch (courseData.musics[stageNum].key)
        {
            case 0:
                new Immortal().getNote(courseData.musics[stageNum].list[courseData.musicLevels[stageNum]]);
                break;
            case 1:
                new Kamui().getNote(courseData.musics[stageNum].list[courseData.musicLevels[stageNum]]);
                break;
            case 2:
                new Motivity().getNote(courseData.musics[stageNum].list[courseData.musicLevels[stageNum]]);
                break;
            case 3:
                new Whiteblue().getNote(courseData.musics[stageNum].list[courseData.musicLevels[stageNum]]);
                break;
            case 4:
                new Brandnew_Days().getNote(courseData.musics[stageNum].list[courseData.musicLevels[stageNum]]);
                break;
            case 5:
                new Sapphire().getNote(courseData.musics[stageNum].list[courseData.musicLevels[stageNum]]);
                break;
            case 6:
                new TheTalesRemix().getNote(courseData.musics[stageNum].list[courseData.musicLevels[stageNum]]);
                break;
            case 7:
                new Entire().getNote(courseData.musics[stageNum].list[courseData.musicLevels[stageNum]]);
                break;
            case 8:
                new LazyDays().getNote(courseData.musics[stageNum].list[courseData.musicLevels[stageNum]]);
                break;
            case 9:
                new Deborah().getNote(courseData.musics[stageNum].list[courseData.musicLevels[stageNum]]);
                break;
            case 10:
                new ALie_Deep().getNote(courseData.musics[stageNum].list[courseData.musicLevels[stageNum]]);
                break;
            case 100:
                new Test().getNote(courseData.musics[stageNum].list[courseData.musicLevels[stageNum]]);
                break;
            default:
                break;
        }
        MusicPlayer.SelectedMusic = courseData.musics[stageNum].music;
        MusicPlayer.pattern = courseData.musics[stageNum].list[courseData.musicLevels[stageNum]].Notes;
        MusicPlayer.videoClip = courseData.musics[stageNum].bga;
        MusicPlayer.notesNum = courseData.musics[stageNum].list[courseData.musicLevels[stageNum]].max_combo;
        MusicPlayer.info = courseData.musics[stageNum];
        MusicPlayer.diff = courseData.musics[stageNum].list[courseData.musicLevels[stageNum]].Difficulty;
        Result.music = courseData.musics[stageNum].name;
        Result.difficult = courseData.musics[stageNum].list[courseData.musicLevels[stageNum]].Difficulty;
        Result.texture = courseData.musics[stageNum].list[courseData.musicLevels[stageNum]].catchParase;
        Result.back = courseData.musics[stageNum].bga_blur;
        Result.toResult = courseData.musics[stageNum].list[courseData.musicLevels[stageNum]];
        SceneManager.LoadScene("GameScene");
    }
}
