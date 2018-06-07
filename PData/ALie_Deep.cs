using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ALie_Deep : MonoBehaviour {

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
        MusicInfo.key = 10;
        MusicInfo.name = "A Lie -Deep Inside Mix-";
        MusicInfo.composer = "Makou";
        MusicInfo.visualizer = "Ache";
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
        normal.level = 4;
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
        hard.level = 5;
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
        extreme.level = 20;
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
            //basic scratch
            input.Notes.Add(new Data.NoteInfo(false, 0.00f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.27f + 0.00f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 0.40f + 0.00f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 0.54f + 0.00f, 0.65f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 1.09f, 0.65f, "a"));

            //3/1
            input.Notes.Add(new Data.NoteInfo(false, 2.18f + 0.00f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.72f + 0.00f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.27f + 0.00f, 0.65f, "s"));

            //basic scratch
            input.Notes.Add(new Data.NoteInfo(false, 4.36f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.27f + 4.36f, 0.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 0.40f + 4.36f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 0.54f + 4.36f, 0.65f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 5.45f, 0.65f, "d"));

            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 6.54f + 0.00f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 6.81f + 0.00f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 7.09f + 0.00f, 0.65f, "f"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 7.63f + 0.00f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 7.90f + 0.00f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 8.18f + 0.00f, 0.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 8.45f + 0.00f, 0.65f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 8.72f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 9.81f, 0.65f, "space"));

            //3/1
            input.Notes.Add(new Data.NoteInfo(false, 2.18f + 8.72f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.72f + 8.72f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.27f + 8.72f, 0.65f, "f"));

            //basic scratch
            input.Notes.Add(new Data.NoteInfo(false, 13.09f, 0.65f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 0.27f + 13.09f, 0.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 0.40f + 13.09f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 0.54f + 13.09f, 0.65f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 14.18f, 0.65f, ";"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 7.63f + 7.64f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 7.90f + 7.64f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 8.18f + 7.64f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 8.45f + 7.64f, 0.65f, "f"));

            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 6.54f + 10.09f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 6.81f + 10.09f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 7.09f + 10.09f, 0.65f, "j"));

            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 17.45f + 0.00f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 18.00f + 0.00f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 18.54f + 0.00f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 19.09f + 0.00f, 0.65f, "d"));
            //additional
            input.Notes.Add(new Data.NoteInfo(false, 18.00f + 0.00f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 19.09f + 0.00f, 0.65f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 17.45f + 2.18f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 18.00f + 2.18f, 0.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 18.54f + 2.18f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 19.09f + 2.18f, 0.65f, "l"));
            //additional
            input.Notes.Add(new Data.NoteInfo(false, 18.00f + 2.18f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 19.09f + 2.18f, 0.65f, "d"));

            //basic scratch
            input.Notes.Add(new Data.NoteInfo(false, 21.81f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 0.27f + 21.81f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 0.40f + 21.81f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 0.54f + 21.81f, 0.65f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 22.90f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 24.00f, 0.65f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 25.09f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 25.09f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 25.63f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 25.63f, 0.65f, "j"));

            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 6.54f + 19.64f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 6.81f + 19.64f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 7.09f + 19.64f, 0.65f, "j"));

            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 6.54f + 20.73f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 6.81f + 20.73f, 0.65f, "d"));

            //4com
            input.Notes.Add(new Data.NoteInfo(false, 27.81f + 0.00f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 27.95f + 0.00f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 28.09f + 0.00f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 28.22f + 0.00f, 0.65f, "d"));

            //3/1
            input.Notes.Add(new Data.NoteInfo(false, 2.18f + 26.18f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.72f + 26.18f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.27f + 26.18f, 0.65f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 30.00f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.00f, 0.65f, "k"));

            //basic scratch
            input.Notes.Add(new Data.NoteInfo(false, 30.54f, 0.65f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 0.27f + 30.54f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.40f + 30.54f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 0.54f + 30.54f, 0.65f, "s"));

            input.Notes.Add(new Data.NoteInfo(true, 31.63f, 32.18f, "f"));

            //3/1
            input.Notes.Add(new Data.NoteInfo(false, 2.18f + 30.54f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.72f + 30.54f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.27f + 30.54f, 0.65f, "d"));
            //3/1
            input.Notes.Add(new Data.NoteInfo(false, 2.18f + 30.54f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 2.72f + 30.54f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.27f + 30.54f, 0.65f, "f"));

            //basic scratch
            input.Notes.Add(new Data.NoteInfo(true, 34.09f, 34.90f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.27f + 34.90f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.40f + 34.90f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 0.54f + 34.90f, 0.65f, "s"));

            input.Notes.Add(new Data.NoteInfo(true, 36.00f, 37.09f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 36.00f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 37.09f, 0.65f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 37.63f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 37.63f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 38.18f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 38.18f, 0.65f, "f"));

            input.Notes.Add(new Data.NoteInfo(true, 38.45f, 39.27f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 39.27f, 37.09f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 39.95f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 40.22f, 0.65f, "s"));

            //3/1
            input.Notes.Add(new Data.NoteInfo(false, 2.18f + 39.27f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.72f + 39.27f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 42.40f, 0.65f, "s"));
            //3/1
            input.Notes.Add(new Data.NoteInfo(false, 2.18f + 39.27f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.72f + 39.27f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 42.40f, 0.65f, "j"));

            //4com
            input.Notes.Add(new Data.NoteInfo(false, 27.81f + 15.28f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 27.95f + 15.28f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 28.09f + 15.28f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 28.22f + 15.28f, 0.65f, "f"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 27.81f + 16.09f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 27.95f + 16.09f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 28.09f + 16.09f, 0.65f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 44.72f, 0.65f, "l"));

            //3/1
            input.Notes.Add(new Data.NoteInfo(false, 2.18f + 43.63f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 2.72f + 43.63f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 3.27f + 43.63f, 0.65f, "space"));
            //3/1
            input.Notes.Add(new Data.NoteInfo(false, 2.18f + 43.63f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.72f + 43.63f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 3.27f + 43.63f, 0.65f, "d"));

            input.Notes.Add(new Data.NoteInfo(true, 47.45f, 48.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 48.00f, 37.09f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 48.81f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 48.81f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 49.09f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 49.09f, 0.65f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 49.63f, 0.65f, "k"));

            input.Notes.Add(new Data.NoteInfo(true, 50.18f, 50.72f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 50.72f, 51.27f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 51.27f, 52.36f, "f"));

            input.Notes.Add(new Data.NoteInfo(true, 52.36f, 53.45f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 53.45f, 54.54f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 54.81f, 0.65f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 55.77f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 56.18f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 56.72f, 57.81f, "a"));
            input.Notes.Add(new Data.NoteInfo(true, 57.81f, 58.90f, ";"));
            input.Notes.Add(new Data.NoteInfo(true, 58.90f, 60.00f, "q"));
            input.Notes.Add(new Data.NoteInfo(true, 60.00f, 61.09f, "p"));
            input.Notes.Add(new Data.NoteInfo(true, 61.09f, 62.18f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 62.18f, 54.54f, "d"));

            input.Notes.Add(new Data.NoteInfo(true, 62.72f, 63.27f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 63.27f, 54.54f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 64.50f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 64.77f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 65.04f, 0.65f, "l"));

            input.Notes.Add(new Data.NoteInfo(true, 65.45f, 66.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 66.00f, 66.54f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 66.54f, 67.09f, "s"));

            input.Notes.Add(new Data.NoteInfo(true, 67.63f, 68.72f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 67.63f, 68.72f, "k"));

            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 17.45f + 52.36f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 18.00f + 52.36f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 18.54f + 52.36f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 19.09f + 52.36f, 0.65f, "k"));

            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 6.54f + 65.46f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 6.81f + 65.46f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 7.09f + 65.46f, 0.65f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 73.09f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 73.63f, 0.65f, "d"));

            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 6.54f + 67.64f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 6.81f + 67.64f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 7.09f + 67.64f, 0.65f, "f"));

            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 6.54f + 68.73f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 6.81f + 68.73f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 7.09f + 68.73f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 6.54f + 68.73f, 0.65f, "space"));

            input.Notes.Add(new Data.NoteInfo(false, 76.36f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 76.50f, 0.65f, "f"));

            input.Notes.Add(new Data.NoteInfo(true, 76.90f, 77.45f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 77.45f, 78.54f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 78.81f, 0.65f, "l"));

            //3/1
            input.Notes.Add(new Data.NoteInfo(false, 2.18f + 76.91f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 2.72f + 76.91f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.27f + 76.91f, 0.65f, "space"));

            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 6.54f + 74.18f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 6.81f + 74.18f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 7.09f + 74.18f, 0.65f, "s"));

            //3/1
            input.Notes.Add(new Data.NoteInfo(false, 2.18f + 79.63f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.72f + 79.63f, 0.65f, "f"));

            //basic scratch
            input.Notes.Add(new Data.NoteInfo(false, 82.90f, 0.65f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 0.27f + 82.90f, 0.65f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 0.40f + 82.90f, 0.65f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 0.54f + 82.90f, 0.65f, ";"));

            input.Notes.Add(new Data.NoteInfo(false, 84.00f, 0.65f, "space"));

            //3/1
            input.Notes.Add(new Data.NoteInfo(false, 2.18f + 82.91f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.72f + 82.91f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.27f + 82.91f, 0.65f, "f"));
            //3/1
            input.Notes.Add(new Data.NoteInfo(false, 2.18f + 82.91f, 0.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 2.72f + 82.91f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.27f + 82.91f, 0.65f, "j"));

            input.Notes.Add(new Data.NoteInfo(true, 86.72f, 87.27f, "space"));

            //piano solo
            input.Notes.Add(new Data.NoteInfo(false, 88.09f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 88.22f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 88.36f, 88.63f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 88.77f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 89.04f, 0.65f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 89.31f, 0.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 89.59f, 0.65f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 90.00f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 90.13f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 90.40f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 90.68f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 90.95f, 0.65f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 91.90f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 92.18f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 92.45f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 92.59f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 92.86f, 0.65f, "j"));

            input.Notes.Add(new Data.NoteInfo(true, 93.13f, 93.54f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 93.54f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 93.68f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 93.95f, 0.65f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 94.36f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 94.77f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 95.04f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 95.31f, 0.65f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 96.54f, 0.65f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 96.95f, 0.65f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 97.36f, 0.65f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 97.63f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 97.90f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 98.04f, 0.65f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 98.31f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 98.59f, 0.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 98.86f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 99.27f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 99.40f, 0.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 99.68f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 99.81f, 0.65f, "f"));

            input.Notes.Add(new Data.NoteInfo(true, 100.36f, 101.45f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 101.45f, 102.54f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 102.54f, 103.63f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 103.63f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 104.18f, 0.65f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 104.86f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 105.27f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 105.54f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 105.68f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 105.95f, 0.65f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 106.36f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 106.77f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 107.18f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 107.59f, 0.65f, "l"));

            //5com
            input.Notes.Add(new Data.NoteInfo(false, 108.00f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 108.13f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 108.27f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 108.40f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 108.54f, 0.65f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 108.95f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 109.09f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 109.36f, 0.65f, "s"));

            input.Notes.Add(new Data.NoteInfo(true, 109.63f, 110.04f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 110.18f, 110.59f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 110.72f, 111.13f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 111.27f, 111.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 111.81f, 112.36f, "a"));

            input.Notes.Add(new Data.NoteInfo(false, 112.77f, 0.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 113.18f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 113.59f, 0.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 114.00f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 114.40f, 0.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 114.81f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 115.22f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 115.63f, 0.65f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 116.04f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 116.18f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 116.45f, 0.65f, "s"));
            //2com/0.25/2com
            input.Notes.Add(new Data.NoteInfo(false, 116.72f + 0.00f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 116.86f + 0.00f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 117.13f + 0.00f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 117.27f + 0.00f, 0.65f, "j"));
            //2com/0.25/2com
            input.Notes.Add(new Data.NoteInfo(false, 116.72f + 0.82f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 116.86f + 0.82f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 117.13f + 0.82f, 0.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 117.27f + 0.82f, 0.65f, "k"));
            //2com/0.25/2com
            input.Notes.Add(new Data.NoteInfo(false, 116.72f + 1.64f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 116.86f + 1.64f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 117.13f + 1.64f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 117.27f + 1.64f, 0.65f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 119.18f, 0.65f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 119.72f, 0.65f, ";"));

            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 6.54f + 113.73f, 0.65f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 6.81f + 113.73f, 0.65f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 7.09f + 113.73f, 0.65f, "a"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 6.54f + 114.55f, 0.65f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 6.81f + 114.55f, 0.65f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 7.09f + 114.55f, 0.65f, "a"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 6.54f + 114.55f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 6.81f + 114.55f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 7.09f + 114.55f, 0.65f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 122.18f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 123.27f, 0.65f, "s"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 7.63f + 116.73f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 7.90f + 116.73f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.18f + 116.73f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 8.45f + 116.73f, 0.65f, "d"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 7.63f + 117.82f, 0.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 7.90f + 117.82f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 8.18f + 117.82f, 0.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 8.45f + 117.82f, 0.65f, "j"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 7.63f + 118.91f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 7.90f + 118.91f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 8.18f + 118.91f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 8.45f + 118.91f, 0.65f, "f"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 7.63f + 120.0f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 7.90f + 120.0f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 8.18f + 120.0f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 8.45f + 120.0f, 0.65f, "k"));

            input.Notes.Add(new Data.NoteInfo(true, 128.72f, 129.81f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 129.81f, 130.90f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 130.90f, 131.72f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 131.72f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 132.00f, 0.65f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 132.54f, 0.65f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 133.09f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 133.36f, 0.65f, "d"));

            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 6.54f + 127.91f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 6.81f + 127.91f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 7.09f + 127.91f, 0.65f, "f"));

            input.Notes.Add(new Data.NoteInfo(true, 135.27f, 135.81f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 135.81f, 136.36f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 136.36f, 136.90f, "space"));

            input.Notes.Add(new Data.NoteInfo(true, 137.45f, 138.54f, "k"));

            //2/1/3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 139.63f + 0.00f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 140.18f + 0.00f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 140.72f + 0.00f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 141.00f + 0.00f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 141.27f + 0.00f, 0.65f, "d"));

            //2/1/3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 139.63f + 2.18f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 140.18f + 2.18f, 0.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 140.72f + 2.18f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 141.00f + 2.18f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 141.27f + 2.18f, 0.65f, "k"));

            //basic scratch
            input.Notes.Add(new Data.NoteInfo(false, 144.00f, 0.65f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 0.27f + 144.00f, 0.65f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 0.40f + 144.00f, 0.65f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 0.54f + 144.00f, 0.65f, "p"));

            input.Notes.Add(new Data.NoteInfo(true, 145.09f, 146.18f, "space"));

            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 6.54f + 139.64f, 0.65f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 6.81f + 139.64f, 0.65f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 7.09f + 139.64f, 0.65f, "q"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 6.54f + 139.64f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 6.81f + 139.64f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 7.09f + 139.64f, 0.65f, "space"));
        }
        else if (input.Difficulty.Equals("Hard"))
        {
            //1st drum/2
            input.Notes.Add(new Data.NoteInfo(false, 0.00f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.54f + 0.00f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.09f + 0.00f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.22f + 0.00f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.36f + 0.00f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.63f + 0.00f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.77f + 0.00f, 0.65f, "k"));
            //1st drum/2
            input.Notes.Add(new Data.NoteInfo(false, 2.18f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.54f + 2.18f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.09f + 2.18f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.22f + 2.18f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.36f + 2.18f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.63f + 2.18f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.77f + 2.18f, 0.65f, "k"));

            //1st drum/2
            input.Notes.Add(new Data.NoteInfo(false, 4.36f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.54f + 4.36f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.09f + 4.36f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.22f + 4.36f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.36f + 4.36f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.63f + 4.36f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.77f + 4.36f, 0.65f, "k"));
            //1st drum/2
            input.Notes.Add(new Data.NoteInfo(false, 6.54f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.54f + 6.54f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.09f + 6.54f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.22f + 6.54f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.36f + 6.54f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.63f + 6.54f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.77f + 6.54f, 0.65f, "k"));
            //1st drum/2
            input.Notes.Add(new Data.NoteInfo(false, 8.72f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.54f + 8.72f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.09f + 8.72f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.22f + 8.72f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.36f + 8.72f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.63f + 8.72f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.77f + 8.72f, 0.65f, "k"));
            //1st drum/2
            input.Notes.Add(new Data.NoteInfo(false, 10.90f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.54f + 10.90f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.09f + 10.90f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.22f + 10.90f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.36f + 10.90f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.63f + 10.90f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.77f + 10.90f, 0.65f, "k"));
            //1st drum/2
            input.Notes.Add(new Data.NoteInfo(false, 13.09f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.54f + 13.09f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.09f + 13.09f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.22f + 13.09f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.36f + 13.09f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.63f + 13.09f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.77f + 13.09f, 0.65f, "k"));
            //1st drum/2
            input.Notes.Add(new Data.NoteInfo(false, 15.27f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.54f + 15.27f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.09f + 15.27f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.22f + 15.27f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.36f + 15.27f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.63f + 15.27f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.77f + 15.27f, 0.65f, "k"));
            //basic scratch
            input.Notes.Add(new Data.NoteInfo(false, 0.00f, 0.65f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 0.27f + 0.00f, 0.65f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 0.40f + 0.00f, 0.65f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 0.54f + 0.00f, 0.65f, "p"));

            input.Notes.Add(new Data.NoteInfo(false, 1.09f, 0.65f, "q"));

            //3/1
            input.Notes.Add(new Data.NoteInfo(false, 2.18f + 0.00f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 2.72f + 0.00f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 3.27f + 0.00f, 0.65f, "space"));

            //basic scratch
            input.Notes.Add(new Data.NoteInfo(false, 4.36f, 0.65f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 0.27f + 4.36f, 0.65f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 0.40f + 4.36f, 0.65f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 0.54f + 4.36f, 0.65f, "p"));

            input.Notes.Add(new Data.NoteInfo(false, 5.45f, 0.65f, "a"));

            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 6.54f + 0.00f, 0.65f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 6.81f + 0.00f, 0.65f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 7.09f + 0.00f, 0.65f, ";"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 7.63f + 0.00f, 0.65f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 7.90f + 0.00f, 0.65f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 8.18f + 0.00f, 0.65f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 8.45f + 0.00f, 0.65f, ";"));

            input.Notes.Add(new Data.NoteInfo(false, 8.72f, 0.65f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 9.81f, 0.65f, ";"));

            //3/1
            input.Notes.Add(new Data.NoteInfo(false, 2.18f + 8.72f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 2.72f + 8.72f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 3.27f + 8.72f, 0.65f, "space"));

            //basic scratch
            input.Notes.Add(new Data.NoteInfo(false, 13.09f, 0.65f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 0.27f + 13.09f, 0.65f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 0.40f + 13.09f, 0.65f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 0.54f + 13.09f, 0.65f, "p"));

            input.Notes.Add(new Data.NoteInfo(false, 14.18f, 0.65f, "q"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 7.63f + 7.64f, 0.65f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 7.90f + 7.64f, 0.65f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 8.18f + 7.64f, 0.65f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 8.45f + 7.64f, 0.65f, ";"));

            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 6.54f + 10.09f, 0.65f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 6.81f + 10.09f, 0.65f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 7.09f + 10.09f, 0.65f, "q"));

            //shuffle area
            //basic scratch
            input.Notes.Add(new Data.NoteInfo(false, 0.00f + 17.45f, 0.65f + 17.45f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 0.27f + 0.00f + 17.45f, 0.65f + 17.45f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 0.40f + 0.00f + 17.45f, 0.65f + 17.45f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 0.54f + 0.00f + 17.45f, 0.65f + 17.45f, "p"));

            input.Notes.Add(new Data.NoteInfo(false, 1.09f + 17.45f, 0.65f + 17.45f, "a"));

            //3/1
            input.Notes.Add(new Data.NoteInfo(false, 2.18f + 0.00f + 17.45f, 0.65f + 17.45f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 2.72f + 0.00f + 17.45f, 0.65f + 17.45f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 3.27f + 0.00f + 17.45f, 0.65f + 17.45f, "space"));

            //basic scratch
            input.Notes.Add(new Data.NoteInfo(false, 4.36f + 17.45f, 0.65f + 17.45f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 0.27f + 4.36f + 17.45f, 0.65f + 17.45f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 0.40f + 4.36f + 17.45f, 0.65f + 17.45f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 0.54f + 4.36f + 17.45f, 0.65f + 17.45f, "q"));

            input.Notes.Add(new Data.NoteInfo(false, 5.45f + 17.45f, 0.65f + 17.45f, ";"));

            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 6.54f + 0.00f + 17.45f, 0.65f + 17.45f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 6.81f + 0.00f + 17.45f, 0.65f + 17.45f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 7.09f + 0.00f + 17.45f, 0.65f + 17.45f, "p"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 7.63f + 0.00f + 17.45f, 0.65f + 17.45f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 7.90f + 0.00f + 17.45f, 0.65f + 17.45f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 8.18f + 0.00f + 17.45f, 0.65f + 17.45f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 8.45f + 0.00f + 17.45f, 0.65f + 17.45f, "a"));

            input.Notes.Add(new Data.NoteInfo(false, 8.72f + 17.45f, 0.65f + 17.45f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 9.81f + 17.45f, 0.65f + 17.45f, "space"));

            //3/1
            input.Notes.Add(new Data.NoteInfo(false, 2.18f + 8.72f + 17.45f, 0.65f + 17.45f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 2.72f + 8.72f + 17.45f, 0.65f + 17.45f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 3.27f + 8.72f + 17.45f, 0.65f + 17.45f, "space"));

            //basic scratch
            input.Notes.Add(new Data.NoteInfo(false, 13.09f + 17.45f, 0.65f + 17.45f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 0.27f + 13.09f + 17.45f, 0.65f + 17.45f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 0.40f + 13.09f + 17.45f, 0.65f + 17.45f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 0.54f + 13.09f + 17.45f, 0.65f + 17.45f, "p"));

            input.Notes.Add(new Data.NoteInfo(false, 14.18f + 17.45f, 0.65f + 17.45f, ";"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 7.63f + 7.64f + 17.45f, 0.65f + 17.45f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 7.90f + 7.64f + 17.45f, 0.65f + 17.45f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 8.18f + 7.64f + 17.45f, 0.65f + 17.45f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 8.45f + 7.64f + 17.45f, 0.65f + 17.45f, ";"));

            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 6.54f + 10.09f + 17.45f, 0.65f + 17.45f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 6.81f + 10.09f + 17.45f, 0.65f + 17.45f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 7.09f + 10.09f + 17.45f, 0.65f + 17.45f, "q"));


            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 17.45f + 0.00f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 18.00f + 0.00f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 18.54f + 0.00f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 19.09f + 0.00f, 0.65f, "d"));
            //additional
            input.Notes.Add(new Data.NoteInfo(false, 18.00f + 0.00f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 19.09f + 0.00f, 0.65f, "k"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 17.45f + 2.18f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 18.00f + 2.18f, 0.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 18.54f + 2.18f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 19.09f + 2.18f, 0.65f, "l"));
            //additional
            input.Notes.Add(new Data.NoteInfo(false, 18.00f + 2.18f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 19.09f + 2.18f, 0.65f, "d"));

            //basic scratch
            input.Notes.Add(new Data.NoteInfo(false, 21.81f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 0.27f + 21.81f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 0.40f + 21.81f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 0.54f + 21.81f, 0.65f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 22.90f, 0.65f, "f"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 23.59f + 0.00f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 23.72f + 0.00f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 23.86f + 0.00f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 19.09f + 0.00f, 0.65f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 24.00f, 0.65f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 25.09f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 25.09f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 25.63f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 25.63f, 0.65f, "j"));

            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 6.54f + 19.64f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 6.81f + 19.64f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 7.09f + 19.64f, 0.65f, "j"));

            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 6.54f + 20.73f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 6.81f + 20.73f, 0.65f, "d"));

            //4com
            input.Notes.Add(new Data.NoteInfo(false, 27.81f + 0.00f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 27.95f + 0.00f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 28.09f + 0.00f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 28.22f + 0.00f, 0.65f, "d"));

            //3/1
            input.Notes.Add(new Data.NoteInfo(false, 2.18f + 26.18f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.72f + 26.18f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.27f + 26.18f, 0.65f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 30.00f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.00f, 0.65f, "k"));

            //basic scratch
            input.Notes.Add(new Data.NoteInfo(false, 30.54f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 0.27f + 30.54f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.40f + 30.54f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 0.54f + 30.54f, 0.65f, "s"));

            input.Notes.Add(new Data.NoteInfo(true, 31.63f, 32.18f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 31.63f, 0.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 31.90f, 0.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 32.18f, 0.65f, "l"));
            //3/1
            input.Notes.Add(new Data.NoteInfo(false, 2.18f + 30.54f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.72f + 30.54f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.27f + 30.54f, 0.65f, "d"));
            //3/1
            input.Notes.Add(new Data.NoteInfo(false, 2.18f + 30.54f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 2.72f + 30.54f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.27f + 30.54f, 0.65f, "f"));
            //5com
            input.Notes.Add(new Data.NoteInfo(false, 108.00f - 73.91f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 108.13f - 73.91f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 108.27f - 73.91f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 108.40f - 73.91f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 108.54f - 73.91f, 0.65f, "f"));
            
            //basic scratch
            input.Notes.Add(new Data.NoteInfo(true, 34.09f, 34.90f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.27f + 34.90f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.40f + 34.90f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 0.54f + 34.90f, 0.65f, "s"));

            input.Notes.Add(new Data.NoteInfo(true, 36.00f, 37.09f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 36.00f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 37.09f, 0.65f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 37.63f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 37.63f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 38.18f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 38.18f, 0.65f, "f"));

            input.Notes.Add(new Data.NoteInfo(true, 38.45f, 39.27f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 39.27f, 37.09f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 39.95f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 40.22f, 0.65f, "s"));

            //3/1
            input.Notes.Add(new Data.NoteInfo(false, 2.18f + 39.27f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.72f + 39.27f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 42.40f, 0.65f, "s"));
            //3/1
            input.Notes.Add(new Data.NoteInfo(false, 2.18f + 39.27f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.72f + 39.27f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 42.40f, 0.65f, "j"));

            //4com
            input.Notes.Add(new Data.NoteInfo(false, 27.81f + 15.28f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 27.95f + 15.28f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 28.09f + 15.28f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 28.22f + 15.28f, 0.65f, "f"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 27.81f + 16.09f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 27.95f + 16.09f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 28.09f + 16.09f, 0.65f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 44.72f, 0.65f, "l"));

            //3/1
            input.Notes.Add(new Data.NoteInfo(false, 2.18f + 43.63f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 2.72f + 43.63f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 3.27f + 43.63f, 0.65f, "space"));
            //3/1
            input.Notes.Add(new Data.NoteInfo(false, 2.18f + 43.63f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.72f + 43.63f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 3.27f + 43.63f, 0.65f, "d"));

            input.Notes.Add(new Data.NoteInfo(true, 47.45f, 48.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 48.00f, 37.09f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 48.27f, 37.09f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 48.54f, 37.09f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 48.81f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 48.81f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 49.09f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 49.09f, 0.65f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 49.36f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 49.63f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 49.90f, 0.65f, "k"));

            input.Notes.Add(new Data.NoteInfo(true, 50.18f, 50.72f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 50.72f, 51.27f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 51.27f, 52.36f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 50.18f, 50.72f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 50.72f, 51.27f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 51.27f, 52.36f, "l"));

            //
            input.Notes.Add(new Data.NoteInfo(false, 52.36f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 52.36f, 0.65f, "j"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 52.63f + 0.00f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 52.77f + 0.00f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 52.90f + 0.00f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 52.63f + 0.00f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 52.90f + 0.00f, 0.65f, "l"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 52.63f + 0.55f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 52.77f + 0.55f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 52.90f + 0.55f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 52.90f + 0.55f, 0.65f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 53.72f, 0.65f, "f"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 52.63f + 1.37f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 52.77f + 1.37f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 52.90f + 1.37f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 52.63f + 1.37f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 52.90f + 1.37f, 0.65f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 54.54f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.81f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.81f, 0.65f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 55.09f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 55.22f, 0.65f, "f"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 52.63f + 2.73f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 52.77f + 2.73f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 52.90f + 2.73f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 52.63f + 2.73f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 52.90f + 2.73f, 0.65f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 55.90f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 56.18f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 56.45f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 55.90f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 56.18f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 56.45f, 0.65f, "j"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 52.63f + 4.09f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 52.77f + 4.09f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 52.90f + 4.09f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 52.90f + 4.09f, 0.65f, "s"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 52.63f + 4.5f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 52.77f + 4.5f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 52.77f + 4.5f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 52.90f + 4.5f, 0.65f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 57.54f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 57.54f, 0.65f, "f"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 52.63f + 5.18f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 52.63f + 5.18f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 52.77f + 5.18f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 52.90f + 5.18f, 0.65f, "j"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 52.63f + 5.59f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 52.77f + 5.59f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 52.90f + 5.59f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 52.90f + 5.59f, 0.65f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 58.63f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 58.77f, 0.65f, "s"));

            //4com
            input.Notes.Add(new Data.NoteInfo(false, 27.81f + 31.09f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 27.95f + 31.09f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 28.09f + 31.09f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 28.22f + 31.09f, 0.65f, "j"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 27.81f + 31.64f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 27.95f + 31.64f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 28.09f + 31.64f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 28.22f + 31.64f, 0.65f, "k"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 27.81f + 32.19f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 27.95f + 32.19f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 28.09f + 32.19f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 28.22f + 32.19f, 0.65f, "l"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 27.81f + 32.73f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 27.95f + 32.73f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 28.09f + 32.73f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 28.22f + 32.73f, 0.65f, "k"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 27.81f + 33.28f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 27.95f + 33.28f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 28.09f + 33.28f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 28.22f + 33.28f, 0.65f, "j"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 27.81f + 33.82f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 27.95f + 33.82f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 28.09f + 33.82f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 28.22f + 33.82f, 0.65f, "k"));

            //4com
            input.Notes.Add(new Data.NoteInfo(false, 27.81f + 34.37f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 27.81f + 34.37f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 27.95f + 34.37f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 28.09f + 34.37f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 28.09f + 34.37f, 0.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 28.22f + 34.37f, 0.65f, "d"));

            input.Notes.Add(new Data.NoteInfo(true, 62.72f, 63.27f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 62.72f, 63.27f, "k"));

            //4com
            input.Notes.Add(new Data.NoteInfo(false, 27.81f + 35.46f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 27.95f + 35.46f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 28.09f + 35.46f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 28.22f + 35.46f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 28.22f + 35.46f, 0.65f, "k"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 27.81f + 36.0f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 27.95f + 36.0f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 28.09f + 36.0f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 28.22f + 36.0f, 0.65f, "d"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 27.81f + 36.55f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 27.95f + 36.55f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 27.95f + 36.55f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 28.09f + 36.55f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 28.22f + 36.55f, 0.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 28.22f + 36.55f, 0.65f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 64.90f, 66.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 65.18f, 66.54f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 64.90f, 66.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 65.18f, 66.54f, "k"));
            //
            input.Notes.Add(new Data.NoteInfo(true, 65.45f, 66.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 66.00f, 66.54f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 66.54f, 67.09f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 65.45f, 66.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 66.00f, 66.54f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 66.54f, 67.09f, "a"));

            input.Notes.Add(new Data.NoteInfo(false, 67.22f, 66.54f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 67.36f, 67.09f, "j"));

            input.Notes.Add(new Data.NoteInfo(true, 67.63f, 69.81f, "l"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 7.63f + 60.0f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 7.90f + 60.0f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 8.18f + 60.0f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 8.45f + 60.0f, 0.65f, "f"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 52.63f + 16.09f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 52.77f + 16.09f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 52.90f + 16.09f, 0.65f, "s"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 7.63f + 60.0f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 7.90f + 60.0f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 8.18f + 60.0f, 0.65f, "f"));
            //rest time
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 17.45f + 52.36f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 18.00f + 52.36f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 18.54f + 52.36f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 19.09f + 52.36f, 0.65f, "k"));

            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 6.54f + 65.46f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 6.81f + 65.46f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 7.09f + 65.46f, 0.65f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 73.09f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 73.63f, 0.65f, "d"));

            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 6.54f + 67.64f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 6.81f + 67.64f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 7.09f + 67.64f, 0.65f, "f"));

            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 6.54f + 68.73f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 6.81f + 68.73f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 7.09f + 68.73f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 6.54f + 68.73f, 0.65f, "space"));

            input.Notes.Add(new Data.NoteInfo(false, 76.36f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 76.50f, 0.65f, "f"));

            input.Notes.Add(new Data.NoteInfo(true, 76.90f, 77.45f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 77.45f, 78.54f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 78.81f, 0.65f, "l"));

            //3/1
            input.Notes.Add(new Data.NoteInfo(false, 2.18f + 76.91f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 2.72f + 76.91f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.27f + 76.91f, 0.65f, "space"));

            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 6.54f + 74.18f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 6.81f + 74.18f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 7.09f + 74.18f, 0.65f, "s"));

            //3/1
            input.Notes.Add(new Data.NoteInfo(false, 2.18f + 79.63f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.72f + 79.63f, 0.65f, "f"));

            //basic scratch
            input.Notes.Add(new Data.NoteInfo(false, 82.90f, 0.65f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 0.27f + 82.90f, 0.65f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 0.40f + 82.90f, 0.65f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 0.54f + 82.90f, 0.65f, ";"));

            input.Notes.Add(new Data.NoteInfo(false, 84.00f, 0.65f, "space"));

            //3/1
            input.Notes.Add(new Data.NoteInfo(false, 2.18f + 82.91f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.72f + 82.91f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.27f + 82.91f, 0.65f, "f"));
            //3/1
            input.Notes.Add(new Data.NoteInfo(false, 2.18f + 82.91f, 0.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 2.72f + 82.91f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.27f + 82.91f, 0.65f, "j"));

            input.Notes.Add(new Data.NoteInfo(true, 86.72f, 87.27f, "space"));

            //piano solo
            input.Notes.Add(new Data.NoteInfo(false, 87.27f, 0.65f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 88.09f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 88.22f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 88.36f, 88.63f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 88.77f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 89.04f, 0.65f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 89.31f, 0.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 89.59f, 0.65f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 90.00f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 90.13f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 90.40f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 90.68f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 90.95f, 0.65f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 91.90f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 92.18f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 92.45f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 92.59f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 92.86f, 0.65f, "j"));

            input.Notes.Add(new Data.NoteInfo(true, 93.13f, 93.54f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 93.54f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 93.68f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 93.95f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 94.09f, 0.65f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 94.36f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 94.5f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 94.77f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 95.04f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 95.31f, 0.65f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 96.54f, 0.65f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 96.95f, 0.65f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 97.36f, 0.65f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 97.63f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 97.90f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 98.04f, 0.65f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 98.31f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 98.59f, 0.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 98.86f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 99.27f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 99.40f, 0.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 99.68f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 99.81f, 0.65f, "f"));

            //4com
            input.Notes.Add(new Data.NoteInfo(false, 27.81f + 72.55f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 27.95f + 72.55f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 28.09f + 72.55f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 28.22f + 72.55f, 0.65f, "j"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 27.81f + 73.09f, 0.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 27.95f + 73.09f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 28.09f + 73.09f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 28.22f + 73.09f, 0.65f, "f"));

            //4com
            input.Notes.Add(new Data.NoteInfo(false, 27.81f + 73.64f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 27.95f + 73.64f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 28.09f + 73.64f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 28.22f + 73.64f, 0.65f, "d"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 27.81f + 74.19f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 27.95f + 74.19f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 28.09f + 74.19f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 28.22f + 74.19f, 0.65f, "s"));

            //4com
            input.Notes.Add(new Data.NoteInfo(false, 27.81f + 74.73f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 27.95f + 74.73f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 28.09f + 74.73f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 28.22f + 74.73f, 0.65f, "j"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 27.81f + 75.28f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 27.95f + 75.28f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 28.09f + 75.28f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 28.22f + 75.28f, 0.65f, "k"));

            //4com
            input.Notes.Add(new Data.NoteInfo(false, 27.81f + 75.82f, 0.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 27.95f + 75.82f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 28.09f + 75.82f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 28.22f + 75.82f, 0.65f, "l"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 27.81f + 76.37f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 27.95f + 76.37f, 0.65f, "d"));


            input.Notes.Add(new Data.NoteInfo(false, 104.86f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 105.27f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 105.54f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 105.68f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 105.95f, 0.65f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 106.09f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 106.36f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 106.63f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 106.77f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 107.04f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 107.18f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 107.45f, 0.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 107.59f, 0.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 107.72f, 0.65f, "l"));
            //5com
            input.Notes.Add(new Data.NoteInfo(false, 108.00f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 108.13f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 108.27f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 108.40f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 108.54f, 0.65f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 108.95f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 109.09f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 109.36f, 0.65f, "s"));

            //4com
            input.Notes.Add(new Data.NoteInfo(false, 27.81f + 81.82f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 27.95f + 81.82f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 28.09f + 81.82f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 28.22f + 81.82f, 0.65f, "d"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 27.81f + 82.37f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 27.95f + 82.37f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 28.09f + 82.37f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 28.22f + 82.37f, 0.65f, "f"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 27.81f + 82.91f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 27.95f + 82.91f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 28.09f + 82.91f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 28.22f + 82.91f, 0.65f, "j"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 27.81f + 83.46f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 27.95f + 83.46f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 28.09f + 83.46f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 28.22f + 83.46f, 0.65f, "l"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 27.81f + 84.0f, 0.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 27.95f + 84.0f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 28.09f + 84.0f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 28.22f + 84.0f, 0.65f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 112.5f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 112.36f, 0.65f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 112.77f, 0.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 113.18f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 113.59f, 0.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 114.00f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 114.40f, 0.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 114.81f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 115.22f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 115.63f, 0.65f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 116.04f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 116.18f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 116.45f, 0.65f, "s"));
            //2com/0.25/2com
            input.Notes.Add(new Data.NoteInfo(false, 116.72f + 0.00f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 116.86f + 0.00f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 117.13f + 0.00f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 117.27f + 0.00f, 0.65f, "j"));
            //2com/0.25/2com
            input.Notes.Add(new Data.NoteInfo(false, 116.72f + 0.82f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 116.86f + 0.82f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 117.13f + 0.82f, 0.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 117.27f + 0.82f, 0.65f, "k"));
            //2com/0.25/2com
            input.Notes.Add(new Data.NoteInfo(false, 116.72f + 1.64f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 116.86f + 1.64f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 117.13f + 1.64f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 117.27f + 1.64f, 0.65f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 119.18f, 0.65f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 119.72f, 0.65f, ";"));

            
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 6.54f + 113.73f, 0.65f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 6.81f + 113.73f, 0.65f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 7.09f + 113.73f, 0.65f, "a"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 6.54f + 114.55f, 0.65f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 6.81f + 114.55f, 0.65f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 7.09f + 114.55f, 0.65f, "a"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 6.54f + 114.55f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 6.81f + 114.55f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 7.09f + 114.55f, 0.65f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 122.18f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 123.27f, 0.65f, "s"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 7.63f + 116.73f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 7.90f + 116.73f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.18f + 116.73f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 8.45f + 116.73f, 0.65f, "d"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 7.63f + 117.82f, 0.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 7.90f + 117.82f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 8.18f + 117.82f, 0.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 8.45f + 117.82f, 0.65f, "j"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 7.63f + 118.91f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 7.90f + 118.91f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 8.18f + 118.91f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 8.45f + 118.91f, 0.65f, "f"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 7.63f + 120.0f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 7.90f + 120.0f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 8.18f + 120.0f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 8.45f + 120.0f, 0.65f, "k"));

            input.Notes.Add(new Data.NoteInfo(true, 128.72f, 129.81f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 129.81f, 130.90f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 130.90f, 131.72f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 131.72f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 132.00f, 0.65f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 132.54f, 0.65f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 133.09f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 133.36f, 0.65f, "d"));

            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 6.54f + 127.91f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 6.81f + 127.91f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 7.09f + 127.91f, 0.65f, "f"));

            input.Notes.Add(new Data.NoteInfo(true, 135.27f, 135.81f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 135.81f, 136.36f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 136.36f, 136.90f, "j"));

            input.Notes.Add(new Data.NoteInfo(true, 137.45f, 138.54f, "k"));
            // final drum
            //1st drum/2
            input.Notes.Add(new Data.NoteInfo(false, 124.36f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.54f + 124.36f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.09f + 124.36f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.22f + 124.36f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.36f + 124.36f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.63f + 124.36f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.77f + 124.36f, 0.65f, "space"));
            //1st drum/2
            input.Notes.Add(new Data.NoteInfo(false, 126.54f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.54f + 126.54f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.09f + 126.54f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.22f + 126.54f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.36f + 126.54f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.63f + 126.54f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.77f + 126.54f, 0.65f, "space"));
            //1st drum/2
            input.Notes.Add(new Data.NoteInfo(false, 128.72f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.54f + 128.72f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.09f + 128.72f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.22f + 128.72f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.36f + 128.72f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.63f + 128.72f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.77f + 128.72f, 0.65f, "space"));
            //1st drum/2
            input.Notes.Add(new Data.NoteInfo(false, 130.90f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.54f + 130.90f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.09f + 130.90f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.22f + 130.90f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.36f + 130.90f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.63f + 130.90f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.77f + 130.90f, 0.65f, "space"));
            //1st drum/2
            input.Notes.Add(new Data.NoteInfo(false, 133.09f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.54f + 133.09f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.09f + 133.09f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.22f + 133.09f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.36f + 133.09f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.63f + 133.09f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.77f + 133.09f, 0.65f, "space"));
            //1st drum/2
            input.Notes.Add(new Data.NoteInfo(false, 135.27f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.54f + 135.27f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.09f + 135.27f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.22f + 135.27f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.36f + 135.27f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.63f + 135.27f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.77f + 135.27f, 0.65f, "space"));
 
            //1st drum/2
            input.Notes.Add(new Data.NoteInfo(false, 137.45f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.54f + 137.45f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.09f + 137.45f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.22f + 137.45f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.36f + 137.45f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.63f + 137.45f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.77f + 137.45f, 0.65f, "space"));

            //2/1/3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 139.63f + 0.00f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 140.18f + 0.00f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 140.72f + 0.00f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 141.00f + 0.00f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 141.27f + 0.00f, 0.65f, "d"));

            //2/1/3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 139.63f + 2.18f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 140.18f + 2.18f, 0.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 140.72f + 2.18f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 141.00f + 2.18f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 141.27f + 2.18f, 0.65f, "k"));

            //basic scratch
            input.Notes.Add(new Data.NoteInfo(false, 144.00f, 0.65f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 0.27f + 144.00f, 0.65f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 0.40f + 144.00f, 0.65f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 0.54f + 144.00f, 0.65f, "p"));

            input.Notes.Add(new Data.NoteInfo(true, 145.09f, 146.18f, "space"));

            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 6.54f + 139.64f, 0.65f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 6.81f + 139.64f, 0.65f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 7.09f + 139.64f, 0.65f, "q"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 6.54f + 139.64f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 6.81f + 139.64f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 7.09f + 139.64f, 0.65f, "space"));
        }
        else if (input.Difficulty.Equals("Extreme"))
        {
            input.Notes.Add(new Data.NoteInfo(true, 0.00f, 0.65f, "k"));
        }
    }
}
