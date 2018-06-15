using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class Sapphire : MonoBehaviour {
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
        MusicInfo.key = 5;
        MusicInfo.name = "Sapphire";
        MusicInfo.composer = "Kari";
        MusicInfo.visualizer = "NANACO★SYNDROME";
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
        normal.level = 5;
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
        hard.level = 13;
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
            if (notes.isLong)
            {
                comboCalc += 2;
            }
            else
            {
                comboCalc++;
            }
        }
        input.max_combo = comboCalc;
    }
    void CreateNote(Data.Playdata input)
    {
        input.Notes = new List<Data.NoteInfo>();
        if (input.Difficulty.Equals("Normal"))
        {
            input.Notes.Add(new Data.NoteInfo(true, 0.0f, 1.09f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.09f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.31f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.53f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 1.74f, 3.05f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 3.05f, 5.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 5.00f, 5.87f, "k"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 6.09f +0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 6.31f+0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 6.53f+0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 6.74f+0.00f, 2.0f, "d"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.05f + 0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 8.27f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 8.48f + 0.00f, 2.0f, "l"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 6.09f + 3.70f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 6.31f + 3.70f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 6.53f + 3.70f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 6.74f + 3.70f, 2.0f, "k"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 6.09f + 5.22f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 6.31f + 5.22f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 6.53f + 5.22f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 6.74f + 5.22f, 2.0f, "j"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 6.09f + 6.96f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 6.31f + 6.96f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 6.53f + 6.96f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 6.74f + 6.96f, 2.0f, "d"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 13.92f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 14.35f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 14.79f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 15.22f + 0.00f, 2.0f, "s"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 13.92f + 1.74f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 14.35f + 1.74f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 14.79f + 1.74f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.22f + 1.74f, 2.0f, "d"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 13.92f + 3.48f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 14.35f + 3.48f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 14.79f + 3.48f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 15.22f + 3.48f, 2.0f, "j"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 13.92f + 5.22f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 14.35f + 5.22f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 14.79f + 5.22f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.22f + 5.22f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 20.87f, 2.0f, "space"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.05f + 13.91f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.27f + 13.91f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 8.48f + 13.91f, 2.0f, "space"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 6.09f + 17.61f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 6.31f + 17.61f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 6.53f + 17.61f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 6.74f + 17.61f, 2.0f, "k"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 6.09f + 19.13f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 6.31f + 19.13f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 6.53f + 19.13f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 6.74f + 19.13f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 26.74f, 27.83f, "a"));
            //7/0.5
            input.Notes.Add(new Data.NoteInfo(false, 28.05f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 28.27f + 0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 28.48f + 0.00f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 28.70f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 28.92f + 0.00f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 29.14f + 0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 29.35f + 0.00f, 2.0f, "space"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 30.44f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 30.66f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.87f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 31.09f + 0.00f, 2.0f, "d"));
            //7/0.5
            input.Notes.Add(new Data.NoteInfo(false, 28.05f + 3.48f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 28.27f + 3.48f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 28.48f + 3.48f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 28.70f + 3.48f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 28.92f + 3.48f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 29.14f + 3.48f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 29.35f + 3.48f, 2.0f, "k"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 30.44f + 3.48f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 30.66f + 3.48f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.87f + 3.48f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 31.09f + 3.48f, 2.0f, "k"));
            //7/0.5
            input.Notes.Add(new Data.NoteInfo(false, 28.05f + 6.95f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 28.27f + 6.95f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 28.48f + 6.95f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 28.70f + 6.95f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 28.92f + 6.95f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 29.14f + 6.95f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 29.35f + 6.95f, 2.0f, "l"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 30.44f + 6.95f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 30.66f + 6.95f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.87f + 6.95f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 31.09f + 6.95f, 2.0f, "d"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.05f + 30.43f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 8.27f + 30.43f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 8.48f + 30.43f, 2.0f, "j"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.05f + 31.09f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 8.27f + 31.09f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.48f + 31.09f, 2.0f, "s"));
            //
            input.Notes.Add(new Data.NoteInfo(false, 39.79f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 39.90f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 40.0f, 41.75f, "p"));
            //1st groove
            input.Notes.Add(new Data.NoteInfo(true, 41.74f+0.00f, 42.18f+0.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 42.18f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 42.61f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 43.05f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 43.48f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 43.70f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 43.92f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 44.03f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 44.14f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 44.24f + 0.00f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 44.79f + 0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 44.90f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 45.00f + 0.00f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 45.11f + 0.00f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(true, 45.66f + 0.00f, 46.31f + 0.00f, "q"));
            input.Notes.Add(new Data.NoteInfo(true, 46.53f + 0.00f, 47.40f + 0.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 47.61f + 0.00f, 48.05f + 0.00f, "space"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.05f + 40.65f+0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 8.27f + 40.65f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.48f + 40.65f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 50.22f + 0.00f, 50.66f + 0.00f, "s"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.05f + 43.04f + 0.00f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 8.27f + 43.04f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 8.48f + 43.04f + 0.00f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 52.18f + 0.00f, 53.05f + 0.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 53.05f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 53.70f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 55.22f, 55.66f, "k"));
            //1st groove
            input.Notes.Add(new Data.NoteInfo(true, 41.74f + 13.92f, 42.18f + 13.92f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 42.18f + 13.92f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 42.61f + 13.92f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 43.05f + 13.92f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 43.48f + 13.92f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 43.70f + 13.92f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 43.92f + 13.92f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 44.03f + 13.92f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 44.14f + 13.92f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 44.24f + 13.92f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 44.79f + 13.92f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 44.90f + 13.92f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 45.00f + 13.92f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 45.11f + 13.92f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(true, 45.66f + 13.92f, 46.31f + 13.92f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 46.53f + 13.92f, 47.40f + 13.92f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 47.61f + 13.92f, 48.05f + 13.92f, "l"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.05f + 40.65f + 13.92f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.27f + 40.65f + 13.92f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 8.48f + 40.65f + 13.92f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 50.22f + 13.92f, 50.66f + 13.92f, "l"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.05f + 43.04f + 13.92f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 8.27f + 43.04f + 13.92f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 8.48f + 43.04f + 13.92f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 52.18f + 13.92f, 66.96f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 66.96f,2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 67.61f, 68.27f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 69.14f, 69.57f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 69.57f, 2.0f, "d"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.05f + 62.61f+0.00f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 8.27f + 62.61f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 8.48f + 62.61f, 2.0f, "j"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.05f + 64.35f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 8.27f + 64.35f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 8.48f + 64.35f, 2.0f, "space"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 6.09f + 66.96f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 6.31f + 66.96f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 6.53f + 66.96f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 6.74f + 66.96f, 2.0f, "space"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.05f + 66.52f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 8.27f + 66.52f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.48f + 66.52f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 75.22f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 75.44f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 76.53f, 2.0f, "l"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.05f + 69.56f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 8.27f + 69.56f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 8.48f + 69.56f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 78.70f, 2.0f, "f"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.05f + 71.3f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 8.27f + 71.3f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.48f + 71.3f, 2.0f, "f"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 6.09f + 73.91f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 6.31f + 73.91f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 6.53f + 73.91f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 6.74f + 73.91f, 2.0f, "k"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.05f + 73.04f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 8.27f + 73.04f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.48f + 73.04f, 2.0f, "s"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.05f + 73.69f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 8.27f + 73.69f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 8.48f + 73.69f, 2.0f, "space"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.05f + 74.78f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 8.27f + 74.78f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.48f + 74.78f, 2.0f, "f"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 6.09f + 77.39f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 6.31f + 77.39f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 6.53f + 77.39f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 6.74f + 77.39f, 2.0f, "space"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.05f + 76.52f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 8.27f + 76.52f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 8.48f + 76.52f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 86.31f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 86.42f + 0.00f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 86.53f + 0.00f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 86.74f + 0.00f, 2.0f, "l"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 6.09f + 80.87f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 6.31f + 80.87f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 6.53f + 80.87f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 6.74f + 80.87f, 2.0f, "space"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.05f + 80.0f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 8.27f + 80.0f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.48f + 80.0f, 2.0f, "s"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.05f + 81.74f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 8.27f + 81.74f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.48f + 81.74f, 2.0f, "f"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.05f + 82.61f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.27f + 82.61f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 8.48f + 82.61f, 2.0f, "space"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 6.09f + 85.22f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 6.31f + 85.22f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 6.53f + 85.22f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 6.74f + 85.22f, 2.0f, "d"));
            //
            input.Notes.Add(new Data.NoteInfo(false, 93.05f + 0.00f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 93.48f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 93.70f + 0.00f, 2.0f, "j"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 6.09f + 87.83f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 6.31f + 87.83f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 6.53f + 87.83f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 6.74f + 87.83f, 2.0f, "s"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 6.09f + 89.13f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 6.31f + 89.13f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 6.53f + 89.13f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 6.74f + 89.13f, 2.0f, "f"));
            //
            input.Notes.Add(new Data.NoteInfo(false, 96.09f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 96.31f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 96.96f + 0.00f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 97.18f + 0.00f, 2.0f, "j"));
            //1st groove
            input.Notes.Add(new Data.NoteInfo(true, 41.74f + 55.66f, 42.18f + 55.66f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 42.18f + 55.66f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 42.61f + 55.66f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 43.05f + 55.66f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 43.48f + 55.66f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 43.70f + 55.66f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 43.92f + 55.66f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 44.03f + 55.66f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 44.14f + 55.66f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 44.24f + 55.66f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 44.79f + 55.66f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 44.90f + 55.66f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 45.00f + 55.66f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 45.11f + 55.66f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 45.66f + 55.66f, 46.31f + 55.66f, "q"));
            input.Notes.Add(new Data.NoteInfo(true, 46.53f + 55.66f, 47.40f + 55.66f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 47.61f + 55.66f, 48.05f + 55.66f, "j"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.05f + 40.65f + 55.66f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 8.27f + 40.65f + 55.66f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 8.48f + 40.65f + 55.66f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 50.22f + 55.66f, 50.66f + 55.66f, "d"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.05f + 43.04f + 55.66f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 8.27f + 43.04f + 55.66f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 8.48f + 43.04f + 55.66f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 52.18f + 55.66f, 53.05f + 55.66f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 53.05f + 55.66f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 53.70f + 55.66f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(true, 110.87f, 111.31f, "j"));
            //1st groove
            input.Notes.Add(new Data.NoteInfo(true, 41.74f + 69.57f, 42.18f + 69.57f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 42.18f + 69.57f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 42.61f + 69.57f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 43.05f + 69.57f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 43.48f + 69.57f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 43.70f + 69.57f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 43.92f + 69.57f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 44.03f + 69.57f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 44.14f + 69.57f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 44.24f + 69.57f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 44.79f + 69.57f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 44.90f + 69.57f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 45.00f + 69.57f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 45.11f + 69.57f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(true, 45.66f + 69.57f, 46.31f + 69.57f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 46.53f + 69.57f, 47.40f + 69.57f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 47.61f + 69.57f, 48.05f + 69.57f, ";"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.05f + 40.65f + 69.57f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 8.27f + 40.65f + 69.57f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.48f + 40.65f + 69.57f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 50.22f + 69.57f, 50.66f + 69.57f, "s"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.05f + 43.04f + 69.57f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 8.27f + 43.04f + 69.57f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 8.48f + 43.04f + 69.57f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 52.18f + 69.57f, 53.05f + 69.57f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 53.05f + 69.57f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 53.70f + 69.57f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 124.83f, 125.22f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 125.66f, 128.70f, "space"));
        }
        else if (input.Difficulty.Equals("Hard"))
        {
            input.Notes.Add(new Data.NoteInfo(true, 0.0f+0.00f, 1.09f, "j"));
            //first groove
            input.Notes.Add(new Data.NoteInfo(false, 1.09f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.31f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.53f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.74f + 0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.96f + 0.00f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 2.40f + 0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.83f + 0.00f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 3.05f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 3.27f + 0.00f, 4.79f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 5.00f + 0.00f, 5.44f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 5.66f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 5.87f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 6.09f + 0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 6.31f + 0.00f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 6.53f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 6.74f + 0.00f, 2.0f, "d"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.05f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 8.27f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.48f + 0.00f, 2.0f, "f"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 6.09f + 3.7f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 6.31f + 3.7f + 0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 6.53f + 3.7f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 6.74f + 3.7f + 0.00f, 2.0f, "l"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 6.09f + 5.22f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 6.31f + 5.22f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 6.53f + 5.22f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 6.74f + 5.22f + 0.00f, 2.0f, "a"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 6.09f + 6.96f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 6.31f + 6.96f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 6.53f + 6.96f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 6.74f + 6.96f + 0.00f, 15.00f, "d"));
            //first groove
            input.Notes.Add(new Data.NoteInfo(false, 1.09f + 13.91f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.31f + 13.91f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.53f + 13.91f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 1.74f + 13.91f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 1.96f + 13.91f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 2.40f + 13.91f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.83f + 13.91f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.05f + 13.91f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 3.27f + 13.91f, 18.70f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 5.00f + 13.91f, 19.35f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 5.66f + 13.91f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 5.87f + 13.91f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 6.09f + 13.91f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 6.31f + 13.91f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 6.53f + 13.91f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 6.74f + 13.91f, 2.0f, "d"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.05f + 13.91f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.27f + 13.91f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 8.48f + 13.91f, 2.0f, "j"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 6.09f + 3.7f + 13.91f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 6.31f + 3.7f + 13.91f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 6.53f + 3.7f + 13.91f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 6.74f + 3.7f + 13.91f, 2.0f, "d"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 6.09f + 5.22f + 13.91f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 6.31f + 5.22f + 13.91f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 6.53f + 5.22f + 13.91f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 6.74f + 5.22f + 13.91f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 26.09f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 26.31f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 26.53f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 26.74f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 26.96f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 27.07f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 27.18f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 27.29f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 27.40f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 27.61f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 13.92f + 0.00f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 14.35f + 0.00f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 14.79f + 0.00f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 15.22f + 0.00f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 13.92f + 1.74f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 14.35f + 1.74f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 14.79f + 1.74f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 15.22f + 1.74f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 13.92f + 3.48f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 14.35f + 3.48f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 14.79f + 3.48f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 15.22f + 3.48f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 13.92f + 5.22f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 14.35f + 5.22f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 14.79f + 5.22f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 15.22f + 5.22f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 13.92f + 6.95f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 14.35f + 6.95f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 14.79f + 6.95f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 15.22f + 6.95f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 13.92f + 8.69f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 14.35f + 8.69f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 14.79f + 8.69f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 15.22f + 8.69f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 13.92f + 10.43f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 14.35f + 10.43f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 14.79f + 10.43f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 15.22f + 10.43f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 13.92f + 12.17f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 14.35f + 12.17f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 14.79f + 12.17f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 15.22f + 12.17f, 2.0f, "space"));
            //7/0.5
            input.Notes.Add(new Data.NoteInfo(false, 28.05f + 0.00f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 28.27f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 28.48f + 0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 28.70f + 0.00f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 28.92f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 29.14f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 29.35f + 0.00f, 2.0f, "f"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 30.44f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 30.66f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.87f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 31.09f + 0.00f, 2.0f, "d"));
            //7/0.5
            input.Notes.Add(new Data.NoteInfo(false, 28.05f + 3.48f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 28.27f + 3.48f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 28.48f + 3.48f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 28.70f + 3.48f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 28.92f + 3.48f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 29.14f + 3.48f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 29.35f + 3.48f, 2.0f, "j"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 30.44f + 3.48f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 30.66f + 3.48f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.87f + 3.48f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 31.09f + 3.48f, 2.0f, "k"));
            //7/0.5
            input.Notes.Add(new Data.NoteInfo(false, 28.05f + 6.95f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 28.27f + 6.95f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 28.48f + 6.95f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 28.70f + 6.95f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 28.92f + 6.95f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 29.14f + 6.95f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 29.35f + 6.95f, 2.0f, "k"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 30.44f + 6.95f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 30.66f + 6.95f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.87f + 6.95f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 31.09f + 6.95f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 38.27f, 40.00f, "q"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.05f + 30.43f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 8.27f + 30.43f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.48f + 30.43f, 2.0f, "s"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.05f + 31.09f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 8.27f + 31.09f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 8.48f + 31.09f, 2.0f, "j"));
            //
            input.Notes.Add(new Data.NoteInfo(false, 39.79f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 39.90f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 40.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 40.11f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 40.22f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 40.33f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 40.44f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 40.55f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 40.66f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 40.87f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 40.98f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 41.09f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 41.20f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 41.31f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 41.42f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 41.53f, 2.0f, "l"));
            //second groove
            input.Notes.Add(new Data.NoteInfo(true, 41.74f+0.00f, 42.18f + 0.00f, "p"));
            input.Notes.Add(new Data.NoteInfo(true, 42.18f + 0.00f, 43.48f + 0.00f, "d"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 13.92f + 28.26f + 0.00f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 14.35f + 28.26f + 0.00f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 14.79f + 28.26f + 0.00f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 15.22f + 28.26f + 0.00f, 2.0f, "space"));
            //
            input.Notes.Add(new Data.NoteInfo(false, 43.70f + 0.00f, 2.0f, "s"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 43.92f + 0.00f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 44.03f + 0.00f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 44.14f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 44.24f + 0.00f, 2.0f, "j"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 43.92f + 0.87f + 0.00f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 44.03f + 0.87f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 44.14f + 0.87f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 44.24f + 0.87f + 0.00f, 2.0f, "f"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 43.92f + 1.3f + 0.00f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 44.03f + 1.3f + 0.00f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 44.14f + 1.3f + 0.00f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 44.24f + 1.3f + 0.00f, 2.0f, ";"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 13.92f + 31.3f + 0.00f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 14.35f + 31.3f + 0.00f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 14.79f + 31.3f + 0.00f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 15.22f + 31.3f + 0.00f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 46.96f + 0.00f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 45.66f + 0.00f, 46.31f + 0.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 45.66f + 0.00f, 46.31f + 0.00f, "j"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 43.92f + 2.61f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 44.03f + 2.61f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 44.14f + 2.61f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 44.24f + 2.61f + 0.00f, 2.0f, "j"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 43.92f + 3.04f + 0.00f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 44.03f + 3.04f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 44.14f + 3.04f + 0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 44.24f + 3.04f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 47.61f + 0.00f, 48.05f + 0.00f, "space"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.05f + 40.65f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 8.27f + 40.65f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 8.48f + 40.65f + 0.00f, 50.0f+0.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 50.22f + 0.00f, 50.66f + 0.00f, "f"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.05f + 40.65f + 0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 8.27f + 40.65f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 8.48f + 40.65f + 0.00f, 50.0f + 0.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 50.22f + 0.00f, 50.66f + 0.00f, "l"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.05f + 43.04f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 8.27f + 43.04f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.48f + 43.04f + 0.00f, 2.0f, "s"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 43.92f + 7.82f + 0.00f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 44.03f + 7.82f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 44.14f + 7.82f + 0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 44.24f + 7.82f + 0.00f, 2.0f, "space"));

            input.Notes.Add(new Data.NoteInfo(true, 52.18f + 0.00f, 53.05f + 0.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 53.05f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 53.48f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 53.70f + 0.00f, 54.35f+0.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 55.22f + 0.00f, 55.66f + 0.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 52.18f + 0.00f, 53.05f + 0.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 53.05f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 53.48f + 0.00f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 53.70f + 0.00f, 54.35f + 0.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 55.22f + 0.00f, 55.66f + 0.00f, "l"));
            //second groove
            input.Notes.Add(new Data.NoteInfo(true, 41.74f + 13.92f, 42.18f + 13.92f, "q"));
            input.Notes.Add(new Data.NoteInfo(true, 42.18f + 13.92f, 43.48f + 13.92f, "k"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 13.92f + 28.26f + 13.92f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 14.35f + 28.26f + 13.92f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 14.79f + 28.26f + 13.92f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.22f + 28.26f + 13.92f, 2.0f, "d"));
            //
            input.Notes.Add(new Data.NoteInfo(false, 43.70f + 13.92f, 2.0f, "j"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 43.92f + 13.92f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 44.03f + 13.92f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 44.14f + 13.92f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 44.24f + 13.92f, 2.0f, "a"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 43.92f + 0.87f + 13.92f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 44.03f + 0.87f + 13.92f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 44.14f + 0.87f + 13.92f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 44.24f + 0.87f + 13.92f, 2.0f, ";"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 43.92f + 1.3f + 13.92f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 44.03f + 1.3f + 13.92f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 44.14f + 1.3f + 13.92f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 44.24f + 1.3f + 13.92f, 2.0f, "a"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 13.92f + 31.3f + 13.92f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 14.35f + 31.3f + 13.92f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 14.79f + 31.3f + 13.92f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 15.22f + 31.3f + 13.92f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 46.96f + 13.92f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 45.66f + 13.92f, 46.31f + 13.92f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 45.66f + 13.92f, 46.31f + 13.92f, "l"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 43.92f + 2.61f + 13.92f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 44.03f + 2.61f + 13.92f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 44.14f + 2.61f + 13.92f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 44.24f + 2.61f + 13.92f, 2.0f, "d"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 43.92f + 3.04f + 13.92f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 44.03f + 3.04f + 13.92f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 44.14f + 3.04f + 13.92f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 44.24f + 3.04f + 13.92f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 47.61f + 13.92f, 48.05f + 13.92f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 13.92f + 48.69f+0.00f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 14.35f + 48.69f + 0.00f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 14.79f + 48.69f + 0.00f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 15.22f + 48.69f + 0.00f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 13.92f + 50.43f + 0.00f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 14.35f + 50.43f + 0.00f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 14.79f + 50.43f + 0.00f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 15.22f + 50.43f + 0.00f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 13.92f + 52.17f + 0.00f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 14.35f + 52.17f + 0.00f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 14.79f + 52.17f + 0.00f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 15.22f + 52.17f + 0.00f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 13.92f + 53.91f + 0.00f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 14.35f + 53.91f + 0.00f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 14.79f + 53.91f + 0.00f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 15.22f + 53.91f + 0.00f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 69.57f + 0.00f, 2.0f, "space"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.05f + 40.65f + 13.92f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 8.27f + 40.65f + 13.92f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 8.48f + 40.65f + 13.92f, 50.0f + 13.92f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 50.22f + 13.92f, 50.66f + 13.92f, "d"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.05f + 40.65f + 13.92f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 8.27f + 40.65f + 13.92f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 8.48f + 40.65f + 13.92f, 50.0f + 13.92f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 50.22f + 13.92f, 50.66f + 13.92f, "k"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.05f + 43.04f + 13.92f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 8.27f + 43.04f + 13.92f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.48f + 43.04f + 13.92f, 2.0f, "s"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 43.92f + 7.82f + 13.92f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 44.03f + 7.82f + 13.92f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 44.14f + 7.82f + 13.92f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 44.24f + 7.82f + 13.92f, 2.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(true, 52.18f + 13.92f, 53.05f + 13.92f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 53.05f + 13.92f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 53.48f + 13.92f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 53.70f + 13.92f, 54.35f + 13.92f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 55.22f + 13.92f, 55.66f + 13.92f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 52.18f + 13.92f, 53.05f + 13.92f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 53.05f + 13.92f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 53.48f + 13.92f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 53.70f + 13.92f, 54.35f + 13.92f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 55.22f + 13.92f, 55.66f + 13.92f, "j"));
            //mid point
            input.Notes.Add(new Data.NoteInfo(false, 69.57f, 2.0f, "d"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.05f + 62.61f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 8.27f + 62.61f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.48f + 62.61f, 2.0f, "s"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.05f + 64.35f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 8.27f + 64.35f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 8.48f + 64.35f, 2.0f, "l"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 6.09f + 66.96f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 6.31f + 66.96f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 6.53f + 66.96f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 6.74f + 66.96f, 2.0f, "d"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.05f + 66.52f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 8.27f + 66.52f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 8.48f + 66.52f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 75.22f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 75.44f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 76.53f, 2.0f, "d"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.05f + 69.56f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 8.27f + 69.56f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 8.48f + 69.56f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 78.70f, 2.0f, ";"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.05f + 71.3f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.27f + 71.3f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 8.48f + 71.3f, 2.0f, "q"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 6.09f + 73.91f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 6.31f + 73.91f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 6.53f + 73.91f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 6.74f + 73.91f, 2.0f, "l"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.05f + 73.04f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 8.27f + 73.04f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 8.48f + 73.04f, 2.0f, "d"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.05f + 73.69f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 8.27f + 73.69f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 8.48f + 73.69f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 82.40f, 2.0f, "j"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.05f + 74.78f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 8.27f + 74.78f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 8.48f + 74.78f, 2.0f, "k"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 6.09f + 77.39f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 6.31f + 77.39f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 6.53f + 77.39f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 6.74f + 77.39f, 2.0f, "j"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.05f + 76.52f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 8.27f + 76.52f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 8.48f + 76.52f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 86.31f + 0.00f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 86.42f + 0.00f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 86.53f + 0.00f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 86.74f + 0.00f, 2.0f, "k"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 6.09f + 80.87f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 6.31f + 80.87f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 6.53f + 80.87f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 6.74f + 80.87f, 2.0f, "j"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.05f + 80.0f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 8.27f + 80.0f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.48f + 80.0f, 2.0f, "s"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.05f + 81.74f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 8.27f + 81.74f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 8.48f + 81.74f, 2.0f, "l"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.05f + 82.61f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 8.27f + 82.61f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.48f + 82.61f, 2.0f, "s"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 6.09f + 85.22f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 6.31f + 85.22f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 6.53f + 85.22f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 6.74f + 85.22f, 2.0f, "l"));
            //
            input.Notes.Add(new Data.NoteInfo(false, 93.05f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 93.48f + 0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 93.70f + 0.00f, 2.0f, "f"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 6.09f + 87.83f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 6.31f + 87.83f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 6.53f + 87.83f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 6.74f + 87.83f, 2.0f, "d"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 6.09f + 89.13f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 6.31f + 89.13f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 6.53f + 89.13f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 6.74f + 89.13f, 2.0f, "k"));
            //
            input.Notes.Add(new Data.NoteInfo(false, 96.09f + 0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 96.31f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 96.96f + 0.00f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 97.18f + 0.00f, 2.0f, "a"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 13.92f + 67.82f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 14.35f + 67.82f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 14.79f + 67.82f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 15.22f + 67.82f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 13.92f + 69.56f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 14.35f + 69.56f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 14.79f + 69.56f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 15.22f + 69.56f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 13.92f + 71.3f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 14.35f + 71.3f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 14.79f + 71.3f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 15.22f + 71.3f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 13.92f + 73.04f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 14.35f + 73.04f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 14.79f + 73.04f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 15.22f + 73.04f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 13.92f + 74.78f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 14.35f + 74.78f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 14.79f + 74.78f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 15.22f + 74.78f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 13.92f + 76.52f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 14.35f + 76.52f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 14.79f + 76.52f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 15.22f + 76.52f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 13.92f + 78.26f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 14.35f + 78.26f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 14.79f + 78.26f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 15.22f + 78.26f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 13.92f + 80.0f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 14.35f + 80.0f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 14.79f + 80.0f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 15.22f + 80.0f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 13.92f + 81.74f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 14.35f + 81.74f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 14.79f + 81.74f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 15.22f + 81.74f, 2.0f, "space"));
            //second groove
            input.Notes.Add(new Data.NoteInfo(true, 41.74f + 55.66f, 42.18f + 55.66f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 42.18f + 55.66f, 43.48f + 55.66f, "s"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 13.92f + 28.26f + 55.66f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 14.35f + 28.26f + 55.66f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 14.79f + 28.26f + 55.66f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 15.22f + 28.26f + 55.66f, 2.0f, "j"));
            //
            input.Notes.Add(new Data.NoteInfo(false, 43.70f + 55.66f, 2.0f, "k"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 43.92f + 55.66f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 44.03f + 55.66f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 44.14f + 55.66f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 44.24f + 55.66f, 2.0f, "a"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 43.92f + 0.87f + 55.66f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 44.03f + 0.87f + 55.66f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 44.14f + 0.87f + 55.66f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 44.24f + 0.87f + 55.66f, 2.0f, ";"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 43.92f + 1.3f + 55.66f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 44.03f + 1.3f + 55.66f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 44.14f + 1.3f + 55.66f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 44.24f + 1.3f + 55.66f, 2.0f, "a"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 13.92f + 31.3f + 55.66f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 14.35f + 31.3f + 55.66f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 14.79f + 31.3f + 55.66f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 15.22f + 31.3f + 55.66f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 46.96f + 55.66f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 45.66f + 55.66f, 46.31f + 55.66f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 45.66f + 55.66f, 46.31f + 55.66f, "k"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 43.92f + 2.61f + 55.66f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 44.03f + 2.61f + 55.66f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 44.14f + 2.61f + 55.66f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 44.24f + 2.61f + 55.66f, 2.0f, ";"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 43.92f + 3.04f + 55.66f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 44.03f + 3.04f + 55.66f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 44.14f + 3.04f + 55.66f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 44.24f + 3.04f + 55.66f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 47.61f + 55.66f, 48.05f + 55.66f, "d"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.05f + 40.65f + 55.66f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 8.27f + 40.65f + 55.66f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 8.48f + 40.65f + 55.66f, 50.0f + 55.66f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 50.22f + 55.66f, 50.66f + 55.66f, "s"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.05f + 40.65f + 55.66f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 8.27f + 40.65f + 55.66f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 8.48f + 40.65f + 55.66f, 50.0f + 55.66f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 50.22f + 55.66f, 50.66f + 55.66f, "j"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.05f + 43.04f + 55.66f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 8.27f + 43.04f + 55.66f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 8.48f + 43.04f + 55.66f, 2.0f, "k"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 43.92f + 7.82f + 55.66f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 44.03f + 7.82f + 55.66f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 44.14f + 7.82f + 55.66f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 44.24f + 7.82f + 55.66f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(true, 52.18f + 55.66f, 53.05f + 55.66f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 53.05f + 55.66f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 53.48f + 55.66f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 53.70f + 55.66f, 54.35f + 55.66f, "s"));
         
            input.Notes.Add(new Data.NoteInfo(true, 52.18f + 55.66f, 53.05f + 55.66f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 53.05f + 55.66f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 53.48f + 55.66f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 53.70f + 55.66f, 54.35f + 55.66f, "j"));
            //second groove
            input.Notes.Add(new Data.NoteInfo(true, 110.87f, 111.31f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 111.31f, 43.48f + 69.57f, "d"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 13.92f + 28.26f + 69.57f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 14.35f + 28.26f + 69.57f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 14.79f + 28.26f + 69.57f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.22f + 28.26f + 69.57f, 2.0f, "k"));
            //
            input.Notes.Add(new Data.NoteInfo(false, 43.70f + 69.57f, 2.0f, "j"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 43.92f + 69.57f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 44.03f + 69.57f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 44.14f + 69.57f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 44.24f + 69.57f, 2.0f, "j"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 43.92f + 0.87f + 69.57f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 44.03f + 0.87f + 69.57f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 44.14f + 0.87f + 69.57f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 44.24f + 0.87f + 69.57f, 2.0f, "f"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 43.92f + 1.3f + 69.57f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 44.03f + 1.3f + 69.57f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 44.14f + 1.3f + 69.57f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 44.24f + 1.3f + 69.57f, 2.0f, "p"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 13.92f + 31.3f + 69.57f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 14.35f + 31.3f + 69.57f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 14.79f + 31.3f + 69.57f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 15.22f + 31.3f + 69.57f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 46.96f + 69.57f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 45.66f + 69.57f, 46.31f + 69.57f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 45.66f + 69.57f, 46.31f + 69.57f, "l"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 43.92f + 2.61f + 69.57f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 44.03f + 2.61f + 69.57f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 44.14f + 2.61f + 69.57f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 44.24f + 2.61f + 69.57f, 2.0f, "k"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 43.92f + 3.04f + 69.57f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 44.03f + 3.04f + 69.57f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 44.14f + 3.04f + 69.57f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 44.24f + 3.04f + 69.57f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 47.61f + 69.57f, 48.05f + 69.57f, "space"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.05f + 40.65f + 69.57f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 8.27f + 40.65f + 69.57f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 8.48f + 40.65f + 69.57f, 50.0f + 69.57f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 50.22f + 69.57f, 50.66f + 69.57f, "s"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.05f + 40.65f + 69.57f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 8.27f + 40.65f + 69.57f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 8.48f + 40.65f + 69.57f, 50.0f + 69.57f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 50.22f + 69.57f, 50.66f + 69.57f, "j"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.05f + 43.04f + 69.57f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 8.27f + 43.04f + 69.57f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.48f + 43.04f + 69.57f, 2.0f, "f"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 43.92f + 7.82f + 69.57f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 44.03f + 7.82f + 69.57f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 44.14f + 7.82f + 69.57f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 44.24f + 7.82f + 69.57f, 2.0f, "p"));

            input.Notes.Add(new Data.NoteInfo(true, 52.18f + 69.57f, 53.05f + 69.57f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 53.05f + 69.57f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 53.48f + 69.57f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 53.70f + 69.57f, 54.35f + 69.57f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 55.22f + 69.57f, 55.66f + 69.57f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 52.18f + 69.57f, 53.05f + 69.57f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 53.05f + 69.57f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 53.48f + 69.57f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 53.70f + 69.57f, 54.35f + 69.57f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 55.22f + 69.57f, 55.66f + 69.57f, "j"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 13.92f + 104.35f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 14.35f + 104.35f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 14.79f + 104.35f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 15.22f + 104.35f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 13.92f + 106.08f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 14.35f + 106.08f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 14.79f + 106.08f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 15.22f + 106.08f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 13.92f + 107.82f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 14.35f + 107.82f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 14.79f + 107.82f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 15.22f + 107.82f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 13.92f + 109.56f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 14.35f + 109.56f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 14.79f + 109.56f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 15.22f + 109.56f, 2.0f, "space"));

            input.Notes.Add(new Data.NoteInfo(true, 125.66f, 128.70f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 125.66f, 128.70f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 125.66f, 128.70f, "k"));
        }
        else if (input.Difficulty.Equals("Extreme"))
        {
            input.Notes.Add(new Data.NoteInfo(false, 0.0f, 2.0f, "s"));
        }
    }
}
