using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class Deborah : MonoBehaviour
{

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
        MusicInfo.key = 9;
        MusicInfo.name = "Deborah";
        MusicInfo.composer = "Paul Bazooka";
        MusicInfo.visualizer = "PUNEW, DANZI";
        MusicInfo.music = clip;
        MusicInfo.bga_blur = bga_blur;
        MusicInfo.bga = bga;
        MusicInfo.list = new List<Data.Playdata>();
        ListInit();

        return MusicInfo;
    }
    void ListInit()
    {
        //int comboCalc = 0;
        Data.Playdata normal = new Data.Playdata();
        normal.Difficulty = "Normal";
        normal.catchParase = normal_img;
        normal.level = 4;
        /*CreateNote(normal);
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
        normal.max_combo = comboCalc;*/
        MusicInfo.list.Add(normal);

        //comboCalc = 0;
        Data.Playdata hard = new Data.Playdata();
        hard.Difficulty = "Hard";
        hard.level = 5;
        hard.catchParase = hard_img;
        /*CreateNote(hard);
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
        hard.max_combo = comboCalc;*/
        MusicInfo.list.Add(hard);

        //comboCalc = 0;
        Data.Playdata extreme = new Data.Playdata();
        extreme.Difficulty = "Extreme";
        extreme.level = 20;
        extreme.catchParase = extreme_img;
        /*CreateNote(extreme);
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
        extreme.max_combo = comboCalc;*/
        MusicInfo.list.Add(extreme);
    }
    public void getNote(Data.Playdata input)
    {
        int comboCalc = 0;
        CreateNote(input);
        foreach (Data.NoteInfo notes in input.Notes)
        {
                comboCalc++;
        }
        input.max_combo = comboCalc;
    }
    void CreateNote(Data.Playdata input)
    {
        input.Notes = new List<Data.NoteInfo>();
        if (input.Difficulty.Equals("Normal"))
        {
            input.Notes.Add(new Data.NoteInfo(true, 0.00f, 0.68f, "d"));
            //first zagg
            input.Notes.Add(new Data.NoteInfo(false, 0.90f +0.00f, 0.68f +0.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.36f +0.00f, 0.68f +0.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.81f +0.00f, 0.68f +0.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.04f +0.00f, 0.68f +0.00f, "f"));

            input.Notes.Add(new Data.NoteInfo(true, 2.50f +0.00f, 2.95f +0.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 2.95f +0.00f, 0.68f +0.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.40f +0.00f, 0.68f +0.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 3.86f +0.00f, 0.68f +0.00f, "j"));

            //4com
            input.Notes.Add(new Data.NoteInfo(false, 4.09f +0.00f, 0.68f +0.00f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 4.20f +0.00f, 0.68f +0.00f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 4.31f +0.00f, 0.68f +0.00f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 4.43f +0.00f, 0.68f +0.00f, ";"));

            input.Notes.Add(new Data.NoteInfo(true, 5.00f +0.00f, 5.45f +0.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 5.45f +0.00f, 0.68f +0.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 5.68f +0.00f, 0.68f +0.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 6.13f +0.00f, 6.59f +0.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 7.04f +0.00f, 0.68f +0.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 7.27f +0.00f, 0.68f +0.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 7.50f +0.00f, 7.95f +0.00f, "j"));
            //first zagg
            input.Notes.Add(new Data.NoteInfo(false, 0.90f + 7.28f, 0.68f + 7.28f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.36f + 7.28f, 0.68f + 7.28f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.81f + 7.28f, 0.68f + 7.28f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.04f + 7.28f, 0.68f + 7.28f, "f"));

            input.Notes.Add(new Data.NoteInfo(true, 2.50f + 7.28f, 2.95f + 7.28f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 2.95f + 7.28f, 0.68f + 7.28f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.40f + 7.28f, 0.68f + 7.28f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.86f + 7.28f, 0.68f + 7.28f, "l"));

            //4com
            input.Notes.Add(new Data.NoteInfo(false, 4.09f + 7.28f, 0.68f + 7.28f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 4.20f + 7.28f, 0.68f + 7.28f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 4.31f + 7.28f, 0.68f + 7.28f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 4.43f + 7.28f, 0.68f + 7.28f, ";"));

            input.Notes.Add(new Data.NoteInfo(true, 5.00f + 7.28f, 5.45f + 7.28f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 5.45f + 7.28f, 0.68f + 7.28f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 5.68f + 7.28f, 0.68f + 7.28f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 6.13f + 7.28f, 6.59f + 7.28f, "k"));

            input.Notes.Add(new Data.NoteInfo(true, 13.63f, 14.54f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 14.54f, 15.45f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.45f, 0.68f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 16.36f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 17.04f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 16.36f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 17.04f, 0.68f, "j"));

            input.Notes.Add(new Data.NoteInfo(true, 18.63f, 19.09f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 19.09f, 0.68f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 19.54f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 20.0f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 20.34f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 20.68f, 0.68f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 21.13f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 21.36f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 21.59f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 21.81f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 22.04f, 22.50f, "l"));

            input.Notes.Add(new Data.NoteInfo(true, 22.72f, 23.18f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 23.18f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 23.63f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 23.86f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 24.31f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 24.77f, 0.68f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 25.22f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 25.45f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 25.68f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 25.90f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 26.59f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 27.27f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 27.95f, 0.68f, "l"));

            input.Notes.Add(new Data.NoteInfo(true, 28.63f, 29.09f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 29.09f, 29.54f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 29.54f, 30.0f, "f"));

            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 30.0f+0.00f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 30.45f + 0.00f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.90f + 0.00f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 31.36f + 0.00f, 0.68f, "d"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 30.0f + 1.81f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 30.45f + 1.81f, 0.68f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 30.90f + 1.81f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 31.36f + 1.81f, 0.68f, "l"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 30.0f + 3.63f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.45f + 3.63f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 30.90f + 3.63f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 31.36f + 3.63f, 0.68f, "j"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 30.0f + 5.45f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.45f + 5.45f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 30.90f + 5.45f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 31.36f + 5.45f, 0.68f, "s"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 0.00f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 0.00f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 37.72f + 0.00f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 37.95f + 0.00f, 0.68f, "k"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 0.91f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 0.91f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 37.72f + 0.91f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 37.95f + 0.91f, 0.68f, "f"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 1.82f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 1.82f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 37.72f + 1.82f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 37.95f + 1.82f, 0.68f, "d"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 2.73f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 2.73f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 37.72f + 2.73f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 37.95f + 2.73f, 0.68f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 40.90f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 41.25f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 41.59f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 41.81f, 0.68f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 42.15f, 0.68f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 42.5f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 42.72f, 0.68f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 43.40f, 0.68f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 43.63f, 0.68f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 43.75f, 0.68f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 43.97f, 0.68f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 44.20f, 0.68f, ";"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 44.54f + 0.00f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 44.65f + 0.00f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 44.77f + 0.00f, 0.68f, "d"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 44.54f + 0.46f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 44.65f + 0.46f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 44.77f + 0.46f, 0.68f, "j"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 44.54f + 0.91f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 44.65f + 0.91f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 44.77f + 0.91f, 0.68f, "s"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 44.54f + 1.36f, 0.68f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 44.65f + 1.36f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 44.77f + 1.36f, 0.68f, "l"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 44.54f + 1.82f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 44.65f + 1.82f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 44.77f + 1.82f, 0.68f, "d"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 44.54f + 2.27f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 44.65f + 2.27f, 0.68f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 44.77f + 2.27f, 0.68f, "j"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 44.54f + 2.73f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 44.65f + 2.73f, 0.68f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 44.77f + 2.73f, 0.68f, "f"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 44.54f + 3.18f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 44.65f + 3.18f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 44.77f + 3.18f, 0.68f, "d"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 44.54f + 3.64f, 0.68f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 44.65f + 3.64f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 44.77f + 3.64f, 0.68f, "l"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 44.54f + 4.09f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 44.65f + 4.09f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 44.77f + 4.09f, 0.68f, "f"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 44.54f + 4.55f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 44.65f + 4.55f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 44.77f + 4.55f, 0.68f, "space"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 44.54f + 4.91f, 0.68f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 44.65f + 4.91f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 44.77f + 4.91f, 0.68f, "j"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 44.54f + 5.46f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 44.65f + 5.46f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 44.77f + 5.46f, 0.68f, "space"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 44.54f + 5.91f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 44.65f + 5.91f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 44.77f + 5.91f, 0.68f, "f"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 44.54f + 6.36f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 44.65f + 6.36f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 44.77f + 6.36f, 0.68f, "l"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 44.54f + 6.82f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 44.65f + 6.82f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 44.77f + 6.82f, 0.68f, "k"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 14.54f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 14.54f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 37.72f + 14.54f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 37.95f + 14.54f, 0.68f, "k"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 15.45f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 15.45f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 37.72f + 15.45f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 37.95f + 15.45f, 0.68f, "s"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 16.36f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 16.36f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 37.72f + 16.36f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 37.95f + 16.36f, 0.68f, "j"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 17.27f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 17.27f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 37.72f + 17.27f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 37.95f + 17.27f, 0.68f, "f"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 18.18f, 0.68f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 18.18f, 0.68f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 37.72f + 18.18f, 0.68f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 37.95f + 18.18f, 0.68f, "l"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 19.09f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 19.09f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 37.72f + 19.09f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 37.95f + 19.09f, 0.68f, "k"));

            //9com
            input.Notes.Add(new Data.NoteInfo(false, 44.54f + 12.73f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 44.65f + 12.73f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 44.77f + 12.73f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 44.54f + 13.07f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 44.65f + 13.07f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 44.77f + 13.07f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 44.54f + 13.41f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 44.65f + 13.41f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 44.77f + 13.41f, 0.68f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 59.09f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 60.68f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 62.72f, 0.68f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 64.31f, 0.68f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 66.36f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 67.95f, 0.68f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 70.0f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 70.22f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 70.45f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 70.68f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 70.90f, 0.68f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 71.13f, 0.68f, "l"));

            input.Notes.Add(new Data.NoteInfo(true, 71.59f, 72.27f, ";"));
            input.Notes.Add(new Data.NoteInfo(true, 72.27f, 72.72f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 72.72f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 72.95f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 73.18f, 0.68f, "f"));
            //second zigg
            input.Notes.Add(new Data.NoteInfo(false, 73.63f + 0.00f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 74.31f + 0.00f, 0.68f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 74.54f + 0.00f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 74.88f + 0.00f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 75.22f + 0.00f, 0.68f, "j"));
            //second zigg
            input.Notes.Add(new Data.NoteInfo(false, 73.63f + 1.82f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 74.31f + 1.82f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 74.54f + 1.82f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 74.88f + 1.82f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 75.22f + 1.82f, 0.68f, "k"));
            //second zigg
            input.Notes.Add(new Data.NoteInfo(false, 73.63f + 3.64f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 74.31f + 3.64f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 74.54f + 3.64f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 74.88f + 3.64f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 75.22f + 3.64f, 0.68f, "k"));
            //second zigg
            input.Notes.Add(new Data.NoteInfo(false, 73.63f + 5.46f, 0.68f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 74.31f + 5.46f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 74.54f + 5.46f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 74.88f + 5.46f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 75.22f + 5.46f, 0.68f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 80.90f, 0.68f, "s"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 44.54f + 36.59f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 44.65f + 36.59f, 0.68f, "d"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 44.54f + 36.93f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 44.65f + 36.93f, 0.68f, "k"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 44.54f + 37.27f, 0.68f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 44.65f + 37.27f, 0.68f, "k"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 44.54f + 37.61f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 44.65f + 37.61f, 0.68f, "d"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 44.54f + 37.96f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 44.65f + 37.96f, 0.68f, "s"));
            //4/0.66
            input.Notes.Add(new Data.NoteInfo(false, 82.84f + 0.00f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 83.18f + 0.00f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 83.52f + 0.00f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 83.86f + 0.00f, 0.68f, "d"));
            //4/0.66\
            input.Notes.Add(new Data.NoteInfo(false, 82.84f + 1.36f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 83.18f + 1.36f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 83.52f + 1.36f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 83.86f + 1.36f, 0.68f, "d"));
            //4/0.66
            input.Notes.Add(new Data.NoteInfo(false, 82.84f + 2.72f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 83.18f + 2.72f, 0.68f, "d"));

            //finale
            input.Notes.Add(new Data.NoteInfo(true, 88.18f, 88.63f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 88.63f, 0.65f, "s"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 4.09f + 85.0f, 0.68f + 85.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 4.20f + 85.0f, 0.68f + 85.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 4.31f + 85.0f, 0.68f + 85.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 4.43f + 85.0f, 0.68f + 0.00f, "f"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 52.27f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 52.27f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 37.72f + 52.27f, 0.68f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 37.95f + 52.27f, 0.68f, "k"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 4.09f + 86.36f, 0.68f + 86.36f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 4.20f + 86.36f, 0.68f + 86.36f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 4.31f + 86.36f, 0.68f + 86.36f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 4.43f + 86.36f, 0.68f + 0.00f, "d"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 53.63f, 0.68f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 53.63f, 0.68f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 37.72f + 53.63f, 0.68f, "q"));

            input.Notes.Add(new Data.NoteInfo(true, 91.81f, 92.27f, ";"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 4.09f + 88.18f, 0.68f , "q"));
            input.Notes.Add(new Data.NoteInfo(false, 4.20f + 88.18f, 0.68f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 4.31f + 88.18f, 0.68f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 4.43f + 88.18f, 0.68f, "a"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 55.45f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 55.45f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 37.72f + 55.45f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 37.95f + 55.45f, 0.68f, "k"));
            //6com
            input.Notes.Add(new Data.NoteInfo(false, 44.54f + 49.09f, 0.68f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 44.65f + 49.09f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 44.77f + 49.09f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 44.54f + 49.43f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 44.65f + 49.43f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 44.77f + 49.43f, 0.68f, "f"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 57.27f, 0.68f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 57.27f, 0.68f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 37.72f + 57.27f, 0.68f, "p"));

            input.Notes.Add(new Data.NoteInfo(true, 95.45f, 95.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 95.9f, 0.68f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 96.13f, 0.68f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 96.36f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 96.59f, 0.68f, "d"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 59.54f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 59.54f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 37.72f + 59.54f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 37.95f + 59.54f, 0.68f, "j"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 4.09f + 93.63f, 0.68f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 4.20f + 93.63f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 4.31f + 93.63f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 4.43f + 93.63f, 0.68f, "k"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 60.91f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 60.91f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 37.72f + 60.91f, 0.68f, "f"));

            input.Notes.Add(new Data.NoteInfo(true, 99.09f, 99.54f, "space"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 4.09f + 95.45f, 0.68f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 4.20f + 95.45f, 0.68f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 4.31f + 95.45f, 0.68f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 4.43f + 95.45f, 0.68f, "a"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 62.73f, 0.68f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 62.73f, 0.68f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 37.72f + 62.73f, 0.68f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 37.95f + 62.73f, 0.68f, ";"));
            //6com
            input.Notes.Add(new Data.NoteInfo(false, 44.54f + 56.36f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 44.65f + 56.36f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 44.77f + 56.36f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 44.54f + 56.71f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 44.65f + 56.71f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 44.77f + 56.71f, 0.68f, "l"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 64.54f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 64.54f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 37.72f + 64.54f, 0.68f, "j"));

            input.Notes.Add(new Data.NoteInfo(true, 102.72f, 103.18f, "f"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 4.09f + 99.09f, 0.68f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 4.20f + 99.09f, 0.68f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 4.31f + 99.09f, 0.68f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 4.43f + 99.09f, 0.68f, ";"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 66.36f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 66.36f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 37.72f + 66.36f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 37.95f + 66.36f, 0.68f, "j"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 67.27f, 0.68f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 67.27f, 0.68f, "j"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 4.09f + 100.91f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 4.20f + 100.91f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 4.31f + 100.91f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 4.43f + 100.91f, 0.68f, "d"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 68.18f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 68.18f, 0.68f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 37.72f + 68.18f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 37.95f + 68.18f, 0.68f, "k"));

            input.Notes.Add(new Data.NoteInfo(true, 106.36f, 106.81f, "l"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 4.09f + 102.72f, 0.68f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 4.20f + 102.72f, 0.68f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 4.31f + 102.72f, 0.68f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 4.43f + 102.72f, 0.68f, ";"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 70.0f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 70.0f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 37.72f + 70.0f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 37.95f + 70.0f, 0.68f, "f"));
            //6com
            input.Notes.Add(new Data.NoteInfo(false, 4.09f + 104.09f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 4.20f + 104.09f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 4.31f + 104.09f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 4.09f + 104.43f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 4.20f + 104.43f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 4.31f + 104.43f, 0.68f, "k"));
            //
            input.Notes.Add(new Data.NoteInfo(false, 109.07f, 106.81f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 109.54f, 110.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(true, 110.0f, 110.45f, "d"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 4.09f + 106.36f, 0.68f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 4.20f + 106.36f, 0.68f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 4.31f + 106.36f, 0.68f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 4.43f + 106.36f, 0.68f, "p"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 73.63f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 73.63f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 37.72f + 73.63f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 37.95f + 73.63f, 0.68f, "d"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 74.54f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 74.54f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 37.72f + 74.54f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 37.95f + 74.54f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 112.72f, 113.18f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 113.18f, 113.63f, "j"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 76.36f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 76.36f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 37.72f + 76.36f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 37.95f + 76.36f, 0.68f, "k"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 77.27f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 77.27f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 37.72f + 77.27f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 37.95f + 77.27f, 0.68f, "s"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 78.18f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 78.18f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 37.72f + 78.18f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 37.95f + 78.18f, 0.68f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 116.36f, 106.81f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 116.47f, 106.81f, "f"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 4.09f + 112.72f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 4.20f + 112.72f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 4.31f + 112.72f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 4.43f + 112.72f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 117.27f, 106.81f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 117.27f, 106.81f, "l"));
        }
        else if (input.Difficulty.Equals("Hard"))
        {
            input.Notes.Add(new Data.NoteInfo(false, 0.00f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.22f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 0.34f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 0.45f, 0.68f, "d"));
            //first zagg
            input.Notes.Add(new Data.NoteInfo(false, 0.90f + 0.00f, 0.68f + 0.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.36f + 0.00f, 0.68f + 0.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.81f + 0.00f, 0.68f + 0.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.04f + 0.00f, 0.68f + 0.00f, "d"));

            input.Notes.Add(new Data.NoteInfo(true, 2.50f + 0.00f, 2.95f + 0.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 2.95f + 0.00f, 0.68f + 0.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.40f + 0.00f, 0.68f + 0.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.86f + 0.00f, 0.68f + 0.00f, "d"));

            //4com
            input.Notes.Add(new Data.NoteInfo(false, 4.09f + 0.00f, 0.68f + 0.00f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 4.20f + 0.00f, 0.68f + 0.00f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 4.31f + 0.00f, 0.68f + 0.00f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 4.43f + 0.00f, 0.68f + 0.00f, ";"));

            input.Notes.Add(new Data.NoteInfo(true, 5.00f + 0.00f, 5.45f + 0.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 5.45f + 0.00f, 0.68f + 0.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 5.68f + 0.00f, 0.68f + 0.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 6.13f + 0.00f, 6.59f + 0.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 7.04f + 0.00f, 0.68f + 0.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 7.27f + 0.00f, 0.68f + 0.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 7.50f + 0.00f, 7.95f + 0.00f, "d"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.90f + 0.00f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.13f + 0.00f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.36f + 0.00f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.59f + 0.00f, 0.68f, "f"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.90f + 0.91f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.13f + 0.91f, 0.68f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 1.36f + 0.91f, 0.68f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 1.59f + 0.91f, 0.68f, "j"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.90f + 1.82f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.13f + 1.82f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.36f + 1.82f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.59f + 1.82f, 0.68f, "s"));

            input.Notes.Add(new Data.NoteInfo(true, 3.63f, 3.97f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 0.90f + 3.19f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.13f + 3.19f, 0.68f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 1.36f + 3.19f, 0.68f, "f"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.90f + 3.87f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.13f + 3.87f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.36f + 3.87f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.59f + 3.87f, 0.68f, "j"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.90f + 4.78f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.13f + 4.78f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.36f + 4.78f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.59f + 4.78f, 0.68f, "l"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.90f + 5.69f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.13f + 5.69f, 0.68f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 1.36f + 5.69f, 0.68f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 1.59f + 5.69f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 7.50f + 0.00f, 7.95f + 0.00f, "f"));
            //first zagg
            input.Notes.Add(new Data.NoteInfo(false, 0.90f + 7.28f, 0.68f + 7.28f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.36f + 7.28f, 0.68f + 7.28f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.81f + 7.28f, 0.68f + 7.28f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.04f + 7.28f, 0.68f + 7.28f, "f"));

            input.Notes.Add(new Data.NoteInfo(true, 2.50f + 7.28f, 2.95f + 7.28f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 2.95f + 7.28f, 0.68f + 7.28f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.40f + 7.28f, 0.68f + 7.28f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.86f + 7.28f, 0.68f + 7.28f, "l"));

            //4com
            input.Notes.Add(new Data.NoteInfo(false, 4.09f + 7.28f, 0.68f + 7.28f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 4.20f + 7.28f, 0.68f + 7.28f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 4.31f + 7.28f, 0.68f + 7.28f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 4.43f + 7.28f, 0.68f + 7.28f, ";"));

            input.Notes.Add(new Data.NoteInfo(true, 5.00f + 7.28f, 5.45f + 7.28f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 5.45f + 7.28f, 0.68f + 7.28f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 5.68f + 7.28f, 0.68f + 7.28f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 6.13f + 7.28f, 6.59f + 7.28f, "k"));

            input.Notes.Add(new Data.NoteInfo(true, 13.63f, 14.54f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 14.54f, 15.45f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.45f, 0.68f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 16.36f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 17.04f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 16.36f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 17.04f, 0.68f, "j"));

            input.Notes.Add(new Data.NoteInfo(true, 18.63f, 19.09f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 19.09f, 0.68f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 19.54f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 20.0f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 20.34f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 20.68f, 0.68f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 21.13f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 21.36f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 21.59f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 21.81f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 22.04f, 22.50f, "l"));

            input.Notes.Add(new Data.NoteInfo(true, 22.72f, 23.18f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 23.18f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 23.63f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 23.86f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 24.31f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 24.77f, 0.68f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 25.22f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 25.45f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 25.68f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 25.90f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 26.59f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 27.27f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 27.95f, 0.68f, "l"));

            input.Notes.Add(new Data.NoteInfo(true, 28.63f, 29.09f, "d"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 4.09f + 24.54f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 4.20f + 24.54f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 4.31f + 24.54f, 0.68f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 29.09f, 29.54f, "s"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 4.09f + 25.0f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 4.20f + 25.0f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 4.31f + 25.0f, 0.68f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 29.54f, 30.0f, "f"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 4.09f + 25.45f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 4.20f + 25.45f, 0.68f, "k"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 30.0f + 0.00f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 30.45f + 0.00f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.90f + 0.00f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 31.36f + 0.00f, 0.68f, "d"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 30.0f + 1.81f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 30.45f + 1.81f, 0.68f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 30.90f + 1.81f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 31.36f + 1.81f, 0.68f, "l"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 30.0f + 3.63f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.45f + 3.63f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 30.90f + 3.63f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 31.36f + 3.63f, 0.68f, "j"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 30.0f + 5.45f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.45f + 5.45f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 30.90f + 5.45f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 31.36f + 5.45f, 0.68f, "s"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(true, 30.0f + 0.00f, 30.0f + 0.00f+ 0.22f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 30.45f + 0.00f, 30.45f + 0.00f+0.22f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 30.90f + 0.00f, 30.90f + 0.00f+0.22f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 31.36f + 0.00f, 31.36f + 0.00f+0.22f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(true, 30.0f + 1.81f, 30.0f + 1.81f+ 0.22f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 30.45f + 1.81f, 30.45f + 1.81f+0.22f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 30.90f + 1.81f, 30.90f + 1.81f+0.22f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 31.36f + 1.81f, 31.36f + 1.81f+0.22f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(true, 30.0f + 3.63f, 30.0f + 3.63f+ 0.22f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 30.45f + 3.63f, 30.45f + 3.63f+0.22f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 30.90f + 3.63f, 30.90f + 3.63f+0.22f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 31.36f + 3.63f, 31.36f + 3.63f+0.22f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(true, 30.0f + 5.45f, 30.0f + 5.45f+ 0.22f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 30.45f + 5.45f, 30.45f + 5.45f+0.22f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 30.90f + 5.45f, 30.90f + 5.45f+0.22f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 31.36f + 5.45f, 31.36f + 5.45f+ 0.22f, "space"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 0.00f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 0.00f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 37.72f + 0.00f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 37.95f + 0.00f, 0.68f, "k"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 0.91f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 0.91f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 37.72f + 0.91f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 37.95f + 0.91f, 0.68f, "f"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 1.82f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 1.82f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 37.72f + 1.82f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 37.95f + 1.82f, 0.68f, "d"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 2.73f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 2.73f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 37.72f + 2.73f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 37.95f + 2.73f, 0.68f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 40.90f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 41.25f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 41.59f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 41.81f, 0.68f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 42.15f, 0.68f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 42.5f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 42.72f, 0.68f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 43.40f, 0.68f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 43.63f, 0.68f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 43.75f, 0.68f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 43.97f, 0.68f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 44.20f, 0.68f, ";"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 44.54f + 0.00f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 44.65f + 0.00f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 44.77f + 0.00f, 0.68f, "d"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 44.54f + 0.46f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 44.65f + 0.46f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 44.77f + 0.46f, 0.68f, "j"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 44.54f + 0.91f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 44.65f + 0.91f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 44.77f + 0.91f, 0.68f, "s"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 44.54f + 1.36f, 0.68f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 44.65f + 1.36f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 44.77f + 1.36f, 0.68f, "l"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 44.54f + 1.82f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 44.65f + 1.82f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 44.77f + 1.82f, 0.68f, "d"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 44.54f + 2.27f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 44.65f + 2.27f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 44.77f + 2.27f, 0.68f, "j"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 44.54f + 2.73f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 44.65f + 2.73f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 44.77f + 2.73f, 0.68f, "f"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 44.54f + 3.18f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 44.65f + 3.18f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 44.77f + 3.18f, 0.68f, "d"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 44.54f + 3.64f, 0.68f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 44.65f + 3.64f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 44.77f + 3.64f, 0.68f, "l"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 44.54f + 4.09f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 44.65f + 4.09f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 44.77f + 4.09f, 0.68f, "f"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 44.54f + 4.55f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 44.65f + 4.55f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 44.77f + 4.55f, 0.68f, "j"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 44.54f + 4.91f, 0.68f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 44.65f + 4.91f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 44.77f + 4.91f, 0.68f, "j"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 44.54f + 5.46f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 44.65f + 5.46f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 44.77f + 5.46f, 0.68f, "f"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 44.54f + 5.91f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 44.65f + 5.91f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 44.77f + 5.91f, 0.68f, "f"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 44.54f + 6.36f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 44.65f + 6.36f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 44.77f + 6.36f, 0.68f, "l"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 44.54f + 6.82f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 44.65f + 6.82f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 44.77f + 6.82f, 0.68f, "k"));
            //base
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 30.0f + 14.54f, 0.68f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 30.45f + 14.54f, 0.68f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 30.90f + 14.54f, 0.68f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 31.36f + 14.54f, 0.68f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 30.0f + 16.36f, 0.68f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 30.45f + 16.36f, 0.68f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 30.90f + 16.36f, 0.68f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 31.36f + 16.36f, 0.68f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 30.0f + 18.18f, 0.68f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 30.45f + 18.18f, 0.68f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 30.90f + 18.18f, 0.68f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 31.36f + 18.18f, 0.68f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 30.0f + 20.0f, 0.68f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 30.45f + 20.0f, 0.68f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 30.90f + 20.0f, 0.68f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 31.36f + 20.0f, 0.68f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 30.0f + 21.81f, 0.68f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 30.45f + 21.81f, 0.68f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 30.90f + 21.81f, 0.68f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 31.36f + 21.81f, 0.68f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 30.0f + 23.63f, 0.68f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 30.45f + 23.63f, 0.68f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 30.90f + 23.63f, 0.68f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 31.36f + 23.63f, 0.68f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 30.0f + 25.45f, 0.68f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 30.45f + 25.45f, 0.68f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 30.90f + 25.45f, 0.68f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 31.36f + 25.45f, 0.68f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 30.0f + 27.27f, 0.68f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 30.45f + 27.27f, 0.68f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 30.90f + 27.27f, 0.68f, "space"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 14.54f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 14.54f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 37.72f + 14.54f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 37.95f + 14.54f, 0.68f, "k"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 15.45f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 15.45f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 37.72f + 15.45f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 37.95f + 15.45f, 0.68f, "s"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 16.36f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 16.36f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 37.72f + 16.36f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 37.95f + 16.36f, 0.68f, "j"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 17.27f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 17.27f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 37.72f + 17.27f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 37.95f + 17.27f, 0.68f, "f"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 18.18f, 0.68f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 18.18f, 0.68f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 37.72f + 18.18f, 0.68f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 37.95f + 18.18f, 0.68f, "l"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 19.09f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 19.09f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 37.72f + 19.09f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 37.95f + 19.09f, 0.68f, "k"));

            //9com
            input.Notes.Add(new Data.NoteInfo(false, 44.54f + 12.73f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 44.65f + 12.73f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 44.77f + 12.73f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 44.54f + 13.07f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 44.65f + 13.07f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 44.77f + 13.07f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 44.54f + 13.41f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 44.65f + 13.41f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 44.77f + 13.41f, 0.68f, "s"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 21.82f, 0.68f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 21.82f, 0.68f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 37.72f + 21.82f, 0.68f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 37.95f + 21.82f, 0.68f, "a"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 22.73f, 0.68f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 22.73f, 0.68f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 37.72f + 22.73f, 0.68f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 37.95f + 22.73f, 0.68f, "p"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 23.63f, 0.68f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 23.63f, 0.68f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 37.72f + 23.63f, 0.68f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 37.95f + 23.63f, 0.68f, "q"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 24.54f, 0.68f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 24.54f, 0.68f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 37.72f + 24.54f, 0.68f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 37.95f + 24.54f, 0.68f, ";"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 25.45f, 0.68f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 25.45f, 0.68f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 37.72f + 25.45f, 0.68f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 37.95f + 25.45f, 0.68f, "a"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 26.36f, 0.68f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 26.36f, 0.68f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 37.72f + 26.36f, 0.68f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 37.95f + 26.36f, 0.68f, "q"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 27.27f, 0.68f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 27.27f, 0.68f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 37.72f + 27.27f, 0.68f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 37.95f + 27.27f, 0.68f, "p"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 28.18f, 0.68f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 28.18f, 0.68f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 37.72f + 28.18f, 0.68f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 37.95f + 28.18f, 0.68f, ";"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 29.09f, 0.68f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 29.09f, 0.68f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 37.72f + 29.09f, 0.68f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 37.95f + 29.09f, 0.68f, "a"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 30.0f, 0.68f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 30.0f, 0.68f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 37.72f + 30.0f, 0.68f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 37.95f + 30.0f, 0.68f, "p"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 30.91f, 0.68f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 30.91f, 0.68f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 37.72f + 30.91f, 0.68f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 37.95f + 30.91f, 0.68f, ";"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 31.82f, 0.68f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 31.82f, 0.68f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 37.72f + 31.82f, 0.68f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 37.95f + 31.82f, 0.68f, "a"));

            input.Notes.Add(new Data.NoteInfo(false, 59.09f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 60.68f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 62.72f, 0.68f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 64.31f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 66.36f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 67.95f, 0.68f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 70.0f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 70.22f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 70.45f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 70.68f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 70.90f, 0.68f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 71.13f, 0.68f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 71.36f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 71.59f, 0.68f, "d"));

            input.Notes.Add(new Data.NoteInfo(true, 71.59f, 72.27f, ";"));
            input.Notes.Add(new Data.NoteInfo(true, 72.27f, 72.72f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 72.72f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 72.95f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 73.18f, 0.68f, "f"));
            //second zigg
            input.Notes.Add(new Data.NoteInfo(false, 73.63f + 0.00f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 74.31f + 0.00f, 0.68f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 74.54f + 0.00f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 74.88f + 0.00f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 75.22f + 0.00f, 0.68f, "j"));
            //second zigg
            input.Notes.Add(new Data.NoteInfo(false, 73.63f + 1.82f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 74.31f + 1.82f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 74.54f + 1.82f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 74.88f + 1.82f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 75.22f + 1.82f, 0.68f, "k"));
            //second zigg
            input.Notes.Add(new Data.NoteInfo(false, 73.63f + 3.64f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 74.31f + 3.64f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 74.54f + 3.64f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 74.88f + 3.64f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 75.22f + 3.64f, 0.68f, "k"));
            //second zigg
            input.Notes.Add(new Data.NoteInfo(false, 73.63f + 5.46f, 0.68f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 74.31f + 5.46f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 74.54f + 5.46f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 74.88f + 5.46f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 75.22f + 5.46f, 0.68f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 80.90f, 0.68f, "s"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 44.54f + 36.59f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 44.65f + 36.59f, 0.68f, "d"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 44.54f + 36.93f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 44.65f + 36.93f, 0.68f, "k"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 44.54f + 37.27f, 0.68f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 44.65f + 37.27f, 0.68f, "k"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 44.54f + 37.61f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 44.65f + 37.61f, 0.68f, "d"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 44.54f + 37.96f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 44.65f + 37.96f, 0.68f, "s"));
            //4/0.66
            input.Notes.Add(new Data.NoteInfo(false, 82.84f + 0.00f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 83.18f + 0.00f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 83.52f + 0.00f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 83.86f + 0.00f, 0.68f, "d"));
            //4/0.66\
            input.Notes.Add(new Data.NoteInfo(false, 82.84f + 1.36f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 83.18f + 1.36f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 83.52f + 1.36f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 83.86f + 1.36f, 0.68f, "d"));
            //4/0.66
            input.Notes.Add(new Data.NoteInfo(false, 82.84f + 2.72f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 83.18f + 2.72f, 0.68f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 86.43f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 86.66f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 86.81f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 87.04f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 87.27f, 0.68f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 86.43f, 0.68f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 86.66f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 86.81f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 87.04f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 87.27f, 0.68f, "l"));
            //finale
            input.Notes.Add(new Data.NoteInfo(true, 88.18f, 88.63f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 88.63f, 0.65f, "s"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 4.09f + 85.0f, 0.68f + 85.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 4.20f + 85.0f, 0.68f + 85.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 4.31f + 85.0f, 0.68f + 85.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 4.43f + 85.0f, 0.68f + 0.00f, "f"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 52.27f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 52.27f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 37.72f + 52.27f, 0.68f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 37.95f + 52.27f, 0.68f, "k"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 4.09f + 86.36f, 0.68f + 86.36f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 4.20f + 86.36f, 0.68f + 86.36f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 4.31f + 86.36f, 0.68f + 86.36f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 4.43f + 86.36f, 0.68f + 0.00f, "d"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 53.63f, 0.68f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 53.63f, 0.68f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 37.72f + 53.63f, 0.68f, "q"));

            input.Notes.Add(new Data.NoteInfo(true, 91.81f, 92.27f, ";"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 4.09f + 88.18f, 0.68f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 4.20f + 88.18f, 0.68f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 4.31f + 88.18f, 0.68f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 4.43f + 88.18f, 0.68f, "a"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 55.45f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 55.45f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 37.72f + 55.45f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 37.95f + 55.45f, 0.68f, "k"));
            //6com
            input.Notes.Add(new Data.NoteInfo(false, 44.54f + 49.09f, 0.68f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 44.65f + 49.09f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 44.77f + 49.09f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 44.54f + 49.43f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 44.65f + 49.43f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 44.77f + 49.43f, 0.68f, "f"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 57.27f, 0.68f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 57.27f, 0.68f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 37.72f + 57.27f, 0.68f, "p"));

            input.Notes.Add(new Data.NoteInfo(true, 95.45f, 95.9f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 95.9f, 0.68f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 96.13f, 0.68f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 96.36f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 96.59f, 0.68f, "d"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 59.54f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 59.54f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 37.72f + 59.54f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 37.95f + 59.54f, 0.68f, "j"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 4.09f + 93.63f, 0.68f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 4.20f + 93.63f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 4.31f + 93.63f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 4.43f + 93.63f, 0.68f, "k"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 60.91f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 60.91f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 37.72f + 60.91f, 0.68f, "f"));

            input.Notes.Add(new Data.NoteInfo(true, 99.09f, 99.54f, "d"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 4.09f + 95.45f, 0.68f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 4.20f + 95.45f, 0.68f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 4.31f + 95.45f, 0.68f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 4.43f + 95.45f, 0.68f, "a"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 62.73f, 0.68f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 62.73f, 0.68f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 37.72f + 62.73f, 0.68f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 37.95f + 62.73f, 0.68f, ";"));
            //6com
            input.Notes.Add(new Data.NoteInfo(false, 44.54f + 56.36f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 44.65f + 56.36f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 44.77f + 56.36f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 44.54f + 56.71f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 44.65f + 56.71f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 44.77f + 56.71f, 0.68f, "l"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 64.54f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 64.54f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 37.72f + 64.54f, 0.68f, "j"));

            input.Notes.Add(new Data.NoteInfo(true, 102.72f, 103.18f, "f"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 4.09f + 99.09f, 0.68f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 4.20f + 99.09f, 0.68f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 4.31f + 99.09f, 0.68f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 4.43f + 99.09f, 0.68f, ";"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 66.36f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 66.36f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 37.72f + 66.36f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 37.95f + 66.36f, 0.68f, "j"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 67.27f, 0.68f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 67.27f, 0.68f, "j"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 4.09f + 100.91f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 4.20f + 100.91f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 4.31f + 100.91f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 4.43f + 100.91f, 0.68f, "d"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 68.18f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 68.18f, 0.68f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 37.72f + 68.18f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 37.95f + 68.18f, 0.68f, "k"));

            input.Notes.Add(new Data.NoteInfo(true, 106.36f, 106.81f, "l"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 4.09f + 102.72f, 0.68f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 4.20f + 102.72f, 0.68f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 4.31f + 102.72f, 0.68f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 4.43f + 102.72f, 0.68f, ";"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 70.0f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 70.0f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 37.72f + 70.0f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 37.95f + 70.0f, 0.68f, "f"));
            //6com
            input.Notes.Add(new Data.NoteInfo(false, 4.09f + 104.09f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 4.20f + 104.09f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 4.31f + 104.09f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 4.09f + 104.43f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 4.20f + 104.43f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 4.31f + 104.43f, 0.68f, "k"));
            //
            input.Notes.Add(new Data.NoteInfo(false, 109.07f, 106.81f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 109.54f, 110.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(true, 110.0f, 110.45f, "d"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 4.09f + 106.36f, 0.68f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 4.20f + 106.36f, 0.68f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 4.31f + 106.36f, 0.68f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 4.43f + 106.36f, 0.68f, "p"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 73.63f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 73.63f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 37.72f + 73.63f, 0.68f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 37.95f + 73.63f, 0.68f, "d"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 74.54f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 74.54f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 37.72f + 74.54f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 37.95f + 74.54f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 112.72f, 113.18f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 113.18f, 113.63f, "j"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 30.0f + 65.45f, 0.68f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 30.45f + 65.45f, 0.68f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 30.90f + 65.45f, 0.68f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 31.36f + 65.45f, 0.68f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 30.0f + 67.27f, 0.68f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 30.45f + 67.27f, 0.68f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 30.90f + 67.27f, 0.68f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 31.36f + 67.27f, 0.68f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 30.0f + 69.09f, 0.68f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 30.45f + 69.09f, 0.68f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 30.90f + 69.09f, 0.68f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 31.36f + 69.09f, 0.68f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 30.0f + 70.9f, 0.68f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 30.45f + 70.9f, 0.68f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 30.90f + 70.9f, 0.68f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 31.36f + 70.9f, 0.68f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 30.0f + 72.72f, 0.68f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 30.45f + 72.72f, 0.68f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 30.90f + 72.72f, 0.68f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 31.36f + 72.72f, 0.68f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 30.0f + 74.54f, 0.68f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 30.45f + 74.54f, 0.68f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 30.90f + 74.54f, 0.68f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 31.36f + 74.54f, 0.68f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 30.0f + 76.36f, 0.68f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 30.45f + 76.36f, 0.68f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 30.90f + 76.36f, 0.68f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 31.36f + 76.36f, 0.68f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 30.0f + 78.18f, 0.68f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 30.45f + 78.18f, 0.68f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 30.90f + 78.18f, 0.68f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 31.36f + 78.18f, 0.68f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 30.0f + 80.0f, 0.68f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 30.45f + 80.0f, 0.68f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 30.90f + 80.0f, 0.68f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 31.36f + 80.0f, 0.68f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 30.0f + 81.81f, 0.68f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 30.45f + 81.81f, 0.68f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 30.90f + 81.81f, 0.68f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 31.36f + 81.81f, 0.68f, "space"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 76.36f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 76.36f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 37.72f + 76.36f, 0.68f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 37.95f + 76.36f, 0.68f, "k"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 77.27f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 77.27f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 37.72f + 77.27f, 0.68f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 37.95f + 77.27f, 0.68f, "s"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 37.27f + 78.18f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 37.50f + 78.18f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 37.72f + 78.18f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 37.95f + 78.18f, 0.68f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 116.36f, 106.81f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 116.47f, 106.81f, "f"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 4.09f + 112.72f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 4.20f + 112.72f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 4.31f + 112.72f, 0.68f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 4.43f + 112.72f, 0.68f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 117.27f, 106.81f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 117.27f, 106.81f, "l"));

            input.Notes.Add(new Data.NoteInfo(true, 113.63f, 114.54f, "a"));
            input.Notes.Add(new Data.NoteInfo(true, 114.54f, 115.45f, "p"));
            input.Notes.Add(new Data.NoteInfo(true, 115.45f, 116.36f, "a"));
            input.Notes.Add(new Data.NoteInfo(true, 116.36f, 116.81f, "p"));
            input.Notes.Add(new Data.NoteInfo(true, 116.81f, 117.27f, "q"));
        }
        else if (input.Difficulty.Equals("Extreme"))
        {
            input.Notes.Add(new Data.NoteInfo(true, 0.00f, 0.65f, "k"));
        }
    }
}
