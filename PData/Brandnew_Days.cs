using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Brandnew_Days : MonoBehaviour
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
        MusicInfo.key = 4;
        MusicInfo.name = "Brandnew Days";
        MusicInfo.composer = "Planetboom";//
        MusicInfo.visualizer = "Lucy, Dumpling Life";
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
        normal.level = 1;
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
        hard.level = 14;
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
        CreateNote(input);
        input.max_combo = input.Notes.Count;
    }
    void CreateNote(Data.Playdata input)
    {
        input.Notes = new List<Data.NoteInfo>();
        if (input.Difficulty.Equals("Normal"))
        {
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.23f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.95f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.68f + 0.00f, 2.0f, "f"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 2.40f + 0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.89f + 0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.37f + 0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.85f + 0.00f, 2.0f, "j"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.23f + 3.87f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 0.95f + 3.87f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.68f + 3.87f, 2.0f, "j"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 2.40f + 3.87f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.89f + 3.87f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 3.37f + 3.87f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 3.85f + 3.87f, 2.0f, "s"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.23f + 7.74f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.95f + 7.74f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.68f + 7.74f, 2.0f, "f"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 2.40f + 7.74f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 2.89f + 7.74f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.37f + 7.74f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.85f + 7.74f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 0.23f + 11.61f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 0.95f + 11.61f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 13.29f, 15.71f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 15.71f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 17.64f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 19.58f, 2.0f, "f"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 2.40f + 19.6f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.89f + 19.6f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.37f + 19.6f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.85f + 19.6f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 25.39f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.32f, 2.0f, "s"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 2.40f + 27.34f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.89f + 27.34f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.37f + 27.34f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 31.68f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 32.16f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 32.4f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 32.89f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 34.58f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(true, 34.82f, 36.52f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 36.76f, 38.45f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 2.40f + 36.53f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.89f + 36.53f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.37f + 36.53f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.85f + 36.53f, 2.0f, "d"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 2.40f + 38.47f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.89f + 38.47f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.37f + 38.47f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.85f + 38.47f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 42.56f, 46.19f, "k"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 47.64f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 48.61f + 0.00f, 2.0f, "d"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 3.87f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 47.64f + 3.87f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 48.61f + 3.87f, 2.0f, "k"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 7.74f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 47.64f + 7.74f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 48.61f + 7.74f, 2.0f, "s"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 11.61f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 47.64f + 11.61f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 59.98f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 63.61f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 67.0f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 70.39f, 2.0f, "j"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 27.09f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 47.64f + 27.09f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 48.61f + 27.09f, 2.0f, "f"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 30.96f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 47.64f + 30.96f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 48.61f + 30.96f, 2.0f, "l"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 34.84f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 47.64f + 34.84f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 48.61f + 34.84f, 2.0f, "s"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 38.71f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 47.64f + 38.71f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 48.61f + 38.71f, 88.77f, "l"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 42.58f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 47.64f + 42.58f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 48.61f + 42.58f, 2.0f, "d"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 46.45f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 47.64f + 46.45f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 48.61f + 46.45f, 2.0f, "s"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 50.32f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 47.64f + 50.32f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 48.61f + 50.32f, 2.0f, "space"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 54.19f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 47.64f + 54.19f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 48.61f + 54.19f, 2.0f, "j"));
            //2/1
            input.Notes.Add(new Data.NoteInfo(false, 104.74f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 105.71f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 106.68f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 107.64f + 0.00f, 2.0f, "s"));
            //2/1
            input.Notes.Add(new Data.NoteInfo(false, 104.74f + 3.87f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 105.71f + 3.87f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 106.68f + 3.87f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 107.64f + 3.87f, 2.0f, "j"));
            //2/1
            input.Notes.Add(new Data.NoteInfo(false, 104.74f + 7.74f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 105.71f + 7.74f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 106.68f + 7.74f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 107.64f + 7.74f, 2.0f, "f"));
            //2/1
            input.Notes.Add(new Data.NoteInfo(false, 104.74f + 11.61f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 105.71f + 11.61f, 2.0f, "k"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.23f + 118.06f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.95f + 118.06f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.68f + 118.06f, 2.0f, "f"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.23f + 121.93f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 0.95f + 121.93f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.68f + 121.93f, 2.0f, "j"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.23f + 125.8f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 0.95f + 125.8f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.68f + 125.8f, 2.0f, "j"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.23f + 129.67f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 0.95f + 129.67f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 1.68f + 129.67f, 133.29f, "k"));
        }
        else if (input.Difficulty.Equals("Hard"))
        {
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.23f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.95f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 1.68f + 0.00f, 3.85f+0.0f, "f"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 2.40f + 0.00f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 2.89f + 0.00f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 3.37f + 0.00f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 3.85f + 0.00f, 2.0f, ";"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.23f + 3.87f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 0.95f + 3.87f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 1.68f + 3.87f, 3.85f + 3.87f, "j"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 2.40f + 3.87f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 2.89f + 3.87f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 3.37f + 3.87f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 3.85f + 3.87f, 2.0f, "a"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.23f + 7.74f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 0.95f + 7.74f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 1.68f + 7.74f, 3.85f + 7.74f, "s"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 2.40f + 7.74f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 2.89f + 7.74f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 3.37f + 7.74f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 3.85f + 7.74f, 2.0f, "p"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.23f + 11.61f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 0.95f + 11.61f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 1.68f + 11.61f, 15.71f, "l"));
            //1st rythem
            input.Notes.Add(new Data.NoteInfo(false, 15.71f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 16.19f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 16.68f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 17.16f + 0.00f, 2.0f, "d"));
            //
            input.Notes.Add(new Data.NoteInfo(false, 15.95f + 0.00f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 16.43f + 0.00f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 16.92f + 0.00f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 17.40f + 0.00f, 2.0f, "space"));
            //
            input.Notes.Add(new Data.NoteInfo(false, 16.19f + 0.00f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 17.16f + 0.00f, 2.0f, "k"));
            //
            input.Notes.Add(new Data.NoteInfo(false, 17.52f + 0.00f, 2.0f, "j"));
            //1st rythem
            input.Notes.Add(new Data.NoteInfo(false, 15.71f + 1.93f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 16.19f + 1.93f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 16.68f + 1.93f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 17.16f + 1.93f, 2.0f, "k"));
            //
            input.Notes.Add(new Data.NoteInfo(false, 15.95f + 1.93f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 16.43f + 1.93f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 16.92f + 1.93f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 17.40f + 1.93f, 2.0f, "space"));
            //
            input.Notes.Add(new Data.NoteInfo(false, 16.19f + 1.93f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 17.16f + 1.93f, 2.0f, "s"));
            //
            input.Notes.Add(new Data.NoteInfo(false, 17.52f + 1.93f, 2.0f, "f"));
            //1st rythem
            input.Notes.Add(new Data.NoteInfo(false, 15.71f + 3.87f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 16.19f + 3.87f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 16.68f + 3.87f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 17.16f + 3.87f, 2.0f, "d"));
            //
            input.Notes.Add(new Data.NoteInfo(false, 15.95f + 3.87f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 16.43f + 3.87f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 16.92f + 3.87f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 17.40f + 3.87f, 2.0f, "space"));
            //
            input.Notes.Add(new Data.NoteInfo(false, 16.19f + 3.87f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 17.16f + 3.87f, 2.0f, "k"));
            //
            input.Notes.Add(new Data.NoteInfo(false, 17.52f + 3.87f, 2.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 21.54f + 0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 21.76f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 22.00f + 0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 22.24f + 0.00f, 2.0f, "d"));
            //
            input.Notes.Add(new Data.NoteInfo(false, 22.48f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 22.72f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 22.97f + 0.00f, 2.0f, "l"));
            //1st rythem
            input.Notes.Add(new Data.NoteInfo(false, 15.71f + 7.74f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 16.19f + 7.74f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 16.68f + 7.74f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 17.16f + 7.74f, 2.0f, "d"));
            //
            input.Notes.Add(new Data.NoteInfo(false, 15.95f + 7.74f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 16.43f + 7.74f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 16.92f + 7.74f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 17.40f + 7.74f, 2.0f, "space"));
            //
            input.Notes.Add(new Data.NoteInfo(false, 16.19f + 7.74f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 17.16f + 7.74f, 2.0f, "l"));
            //
            input.Notes.Add(new Data.NoteInfo(false, 17.52f + 7.74f, 2.0f, "j"));
            //1st rythem
            input.Notes.Add(new Data.NoteInfo(false, 15.71f + 9.68f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 16.19f + 9.68f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 16.68f + 9.68f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 17.16f + 9.68f, 2.0f, "k"));
            //
            input.Notes.Add(new Data.NoteInfo(false, 15.95f + 9.68f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 16.43f + 9.68f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 16.92f + 9.68f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 17.40f + 9.68f, 2.0f, "space"));
            //
            input.Notes.Add(new Data.NoteInfo(false, 16.19f + 9.68f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 17.16f + 9.68f, 2.0f, "s"));
            //
            input.Notes.Add(new Data.NoteInfo(false, 17.52f + 9.68f, 2.0f, "f"));
            //1st rythem
            input.Notes.Add(new Data.NoteInfo(false, 15.71f + 11.61f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 16.19f + 11.61f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 16.68f + 11.61f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 17.16f + 11.61f, 2.0f, "d"));
            //
            input.Notes.Add(new Data.NoteInfo(false, 15.95f + 11.61f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 16.43f + 11.61f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 16.92f + 11.61f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 17.40f + 11.61f, 2.0f, "space"));
            //
            input.Notes.Add(new Data.NoteInfo(false, 16.19f + 11.61f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 17.16f + 11.61f, 2.0f, "l"));
            //
            input.Notes.Add(new Data.NoteInfo(false, 17.52f + 11.61f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 21.54f + 7.72f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 21.76f + 7.72f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 22.00f + 7.72f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 22.24f + 7.72f, 2.0f, "k"));
            //
            input.Notes.Add(new Data.NoteInfo(false, 22.48f + 7.72f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 22.72f + 7.72f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 22.97f + 7.72f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 31.68f, 2.0f, "s"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 15.71f + 16.45f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 16.19f + 16.45f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 16.68f + 16.45f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 17.16f + 16.45f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 16.68f + 17.42f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 17.16f + 17.42f, 2.0f, "j"));
            //3rys
            input.Notes.Add(new Data.NoteInfo(false, 32.16f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 32.40f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 32.64f + 0.00f, 2.0f, "d"));
            //3rys
            input.Notes.Add(new Data.NoteInfo(false, 32.16f + 0.97f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 32.40f + 0.97f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 32.64f + 0.97f, 2.0f, "d"));
            //3rys
            input.Notes.Add(new Data.NoteInfo(false, 32.16f + 1.94f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 32.40f + 1.94f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 32.64f + 1.94f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(true, 34.85f, 36.52f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 36.76f, 38.45f, "l"));
            //big hit
            input.Notes.Add(new Data.NoteInfo(false, 2.40f + 36.53f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.89f + 36.53f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.37f + 36.53f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.85f + 36.53f, 2.0f, "d"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 2.40f + 36.53f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 2.89f + 36.53f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.37f + 36.53f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.85f + 36.53f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 4.1f + 36.53f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 4.22f + 36.53f, 2.0f, "j"));
            //big hit
            input.Notes.Add(new Data.NoteInfo(false, 2.40f + 38.47f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 2.89f + 38.47f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.37f + 38.47f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.85f + 38.47f, 2.0f, "k"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 2.40f + 38.47f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.89f + 38.47f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.37f + 38.47f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.85f + 38.47f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 42.56f, 44.50f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 44.50f, 46.43f, "d"));
            //ziggy
            input.Notes.Add(new Data.NoteInfo(false, 44.74f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 44.98f, 2.0f, "a"));
            //8com
            input.Notes.Add(new Data.NoteInfo(false, 45.22f + 0.00f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 45.35f + 0.00f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 45.47f + 0.00f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 45.59f + 0.00f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 45.71f + 0.00f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 45.83f + 0.00f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 45.95f + 0.00f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 46.07f + 0.00f, 2.0f, "q"));

            //basic guitar
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 46.92f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 46.92f + 0.00f, 2.0f, "f"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 47.16f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 47.28f + 0.00f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 47.40f + 0.00f, 2.0f, "k"));
            //basic guitar
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 0.96f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 0.96f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 46.92f + 0.96f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 46.92f + 0.96f, 2.0f, "l"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 47.16f + 0.96f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 47.28f + 0.96f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 47.40f + 0.96f, 2.0f, "s"));
            //basic guitar
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 1.93f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 1.93f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 46.92f + 1.93f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 46.92f + 1.93f, 2.0f, "f"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 47.16f + 1.93f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 47.28f + 1.93f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 47.40f + 1.93f, 2.0f, "j"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 47.16f + 2.42f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 47.28f + 2.42f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 47.40f + 2.42f, 2.0f, "f"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 47.16f + 2.90f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 47.28f + 2.90f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 47.40f + 2.90f, 2.0f, "s"));
            //basic guitar
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 3.87f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 3.87f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 46.92f + 3.87f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 46.92f + 3.87f, 2.0f, "l"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 47.16f + 3.87f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 47.28f + 3.87f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 47.40f + 3.87f, 2.0f, "s"));
            //basic guitar
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 4.84f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 4.84f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 46.92f + 4.84f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 46.92f + 4.84f, 2.0f, "s"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 47.16f + 4.84f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 47.28f + 4.84f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 47.40f + 4.84f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 52.48f, 52.97f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 52.97f, 53.45f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 53.45f, 54.42f, "d"));
            //basic guitar
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 7.74f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 7.74f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 46.92f + 7.74f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 46.92f + 7.74f, 2.0f, "d"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 47.16f + 7.74f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 47.28f + 7.74f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 47.40f + 7.74f, 2.0f, "j"));
            //basic guitar
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 8.71f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 8.71f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 46.92f + 8.71f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 46.92f + 8.71f, 2.0f, "j"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 47.16f + 8.71f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 47.28f + 8.71f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 47.40f + 8.71f, 2.0f, "f"));
            //basic guitar
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 9.67f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 9.67f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 46.92f + 9.67f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 46.92f + 9.67f, 2.0f, "s"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 47.16f + 9.67f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 47.28f + 9.67f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 47.40f + 9.67f, 2.0f, "j"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 47.16f + 10.16f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 47.28f + 10.16f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 47.40f + 10.16f, 2.0f, "f"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 47.16f + 10.65f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 47.28f + 10.65f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 47.40f + 10.65f, 2.0f, "l"));
            //basic guitar
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 11.61f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 11.61f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 46.92f + 11.61f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 46.92f + 11.61f, 2.0f, "f"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 47.16f + 11.61f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 47.28f + 11.61f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 47.40f + 11.61f, 2.0f, "k"));
            //basic guitar
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 12.58f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 12.58f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 46.92f + 12.58f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 46.92f + 12.58f, 2.0f, "k"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 47.16f + 12.58f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 47.28f + 12.58f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 47.40f + 12.58f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 60.22f, 62.64f, "space"));
            //guitar solo
            input.Notes.Add(new Data.NoteInfo(true, 63.61f, 64.34f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 64.34f, 64.82f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 64.82f, 65.06f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 65.06f, 66.27f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 66.27f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 66.52f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 66.76f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 67.00f, 68.21f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 68.21f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 68.33f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 68.45f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 68.57f, 69.42f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 69.42f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 69.66f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 69.90f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 70.14f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 70.39f, 71.11f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 71.11f, 71.84f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 71.84f, 72.32f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 72.32f, 73.05f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 73.05f, 73.77f, "f"));
            //2peak
            input.Notes.Add(new Data.NoteInfo(false, 73.77f+0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 74.02f+0.00f, 2.0f, "k"));
            //2peak
            input.Notes.Add(new Data.NoteInfo(false, 73.77f + 0.97f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 74.02f + 0.97f, 2.0f, "q"));
            //2peak
            input.Notes.Add(new Data.NoteInfo(false, 73.77f + 1.94f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 74.02f + 1.94f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 77.16f, 77.64f, "d"));
            //3peak
            input.Notes.Add(new Data.NoteInfo(false, 77.64f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 77.89f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 78.13f + 0.00f, 2.0f, "f"));
            //3peak
            input.Notes.Add(new Data.NoteInfo(false, 77.64f + 0.97f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 77.89f + 0.97f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 78.13f + 0.97f, 2.0f, "p"));
            //3peak
            input.Notes.Add(new Data.NoteInfo(false, 77.64f + 1.94f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 77.89f + 1.94f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 78.13f + 1.94f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 80.55f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 80.79f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 81.03f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 81.15f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 81.27f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 81.39f, 2.0f, "p"));
            //basic guitar
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 34.84f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 34.84f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 46.92f + 34.84f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 46.92f + 34.84f, 2.0f, "d"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 47.16f + 34.84f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 47.28f + 34.84f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 47.40f + 34.84f, 2.0f, "j"));
            //basic guitar
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 35.8f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 35.8f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 46.92f + 35.8f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 46.92f + 35.8f, 2.0f, "j"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 47.16f + 35.8f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 47.28f + 35.8f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 47.40f + 35.8f, 2.0f, "f"));
            //basic guitar
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 36.77f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 36.77f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 46.92f + 36.77f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 46.92f + 36.77f, 2.0f, "f"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 47.16f + 36.77f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 47.28f + 36.77f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 47.40f + 36.77f, 2.0f, "j"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 47.16f + 37.26f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 47.28f + 37.26f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 47.40f + 37.26f, 2.0f, "f"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 47.16f + 37.74f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 47.28f + 37.74f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 47.40f + 37.74f, 2.0f, "j"));
            //basic guitar
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 38.71f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 38.71f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 46.92f + 38.71f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 46.92f + 38.71f, 2.0f, "f"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 47.16f + 38.71f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 47.28f + 38.71f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 47.40f + 38.71f, 2.0f, "j"));
            //basic guitar
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 39.67f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 39.67f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 46.92f + 39.67f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 46.92f + 39.67f, 2.0f, "j"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 47.16f + 39.67f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 47.28f + 39.67f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 47.40f + 39.67f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(true, 87.32f, 87.81f, "l"));
            //com
            input.Notes.Add(new Data.NoteInfo(false, 47.16f + 40.65f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 47.28f + 40.65f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 47.40f + 40.65f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 47.16f + 41.01f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 47.28f + 41.01f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 47.40f + 41.01f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 47.16f + 41.37f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 47.28f + 41.37f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 47.40f + 41.37f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 47.16f + 41.73f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 47.28f + 41.73f, 2.0f, "f"));
            //basic guitar
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 42.58f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 42.58f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 46.92f + 42.58f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 46.92f + 42.58f, 2.0f, "f"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 47.16f + 42.58f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 47.28f + 42.58f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 47.40f + 42.58f, 2.0f, "j"));
            //basic guitar
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 43.54f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 43.54f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 46.92f + 43.54f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 46.92f + 43.54f, 2.0f, "j"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 47.16f + 43.54f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 47.28f + 43.54f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 47.40f + 43.54f, 2.0f, "s"));
            //basic guitar
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 44.51f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 44.51f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 46.92f + 44.51f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 46.92f + 44.51f, 2.0f, "s"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 47.16f + 44.51f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 47.28f + 44.51f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 47.40f + 44.51f, 2.0f, "j"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 47.16f + 45.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 47.28f + 45.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 47.40f + 45.00f, 2.0f, "f"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 47.16f + 45.48f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 47.28f + 45.48f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 47.40f + 45.48f, 2.0f, "l"));
            //basic guitar
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 46.45f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 46.45f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 46.92f + 46.45f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 46.92f + 46.45f, 2.0f, "d"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 47.16f + 46.45f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 47.28f + 46.45f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 47.40f + 46.45f, 2.0f, "j"));
            //basic guitar
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 47.42f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 47.42f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 46.92f + 47.42f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 46.92f + 47.42f, 2.0f, "j"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 47.16f + 47.42f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 47.28f + 47.42f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 47.40f + 47.42f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 95.06f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 95.31f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 95.55f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 95.79f, 97.00f, "space"));
            //basic guitar
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 50.32f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 50.32f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 46.92f + 50.32f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 46.92f + 50.32f, 2.0f, "s"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 47.16f + 50.32f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 47.28f + 50.32f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 47.40f + 50.32f, 2.0f, "k"));
            //basic guitar
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 51.29f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 51.29f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 46.92f + 51.29f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 46.92f + 51.29f, 2.0f, "k"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 47.16f + 51.29f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 47.28f + 51.29f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 47.40f + 51.29f, 2.0f, "s"));
            //basic guitar
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 52.25f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 52.25f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 46.92f + 52.25f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 46.92f + 52.25f, 2.0f, "d"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 47.16f + 52.25f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 47.28f + 52.25f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 47.40f + 52.25f, 2.0f, "j"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 47.16f + 52.74f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 47.28f + 52.74f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 47.40f + 52.74f, 2.0f, "s"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 47.16f + 53.23f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 47.28f + 53.23f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 47.40f + 53.23f, 2.0f, "k"));
            //basic guitar
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 54.19f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 54.19f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 46.92f + 54.19f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 46.92f + 54.19f, 2.0f, "s"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 47.16f + 54.19f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 47.28f + 54.19f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 47.40f + 54.19f, 2.0f, "l"));
            //basic guitar
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 55.16f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 55.16f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 46.92f + 55.16f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 46.92f + 55.16f, 2.0f, "l"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 47.16f + 55.16f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 47.28f + 55.16f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 47.40f + 55.16f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 102.81f, 103.29f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 103.29f, 103.77f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 103.77f, 104.74f, "l"));
            //guitar rage
            input.Notes.Add(new Data.NoteInfo(false, 104.74f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 104.86f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 104.98f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 105.22f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 105.35f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 105.47f + 0.00f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 105.71f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 105.95f + 0.00f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 106.19f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 106.43f + 0.00f, 2.0f, "k"));
            //guitar rage
            input.Notes.Add(new Data.NoteInfo(false, 104.74f + 1.94f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 104.86f + 1.94f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 104.98f + 1.94f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 105.22f + 1.94f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 105.35f + 1.94f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 105.47f + 1.94f, 2.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 105.71f + 1.94f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 105.95f + 1.94f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 106.19f + 1.94f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 106.43f + 1.94f, 2.0f, "d"));
            //guitar rage
            input.Notes.Add(new Data.NoteInfo(false, 104.74f + 3.87f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 104.86f + 3.87f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 104.98f + 3.87f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 105.22f + 3.87f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 105.35f + 3.87f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 105.47f + 3.87f, 2.0f, "space"));

            input.Notes.Add(new Data.NoteInfo(false, 105.71f + 3.87f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 105.95f + 3.87f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 106.19f + 3.87f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 106.43f + 3.87f, 2.0f, "k"));
            //guitar rage
            input.Notes.Add(new Data.NoteInfo(false, 104.74f + 5.81f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 104.86f + 5.81f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 104.98f + 5.81f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 105.22f + 5.81f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 105.35f + 5.81f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 105.47f + 5.81f, 2.0f, "space"));

            input.Notes.Add(new Data.NoteInfo(false, 105.71f + 5.81f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 105.95f + 5.81f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 106.19f + 5.81f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 106.43f + 5.81f, 2.0f, "l"));
            //guitar rage2
            input.Notes.Add(new Data.NoteInfo(false, 104.74f + 7.74f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 104.86f + 7.74f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 104.98f + 7.74f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 105.10f + 7.74f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 105.22f + 7.74f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 105.35f + 7.74f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 105.47f + 7.74f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 105.59f + 7.74f, 2.0f, "space"));

            input.Notes.Add(new Data.NoteInfo(false, 105.71f + 7.74f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 105.95f + 7.74f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 106.19f + 7.74f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 106.43f + 7.74f, 2.0f, "k"));
            //guitar rage2
            input.Notes.Add(new Data.NoteInfo(false, 104.74f + 9.68f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 104.86f + 9.68f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 104.98f + 9.68f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 105.10f + 9.68f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 105.22f + 9.68f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 105.35f + 9.68f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 105.47f + 9.68f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 105.59f + 9.68f, 2.0f, "space"));

            input.Notes.Add(new Data.NoteInfo(false, 105.71f + 9.68f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 105.95f + 9.68f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 106.19f + 9.68f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 106.43f + 9.68f, 2.0f, "d"));
            //guitar rage2
            input.Notes.Add(new Data.NoteInfo(false, 104.74f + 11.61f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 104.86f + 11.61f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 104.98f + 11.61f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 105.10f + 11.61f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 105.22f + 11.61f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 105.35f + 11.61f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 105.47f + 11.61f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 105.59f + 11.61f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 105.71f + 11.61f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 105.95f + 11.61f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 106.19f + 11.61f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 106.43f + 11.61f, 2.0f, "p"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.23f + 118.06f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.95f + 118.06f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 1.68f + 118.06f, 3.85f + 118.06f, "f"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 2.40f + 118.06f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 2.89f + 118.06f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 3.37f + 118.06f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 3.85f + 118.06f, 2.0f, ";"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.23f + 121.93f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 0.95f + 121.93f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 1.68f + 121.93f, 3.85f + 121.93f, "j"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 2.40f + 121.93f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 2.89f + 121.93f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 3.37f + 121.93f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 3.85f + 121.93f, 2.0f, "a"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.23f + 125.8f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.95f + 125.8f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 1.68f + 125.8f, 3.85f + 125.8f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 2.40f + 125.8f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 2.89f + 125.8f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 3.37f + 125.8f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 3.85f + 125.8f, 2.0f, "p"));

            input.Notes.Add(new Data.NoteInfo(false, 129.9f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 130.63f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 131.35f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 131.60f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 131.84f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 132.08f, 135.71f, "k"));
        }
        else if (input.Difficulty.Equals("Extreme"))
        {
            input.Notes.Add(new Data.NoteInfo(false, 0.0f, 2.0f, "s"));
        }
    }
}
