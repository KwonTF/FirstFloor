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
        MusicInfo.composer = "Planetboom";
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
        hard.level = 14;
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
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.23f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.95f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.68f + 0.00f, 2.0f, "s"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 2.40f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.89f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 3.37f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 3.85f + 0.00f, 2.0f, "s"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.23f + 3.87f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.95f + 3.87f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.68f + 3.87f, 2.0f, "s"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 2.40f + 3.87f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.89f + 3.87f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 3.37f + 3.87f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 3.85f + 3.87f, 2.0f, "s"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.23f + 7.74f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.95f + 7.74f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.68f + 7.74f, 2.0f, "s"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 2.40f + 7.74f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.89f + 7.74f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 3.37f + 7.74f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 3.85f + 7.74f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 0.23f + 11.61f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.95f + 11.61f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 13.29f, 15.71f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 15.71f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 17.64f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 19.58f, 2.0f, "s"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 2.40f + 19.6f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.89f + 19.6f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 3.37f + 19.6f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 3.85f + 19.6f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 25.39f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 27.32f, 2.0f, "s"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 2.40f + 27.34f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.89f + 27.34f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 3.37f + 27.34f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 31.68f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 32.16f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 32.4f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 32.89f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 34.58f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(true, 34.82f, 36.52f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 36.76f, 38.45f, "s"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 2.40f + 36.53f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.89f + 36.53f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 3.37f + 36.53f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 3.85f + 36.53f, 2.0f, "s"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 2.40f + 38.47f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.89f + 38.47f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 3.37f + 38.47f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 3.85f + 38.47f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 42.56f, 46.19f, "s"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 47.64f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 48.61f + 0.00f, 2.0f, "s"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 3.87f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 47.64f + 3.87f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 48.61f + 3.87f, 2.0f, "s"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 7.74f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 47.64f + 7.74f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 48.61f + 7.74f, 2.0f, "s"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 11.61f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 47.64f + 11.61f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 59.98f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 63.61f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 67.0f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 70.39f, 2.0f, "s"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 27.09f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 47.64f + 27.09f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 48.61f + 27.09f, 2.0f, "s"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 30.96f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 47.64f + 30.96f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 48.61f + 30.96f, 2.0f, "s"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 34.84f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 47.64f + 34.84f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 48.61f + 34.84f, 2.0f, "s"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 38.71f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 47.64f + 38.71f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 48.61f + 38.71f, 88.77f, "s"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 42.58f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 47.64f + 42.58f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 48.61f + 42.58f, 2.0f, "s"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 46.45f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 47.64f + 46.45f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 48.61f + 46.45f, 2.0f, "s"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 50.32f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 47.64f + 50.32f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 48.61f + 50.32f, 2.0f, "s"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 46.68f + 54.19f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 47.64f + 54.19f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 48.61f + 54.19f, 2.0f, "s"));
            //2/1
            input.Notes.Add(new Data.NoteInfo(false, 104.74f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 47.64f + 0.00f, 2.0f, "s"));
        }
        else if (input.Difficulty.Equals("Hard"))
        {
            input.Notes.Add(new Data.NoteInfo(false, 0.0f, 2.0f, "s"));
        }
        else if (input.Difficulty.Equals("Extreme"))
        {
            input.Notes.Add(new Data.NoteInfo(false, 0.0f, 2.0f, "s"));
        }
    }
}
