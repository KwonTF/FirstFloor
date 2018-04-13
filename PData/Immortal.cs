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
        hard.level = 2;
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
            input.Notes.Add(new Data.NoteInfo(false, 2.0f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.1f, 2.3f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.2f, 2.3f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.3f, 2.3f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.4f, 2.3f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.5f, 2.3f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.6f, 2.3f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.7f, 2.3f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.8f, 2.3f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.9f, 2.3f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 3.0f, 2.3f, "s"));
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
