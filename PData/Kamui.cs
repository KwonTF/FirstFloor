using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Kamui: MonoBehaviour{

    public AudioClip clip;
    public VideoClip bga;
    public VideoClip bga_blur;
    public Texture normal_img;
    public Texture hard_img;
    public Texture extreme_img;


    Data.MusicInfo MusicInfo = new Data.MusicInfo();
    void Start()
    {
        MusicInfo.music = clip;
        MusicInfo.bga_blur = bga_blur;
        MusicInfo.bga = bga;
    }
    public Data.MusicInfo GetInfo()
    {
        MusicInfo.key = 1;
        MusicInfo.name = "Kamui";
        MusicInfo.composer = "TJ.Hangneil";
        MusicInfo.visualizer = "";
        MusicInfo.music = clip;
        MusicInfo.bga_blur = bga_blur;
        MusicInfo.bga = bga;
        MusicInfo.list = new List<Data.Playdata>();
        ListInit();
        
        return MusicInfo;
    }
     void ListInit()
    {
        int comboCalc = 0;
        Data.Playdata normal = new Data.Playdata();
        normal.Difficulty = "Normal";
        normal.catchParase = normal_img;
        normal.level = 5;
        CreateNote(normal);
        foreach (Data.NoteInfo notes in normal.Notes)
        {
            if (notes.isLong)
            {
                comboCalc += 2;
            }
            else
            {
                comboCalc++;
            }
        }
        normal.max_combo = comboCalc;
        MusicInfo.list.Add(normal);

        comboCalc = 0;
        Data.Playdata hard = new Data.Playdata();
        hard.Difficulty = "Hard";
        hard.level = 20;
        hard.catchParase = hard_img;
        CreateNote(hard);
        foreach (Data.NoteInfo notes in hard.Notes)
        {
            if (notes.isLong)
            {
                comboCalc += 2;
            }
            else
            {
                comboCalc++;
            }
        }
        hard.max_combo = comboCalc;
        MusicInfo.list.Add(hard);

        comboCalc = 0;
        Data.Playdata extreme = new Data.Playdata();
        extreme.Difficulty = "Extreme";
        extreme.level = 99;
        extreme.catchParase = extreme_img;
        CreateNote(extreme);
        foreach (Data.NoteInfo notes in extreme.Notes)
        {
            if (notes.isLong)
            {
                comboCalc += 2;
            }
            else
            {
                comboCalc++;
            }
        }
        extreme.max_combo = comboCalc;
        MusicInfo.list.Add(extreme);
    }
    void CreateNote(Data.Playdata input)
    {
        input.Notes = new List<Data.NoteInfo>();
        if (input.Difficulty.Equals("Normal"))
        {
            input.Notes.Add(new Data.NoteInfo(false, 2.65f, 2.0f, "s"));//117
            input.Notes.Add(new Data.NoteInfo(false, 4.86f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 7.15f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 9.36f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 10.51f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 11.72f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 14.01f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 16.29f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 18.58f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 20.86f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 21.43f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 22.01f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 23.15f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 23.72f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 24.29f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 25.43f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 26.01f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 26.58f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 30.01f, 31.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 32.29f, 33.98f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 34.58f, 36.22f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 36.86f, 38.51f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 39.15f, 40.79f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 41.43f, 43.08f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 43.72f, 45.36f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 46.01f, 47.08f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 48.29f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 49.43f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 50.58f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 51.72f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 52.86f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 54.01f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 55.08f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 56.22f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 56.93f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 57.22f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 62.01f, 64.22f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 64.29f, 66.51f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 66.58f, 68.79f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 68.86f, 71.08f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 71.72f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 72.29f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 72.88f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 73.44f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 74.01f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 74.58f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 75.15f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 75.72f, 76.51f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 76.86f, 77.65f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 80.29f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 82.58f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 84.67f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 87.15f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 89.51f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 89.86f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 90.29f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 90.72f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 91.15f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 91.65f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 92.08f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 92.51f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 92.93f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 93.29f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 93.72f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 94.15f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 94.58f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(true, 95.15f, 95.93f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 96.22f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 97.37f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 98.58f, 100.22f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 100.22f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 100.86f, 101.93f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 101.93f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 103.15f, 104.51f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 104.51f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 105.43f, 107.08f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 107.08f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 107.72f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 108.08f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 108.51f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 108.93f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 109.36f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 109.86f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 110.29f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 110.72f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 111.15f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 111.51f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 111.93f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 112.36f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 112.79f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 113.22f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 113.79f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 114.08f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 114.65f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 114.93f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 115.43f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 115.86f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 116.29f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 116.58f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 116.93f, 2.0f, "space"));
        }
        else if (input.Difficulty.Equals("Hard"))
        {
            input.Notes.Add(new Data.NoteInfo(true, 0.51f, 1.01f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.51f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.72f, 0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.93f, 0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.15f, 0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.36f, 0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 2.58f, 0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 3.01f, 0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.29f, 0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.58f, 0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.86f, 0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 4.15f, 0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 4.43f, 0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.58f+2.28f, 0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.01f+2.28f, 0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 3.29f+2.28f, 0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 3.58f+2.28f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 3.86f+2.28f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 4.15f+2.28f, 0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 4.43f+2.28f, 0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.58f + 4.57f, 0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 3.01f + 4.57f, 0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.29f + 4.57f, 0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.58f + 4.57f, 0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 3.86f + 4.57f, 0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 4.15f + 4.57f, 0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 4.43f + 4.57f, 0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 9.43f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 9.86f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 10.15f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 10.43f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 10.58f,11.360f, "q"));

            input.Notes.Add(new Data.NoteInfo(false, 11.72f, 0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 12.01f, 0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 12.15f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 12.43f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 12.58f, 0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 12.72f, 0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 13.0f, 0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 13.15f, 0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 13.29f, 0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 13.57f, 0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 13.65f, 0f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 11.72f +2.31f, 0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 12.01f +2.31f, 0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 12.15f +2.31f, 0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 12.43f +2.31f, 0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 12.58f +2.31f, 0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 12.72f +2.31f, 0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 13.00f +2.31f, 0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 13.15f +2.31f, 0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 13.29f +2.31f, 0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 13.57f +2.31f, 0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 13.65f +2.31f, 0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 11.72f + 4.57f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 12.01f + 4.57f, 0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 12.15f + 4.57f, 0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 12.43f + 4.57f, 0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 12.58f + 4.57f, 0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 12.72f + 4.57f, 0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 13.00f + 4.57f, 0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 13.15f + 4.57f, 0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 13.29f + 4.57f, 0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 13.57f + 4.57f, 0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 13.65f + 4.57f, 0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 11.72f + 6.86f, 0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 12.01f + 6.86f, 0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 12.15f + 6.86f, 0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 12.43f + 6.86f, 0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 12.58f + 6.86f, 0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 12.72f + 6.86f, 0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 13.00f + 6.86f, 0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 13.15f + 6.86f, 0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 13.29f + 6.86f, 0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 13.57f + 6.86f, 0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 13.65f + 6.86f, 0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 20.86f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 20.86f, 0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 21.43f, 0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 21.43f, 0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 22.01f, 0f, "h"));
            input.Notes.Add(new Data.NoteInfo(false, 22.01f, 0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 22.51f, 0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 22.51f, 0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 23.15f, 0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 23.15f, 0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 23.72f, 0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 23.72f, 0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 24.29f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 24.29f, 0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 24.79f, 0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 24.79f, 0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 25.43f, 0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 25.58f, 0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 25.72f, 0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 25.86f, 0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 26.01f, 0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 26.15f, 0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 26.29f, 0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 26.43f, 0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 26.58f, 0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 26.72f, 0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 26.86f, 0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 27.01f, 0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 27.15f, 0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 27.29f, 0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 27.43f, 0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 27.58f, 0f, "p"));
            input.Notes.Add(new Data.NoteInfo(true, 27.72f, 28.51f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 29.36f, 29.93f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 30.01f, 30.79f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 30.86f, 31.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 31.65f, 31.93f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 32.01f, 32.22f, "a"));
            input.Notes.Add(new Data.NoteInfo(true, 32.29f, 32.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 32.72f, 33.08f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 33.15f, 33.93f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 34.01f, 34.22f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 34.29f, 34.51f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 34.58f, 34.93f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 35.01f, 35.36f, "a"));
            input.Notes.Add(new Data.NoteInfo(true, 35.43f, 36.22f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 36.29f, 36.51f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 36.58f, 36.79f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 36.86f, 37.22f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 37.29f, 37.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 37.72f, 38.51f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 38.51f, 39.08f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 39.15f, 39.93f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 40.01f, 40.79f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 40.86f, 41.08f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 41.15f, 41.36f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 41.43f, 41.79f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 41.86f, 42.22f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 42.29f, 43.08f, ";"));
            input.Notes.Add(new Data.NoteInfo(true, 43.15f, 43.36f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 43.43f, 43.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 43.72f, 44.08f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 44.15f, 44.51f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 44.58f, 45.36f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 45.43f, 45.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 45.72f, 45.93f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 46.01f, 46.36f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 46.43f, 46.79f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 46.86f, 47.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 48.29f, 0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 48.72f, 0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 49.29f, 0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 49.65f, 0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 50.01f, 0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 50.29f, 0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 50.65f, 0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 51.22f, 0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 51.72f, 0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 52.29f, 0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 52.58f, 0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 52.86f, 0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 53.29f, 0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 53.93f, 0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 54.29f, 0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 54.58f, 0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 55.08f, 0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 55.72f, 0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 56.22f, 0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 56.93f, 0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 57.22f, 0f, "space"));
            /*input.Notes.Add(new Data.NoteInfo(false, 62.02f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 62.15f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 62.29f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 62.43f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 62.58f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 62.72f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 62.86f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 63.01f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 63.15f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 63.29f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 63.43f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 63.58f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 63.72f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 63.86f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 64.01f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 64.15f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 64.29f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 64.43f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 64.58f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 64.72f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 64.86f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 65.01f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 65.15f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 65.29f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 65.72f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 65.86f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 66.01f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 66.15f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 66.29f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 66.43f, 0f, "s")); 

            input.Notes.Add(new Data.NoteInfo(false, 62.02f+4.57f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 62.15f+4.57f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 62.29f+4.57f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 62.43f+4.57f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 62.58f+4.57f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 62.72f+4.57f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 62.86f+4.57f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 63.01f+4.57f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 63.15f+4.57f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 63.29f+4.57f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 63.43f+4.57f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 63.58f+4.57f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 63.72f+4.57f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 63.86f+4.57f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 64.01f+4.57f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 64.15f+4.57f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 64.29f+4.57f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 64.43f+4.57f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 64.58f+4.57f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 64.72f+4.57f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 64.86f+4.57f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 65.01f+4.57f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 65.15f+4.57f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 65.29f+4.57f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 65.72f+4.57f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 65.86f+4.57f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 66.01f+4.57f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 66.15f+4.57f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 66.29f+4.57f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 66.43f+4.57f, 0f, "s")); 

            input.Notes.Add(new Data.NoteInfo(false, 71.15f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 71.29f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 71.43f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 71.58f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 71.72f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 71.86f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 72.01f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 72.15f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 72.29f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 72.43f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 72.58f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 72.72f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 72.86f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 73.01f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 73.15f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 73.29f, 0f, "s"));
            
            input.Notes.Add(new Data.NoteInfo(false, 73.43f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 73.58f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 73.72f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 73.86f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 74.01f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 74.15f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 74.29f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 74.43f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 74.58f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 74.72f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 74.86f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 75.01f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 75.15f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 75.29f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 75.43f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 75.72f, 76.51f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 76.86f, 77.65f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 78.08f, 77.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 78.51f, 77.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 79.01f, 77.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 79.36f, 77.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 79.72f, 77.65f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 62.02f+18.28f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 62.02f+18.28f, 63.65f+18.28f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 62.15f+18.28f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 62.29f+18.28f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 62.43f+18.28f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 62.58f+18.28f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 62.72f+18.28f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 62.86f+18.28f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 63.01f+18.28f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 63.15f+18.28f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 63.29f+18.28f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 63.43f+18.28f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 63.58f+18.28f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 63.72f+18.28f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 63.86f+18.28f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 64.01f+18.28f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 64.15f+18.28f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 64.29f+18.28f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 64.3f+18.28f, 65.94f+18.28f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 64.43f+18.28f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 64.58f+18.28f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 64.72f+18.28f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 64.86f+18.28f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 65.01f+18.28f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 65.15f+18.28f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 65.29f+18.28f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 65.72f+18.28f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 65.86f+18.28f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 66.01f+18.28f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 66.15f+18.28f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 66.29f+18.28f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 66.43f+18.28f, 0f, "s")); 

         input.Notes.Add(new Data.NoteInfo(false, 62.02f+22.84f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 62.02f+22.84f, 63.65f+22.84f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 62.15f+22.84f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 62.29f+22.84f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 62.43f+22.84f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 62.58f+22.84f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 62.72f+22.84f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 62.86f+22.84f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 63.01f+22.84f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 63.15f+22.84f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 63.29f+22.84f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 63.43f+22.84f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 63.58f+22.84f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 63.72f+22.84f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 63.86f+22.84f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 64.01f+22.84f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 64.15f+22.84f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 64.29f+22.84f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 64.3f+22.84f, 65.94f+22.84f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 64.43f+22.84f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 64.58f+22.84f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 64.72f+22.84f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 64.86f+22.84f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 65.01f+22.84f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 65.15f+22.84f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 65.29f+22.84f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 65.72f+22.84f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 65.86f+22.84f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 66.01f+22.84f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 66.15f+22.84f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 66.29f+22.84f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 66.43f+22.84f, 0f, "s"));
            
             input.Notes.Add(new Data.NoteInfo(false, 89.51f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 89.86f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 90.29f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 90.72f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 91.15f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 91.65f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 92.08f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 92.51f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 92.93f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 93.29f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 93.72f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 94.15f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 94.58f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(true, 95.15f, 95.93f, "space"));

         input.Notes.Add(new Data.NoteInfo(false, 78.08f+18.28f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 78.51f+18.28f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 79.01f+18.28f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 79.36f+18.28f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 79.72f+18.28f, 0f, "s"));

        input.Notes.Add(new Data.NoteInfo(false, 62.02f+36.56f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 62.02f+36.56f, 63.65f+36.56f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 62.15f+36.56f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 62.29f+36.56f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 62.43f+36.56f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 62.58f+36.56f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 62.72f+36.56f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 62.86f+36.56f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 63.01f+36.56f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 63.15f+36.56f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 63.29f+36.56f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 63.43f+36.56f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 63.58f+36.56f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 63.72f+36.56f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 63.86f+36.56f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 64.01f+36.56f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 64.15f+36.56f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 64.29f+36.56f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 64.3f+36.56f, 65.94f+36.56f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 64.43f+36.56f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 64.58f+36.56f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 64.72f+36.56f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 64.86f+36.56f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 65.01f+36.56f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 65.15f+36.56f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 65.29f+36.56f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 65.72f+36.56f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 65.86f+36.56f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 66.01f+36.56f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 66.15f+36.56f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 66.29f+36.56f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 66.43f+36.56f, 0f, "s"));

        input.Notes.Add(new Data.NoteInfo(false, 62.02f+41.13f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 62.02f+41.13f, 63.65f+41.13f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 62.15f+41.13f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 62.29f+41.13f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 62.43f+41.13f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 62.58f+41.13f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 62.72f+41.13f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 62.86f+41.13f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 63.01f+41.13f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 63.15f+41.13f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 63.29f+41.13f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 63.43f+41.13f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 63.58f+41.13f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 63.72f+41.13f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 63.86f+41.13f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 64.01f+41.13f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 64.15f+41.13f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 64.29f+41.13f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 64.3f+41.13f, 65.94f+41.13f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 64.43f+41.13f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 64.58f+41.13f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 64.72f+41.13f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 64.86f+41.13f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 65.01f+41.13f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 65.15f+41.13f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 65.29f+41.13f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 65.72f+41.13f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 65.86f+41.13f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 66.01f+41.13f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 66.15f+41.13f, 0f, "s")); 
            input.Notes.Add(new Data.NoteInfo(false, 66.29f+41.13f, 0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 66.43f+41.13f, 0f, "s"));
             input.Notes.Add(new Data.NoteInfo(false, 107.72f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 108.08f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 108.51f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 108.93f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 109.36f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 109.86f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 110.29f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 110.72f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 111.15f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 111.51f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 111.93f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 112.36f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 112.79f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 113.22f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 113.79f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 114.08f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 114.65f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 114.93f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 115.43f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 115.86f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 116.29f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 116.58f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 116.93f, 2.0f, "space"));
            */
        }
        else if (input.Difficulty.Equals("Extreme"))
        {
            input.Notes.Add(new Data.NoteInfo(false, 2.0f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.0f, 2.0f, "l"));
        }
    }
   
}
