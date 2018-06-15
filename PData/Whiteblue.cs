using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Whiteblue : MonoBehaviour {
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
        MusicInfo.key = 3;
        MusicInfo.name = "WhiteBlue";
        MusicInfo.composer = "zts";
        MusicInfo.visualizer = "Moses";
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
        normal.level = 2;
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
        hard.level = 8;
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
        if (input.Difficulty.Equals("Normal")) {
            input.Notes.Add(new Data.NoteInfo(true, 0.00f + 0.0f, 1.00f+0.0f, "j"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 1.00f + 0.00f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.41f + 0.00f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.83f + 0.00f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.25f + 0.00f, 0.0f, "f"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 1.00f + 1.66f, 1.66f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.41f + 1.66f, 1.66f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.83f + 1.66f, 1.66f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.25f + 1.66f, 1.66f, "d"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 1.00f + 3.33f, 3.33f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.41f + 3.33f, 3.33f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.83f + 3.33f, 3.33f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 2.25f + 3.33f, 3.33f, "k"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 1.00f + 5.0f, 5.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.41f + 5.0f, 5.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.83f + 5.0f, 5.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.25f + 5.0f, 5.0f, "j"));
            //scratch1
            input.Notes.Add(new Data.NoteInfo(false, 7.87f + 0.00f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 8.29f + 0.00f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 8.70f + 0.00f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.81f + 0.00f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 9.12f + 0.00f, 0.0f, "s"));
            //scratch1
            input.Notes.Add(new Data.NoteInfo(false, 7.87f + 1.67f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 8.29f + 1.67f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 8.70f + 1.67f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 8.81f + 1.67f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 9.12f + 1.67f, 0.0f, "j"));
            //scratch1
            input.Notes.Add(new Data.NoteInfo(false, 7.87f + 3.33f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.29f + 3.33f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 8.70f + 3.33f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 8.81f + 3.33f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 9.12f + 3.33f, 0.0f, "d"));
            //scratch1
            input.Notes.Add(new Data.NoteInfo(false, 7.87f + 5.00f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 8.29f + 5.00f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 8.70f + 5.00f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 8.81f + 5.00f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 9.12f + 5.00f, 0.0f, "d"));
             //piano1
            input.Notes.Add(new Data.NoteInfo(false, 14.33f + 0.00f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 14.54f + 0.00f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 14.75f + 0.00f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 14.95f + 0.00f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 0.00f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 15.58f + 0.00f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.79f + 0.00f, 0.0f, "d"));
            //piano1
            input.Notes.Add(new Data.NoteInfo(false, 14.33f + 1.67f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 14.54f + 1.67f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 14.75f + 1.67f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 14.95f + 1.67f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 1.67f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 15.58f + 1.67f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.79f + 1.67f, 0.0f, "j"));
            //piano1
            input.Notes.Add(new Data.NoteInfo(false, 14.33f + 3.33f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 14.54f + 3.33f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 14.75f + 3.33f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 14.95f + 3.33f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 3.33f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.58f + 3.33f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.79f + 3.33f, 0.0f, "s"));
            //piano1
            input.Notes.Add(new Data.NoteInfo(false, 14.33f + 5.00f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 14.54f + 5.00f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 14.75f + 5.00f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 14.95f + 5.00f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 5.00f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.58f + 5.00f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 15.79f + 5.00f, 0.0f, "d"));
            //piano1
            input.Notes.Add(new Data.NoteInfo(false, 14.33f + 6.67f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 14.54f + 6.67f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 14.75f + 6.67f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 14.95f + 6.67f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 6.67f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.58f + 6.67f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 15.79f + 6.67f, 0.0f, "k"));
            //piano1
            input.Notes.Add(new Data.NoteInfo(false, 14.33f + 8.33f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 14.54f + 8.33f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 14.75f + 8.33f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 14.95f + 8.33f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 8.33f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.58f + 8.33f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.79f + 8.33f, 0.0f, "s"));
             //4/1
            input.Notes.Add(new Data.NoteInfo(false, 1.00f + 23.33f, 23.33f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.41f + 23.33f, 23.33f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.83f + 23.33f, 23.33f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.25f + 23.33f, 23.33f, "j"));
             //4/1
            input.Notes.Add(new Data.NoteInfo(false, 1.00f + 24.99f, 24.99f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.41f + 24.99f, 24.99f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.83f + 24.99f, 24.99f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.25f + 24.99f, 24.99f, "d"));
            //cyndi2
            input.Notes.Add(new Data.NoteInfo(false, 27.87f + 0.00f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 28.29f + 0.00f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 28.70f + 0.00f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 29.12f + 0.00f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 29.54f + 0.00f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 29.95f + 0.00f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 0.00f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 30.79f + 0.00f, 0.0f, "d"));
            //combo2 2
            input.Notes.Add(new Data.NoteInfo(false, 31.20f + 0.00f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 31.31f + 0.00f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 31.62f + 0.00f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 31.72f + 0.00f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 32.04f + 0.00f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 32.14f + 0.00f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 32.45f + 0.00f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 32.56f + 0.00f, 0.0f, "j"));
            //combo2 2
            input.Notes.Add(new Data.NoteInfo(false, 31.20f + 1.67f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 31.31f + 1.67f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 31.62f + 1.67f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 31.72f + 1.67f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 32.04f + 1.67f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 32.14f + 1.67f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 32.45f + 1.67f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 32.56f + 1.67f, 0.0f, "k"));
              //cyndi2
            input.Notes.Add(new Data.NoteInfo(false, 27.87f + 6.67f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 28.29f + 6.67f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 28.70f + 6.67f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 29.12f + 6.67f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 29.54f + 6.67f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 29.95f + 6.67f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 6.67f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 30.79f + 6.67f, 0.0f, "d"));
            //combo2 2
            input.Notes.Add(new Data.NoteInfo(false, 31.20f + 6.67f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 31.31f + 6.67f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 31.62f + 6.67f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 31.72f + 6.67f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 32.04f + 6.67f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 32.14f + 6.67f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 32.45f + 6.67f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 32.56f + 6.67f, 0.0f, "k"));
            //combo2 2
            input.Notes.Add(new Data.NoteInfo(false, 31.20f + 8.34f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false,  31.31f + 8.34f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 31.62f + 8.34f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 31.72f + 8.34f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 32.04f + 8.34f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 32.14f + 8.34f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 32.45f + 8.34f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 32.56f + 8.34f, 0.0f, "l"));
            
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 1.00f + 40.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.41f + 40.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.83f + 40.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 2.25f + 40.0f, 0.0f, "k"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 1.00f + 41.66f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.41f + 41.66f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.83f + 41.66f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.25f + 41.66f, 0.0f, "d"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 1.00f + 43.33f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.41f + 43.33f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.83f + 43.33f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.25f + 43.33f, 0.0f, "j"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 1.00f + 45.0f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.41f + 45.0f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.83f + 45.0f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.25f + 45.0f, 0.0f, "s"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 1.00f + 46.66f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.41f + 46.66f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.83f + 46.66f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.25f + 46.66f, 0.0f, "d"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 1.00f + 48.33f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.41f + 48.33f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.83f + 48.33f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.25f + 48.33f, 0.0f, "f"));
            //
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 1.00f + 46.87f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.41f + 46.87f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.83f + 46.87f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 2.25f + 46.87f, 0.0f, "k"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 1.00f + 48.54f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 1.41f + 48.54f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 1.83f + 48.54f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 2.25f + 48.54f, 0.0f, "l"));
            //combo2 2
            input.Notes.Add(new Data.NoteInfo(false, 31.20f + 19.8f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 31.31f + 19.8f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 31.62f + 19.8f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 31.72f + 19.8f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 32.04f + 19.8f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 32.14f + 19.8f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 32.45f + 19.8f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 32.56f + 19.8f, 0.0f, "k"));
            
            input.Notes.Add(new Data.NoteInfo(false, 52.65f + 0.00f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 52.77f + 0.00f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 53.08f + 0.00f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 53.18f + 0.00f, 0.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(true, 53.5f + 0.0f, 54.33f+0.0f, "space"));
            //
            input.Notes.Add(new Data.NoteInfo(false, 56.41f + 0.00f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 56.83f + 0.00f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 57.66f + 0.00f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 58.08f + 0.00f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 58.91f + 0.00f, 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 59.75f + 0.00f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 60.16f + 0.00f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 60.58f + 0.00f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 61.41f + 0.00f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 61.83f + 0.00f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 62.25f + 0.00f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 62.66f + 0.00f, 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 63.60f + 0.00f, 0.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 63.91f + 0.00f, 0.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 64.75f + 0.00f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 65.16f + 0.00f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 65.58f + 0.00f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 66.41f + 0.00f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 66.83f + 0.00f, 0.0f, "a"));

            input.Notes.Add(new Data.NoteInfo(true, 68.08f + 0.0f, 70.58f+0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 71.00f + 0.0f, 74.22f+0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 74.33f + 0.0f, 76.41f+0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 76.83f + 0.0f, 79.35f+0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 79.75f + 0.0f, 82.66f+0.0f, "space"));
            //final cyndi
            input.Notes.Add(new Data.NoteInfo(false, 82.87f + 0.00f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 83.08f + 0.00f, 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 83.50f + 0.00f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 83.70f + 0.00f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 84.12f + 0.00f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 84.54f + 0.00f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 84.75f + 0.00f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 84.95f + 0.00f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 85.37f + 0.00f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 85.58f + 0.00f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 85.79f + 0.00f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 86.00f + 0.00f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 86.41f + 0.00f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 86.62f + 0.00f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 87.04f + 0.00f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 87.25f + 0.00f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 87.45f + 0.00f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 87.87f + 0.00f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 88.08f + 0.00f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 88.29f + 0.00f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 88.70f + 0.00f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 88.91f + 0.00f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 89.12f + 0.00f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 89.54f + 0.00f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 89.75f + 0.00f, 0.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 90.16f + 0.00f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 90.37f + 0.00f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 90.58f + 0.00f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 90.79f + 0.00f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 91.20f + 0.00f, 0.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 91.41f + 0.00f, 0.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 91.62f + 0.00f, 0.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 92.04f + 0.00f, 0.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 92.25f + 0.00f, 0.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 92.45f + 0.00f, 0.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 92.87f + 0.00f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 93.08f + 0.00f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 93.50f + 0.00f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 93.70f + 0.00f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 94.12f + 0.00f, 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 94.55f + 0.00f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 94.75f + 0.00f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 94.95f + 0.00f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 95.37f + 0.00f, 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 95.58f + 0.00f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 95.79f + 0.00f, 0.0f, "space"));
            //final cyndi
            input.Notes.Add(new Data.NoteInfo(false, 82.87f + 13.3f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 83.08f + 13.3f, 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 83.50f + 13.3f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 83.70f + 13.3f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 84.12f + 13.3f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 84.54f + 13.3f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 84.75f + 13.3f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 84.95f + 13.3f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 85.37f + 13.3f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 85.58f + 13.3f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 85.79f + 13.3f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 86.00f + 13.3f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 86.41f + 13.3f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 86.62f + 13.3f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 87.04f + 13.3f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 87.25f + 13.3f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 87.45f + 13.3f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 87.87f + 13.3f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 88.08f + 13.3f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 88.29f + 13.3f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 88.70f + 13.3f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 88.91f + 13.3f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 89.12f + 13.3f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 89.54f + 13.3f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 89.75f + 13.3f, 0.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 90.16f + 13.3f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 90.37f + 13.3f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 90.58f + 13.3f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 90.79f + 13.3f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 91.20f + 13.3f, 0.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 91.41f + 13.3f, 0.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 91.62f + 13.3f, 0.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 92.04f + 13.3f, 0.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 92.25f + 13.3f, 0.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 92.45f + 13.3f, 0.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 92.87f + 13.3f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 93.08f + 13.3f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 93.50f + 13.3f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 93.70f + 13.3f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 94.12f + 13.3f, 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 94.55f + 13.3f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 94.75f + 13.3f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 94.95f + 13.3f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 95.37f + 13.3f, 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 95.58f + 13.3f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 95.79f + 13.3f, 0.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 1.00f + 108.33f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.41f + 108.33f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.83f + 108.33f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.25f + 108.33f, 0.0f, "d"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 1.00f + 110.00f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.41f + 110.00f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.83f + 110.00f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.25f + 110.00f, 0.0f, "j"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 1.00f + 111.66f, 0.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 1.41f + 111.66f, 0.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 1.83f + 111.66f, 0.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 2.25f + 111.66f, 0.0f, "a"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 1.00f + 113.33f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 1.41f + 113.33f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 1.83f + 113.33f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 2.25f + 113.33f, 0.0f, "l"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 1.00f + 115.00f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.41f + 115.00f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.83f + 115.00f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.25f + 115.00f, 0.0f, "j"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 1.00f + 116.66f, 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.41f + 116.66f, 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.83f + 116.66f, 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 2.25f + 116.66f, 0.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 1.00f + 118.33f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.41f + 118.33f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.83f + 118.33f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.25f + 118.33f, 0.0f, "d"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 1.00f + 120.00f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.41f + 120.00f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.83f + 120.00f, 0.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 2.25f + 120.00f, 0.0f, "p"));
            //final cyndi
            input.Notes.Add(new Data.NoteInfo(false, 82.87f + 40.0f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 83.08f + 40.0f, 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 83.50f + 40.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 83.70f + 40.0f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 84.12f + 40.0f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 84.54f + 40.0f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 84.75f + 40.0f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 84.95f + 40.0f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 85.37f + 40.0f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 85.58f + 40.0f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 85.79f + 40.0f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 86.00f + 40.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 86.41f + 40.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 86.62f + 40.0f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 87.04f + 40.0f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 87.25f + 40.0f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 87.45f + 40.0f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 87.87f + 40.0f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 88.08f + 40.0f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 88.29f + 40.0f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 88.70f + 40.0f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 88.91f + 40.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 89.12f + 40.0f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 89.54f + 40.0f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 89.75f + 40.0f, 0.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 90.16f + 40.0f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 90.37f + 40.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 90.58f + 40.0f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 90.79f + 40.0f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 91.20f + 40.0f, 0.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 91.41f + 40.0f, 0.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 91.62f + 40.0f, 0.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 92.04f + 40.0f, 0.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 92.25f + 40.0f, 0.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 92.45f + 40.0f, 0.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 92.87f + 40.0f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 93.08f + 40.0f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 93.50f + 40.0f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 93.70f + 40.0f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 94.12f + 40.0f, 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 94.55f + 40.0f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 94.75f + 40.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 94.95f + 40.0f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 95.37f + 40.0f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 95.58f + 40.0f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 95.79f + 40.0f, 0.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 136.0f, 0.0f, "space"));
        }
        else if (input.Difficulty.Equals("Hard")){
            input.Notes.Add(new Data.NoteInfo(true, 0.00f + 0.0f, 1.00f + 0.0f, "j"));
            //piano1
            input.Notes.Add(new Data.NoteInfo(false, 1.0f + 0.00f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.2f + 0.00f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.41f + 0.00f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.62f + 0.00f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.04f + 0.00f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.25f + 0.00f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.45f + 0.00f, 0.0f, "d"));
            //piano1
            input.Notes.Add(new Data.NoteInfo(false, 1.0f + 1.67f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.2f + 1.67f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.41f + 1.67f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.62f + 1.67f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.04f + 1.67f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 2.25f + 1.67f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 2.45f + 1.67f, 0.0f, "j"));
            //piano1
            input.Notes.Add(new Data.NoteInfo(false, 1.0f + 3.33f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.2f + 3.33f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.41f + 3.33f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.62f + 3.33f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.04f + 3.33f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.25f + 3.33f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.45f + 3.33f, 0.0f, "s"));
            //piano1
            input.Notes.Add(new Data.NoteInfo(false, 1.0f + 5.00f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.2f + 5.00f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.41f + 5.00f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.62f + 5.00f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.04f + 5.00f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 2.25f + 5.00f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.45f + 5.00f, 0.0f, "d"));
            //scratch1
            input.Notes.Add(new Data.NoteInfo(false, 7.87f + 0.00f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 8.29f + 0.00f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 8.70f + 0.00f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.81f + 0.00f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 9.12f + 0.00f, 0.0f, "s"));
            //scratch1
            input.Notes.Add(new Data.NoteInfo(false, 7.87f + 1.67f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 8.29f + 1.67f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 8.70f + 1.67f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 8.81f + 1.67f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 9.12f + 1.67f, 0.0f, "j"));
            //scratch1
            input.Notes.Add(new Data.NoteInfo(false, 7.87f + 3.33f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.29f + 3.33f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 8.70f + 3.33f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 8.81f + 3.33f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 9.12f + 3.33f, 0.0f, "d"));
            //scratch1
            input.Notes.Add(new Data.NoteInfo(false, 7.87f + 5.00f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 8.29f + 5.00f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 8.70f + 5.00f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 8.81f + 5.00f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 9.12f + 5.00f, 0.0f, "d"));
            //piano1
            input.Notes.Add(new Data.NoteInfo(false, 14.33f + 0.00f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 14.54f + 0.00f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 14.75f + 0.00f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 14.95f + 0.00f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 0.00f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 15.58f + 0.00f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.79f + 0.00f, 0.0f, "d"));
            //piano1
            input.Notes.Add(new Data.NoteInfo(false, 14.33f + 1.67f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 14.54f + 1.67f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 14.75f + 1.67f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 14.95f + 1.67f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 1.67f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 15.58f + 1.67f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.79f + 1.67f, 0.0f, "j"));
            //piano1
            input.Notes.Add(new Data.NoteInfo(false, 14.33f + 3.33f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 14.54f + 3.33f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 14.75f + 3.33f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 14.95f + 3.33f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 3.33f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.58f + 3.33f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.79f + 3.33f, 0.0f, "s"));
            //piano1
            input.Notes.Add(new Data.NoteInfo(false, 14.33f + 5.00f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 14.54f + 5.00f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 14.75f + 5.00f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 14.95f + 5.00f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 5.00f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.58f + 5.00f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 15.79f + 5.00f, 0.0f, "d"));
            //piano1
            input.Notes.Add(new Data.NoteInfo(false, 14.33f + 6.67f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 14.54f + 6.67f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 14.75f + 6.67f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 14.95f + 6.67f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 6.67f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.58f + 6.67f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 15.79f + 6.67f, 0.0f, "k"));
            //piano1
            input.Notes.Add(new Data.NoteInfo(false, 14.33f + 8.33f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 14.54f + 8.33f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 14.75f + 8.33f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 14.95f + 8.33f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 8.33f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.58f + 8.33f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.79f + 8.33f, 0.0f, "s"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 1.00f + 23.33f, 23.33f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.41f + 23.33f, 23.33f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.83f + 23.33f, 23.33f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.25f + 23.33f, 23.33f, "j"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 1.00f + 24.99f, 24.99f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.41f + 24.99f, 24.99f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.83f + 24.99f, 24.99f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.25f + 24.99f, 24.99f, "d"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 27.66f + 0.00f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 27.77f + 0.00f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 27.87f + 0.00f, 0.0f, "f"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 27.66f + 0.42f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 27.77f + 0.42f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 27.87f + 0.42f, 0.0f, "j"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 27.66f + 0.84f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 27.77f + 0.84f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 27.87f + 0.84f, 0.0f, "s"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 27.66f + 1.25f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 27.77f + 1.25f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 27.87f + 1.25f, 0.0f, "l"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 27.66f + 1.67f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 27.77f + 1.67f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 27.87f + 1.67f, 0.0f, "d"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 27.66f + 2.09f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 27.77f + 2.09f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 27.87f + 2.09f, 0.0f, "k"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 27.66f + 2.5f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 27.77f + 2.5f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 27.87f + 2.5f, 0.0f, "s"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 27.66f + 2.92f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 27.77f + 2.92f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 27.87f + 2.92f, 0.0f, "l"));
            //combo2 2
            input.Notes.Add(new Data.NoteInfo(false, 31.20f + 0.00f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 31.31f + 0.00f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 31.62f + 0.00f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 31.72f + 0.00f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 32.04f + 0.00f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 32.14f + 0.00f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 32.45f + 0.00f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 32.56f + 0.00f, 0.0f, "j"));
            //combo2 2
            input.Notes.Add(new Data.NoteInfo(false, 31.20f + 1.67f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 31.31f + 1.67f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 31.62f + 1.67f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 31.72f + 1.67f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 32.04f + 1.67f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 32.14f + 1.67f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 32.45f + 1.67f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 32.56f + 1.67f, 0.0f, "k"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 27.66f + 6.67f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 27.77f + 6.67f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 27.87f + 6.67f, 0.0f, "f"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 27.66f + 7.09f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 27.77f + 7.09f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 27.87f + 7.09f, 0.0f, "j"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 27.66f + 7.5f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 27.77f + 7.5f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 27.87f + 7.5f, 0.0f, "s"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 27.66f + 7.92f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 27.77f + 7.92f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 27.87f + 7.92f, 0.0f, "l"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 27.66f + 8.34f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 27.77f + 8.34f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 27.87f + 8.34f, 0.0f, "d"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 27.66f + 8.75f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 27.77f + 8.75f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 27.87f + 8.75f, 0.0f, "k"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 27.66f + 9.17f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 27.77f + 9.17f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 27.87f + 9.17f, 0.0f, "s"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 27.66f + 9.59f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 27.77f + 9.59f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 27.87f + 9.59f, 0.0f, "l"));
            //combo2 2
            input.Notes.Add(new Data.NoteInfo(false, 31.20f + 6.67f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 31.31f + 6.67f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 31.62f + 6.67f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 31.72f + 6.67f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 32.04f + 6.67f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 32.14f + 6.67f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 32.45f + 6.67f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 32.56f + 6.67f, 0.0f, "k"));
            //combo2 2
            input.Notes.Add(new Data.NoteInfo(false, 31.20f + 8.34f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 31.31f + 8.34f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 31.62f + 8.34f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 31.72f + 8.34f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 32.04f + 8.34f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 32.14f + 8.34f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 32.45f + 8.34f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 32.56f + 8.34f, 0.0f, "l"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 1.00f + 40.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.41f + 40.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.83f + 40.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 2.25f + 40.0f, 0.0f, "k"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 1.00f + 41.66f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.41f + 41.66f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.83f + 41.66f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.25f + 41.66f, 0.0f, "d"));
            //
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 1.00f + 40.2f, 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.41f + 40.2f, 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.83f + 40.2f, 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 2.25f + 40.2f, 0.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 1.00f + 41.87f, 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.41f + 41.87f, 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.83f + 41.87f, 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 2.25f + 41.87f, 0.0f, "space"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 27.66f + 16.67f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 27.77f + 16.67f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 27.87f + 16.67f, 0.0f, "f"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 27.66f + 17.09f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 27.77f + 17.09f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 27.87f + 17.09f, 0.0f, "j"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 27.66f + 17.5f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 27.77f + 17.5f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 27.87f + 17.5f, 0.0f, "s"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 27.66f + 17.92f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 27.77f + 17.92f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 27.87f + 17.92f, 0.0f, "l"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 27.66f + 18.34f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 27.77f + 18.34f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 27.87f + 18.34f, 0.0f, "d"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 27.66f + 18.75f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 27.77f + 18.75f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 27.87f + 18.75f, 0.0f, "k"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 27.66f + 19.17f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 27.77f + 19.17f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 27.87f + 19.17f, 0.0f, "s"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 27.66f + 19.59f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 27.77f + 19.59f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 27.87f + 19.59f, 0.0f, "l"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 1.00f + 46.66f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.41f + 46.66f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.83f + 46.66f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.25f + 46.66f, 0.0f, "d"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 1.00f + 48.33f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.41f + 48.33f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.83f + 48.33f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 2.25f + 48.33f, 0.0f, "k"));
            //
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 1.00f + 46.87f, 0.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 1.41f + 46.87f, 0.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 1.83f + 46.87f, 0.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 2.25f + 46.87f, 0.0f, "p"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 1.00f + 48.54f, 0.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 1.41f + 48.54f, 0.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 1.83f + 48.54f, 0.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 2.25f + 48.54f, 0.0f, "q"));
            //combo2 2
            input.Notes.Add(new Data.NoteInfo(false, 31.20f + 19.8f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 31.31f + 19.8f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 31.62f + 19.8f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 31.72f + 19.8f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 32.04f + 19.8f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 32.14f + 19.8f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 32.45f + 19.8f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 32.56f + 19.8f, 0.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 52.65f + 0.00f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 52.77f + 0.00f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 53.08f + 0.00f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 53.18f + 0.00f, 0.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(true, 53.5f + 0.0f, 54.33f + 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 55.58f + 0.0f, 56.0f + 0.0f, "q"));
            //
            input.Notes.Add(new Data.NoteInfo(false, 56.41f + 0.00f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 56.83f + 0.00f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 57.66f + 0.00f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 58.08f + 0.00f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 58.91f + 0.00f, 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 59.75f + 0.00f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 60.16f + 0.00f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 60.58f + 0.00f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 61.41f + 0.00f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 61.83f + 0.00f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 62.25f + 0.00f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 62.66f + 0.00f, 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 63.60f + 0.00f, 0.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 63.91f + 0.00f, 0.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 64.75f + 0.00f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 65.16f + 0.00f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 65.58f + 0.00f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 66.41f + 0.00f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 66.83f + 0.00f, 0.0f, "a"));
            //
            input.Notes.Add(new Data.NoteInfo(true, 68.08f + 0.0f, 68.5f + 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 68.5f + 0.0f, 68.91f + 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 68.91f + 0.0f, 69.75f + 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 69.75f + 0.0f, 70.16f + 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 70.16f + 0.0f, 71.0f + 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 71.0f + 0.0f, 71.41f + 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 71.41f + 0.0f, 72.25f + 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 72.25f + 0.0f, 73.08f + 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 73.08f + 0.0f, 73.5f + 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 73.5f + 0.0f, 73.91f + 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 73.91f + 0.0f, 74.33f + 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 74.33f + 0.0f, 74.75f + 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 74.75f + 0.0f, 75.16f + 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 75.16f + 0.0f, 75.58f + 0.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(true, 75.58f + 0.0f, 76.0f + 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 76.0f + 0.0f, 76.83f + 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 76.83f + 0.0f, 77.25f + 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 77.25f + 0.0f, 78.08f + 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 78.08f + 0.0f, 78.50f + 0.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(true, 78.50f + 0.0f, 78.91f + 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 78.91f + 0.0f, 79.75f + 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 79.75f + 0.0f, 82.66f + 0.0f, "j"));
            //final cyndi
            input.Notes.Add(new Data.NoteInfo(false, 82.87f + 0.00f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 83.08f + 0.00f, 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 83.50f + 0.00f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 83.70f + 0.00f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 84.12f + 0.00f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 84.54f + 0.00f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 84.75f + 0.00f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 84.95f + 0.00f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 85.37f + 0.00f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 85.58f + 0.00f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 85.79f + 0.00f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 86.00f + 0.00f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 86.41f + 0.00f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 86.62f + 0.00f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 87.04f + 0.00f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 87.25f + 0.00f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 87.45f + 0.00f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 87.87f + 0.00f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 88.08f + 0.00f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 88.29f + 0.00f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 88.70f + 0.00f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 88.91f + 0.00f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 89.12f + 0.00f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 89.54f + 0.00f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 89.75f + 0.00f, 0.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 90.16f + 0.00f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 90.37f + 0.00f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 90.58f + 0.00f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 90.79f + 0.00f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 91.20f + 0.00f, 0.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 91.41f + 0.00f, 0.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 91.62f + 0.00f, 0.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 92.04f + 0.00f, 0.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 92.25f + 0.00f, 0.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 92.45f + 0.00f, 0.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 92.87f + 0.00f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 93.08f + 0.00f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 93.50f + 0.00f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 93.70f + 0.00f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 94.12f + 0.00f, 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 94.55f + 0.00f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 94.75f + 0.00f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 94.95f + 0.00f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 95.37f + 0.00f, 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 95.58f + 0.00f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 95.79f + 0.00f, 0.0f, "space"));
            //final cyndi
            input.Notes.Add(new Data.NoteInfo(false, 82.87f + 13.3f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 83.08f + 13.3f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 83.50f + 13.3f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 83.70f + 13.3f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 84.12f + 13.3f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 84.54f + 13.3f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 84.75f + 13.3f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 84.95f + 13.3f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 85.37f + 13.3f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 85.58f + 13.3f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 85.79f + 13.3f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 86.00f + 13.3f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 86.41f + 13.3f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 86.62f + 13.3f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 87.04f + 13.3f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 87.25f + 13.3f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 87.45f + 13.3f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 87.87f + 13.3f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 88.08f + 13.3f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 88.29f + 13.3f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 88.70f + 13.3f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 88.91f + 13.3f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 89.12f + 13.3f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 89.54f + 13.3f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 89.75f + 13.3f, 0.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 90.16f + 13.3f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 90.37f + 13.3f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 90.58f + 13.3f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 90.79f + 13.3f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 91.20f + 13.3f, 0.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 91.41f + 13.3f, 0.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 91.62f + 13.3f, 0.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 92.04f + 13.3f, 0.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 92.25f + 13.3f, 0.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 92.45f + 13.3f, 0.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 92.87f + 13.3f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 93.08f + 13.3f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 93.50f + 13.3f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 93.70f + 13.3f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 94.12f + 13.3f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 94.55f + 13.3f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 94.75f + 13.3f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 94.95f + 13.3f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 95.37f + 13.3f, 0.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 95.58f + 13.3f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 95.79f + 13.3f, 0.0f, "a"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 1.00f + 101.66f, 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.41f + 101.66f, 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.83f + 101.66f, 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 2.25f + 101.66f, 0.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 1.00f + 103.33f, 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.41f + 103.33f, 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.83f + 103.33f, 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 2.25f + 103.33f, 0.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 1.00f + 105.0f, 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.41f + 105.0f, 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.83f + 105.0f, 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 2.25f + 105.0f, 0.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 1.00f + 106.66f, 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.41f + 106.66f, 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.83f + 106.66f, 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 2.25f + 106.66f, 0.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 1.00f + 95.0f, 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.41f + 95.0f, 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.83f + 95.0f, 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 2.25f + 95.0f, 0.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 1.00f + 96.66f, 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.41f + 96.66f, 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.83f + 96.66f, 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 2.25f + 96.66f, 0.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 1.00f + 98.33f, 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.41f + 98.33f, 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.83f + 98.33f, 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 2.25f + 98.33f, 0.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 1.00f + 100.00f, 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.41f + 100.00f, 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.83f + 100.00f, 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 2.25f + 100.00f, 0.0f, "space"));
            //
            //8/2
            input.Notes.Add(new Data.NoteInfo(false, 109.33f + 0.00f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 109.54f + 0.00f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 109.75f + 0.00f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 109.95f + 0.00f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 110.16f + 0.00f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 110.37f + 0.00f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 110.58f + 0.00f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 110.79f + 0.00f, 0.0f, "d"));
            //8/2
            input.Notes.Add(new Data.NoteInfo(false, 109.33f + 1.67f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 109.54f + 1.67f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 109.75f + 1.67f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 109.95f + 1.67f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 110.16f + 1.67f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 110.37f + 1.67f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 110.58f + 1.67f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 110.79f + 1.67f, 0.0f, "d"));
            //
            //8/2
            input.Notes.Add(new Data.NoteInfo(false, 109.33f + 0.1f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 109.54f + 0.1f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 109.75f + 0.1f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 109.95f + 0.1f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 110.16f + 0.1f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 110.37f + 0.1f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 110.58f + 0.1f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 110.79f + 0.1f, 0.0f, "k"));
            //8/2
            input.Notes.Add(new Data.NoteInfo(false, 109.33f + 1.77f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 109.54f + 1.77f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 109.75f + 1.77f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 109.95f + 1.77f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 110.16f + 1.77f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 110.37f + 1.77f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 110.58f + 1.77f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 110.79f + 1.77f, 0.0f, "k"));
            //2
            //8/2
            input.Notes.Add(new Data.NoteInfo(false, 109.33f + 3.33f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 109.54f + 3.33f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 109.75f + 3.33f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 109.95f + 3.33f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 110.16f + 3.33f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 110.37f + 3.33f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 110.58f + 3.33f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 110.79f + 3.33f, 0.0f, "k"));
            //8/2
            input.Notes.Add(new Data.NoteInfo(false, 109.33f + 5.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 109.54f + 5.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 109.75f + 5.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 109.95f + 5.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 110.16f + 5.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 110.37f + 5.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 110.58f + 5.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 110.79f + 5.0f, 0.0f, "k"));
            //
            //8/2
            input.Notes.Add(new Data.NoteInfo(false, 109.33f + 3.43f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 109.54f + 3.43f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 109.75f + 3.43f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 109.95f + 3.43f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 110.16f + 3.43f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 110.37f + 3.43f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 110.58f + 3.43f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 110.79f + 3.43f, 0.0f, "d"));
            //8/2
            input.Notes.Add(new Data.NoteInfo(false, 109.33f + 5.1f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 109.54f + 5.1f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 109.75f + 5.1f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 109.95f + 5.1f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 110.16f + 5.1f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 110.37f + 5.1f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 110.58f + 5.1f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 110.79f + 5.1f, 0.0f, "d"));
            //3
            //8/2
            input.Notes.Add(new Data.NoteInfo(false, 109.33f + 6.67f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 109.54f + 6.67f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 109.75f + 6.67f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 109.95f + 6.67f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 110.16f + 6.67f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 110.37f + 6.67f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 110.58f + 6.67f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 110.79f + 6.67f, 0.0f, "d"));
            //8/2
            input.Notes.Add(new Data.NoteInfo(false, 109.33f + 8.33f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 109.54f + 8.33f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 109.75f + 8.33f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 109.95f + 8.33f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 110.16f + 8.33f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 110.37f + 8.33f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 110.58f + 8.33f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 110.79f + 8.33f, 0.0f, "d"));
            //
            //8/2
            input.Notes.Add(new Data.NoteInfo(false, 109.33f + 6.68f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 109.54f + 6.68f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 109.75f + 6.68f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 109.95f + 6.68f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 110.16f + 6.68f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 110.37f + 6.68f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 110.58f + 6.68f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 110.79f + 6.68f, 0.0f, "k"));
            //8/2
            input.Notes.Add(new Data.NoteInfo(false, 109.33f + 8.34f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 109.54f + 8.34f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 109.75f + 8.34f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 109.95f + 8.34f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 110.16f + 8.34f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 110.37f + 8.34f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 110.58f + 8.34f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 110.79f + 8.34f, 0.0f, "k"));
            //f
            //8/2
            input.Notes.Add(new Data.NoteInfo(false, 109.33f + 10.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 109.54f + 10.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 109.75f + 10.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 109.95f + 10.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 110.16f + 10.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 110.37f + 10.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 110.58f + 10.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 110.79f + 10.0f, 0.0f, "k"));
            //
            //8/2
            input.Notes.Add(new Data.NoteInfo(false, 109.33f + 10.1f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 109.54f + 10.1f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 109.75f + 10.1f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 109.95f + 10.1f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 110.16f + 10.1f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 110.37f + 10.1f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 110.58f + 10.1f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 110.79f + 10.1f, 0.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 121.2f, 0.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 121.41f, 0.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 121.62f, 0.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 121.83f, 0.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 122.25f, 0.0f, "p"));
            //final cyndi
            input.Notes.Add(new Data.NoteInfo(false, 82.87f + 40.0f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 83.08f + 40.0f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 83.50f + 40.0f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 83.70f + 40.0f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 84.12f + 40.0f, 0.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 84.54f + 40.0f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 84.75f + 40.0f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 84.95f + 40.0f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 85.37f + 40.0f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 85.58f + 40.0f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 85.79f + 40.0f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 86.00f + 40.0f, 0.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 86.41f + 40.0f, 0.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 86.62f + 40.0f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 87.04f + 40.0f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 87.25f + 40.0f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 87.45f + 40.0f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 87.87f + 40.0f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 88.08f + 40.0f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 88.29f + 40.0f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 88.70f + 40.0f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 88.91f + 40.0f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 89.12f + 40.0f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 89.54f + 40.0f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 89.75f + 40.0f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 90.16f + 40.0f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 90.37f + 40.0f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 90.58f + 40.0f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 90.79f + 40.0f, 0.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 91.20f + 40.0f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 91.41f + 40.0f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 91.62f + 40.0f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 92.04f + 40.0f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 92.25f + 40.0f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 92.45f + 40.0f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 92.87f + 40.0f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 93.08f + 40.0f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 93.50f + 40.0f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 93.70f + 40.0f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 94.12f + 40.0f, 0.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 94.55f + 40.0f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 94.75f + 40.0f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 94.95f + 40.0f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 95.37f + 40.0f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 95.58f + 40.0f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 95.79f + 40.0f, 0.0f, "d"));
            //
            //final cyndi
            input.Notes.Add(new Data.NoteInfo(false, 82.87f + 40.0f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 83.08f + 40.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 83.50f + 40.0f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 83.70f + 40.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 84.12f + 40.0f, 0.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 84.54f + 40.0f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 84.75f + 40.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 84.95f + 40.0f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 85.37f + 40.0f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 85.58f + 40.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 85.79f + 40.0f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 86.00f + 40.0f, 0.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 86.41f + 40.0f, 0.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 86.62f + 40.0f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 87.04f + 40.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 87.25f + 40.0f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 87.45f + 40.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 87.87f + 40.0f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 88.08f + 40.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 88.29f + 40.0f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 88.70f + 40.0f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 88.91f + 40.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 89.12f + 40.0f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 89.54f + 40.0f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 89.75f + 40.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 90.16f + 40.0f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 90.37f + 40.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 90.58f + 40.0f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 90.79f + 40.0f, 0.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 91.20f + 40.0f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 91.41f + 40.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 91.62f + 40.0f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 92.04f + 40.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 92.25f + 40.0f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 92.45f + 40.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 92.87f + 40.0f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 93.08f + 40.0f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 93.50f + 40.0f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 93.70f + 40.0f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 94.12f + 40.0f, 0.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 94.55f + 40.0f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 94.75f + 40.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 94.95f + 40.0f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 95.37f + 40.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 95.58f + 40.0f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 95.79f + 40.0f, 0.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 136.0f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 136.0f, 0.0f, "j"));
        }
        else if (input.Difficulty.Equals("Extreme")){
            input.Notes.Add(new Data.NoteInfo(false, 2.14f + 0.0f, 0.0f, "l"));
        }
    }
}