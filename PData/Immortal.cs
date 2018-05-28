using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Immortal: MonoBehaviour{

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
        MusicInfo.key = 0;
        MusicInfo.name = "Immortal";
        MusicInfo.composer = "Envy";
        MusicInfo.visualizer = "Default";
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
        normal.level = 6;
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
        hard.level = 12;
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
        extreme.level = 3;
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
            input.Notes.Add(new Data.NoteInfo(true, 0.23f+0.0f, 2.00f+0.0f, "f"));
            //4bit
            input.Notes.Add(new Data.NoteInfo(false, 2.00f + 0.0f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.44f + 0.0f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.88f + 0.0f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 3.32f + 0.0f, 2.0f, "f"));
            //4bit
            input.Notes.Add(new Data.NoteInfo(false, 2.00f + 1.76f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.44f + 1.76f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 2.88f + 1.76f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.32f + 1.76f, 2.0f, "l"));
            //4bit
            input.Notes.Add(new Data.NoteInfo(false, 2.00f + 3.52f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.44f + 3.52f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.88f + 3.52f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.32f + 3.52f, 2.0f, "f"));
            //4bit
            input.Notes.Add(new Data.NoteInfo(false, 2.00f + 5.29f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.44f + 5.29f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 2.88f + 5.29f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 3.32f + 5.29f, 2.0f, "space"));//
            //4bit
            input.Notes.Add(new Data.NoteInfo(false, 2.00f + 7.05f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 2.44f + 7.05f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 2.88f + 7.05f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.32f + 7.05f, 2.0f, "l"));
            //4bit
            input.Notes.Add(new Data.NoteInfo(false, 2.00f + 8.82f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.44f + 8.82f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.88f + 8.82f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.32f + 8.82f, 2.0f, "j"));
            //4bit
            input.Notes.Add(new Data.NoteInfo(false, 2.00f + 10.58f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.44f + 10.58f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 2.88f + 10.58f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 3.32f + 10.58f, 2.0f, "k"));
            //4bit
            input.Notes.Add(new Data.NoteInfo(false, 2.00f + 12.35f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.44f + 12.35f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.88f + 12.35f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.32f + 12.35f, 2.0f, "f"));//

            input.Notes.Add(new Data.NoteInfo(true, 16.11f + 0.0f, 19.64f + 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 19.64f + 0.0f, 23.17f + 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 23.17f + 0.0f, 26.70f + 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 26.70f + 0.0f, 29.35f + 0.0f, "l"));
            //3bit
            input.Notes.Add(new Data.NoteInfo(false, 30.23f + 0.0f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 30.67f + 0.0f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 31.11f + 0.0f, 2.0f, "s"));
            //3bit
            input.Notes.Add(new Data.NoteInfo(false, 30.23f + 1.76f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.67f + 1.76f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 31.11f + 1.76f, 2.0f, "d"));
            //3bit
            input.Notes.Add(new Data.NoteInfo(false, 30.23f + 3.53f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 30.67f + 3.53f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 31.11f + 3.53f, 2.0f, "f"));
            //3bit
            input.Notes.Add(new Data.NoteInfo(false, 30.23f + 5.29f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 30.67f + 5.29f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 31.11f + 5.29f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(true, 37.29f + 0.0f, 38.17f + 0.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 39.05f + 0.0f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 39.94f + 0.0f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 40.82f + 0.0f, 41.26f + 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 41.70f + 0.0f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 41.92f + 0.0f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 42.14f + 0.0f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 42.58f + 0.0f, 43.47f + 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 43.47f + 0.0f, 44.35f + 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 44.35f + 0.0f,  45.67f + 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 45.67f + 0.0f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 45.78f + 0.0f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 45.89f + 0.0f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 46.0f + 0.0f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 46.11f + 0.0f, 46.55f + 0.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 46.77f + 0.0f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 46.88f + 0.0f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 46.99f + 0.0f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 47.11f + 0.0f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 47.22f + 0.0f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 47.33f + 0.0f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 47.44f + 0.0f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 47.55f + 0.0f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 47.66f + 0.0f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 47.77f + 0.0f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 47.88f + 0.0f, 48.76f + 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 48.76f + 0.0f, 49.64f + 0.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(true, 50.52f + 0.0f, 50.97f + 0.0f, "space"));
            //
            input.Notes.Add(new Data.NoteInfo(true, 37.29f + 14.12f, 38.17f + 14.12f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 39.05f + 14.12f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 39.94f + 14.12f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 40.82f + 14.12f, 41.26f + 14.12f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 41.70f + 14.12f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 41.92f + 14.12f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 42.14f + 14.12f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 42.58f + 14.12f, 43.47f + 14.12f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 43.47f + 14.12f, 44.35f + 14.12f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 44.35f + 14.12f, 45.67f + 14.12f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 45.67f + 14.12f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 45.78f + 14.12f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 45.89f + 14.12f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 46.0f + 14.12f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 46.11f + 14.12f, 46.55f + 14.12f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 46.77f + 14.12f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 46.88f + 14.12f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 46.99f + 14.12f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 47.11f + 14.12f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 47.22f + 14.12f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 47.33f + 14.12f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 47.44f + 14.12f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 47.55f + 14.12f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 47.66f + 14.12f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 47.77f + 14.12f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 47.88f + 14.12f, 48.76f + 14.12f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 48.76f + 14.12f, 49.64f + 14.12f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 63.98f + 0.0f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 64.64f + 0.0f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 64.97f + 0.0f, 2.0f, "d"));    
            input.Notes.Add(new Data.NoteInfo(false, 65.30f + 0.0f, 2.0f, "k"));

            //4bit
            input.Notes.Add(new Data.NoteInfo(false, 2.00f + 63.52f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.44f + 63.52f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.88f + 63.52f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 3.32f + 63.52f, 2.0f, "s"));
            //4bit
            input.Notes.Add(new Data.NoteInfo(false, 2.00f + 65.29f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.44f + 65.29f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.88f + 65.29f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.32f + 65.29f, 2.0f, "d"));
            //4bit
            input.Notes.Add(new Data.NoteInfo(false, 2.00f + 67.05f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.44f + 67.05f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.88f + 67.05f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.32f + 67.05f, 2.0f, "f"));
            //4bit
            input.Notes.Add(new Data.NoteInfo(false, 2.00f + 68.82f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 2.44f + 68.82f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 2.88f + 68.82f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.32f + 68.82f, 2.0f, "k"));
            //4bit
            input.Notes.Add(new Data.NoteInfo(false, 2.00f + 70.58f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.44f + 70.58f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.88f + 70.58f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.32f + 70.58f, 2.0f, "k"));
            //4bit
            input.Notes.Add(new Data.NoteInfo(false, 2.00f + 72.35f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 2.44f + 72.35f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.88f + 72.35f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.32f + 72.35f, 2.0f, "d"));
            
            input.Notes.Add(new Data.NoteInfo(false, 76.11f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 76.99f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 77.88f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 78.76f, 2.0f, ";"));
            //3bit
            input.Notes.Add(new Data.NoteInfo(false, 30.23f + 49.41f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 30.67f + 49.41f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 31.11f + 49.41f, 2.0f, "f"));
            //3bit
            input.Notes.Add(new Data.NoteInfo(false, 30.23f + 51.18f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 30.67f + 51.18f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 31.11f + 51.18f, 2.0f, "j"));
            //3bit
            input.Notes.Add(new Data.NoteInfo(false, 30.23f + 52.94f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 30.67f + 52.94f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 31.11f + 52.94f, 2.0f, "d"));
            //3bit
            input.Notes.Add(new Data.NoteInfo(false, 30.23f + 54.71f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 30.67f + 54.71f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 31.11f + 54.71f, 2.0f, "k"));
            //3bit
            input.Notes.Add(new Data.NoteInfo(false, 30.23f + 56.47f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.67f + 56.47f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 31.11f + 56.47f, 2.0f, "s"));
            //3bit
            input.Notes.Add(new Data.NoteInfo(false, 30.23f + 58.24f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 30.67f + 58.24f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 31.11f + 58.24f, 2.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(true, 90.23f, 93.76f, "space"));
            //3bit
            input.Notes.Add(new Data.NoteInfo(false, 30.23f + 63.53f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.67f + 63.53f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 31.11f + 63.53f, 2.0f, "d"));
            //3bit
            input.Notes.Add(new Data.NoteInfo(false, 30.23f + 65.29f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 30.67f + 65.29f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 31.11f + 65.29f, 2.0f, "s"));
            //3bit
            input.Notes.Add(new Data.NoteInfo(false, 30.23f + 67.06f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 30.67f + 67.06f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 31.11f + 67.06f, 2.0f, "j"));
            //3bit
            input.Notes.Add(new Data.NoteInfo(false, 30.23f + 68.82f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 30.67f + 68.82f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 31.11f + 68.82f, 2.0f, "l"));
            //4bit
            input.Notes.Add(new Data.NoteInfo(false, 2.00f + 98.82f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.44f + 98.82f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.88f + 98.82f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.32f + 98.82f, 2.0f, "f"));
            //4bit
            input.Notes.Add(new Data.NoteInfo(false, 2.00f + 100.58f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.44f + 100.58f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 2.88f + 100.58f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 3.32f + 100.58f, 2.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 104.35f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 105.23f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 106.11f, 2.0f, "j"));
            //
            input.Notes.Add(new Data.NoteInfo(true, 37.29f + 70.59f, 38.17f + 70.59f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 39.05f + 70.59f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 39.94f + 70.59f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 40.82f + 70.59f, 41.26f + 70.59f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 41.70f + 70.59f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 41.92f + 70.59f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 42.14f + 70.59f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 42.58f + 70.59f, 43.47f + 70.59f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 43.47f + 70.59f, 44.35f + 70.59f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 44.35f + 70.59f, 45.67f + 70.59f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 45.67f + 70.59f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 45.78f + 70.59f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 45.89f + 70.59f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 46.0f + 70.59f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 46.11f + 70.59f, 46.55f + 70.59f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 46.77f + 70.59f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 46.88f + 70.59f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 46.99f + 70.59f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 47.11f + 70.59f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 47.22f + 70.59f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 47.33f + 70.59f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 47.44f + 70.59f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 47.55f + 70.59f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 47.66f + 70.59f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 47.77f + 70.59f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(true, 118.47f, 119.79f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 120.23f, 120.89f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 120.89f, 121.99f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 122.0f, 119.79f, ";"));
        }
        else if (input.Difficulty.Equals("Hard"))
        {
            input.Notes.Add(new Data.NoteInfo(true, 0.23f + 0.0f, 2.00f + 0.0f, "f"));
            
            //digit
            input.Notes.Add(new Data.NoteInfo(false, 2.0f+0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.11f+0.00f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.22f+0.00f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.33f+0.00f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.44f+0.00f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.55f+0.00f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.66f+0.00f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.77f+0.00f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 2.88f+0.00f, 2.3f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 2.99f+0.00f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.10f+0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.21f+0.00f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.32f+0.00f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.43f+0.00f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.54f+0.00f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.65f+0.00f, 2.3f, "f"));
            //digit
            input.Notes.Add(new Data.NoteInfo(false, 2.0f+1.76f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.11f+1.76f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.22f+1.76f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.33f+1.76f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.44f+1.76f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.55f+1.76f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.66f+1.76f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.77f+1.76f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 2.88f+1.76f, 2.3f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 2.99f+1.76f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.10f+1.76f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.21f+1.76f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.32f+1.76f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.43f+1.76f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.54f+1.76f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.65f+1.76f, 2.3f, "f"));
            //digit
            input.Notes.Add(new Data.NoteInfo(false, 2.0f+3.52f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.11f+3.52f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.22f+3.52f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.33f+3.52f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.44f+3.52f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.55f+3.52f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.66f+3.52f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.77f+3.52f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 2.88f+3.52f, 2.3f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 2.99f+3.52f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.10f+3.52f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.21f+3.52f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.32f+3.52f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.43f+3.52f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.54f+3.52f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.65f+3.52f, 2.3f, "f"));
            //digit
            input.Notes.Add(new Data.NoteInfo(false, 2.0f+5.29f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.11f+5.29f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.22f+5.29f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.33f+5.29f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.44f+5.29f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.55f+5.29f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.66f+5.29f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.77f+5.29f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 2.88f+5.29f, 2.3f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 2.99f+5.29f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.10f+5.29f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.21f+5.29f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.32f+5.29f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.43f+5.29f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.54f+5.29f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.65f+5.29f, 2.3f, "f"));
            //digit
            input.Notes.Add(new Data.NoteInfo(false, 2.0f+7.05f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.11f+7.05f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.22f+7.05f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.33f+7.05f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.44f+7.05f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.55f+7.05f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.66f+7.05f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.77f+7.05f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 2.88f+7.05f, 2.3f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 2.99f+7.05f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.10f+7.05f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.21f+7.05f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.32f+7.05f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.43f+7.05f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.54f+7.05f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.65f+7.05f, 2.3f, "f"));
            //digit
            input.Notes.Add(new Data.NoteInfo(false, 2.0f+8.82f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.11f+8.82f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.22f+8.82f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.33f+8.82f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.44f+8.82f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.55f+8.82f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.66f+8.82f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.77f+8.82f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 2.88f+8.82f, 2.3f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 2.99f+8.82f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.10f+8.82f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.21f+8.82f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.32f+8.82f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.43f+8.82f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.54f+8.82f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.65f+8.82f, 2.3f, "f"));
            //digit
            input.Notes.Add(new Data.NoteInfo(false, 2.0f+10.58f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.11f+10.58f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.22f+10.58f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.33f+10.58f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.44f+10.58f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.55f+10.58f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.66f+10.58f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.77f+10.58f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 2.88f+10.58f, 2.3f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 2.99f+10.58f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.10f+10.58f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.21f+10.58f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.32f+10.58f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.43f+10.58f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.54f+10.58f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.65f+10.58f, 2.3f, "f"));
            //digit
            input.Notes.Add(new Data.NoteInfo(false, 2.0f+12.35f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.11f+12.35f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.22f+12.35f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.33f+12.35f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.44f+12.35f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.55f+12.35f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.66f+12.35f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.77f+12.35f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 2.88f+12.35f, 2.3f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 2.99f+12.35f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.10f+12.35f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.21f+12.35f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.32f+12.35f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.43f+12.35f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.54f+12.35f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.65f+12.35f, 2.3f, "f"));
            
            input.Notes.Add(new Data.NoteInfo(false, 8.17f, 2.3f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 8.61f, 2.3f, "p"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 9.05f+0.0f, 2.3f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 9.49f+0.0f, 2.3f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 9.94f+0.0f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 10.38f+0.0f, 2.3f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 9.05f+1.77f, 2.3f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 9.49f+1.77f, 2.3f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 9.94f+1.77f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 10.38f+1.77f, 2.3f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 9.05f+3.53f, 2.3f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 9.49f+3.53f, 2.3f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 9.94f+3.53f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 10.38f+3.53f, 2.3f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 9.05f+5.3f, 2.3f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 9.49f+5.3f, 2.3f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 9.94f+5.3f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 10.38f+5.3f, 2.3f, "space"));
            
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 16.55f+0.0f, 2.3f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 17.44f+0.0f, 2.3f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 18.32f+0.0f, 2.3f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 19.2f+0.0f, 2.3f, "a"));
              //4/2
            input.Notes.Add(new Data.NoteInfo(false, 16.55f+3.53f, 2.3f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 17.44f+3.53f, 2.3f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 18.32f+3.53f, 2.3f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 19.2f+3.53f, 2.3f, ";"));
              //4/2
            input.Notes.Add(new Data.NoteInfo(false, 16.55f+7.06f, 2.3f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 17.44f+7.06f, 2.3f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 18.32f+7.06f, 2.3f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 19.2f+7.06f, 2.3f, "q"));
              //4/2
            input.Notes.Add(new Data.NoteInfo(false, 16.55f+10.59f, 2.3f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 17.44f+10.59f, 2.3f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 18.32f+10.59f, 2.3f, "p"));

            input.Notes.Add(new Data.NoteInfo(false, 22.29f, 2.3f, "p"));

            input.Notes.Add(new Data.NoteInfo(false, 29.36f, 2.3f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 27.46f, 2.3f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 29.79f, 2.3f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 29.90f, 2.0f, ";"));
            //middle cyiin
            input.Notes.Add(new Data.NoteInfo(true, 16.11f + 0.0f, 17.22f + 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 17.22f + 0.0f, 17.66f + 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 17.66f + 0.0f, 18.76f + 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 18.76f + 0.0f, 19.64f + 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 19.64f + 0.0f, 20.74f + 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 20.74f + 0.0f, 21.19f + 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 21.19f + 0.0f, 22.29f + 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 22.29f + 0.0f, 23.17f + 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 23.17f + 0.0f, 24.27f + 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 24.27f + 0.0f, 24.72f + 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 24.72f + 0.0f, 25.82f + 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 25.82f + 0.0f, 26.26f + 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 26.26f + 0.0f, 26.70f + 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 26.70f + 0.0f, 27.80f + 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 27.80f + 0.0f, 28.47f + 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 28.47f + 0.0f, 29.35f + 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 29.35f + 0.0f, 30.23f + 0.0f, "k"));
            //digit
            input.Notes.Add(new Data.NoteInfo(false, 2.0f+28.230f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.11f+28.230f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.22f+28.230f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.33f+28.230f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.44f+28.230f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.55f+28.230f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.66f+28.230f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.77f+28.230f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 2.88f+28.230f, 2.3f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 2.99f+28.230f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.10f+28.230f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.21f+28.230f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.32f+28.230f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.43f+28.230f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.54f+28.230f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.65f+28.230f, 2.3f, "f"));
            //digit
            input.Notes.Add(new Data.NoteInfo(false, 2.0f+29.990f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.11f+29.990f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.22f+29.990f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.33f+29.990f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.44f+29.990f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.55f+29.990f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.66f+29.990f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.77f+29.990f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 2.88f+29.990f, 2.3f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 2.99f+29.990f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.10f+29.990f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.21f+29.990f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.32f+29.990f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.43f+29.990f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.54f+29.990f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.65f+29.990f, 2.3f, "f"));
            //digit
            input.Notes.Add(new Data.NoteInfo(false, 2.0f+31.76f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.11f+31.76f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.22f+31.76f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.33f+31.76f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.44f+31.76f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.55f+31.76f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.66f+31.76f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.77f+31.76f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 2.88f+31.76f, 2.3f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 2.99f+31.76f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.10f+31.76f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.21f+31.76f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.32f+31.76f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.43f+31.76f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.54f+31.76f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.65f+31.76f, 2.3f, "f"));
            //digit
            input.Notes.Add(new Data.NoteInfo(false, 2.0f+33.52f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.11f+33.52f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.22f+33.52f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.33f+33.52f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.44f+33.52f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.55f+33.52f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.66f+33.52f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.77f+33.52f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 2.88f+33.52f, 2.3f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 2.99f+33.52f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.10f+33.52f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.21f+33.52f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.32f+33.52f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.43f+33.52f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.54f+33.52f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.65f+33.52f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 31.99f + 0.0f, 37.18f + 0.0f, ";"));
            //middle monster
            input.Notes.Add(new Data.NoteInfo(true, 37.29f + 0.0f, 38.17f + 0.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 38.17f, 2.3f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 38.61f, 2.3f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 39.05f, 2.3f, ";"));
            input.Notes.Add(new Data.NoteInfo(true, 39.05f + 0.0f, 39.49f + 0.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 39.49f, 2.3f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 39.94f, 2.3f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 40.38f, 2.3f, "p"));
            input.Notes.Add(new Data.NoteInfo(true, 40.82f + 0.0f, 41.26f + 0.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 41.7f, 2.3f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 41.81f, 2.3f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 41.92f, 2.3f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 42.03f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 42.14f, 2.3f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 42.58f, 2.3f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 42.69f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 42.8f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 42.91f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 43.02f, 2.3f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 43.02f + 0.0f, 43.47f + 0.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 43.47f, 2.3f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 43.58f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 43.69f, 2.3f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 43.8f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 43.91f, 2.3f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 44.02f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 44.13f, 2.3f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 44.24f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 44.35f + 0.0f, 45.67f + 0.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 45.67f, 2.3f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 45.78f, 2.3f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 45.89f, 2.3f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 46.0f, 2.3f, "a"));
            input.Notes.Add(new Data.NoteInfo(true, 46.11f + 0.0f, 46.55f + 0.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 46.77f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 46.88f, 2.3f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 46.99f, 2.3f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 47.11f, 2.3f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 47.22f, 2.3f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 47.33f, 2.3f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 47.44f, 2.3f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 47.55f, 2.3f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 47.66f, 2.3f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 47.77f, 2.3f, "q"));
            input.Notes.Add(new Data.NoteInfo(true, 47.88f + 0.0f, 48.76f + 0.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(true, 48.76f + 0.0f, 49.64f + 0.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 49.64f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 49.75f, 2.3f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 49.86f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 49.97f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 50.08f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 50.19f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 50.30f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 50.41f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 50.52f + 0.0f, 50.97f + 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 51.41f + 0.0f, 52.29f + 0.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(true, 52.29f + 0.0f, 53.17f + 0.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(true, 53.17f + 0.0f, 54.05f + 0.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 54.27f, 2.3f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 54.72f, 2.3f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 54.94f + 0.0f, 55.82f + 0.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(true, 55.82f + 0.0f, 56.04f + 0.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 56.15f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 56.26f, 2.3f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 56.37f, 2.3f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 56.7f, 2.3f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 56.81f, 2.3f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 56.92f, 2.3f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 57.03f, 2.3f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 57.14f, 2.3f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 57.25f, 2.3f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 57.58f, 2.3f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 57.69f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 57.80f, 2.3f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 57.91f, 2.3f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 58.02f, 2.3f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 58.13f, 2.3f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 58.24f, 2.3f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 58.36f, 2.3f, "a"));
            input.Notes.Add(new Data.NoteInfo(true, 58.47f + 0.0f, 59.79f + 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 59.79f, 2.3f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 59.90f, 2.3f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 60.01f, 2.3f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 60.12f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(true, 60.23f + 0.0f, 60.67f + 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 60.89f, 2.3f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 61.0f, 2.3f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 61.11f, 2.3f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 61.22f, 2.3f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 61.33f, 2.3f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 61.44f, 2.3f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 61.55f, 2.3f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 61.66f, 2.3f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 61.77f, 2.3f, "p"));
            input.Notes.Add(new Data.NoteInfo(true, 61.99f + 0.0f, 62.88f + 0.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(true, 62.88f + 0.0f, 63.76f + 0.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 63.98f, 2.3f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 64.64f, 2.3f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 65.08f, 2.3f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 65.30f, 2.3f, "space"));
            //digit
            input.Notes.Add(new Data.NoteInfo(false, 2.0f + 63.52f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.11f + 63.52f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.22f + 63.52f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.33f + 63.52f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.44f + 63.52f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.55f + 63.52f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.66f + 63.52f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.77f + 63.52f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 2.88f + 63.52f, 2.3f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 2.99f + 63.52f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.10f + 63.52f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.21f + 63.52f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.32f + 63.52f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.43f + 63.52f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.54f + 63.52f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.65f + 63.52f, 2.3f, "f"));
            //digit
            input.Notes.Add(new Data.NoteInfo(false, 2.0f + 65.29f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.11f + 65.29f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.22f + 65.29f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.33f + 65.29f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.44f + 65.29f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.55f + 65.29f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.66f + 65.29f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.77f + 65.29f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 2.88f + 65.29f, 2.3f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 2.99f + 65.29f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.10f + 65.29f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.21f + 65.29f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.32f + 65.29f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.43f + 65.29f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.54f + 65.29f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.65f + 65.29f, 2.3f, "f"));
            //digit
            input.Notes.Add(new Data.NoteInfo(false, 2.0f + 67.05f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.11f + 67.05f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.22f + 67.05f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.33f + 67.05f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.44f + 67.05f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.55f + 67.05f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.66f + 67.05f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.77f + 67.05f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 2.88f + 67.05f, 2.3f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 2.99f + 67.05f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.10f + 67.05f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.21f + 67.05f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.32f + 67.05f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.43f + 67.05f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.54f + 67.05f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.65f + 67.05f, 2.3f, "f"));
            //digit
            input.Notes.Add(new Data.NoteInfo(false, 2.0f + 68.82f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.11f + 68.82f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.22f + 68.82f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.33f + 68.82f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.44f + 68.82f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.55f + 68.82f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.66f + 68.82f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.77f + 68.82f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 2.88f + 68.82f, 2.3f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 2.99f + 68.82f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.10f + 68.82f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.21f + 68.82f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.32f + 68.82f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.43f + 68.82f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.54f + 68.82f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.65f + 68.82f, 2.3f, "f"));
            //digit
            input.Notes.Add(new Data.NoteInfo(false, 2.0f + 70.58f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.11f + 70.58f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.22f + 70.58f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.33f + 70.58f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.44f + 70.58f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.55f + 70.58f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.66f + 70.58f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.77f + 70.58f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 2.88f + 70.58f, 2.3f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 2.99f + 70.58f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.10f + 70.58f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.21f + 70.58f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.32f + 70.58f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.43f + 70.58f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.54f + 70.58f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.65f + 70.58f, 2.3f, "f"));
            //digit
            input.Notes.Add(new Data.NoteInfo(false, 2.0f + 72.35f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.11f + 72.35f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.22f + 72.35f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.33f + 72.35f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.44f + 72.35f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.55f + 72.35f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.66f + 72.35f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.77f + 72.35f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 2.88f + 72.35f, 2.3f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 2.99f + 72.35f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.10f + 72.35f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.21f + 72.35f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.32f + 72.35f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.43f + 72.35f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.54f + 72.35f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.65f + 72.35f, 2.3f, "f"));
            
            input.Notes.Add(new Data.NoteInfo(false, 76.11f, 2.3f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 76.33f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 76.55f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 76.77f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 76.99f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 77.11f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 77.33f, 2.3f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 77.44f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 77.66f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 77.77f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 78.10f, 2.3f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 78.32f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 78.76f, 2.3f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 78.98f, 2.3f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 79.2f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 79.42f, 2.0f, "d"));

            //digit
            input.Notes.Add(new Data.NoteInfo(false, 2.0f+77.64f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.11f+77.64f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.22f+77.64f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.33f+77.64f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.44f+77.64f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.55f+77.64f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.66f+77.64f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.77f+77.64f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 2.88f+77.64f, 2.3f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 2.99f+77.64f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.10f+77.64f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.21f+77.64f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.32f+77.64f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.43f+77.64f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.54f+77.64f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.65f+77.64f, 2.3f, "f"));
            //digit
            input.Notes.Add(new Data.NoteInfo(false, 2.0f+79.41f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.11f+79.41f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.22f+79.41f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.33f+79.41f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.44f+79.41f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.55f+79.41f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.66f+79.41f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.77f+79.41f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 2.88f+79.41f, 2.3f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 2.99f+79.41f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.10f+79.41f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.21f+79.41f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.32f+79.41f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.43f+79.41f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.54f+79.41f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.65f+79.41f, 2.3f, "f"));
            //digit
            input.Notes.Add(new Data.NoteInfo(false, 2.0f+81.17f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.11f+81.17f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.22f+81.17f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.33f+81.17f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.44f+81.17f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.55f+81.17f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.66f+81.17f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.77f+81.17f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 2.88f+81.17f, 2.3f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 2.99f+81.17f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.10f+81.17f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.21f+81.17f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.32f+81.17f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.43f+81.17f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.54f+81.17f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.65f+81.17f, 2.3f, "f"));
            //digit
            input.Notes.Add(new Data.NoteInfo(false, 2.0f+82.94f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.11f+82.94f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.22f+82.94f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.33f+82.94f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.44f+82.94f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.55f+82.94f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.66f+82.94f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.77f+82.94f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 2.88f+82.94f, 2.3f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 2.99f+82.94f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.10f+82.94f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.21f+82.94f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.32f+82.94f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.43f+82.94f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.54f+82.94f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.65f+82.94f, 2.3f, "f"));
            //digit
            input.Notes.Add(new Data.NoteInfo(false, 2.0f+84.7f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.11f+84.7f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.22f+84.7f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.33f+84.7f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.44f+84.7f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.55f+84.7f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.66f+84.7f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.77f+84.7f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 2.88f+84.7f, 2.3f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 2.99f+84.7f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.10f+84.7f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.21f+84.7f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.32f+84.7f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.43f+84.7f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.54f+84.7f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.65f+84.7f, 2.3f, "f"));
            //digit
            input.Notes.Add(new Data.NoteInfo(false, 2.0f+86.47f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.11f+86.47f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.22f+86.47f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.33f+86.47f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.44f+86.47f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.55f+86.47f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.66f+86.47f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.77f+86.47f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 2.88f+86.47f, 2.3f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 2.99f+86.47f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.10f+86.47f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.21f+86.47f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.32f+86.47f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.43f+86.47f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.54f+86.47f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.65f+86.47f, 2.3f, "f"));
            //digit
            input.Notes.Add(new Data.NoteInfo(false, 2.0f+88.23f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.11f+88.23f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.22f+88.23f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.33f+88.23f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.44f+88.23f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.55f+88.23f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.66f+88.23f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.77f+88.23f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 2.88f+88.23f, 2.3f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 2.99f+88.23f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.10f+88.23f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.21f+88.23f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.32f+88.23f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.43f+88.23f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.54f+88.23f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.65f+88.23f, 2.3f, "f"));
            //digit
            input.Notes.Add(new Data.NoteInfo(false, 2.0f+89.99f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.11f+89.99f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.22f+89.99f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.33f+89.99f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.44f+89.99f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.55f+89.99f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.66f+89.99f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.77f+89.99f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 2.88f+89.99f, 2.3f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 2.99f+89.99f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.10f+89.99f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.21f+89.99f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.32f+89.99f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.43f+89.99f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.54f+89.99f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.65f+89.99f, 2.3f, "f"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 16.55f+63.53f, 2.3f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 17.44f+63.53f, 2.3f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 18.32f+63.53f, 2.3f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 19.2f+63.53f, 2.3f, "space"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 16.55f+67.06f, 2.3f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 17.44f+67.06f, 2.3f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 18.32f+67.06f, 2.3f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 19.2f+67.06f, 2.3f, "space"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 16.55f+70.59f, 2.3f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 17.44f+70.59f, 2.3f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 18.32f+70.59f, 2.3f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 19.2f+70.59f, 2.3f, "space"));

            input.Notes.Add(new Data.NoteInfo(false, 90.45f, 2.3f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 90.67f, 2.3f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 91.11f, 2.3f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 91.55f, 2.3f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 92.22f, 2.3f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 92.44f, 2.3f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 92.88f, 2.3f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 93.32f, 2.3f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 93.54f, 2.3f, "space"));
            //digit
            input.Notes.Add(new Data.NoteInfo(false, 2.0f + 91.76f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.11f + 91.76f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.22f + 91.76f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.33f + 91.76f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.44f + 91.76f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.55f + 91.76f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.66f + 91.76f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.77f + 91.76f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 2.88f + 91.76f, 2.3f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 2.99f + 91.76f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.10f + 91.76f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.21f + 91.76f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.32f + 91.76f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.43f + 91.76f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.54f + 91.76f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.65f + 91.76f, 2.3f, "f"));
            //digit
            input.Notes.Add(new Data.NoteInfo(false, 2.0f + 93.52f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.11f + 93.52f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.22f + 93.52f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.33f + 93.52f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.44f + 93.52f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.55f + 93.52f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.66f + 93.52f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.77f + 93.52f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 2.88f + 93.52f, 2.3f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 2.99f + 93.52f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.10f + 93.52f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.21f + 93.52f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.32f + 93.52f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.43f + 93.52f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.54f + 93.52f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.65f + 93.52f, 2.3f, "f"));
            //digit
            input.Notes.Add(new Data.NoteInfo(false, 2.0f + 95.29f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.11f + 95.29f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.22f + 95.29f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.33f + 95.29f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.44f + 95.29f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.55f + 95.29f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.66f + 95.29f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.77f + 95.29f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 2.88f + 95.29f, 2.3f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 2.99f + 95.29f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.10f + 95.29f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.21f + 95.29f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.32f + 95.29f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.43f + 95.29f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.54f + 95.29f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.65f + 95.29f, 2.3f, "f"));
            //digit
            input.Notes.Add(new Data.NoteInfo(false, 2.0f + 97.05f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.11f + 97.05f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.22f + 97.05f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.33f + 97.05f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.44f + 97.05f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.55f + 97.05f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.66f + 97.05f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.77f + 97.05f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 2.88f + 97.05f, 2.3f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 2.99f + 97.05f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.10f + 97.05f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.21f + 97.05f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.32f + 97.05f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.43f + 97.05f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.54f + 97.05f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.65f + 97.05f, 2.3f, "f"));
            //digit
            input.Notes.Add(new Data.NoteInfo(false, 2.0f + 98.82f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.11f + 98.82f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.22f + 98.82f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.33f + 98.82f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.44f + 98.82f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.55f + 98.82f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.66f + 98.82f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.77f + 98.82f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 2.88f + 98.82f, 2.3f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 2.99f + 98.82f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.10f + 98.82f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.21f + 98.82f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.32f + 98.82f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.43f + 98.82f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.54f + 98.82f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.65f + 98.82f, 2.3f, "f"));
            //digit
            input.Notes.Add(new Data.NoteInfo(false, 2.0f + 100.58f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.11f + 100.58f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.22f + 100.58f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.33f + 100.58f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.44f + 100.58f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.55f + 100.58f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.66f + 100.58f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.77f + 100.58f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 2.88f + 100.58f, 2.3f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 2.99f + 100.58f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.10f + 100.58f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.21f + 100.58f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.32f + 100.58f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.43f + 100.58f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.54f + 100.58f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.65f + 100.58f, 2.3f, "f"));
            //digit
            input.Notes.Add(new Data.NoteInfo(false, 2.0f + 102.35f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.11f + 102.35f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.22f + 102.35f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.33f + 102.35f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.44f + 102.35f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.55f + 102.35f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.66f + 102.35f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.77f + 102.35f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 2.88f + 102.35f, 2.3f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 2.99f + 102.35f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.10f + 102.35f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.21f + 102.35f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.32f + 102.35f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.43f + 102.35f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.54f + 102.35f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.65f + 102.35f, 2.3f, "f"));
            //digit
            input.Notes.Add(new Data.NoteInfo(false, 2.0f + 104.11f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.11f + 104.11f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.22f + 104.11f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.33f + 104.11f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.44f + 104.11f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.55f + 104.11f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.66f + 104.11f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.77f + 104.11f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 2.88f + 104.11f, 2.3f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 2.99f + 104.11f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.10f + 104.11f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.21f + 104.11f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.32f + 104.11f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.43f + 104.11f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.54f + 104.11f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.65f + 104.11f, 2.3f, "f"));
            
             //8/1
            input.Notes.Add(new Data.NoteInfo(false, 9.05f+85.15f, 2.3f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 9.49f+85.15f, 2.3f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 9.94f+85.15f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 10.38f+85.15f, 2.3f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 10.82f+85.15f, 2.3f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 11.26f+85.15f, 2.3f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 11.71f+85.15f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 12.15f+85.15f, 2.3f, "p"));
             //8/1
            input.Notes.Add(new Data.NoteInfo(false, 9.05f+88.68f, 2.3f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 9.49f+88.68f, 2.3f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 9.94f+88.68f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 10.38f+88.68f, 2.3f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 10.82f+88.68f, 2.3f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 11.26f+88.68f, 2.3f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 11.71f+88.68f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 12.15f+88.68f, 2.3f, "p"));
             //8/1
            input.Notes.Add(new Data.NoteInfo(false, 9.05f+92.21f, 2.3f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 9.49f+92.21f, 2.3f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 9.94f+92.21f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 10.38f+92.21f, 2.3f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 10.82f+92.21f, 2.3f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 11.26f+92.21f, 2.3f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 11.71f+92.21f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 12.15f+92.21f, 2.3f, "p"));
             //8/1
            input.Notes.Add(new Data.NoteInfo(false, 9.05f+95.74f, 2.3f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 9.49f+95.74f, 2.3f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 9.94f+95.74f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 10.38f+95.74f, 2.3f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 10.82f+95.74f, 2.3f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 11.26f+95.74f, 2.3f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 11.71f+95.74f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 12.15f+95.74f, 2.3f, "p"));
             //middle monster
            input.Notes.Add(new Data.NoteInfo(true, 37.29f + 70.59f, 38.17f + 70.59f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 38.17f+70.59f, 2.3f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 38.61f+70.59f, 2.3f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 39.05f+70.59f, 2.3f, ";"));
            input.Notes.Add(new Data.NoteInfo(true, 39.05f + 70.59f, 39.49f + 70.59f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 39.49f+70.59f, 2.3f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 39.94f+70.59f, 2.3f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 40.38f+70.59f, 2.3f, "p"));
            input.Notes.Add(new Data.NoteInfo(true, 40.82f + 70.59f, 41.26f + 70.59f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 41.7f+70.59f, 2.3f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 41.81f+70.59f, 2.3f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 41.92f+70.59f, 2.3f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 42.03f+70.59f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 42.14f+70.59f, 2.3f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 42.58f+70.59f, 2.3f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 42.69f+70.59f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 42.8f+70.59f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 42.91f+70.59f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 43.02f+70.59f, 2.3f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 43.02f + 70.59f, 43.47f + 70.59f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 43.47f+70.59f, 2.3f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 43.58f+70.59f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 43.69f+70.59f, 2.3f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 43.8f+70.59f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 43.91f+70.59f, 2.3f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 44.02f+70.59f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 44.13f+70.59f, 2.3f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 44.24f+70.59f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 44.35f + 70.59f, 45.67f + 70.59f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 45.67f+70.59f, 2.3f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 45.78f+70.59f, 2.3f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 45.89f+70.59f, 2.3f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 46.0f+70.59f, 2.3f, "a"));
            input.Notes.Add(new Data.NoteInfo(true, 46.11f + 70.59f, 46.55f + 70.59f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 46.77f+70.59f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 46.88f+70.59f, 2.3f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 46.99f+70.59f, 2.3f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 47.11f+70.59f, 2.3f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 47.22f+70.59f, 2.3f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 47.33f+70.59f, 2.3f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 47.44f+70.59f, 2.3f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 47.55f+70.59f, 2.3f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 47.66f+70.59f, 2.3f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 47.77f+70.59f, 2.3f, "q"));
            input.Notes.Add(new Data.NoteInfo(true, 47.88f + 70.59f, 48.76f + 70.59f, "p"));
            input.Notes.Add(new Data.NoteInfo(true, 48.76f + 70.59f, 49.64f + 70.59f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 49.64f+70.59f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 49.75f+70.59f, 2.3f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 49.86f+70.59f, 2.3f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 49.97f+70.59f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 50.08f+70.59f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 50.19f+70.59f, 2.3f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 50.30f+70.59f, 2.3f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 50.41f+70.59f, 2.3f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 121.11f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 121.22f, 2.3f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 121.33f, 2.3f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 121.44f, 2.3f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 121.55f, 2.3f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 121.66f, 2.3f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 121.77f, 2.3f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 121.88f, 2.3f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 121.99f, 2.3f, "space"));
            
        }
        else if (input.Difficulty.Equals("Extreme"))
        {
            input.Notes.Add(new Data.NoteInfo(false, 2.0f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.1f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.2f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.3f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.4f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 2.5f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 2.6f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 2.7f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 2.8f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 2.9f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 3.0f, 2.0f, "space"));
        }
    }
   
}
