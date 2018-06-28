using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class Houseplan : MonoBehaviour
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
        MusicInfo.key = 13;
        MusicInfo.name = "Houseplan";
        MusicInfo.composer = "Houseplan";
        MusicInfo.visualizer = "Houseplan";
        MusicInfo.music = clip;
        MusicInfo.bga_blur = bga_blur;
        MusicInfo.bga = bga;
        MusicInfo.list = new List<Data.Playdata>();
        ListInit();

        return MusicInfo;
    }
    void ListInit()
    {
        Data.Playdata normal = new Data.Playdata();
        normal.Difficulty = "Normal";
        normal.catchParase = normal_img;
        normal.level = 6;
        MusicInfo.list.Add(normal);

        Data.Playdata hard = new Data.Playdata();
        hard.Difficulty = "Hard";
        hard.level = 12;
        hard.catchParase = hard_img;
        MusicInfo.list.Add(hard);

        Data.Playdata extreme = new Data.Playdata();
        extreme.Difficulty = "Extreme";
        extreme.level = 3;
        extreme.catchParase = extreme_img;
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
            input.Notes.Add(new Data.NoteInfo(true, 0.0f, 0.9f, "f"));
            //first piano
            input.Notes.Add(new Data.NoteInfo(true, 0.9f + 0.00f, 1.13f + 0.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 1.25f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.48f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.72f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 1.95f + 0.00f, 2.30f + 0.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.42f + 0.00f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(true, 2.77f + 0.00f, 3.00f + 0.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.12f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.36f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.59f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 3.82f + 0.00f, 4.18f + 0.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 4.29f + 0.00f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(true, 4.65f + 0.00f, 4.88f + 0.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 5.00f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 5.23f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 5.47f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 5.70f + 0.00f, 6.05f + 0.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 6.17f + 0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 6.29f + 0.00f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(true, 6.52f + 0.00f, 6.75f + 0.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 6.87f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 7.11f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 7.34f + 0.00f, 2.0f, "f"));
            //
            input.Notes.Add(new Data.NoteInfo(true, 7.46f + 0.00f, 7.81f + 0.00f, "q"));
            input.Notes.Add(new Data.NoteInfo(true, 7.93f + 0.00f, 8.28f + 0.00f, "space"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 7.93f + 0.00f, 0.9f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 8.04f + 0.00f, 0.9f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 8.16f + 0.00f, 0.9f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 8.28f + 0.00f, 0.9f, "q"));
            //2nd piano
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.40f + 0.00f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 8.63f + 0.00f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 8.86f + 0.00f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 9.10f + 0.00f, 0.9f, "l"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.40f + 1.17f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.63f + 1.17f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.86f + 1.17f, 0.9f, "d"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.40f + 1.87f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 8.63f + 1.87f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 8.86f + 1.87f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 9.10f + 1.87f, 0.9f, "l"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.40f + 3.04f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 8.63f + 3.04f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 8.86f + 3.04f, 0.9f, "f"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.40f + 3.75f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.63f + 3.75f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 8.86f + 3.75f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 9.10f + 3.75f, 0.9f, "k"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.40f + 4.68f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 8.63f + 4.68f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 8.86f + 4.68f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 9.10f + 4.68f, 0.9f, "f"));

            input.Notes.Add(new Data.NoteInfo(true, 11.21f, 12.15f, ";"));
            input.Notes.Add(new Data.NoteInfo(true, 13.08f, 14.02f, "q"));

            input.Notes.Add(new Data.NoteInfo(false, 14.02f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 14.37f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 14.72f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 14.96f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 14.96f, 15.43f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 15.43f, 15.90f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 15.90f, 16.36f, "space"));

            input.Notes.Add(new Data.NoteInfo(false, 16.36f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 16.36f, 0.9f, "k"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f+0.00f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 0.00f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 0.00f, 0.9f, "s"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 0.47f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 0.47f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 0.47f, 0.9f, "space"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 0.94f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 0.94f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 0.94f, 0.9f, "l"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 1.40f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 1.40f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 1.40f, 0.9f, "space"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 1.87f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 1.87f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 1.87f, 0.9f, "f"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 2.34f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 2.34f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 2.34f, 0.9f, "space"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 2.81f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 2.81f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 2.81f, 0.9f, "j"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 3.28f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 3.28f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 3.28f, 0.9f, "d"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 3.75f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 3.75f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 3.75f, 0.9f, "f"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 4.22f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 4.22f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 4.22f, 0.9f, "k"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 4.69f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 4.69f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 4.69f, 0.9f, "s"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 5.15f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 5.15f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 5.15f, 0.9f, "space"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 5.62f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 5.62f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 5.62f, 0.9f, "l"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 6.09f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 6.09f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 6.09f, 0.9f, "space"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 6.56f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 6.56f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 6.56f, 0.9f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 23.86f+0.00f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 24.33f+0.00f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 24.80f+0.00f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 25.27f+0.00f, 0.9f, "s"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 23.86f + 1.88f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 24.33f + 1.88f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 24.80f + 1.88f, 0.9f, "k"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 23.86f + 0.00f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 24.33f + 0.00f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 24.80f + 0.00f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 25.27f + 0.00f, 0.9f, "f"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 23.86f + 1.88f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 24.33f + 1.88f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 24.80f + 1.88f, 0.9f, "s"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.40f + 18.75f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.63f + 18.75f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 8.86f + 18.75f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 9.10f + 18.75f, 0.9f, "j"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 11.48f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 11.48f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 11.48f, 0.9f, "l"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 11.83f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 11.83f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 11.83f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 28.79f, 0.9f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 29.02f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 29.37f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 29.61f, 0.9f, "l"));

            input.Notes.Add(new Data.NoteInfo(true, 29.96f, 30.31f, "a"));
            input.Notes.Add(new Data.NoteInfo(true, 30.43f, 30.78f, "p"));

            input.Notes.Add(new Data.NoteInfo(false, 30.90f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 31.01f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 31.36f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 31.60f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 31.83f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 32.18f, 32.65f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 32.77f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 33.00f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 33.36f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 33.59f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 33.82f, 34.29f, "s"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 17.81f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 17.81f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 17.81f, 0.9f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 34.88f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 35.11f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 35.23f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 35.47f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 35.70f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 35.93f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 36.17f, 36.52f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 36.64f, 37.34f, "f"));

            input.Notes.Add(new Data.NoteInfo(true, 37.46f, 37.81f, "q"));
            input.Notes.Add(new Data.NoteInfo(true, 37.93f, 38.28f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 38.40f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 38.51f, 0.9f, "f"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.40f + 30.35f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 8.63f + 30.35f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 8.86f + 30.35f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 9.10f + 30.35f, 0.9f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 39.68f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 39.80f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 40.04f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 40.27f, 40.97f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 41.06f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 41.32f, 0.9f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 41.91f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 42.15f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 42.26f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 42.50f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 42.61f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 42.85f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 43.20f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 43.43f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 43.67f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 43.90f, 0.9f, "s"));

            input.Notes.Add(new Data.NoteInfo(true, 44.02f, 45.78f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 44.49f, 0.9f, "k"));

            //middle cyndi
            input.Notes.Add(new Data.NoteInfo(true, 45.90f+0.00f, 46.13f+0.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 46.36f+0.00f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 46.60f+0.00f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 46.83f+0.00f, 0.9f, "j"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 30.35f+0.00f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 30.35f+0.00f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 30.35f+0.00f, 0.9f, "s"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 30.7f+0.00f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 30.7f+0.00f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 30.7f+0.00f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 47.65f+0.00f, 0.9f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 48.00f+0.00f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 48.24f+0.00f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 48.47f+0.00f, 0.9f, "d"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 32.11f+0.00f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 32.11f+0.00f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 32.11f+0.00f, 0.9f, "j"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 32.46f+0.00f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 32.46f+0.00f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 32.46f+0.00f, 0.9f, "j"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 32.81f+0.00f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 32.81f+0.00f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 32.81f+0.00f, 0.9f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 49.76f+0.00f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 50.00f+0.00f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 50.23f+0.00f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 50.47f+0.00f, 0.9f, "d"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 34.1f+0.00f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 34.1f+0.00f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 34.1f+0.00f, 0.9f, "d"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 34.45f+0.00f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 34.45f+0.00f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 34.45f+0.00f, 0.9f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 51.52f+0.00f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 51.87f+0.00f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 52.11f+0.00f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 52.34f+0.00f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 52.57f+0.00f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 52.81f+0.00f, 53.28f+0.00f, "f"));

            //middle cyndi
            input.Notes.Add(new Data.NoteInfo(true, 45.90f + 7.50f, 46.13f + 7.50f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 46.36f + 7.50f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 46.60f + 7.50f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 46.83f + 7.50f, 0.9f, "k"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 30.35f + 7.50f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 30.35f + 7.50f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 30.35f + 7.50f, 0.9f, "d"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 30.7f + 7.50f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 30.7f + 7.50f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 30.7f + 7.50f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 47.65f + 7.50f, 0.9f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 48.00f + 7.50f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 48.24f + 7.50f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 48.47f + 7.50f, 0.9f, "l"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 32.11f + 7.50f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 32.11f + 7.50f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 32.11f + 7.50f, 0.9f, "k"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 32.46f + 7.50f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 16.72f + 32.46f + 7.50f, 57.15f, "s"));
            

            input.Notes.Add(new Data.NoteInfo(false, 49.76f + 7.50f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 50.00f + 7.50f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 50.23f + 7.50f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 50.47f + 7.50f, 0.9f, "j"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 34.1f + 7.50f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 34.1f + 7.50f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 34.1f + 7.50f, 0.9f, "d"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 34.45f + 7.50f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 34.45f + 7.50f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 34.45f + 7.50f, 0.9f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 59.02f, 0.9f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 59.25f, 0.9f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 59.61f, 0.9f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 59.84f, 0.9f, ";"));
            input.Notes.Add(new Data.NoteInfo(true, 60.43f, 60.90f, "space"));
            //60s piano
            input.Notes.Add(new Data.NoteInfo(false, 60.9f+0.00f, 0.9f, "l"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.40f + 52.85f+0.00f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 8.63f + 52.85f+0.00f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 8.86f + 52.85f+0.00f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 9.10f + 52.85f+0.00f, 0.9f, "j"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.40f + 53.78f+0.00f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 8.63f + 53.78f+0.00f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.86f + 53.78f+0.00f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 9.10f + 53.78f+0.00f, 0.9f, "s"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.40f + 54.72f+0.00f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.63f + 54.72f+0.00f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 8.86f + 54.72f+0.00f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 63.71f+0.00f, 64.65f+0.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 64.65f+0.00f, 65.58f+0.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 65.70f+0.00f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 65.82f+0.00f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 66.05f+0.00f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 66.29f+0.00f, 0.9f, "d"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 49.92f+0.00f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 49.92f+0.00f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 49.92f+0.00f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 66.99f+0.00f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 67.34f+0.00f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 67.81f+0.00f, 0.9f, "f"));

            //60s piano
            input.Notes.Add(new Data.NoteInfo(false, 60.91f + 7.5f, 0.9f, "j"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.40f + 52.85f + 7.5f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 8.63f + 52.85f + 7.5f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.86f + 52.85f + 7.5f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 9.10f + 52.85f + 7.5f, 0.9f, "s"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.40f + 53.78f + 7.5f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.63f + 53.78f + 7.5f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 8.86f + 53.78f + 7.5f, 0.9f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 70.27f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 70.62f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 70.97f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 71.32f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 71.79f, 0.9f, "space"));
            //
            input.Notes.Add(new Data.NoteInfo(false, 70.27f, 0.9f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 70.62f, 0.9f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 70.97f, 0.9f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 71.32f, 0.9f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 71.79f, 0.9f, ";"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 55.55f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 55.55f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 55.55f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 72.61f, 0.9f, "d"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 56.48f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 56.48f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 56.48f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 73.55f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 73.67f, 0.9f, "j"));

            input.Notes.Add(new Data.NoteInfo(true, 74.02f + 0.00f, 74.25f + 0.00f, "q"));
            input.Notes.Add(new Data.NoteInfo(true, 74.49f + 0.00f, 74.72f + 0.00f, "p"));
            input.Notes.Add(new Data.NoteInfo(true, 74.98f + 0.00f, 75.43f + 0.00f, "space"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 7.93f + 67.5f, 0.9f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 8.04f + 67.5f, 0.9f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 8.16f + 67.5f, 0.9f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 8.28f + 67.5f, 0.9f, "a"));

            //middle cyndi
            input.Notes.Add(new Data.NoteInfo(true, 45.90f + 30.00f, 46.13f + 30.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 46.36f + 30.00f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 46.60f + 30.00f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 46.83f + 30.00f, 0.9f, "s"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 30.35f + 30.00f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 30.35f + 30.00f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 30.35f + 30.00f, 0.9f, "f"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 30.7f + 30.00f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 30.7f + 30.00f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 30.7f + 30.00f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 47.65f + 30.00f, 0.9f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 48.00f + 30.00f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 48.24f + 30.00f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 48.47f + 30.00f, 0.9f, "d"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 32.11f + 30.00f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 32.11f + 30.00f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 32.11f + 30.00f, 0.9f, "d"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 32.46f + 30.00f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 32.46f + 30.00f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 32.46f + 30.00f, 0.9f, "k"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 32.81f + 30.00f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 32.81f + 30.00f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 32.81f + 30.00f, 0.9f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 49.76f + 30.00f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 50.00f + 30.00f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 50.23f + 30.00f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 50.47f + 30.00f, 0.9f, "f"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 34.1f + 30.00f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 34.1f + 30.00f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 34.1f + 30.00f, 0.9f, "d"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 34.45f + 30.00f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 34.45f + 30.00f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 34.45f + 30.00f, 0.9f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 51.52f + 30.00f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 51.87f + 30.00f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 52.11f + 30.00f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 52.34f + 30.00f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 52.57f + 30.00f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 52.81f + 30.00f, 53.28f + 30.00f, "d"));

            //middle cyndi
            input.Notes.Add(new Data.NoteInfo(true, 45.90f + 37.5f, 46.13f + 37.5f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 46.36f + 37.5f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 46.60f + 37.5f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 46.83f + 37.5f, 0.9f, "l"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 30.35f + 37.5f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 30.35f + 37.5f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 30.35f + 37.5f, 0.9f, "k"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 30.7f + 37.5f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 30.7f + 37.5f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 30.7f + 37.5f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 47.65f + 37.5f, 0.9f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 48.00f + 37.5f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 48.24f + 37.5f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 48.47f + 37.5f, 0.9f, "j"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 32.11f + 37.5f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 32.11f + 37.5f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 32.11f + 37.5f, 0.9f, "s"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 32.46f + 37.5f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 16.72f + 32.46f + 37.5f, 87.15f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 49.76f + 37.5f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 50.00f + 37.5f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 50.23f + 37.5f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 50.47f + 37.5f, 0.9f, "j"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 34.1f + 37.5f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 34.1f + 37.5f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 34.1f + 37.5f, 0.9f, "s"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 34.45f + 37.5f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 34.45f + 37.5f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 34.45f + 37.5f, 0.9f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 89.14f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 89.25f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 89.37f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 89.49f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 89.72f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 89.96f, 90.43f, "p"));
            input.Notes.Add(new Data.NoteInfo(true, 90.43f, 90.90f, "q"));

            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 23.86f + 67.04f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 24.33f + 67.04f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 24.80f + 67.04f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 25.27f + 67.04f, 0.9f, "f"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 23.86f + 67.04f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 24.33f + 67.04f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 24.80f + 67.04f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 25.27f + 67.04f, 0.9f, "d"));

            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 23.86f + 68.91f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 24.33f + 68.91f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 24.80f + 68.91f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 25.27f + 68.91f, 0.9f, "j"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 23.86f + 68.91f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 24.33f + 68.91f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 24.80f + 68.91f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 25.27f + 68.91f, 0.9f, "k"));

            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 23.86f + 70.79f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 24.33f + 70.79f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 24.80f + 70.79f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 25.27f + 70.79f, 0.9f, "k"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 23.86f + 70.79f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 24.33f + 70.79f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 24.80f + 70.79f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 25.27f + 70.79f, 0.9f, "s"));

            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 23.86f + 72.66f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 24.33f + 72.66f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 24.80f + 72.66f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 25.27f + 72.66f, 0.9f, "s"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 23.86f + 72.66f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 24.33f + 72.66f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 24.80f + 72.66f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 25.27f + 72.66f, 0.9f, "k"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.40f + 90.0f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.63f + 90.0f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.86f + 90.0f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 9.10f + 90.0f, 0.9f, "d"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.40f + 90.93f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 8.63f + 90.93f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 8.86f + 90.93f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 9.10f + 90.93f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 100.15f, 0.9f, "k"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.40f + 91.87f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 8.63f + 91.87f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 8.86f + 91.87f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 9.10f + 91.87f, 0.9f, "j"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.40f + 92.81f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.63f + 92.81f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.86f + 92.81f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 9.10f + 92.81f, 0.9f, "d"));

            //4com
            input.Notes.Add(new Data.NoteInfo(false, 7.93f + 94.22f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 8.04f + 94.22f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 8.16f + 94.22f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 8.28f + 94.22f, 0.9f, "k"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 7.93f + 94.68f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 8.04f + 94.68f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.16f + 94.68f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 8.28f + 94.68f, 0.9f, "d"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 7.93f + 95.15f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 8.04f + 95.15f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 8.16f + 95.15f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 8.28f + 95.15f, 0.9f, "k"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 7.93f + 95.62f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 8.04f + 95.62f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.16f + 95.62f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 8.28f + 95.62f, 0.9f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 104.02f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 104.61f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 104.84f, 0.9f, "space"));
            //
            input.Notes.Add(new Data.NoteInfo(false, 104.02f, 0.9f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 104.61f, 0.9f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 104.84f, 0.9f, "p"));

            input.Notes.Add(new Data.NoteInfo(true, 105.43f, 105.90f, "space"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 7.93f + 97.5f, 0.9f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 8.04f + 97.5f, 0.9f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 8.16f + 97.5f, 0.9f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 8.28f + 97.5f, 0.9f, "a"));

            //first piano
            input.Notes.Add(new Data.NoteInfo(true, 0.9f + 105.0f, 1.13f + 105.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.25f + 105.0f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.48f + 105.0f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.72f + 105.0f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 1.95f + 105.0f, 2.30f + 105.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.42f + 105.0f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(true, 2.77f + 105.0f, 3.00f + 105.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 3.12f + 105.0f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.36f + 105.0f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.59f + 105.0f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 3.82f + 105.0f, 4.18f + 105.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 4.29f + 105.0f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(true, 4.65f + 105.0f, 4.88f + 105.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 5.00f + 105.0f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 5.23f + 105.0f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 5.47f + 105.0f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 5.70f + 105.0f, 6.05f + 105.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 6.17f + 105.0f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 6.29f + 105.0f, 2.0f, "p"));

            input.Notes.Add(new Data.NoteInfo(true, 6.52f + 105.0f, 6.75f + 105.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 6.87f + 105.0f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 7.11f + 105.0f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 7.34f + 105.0f, 2.0f, "k"));
            //
            input.Notes.Add(new Data.NoteInfo(false, 112.58f, 7.81f + 105.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 7.93f + 105.0f, 8.28f + 105.0f, "space"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 7.93f + 105.0f, 0.9f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 8.04f + 105.0f, 0.9f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 8.16f + 105.0f, 0.9f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 8.28f + 105.0f, 0.9f, "p"));

            //2nd piano
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.40f + 0.0f+105f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.63f + 0.0f+105f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 8.86f + 0.0f+105f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 9.10f + 0.0f+105f, 0.9f, "f"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.40f + 1.17f+105f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 8.63f + 1.17f+105f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 8.86f + 1.17f+105f, 0.9f, "j"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.40f + 1.87f+105f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 8.63f + 1.87f+105f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 8.86f + 1.87f+105f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 9.10f + 1.87f+105f, 0.9f, "k"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.40f + 3.04f+105f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.63f + 3.04f+105f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 8.86f + 3.04f+105f, 0.9f, "f"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.40f + 3.75f+105f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 8.63f + 3.75f+105f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.86f + 3.75f+105f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 9.10f + 3.75f+105f, 0.9f, "d"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.40f + 4.68f+105f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 8.63f + 4.68f+105f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 8.86f + 4.68f+105f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 9.10f + 4.68f+105f, 0.9f, "k"));

            input.Notes.Add(new Data.NoteInfo(true, 11.21f+105f, 12.15f+105f, ";"));
            input.Notes.Add(new Data.NoteInfo(true, 13.08f+105f, 14.02f+105f, "a"));

            input.Notes.Add(new Data.NoteInfo(false, 14.02f+105f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 14.37f+105f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 14.72f+105f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 14.96f+105f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 14.96f+105.0f, 15.43f+105.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(true, 15.43f+105.0f, 15.90f+105.0f, "space"));
            //scratch
            input.Notes.Add(new Data.NoteInfo(false, 120.90f + 0.00f, 0.9f, "a"));

            input.Notes.Add(new Data.NoteInfo(false, 121.36f + 0.00f, 0.9f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 121.48f + 0.00f, 0.9f, "a"));

            input.Notes.Add(new Data.NoteInfo(false, 121.83f + 0.00f, 0.9f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 121.95f + 0.00f, 0.9f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 122.07f + 0.00f, 0.9f, "q"));

            input.Notes.Add(new Data.NoteInfo(false, 122.30f + 0.00f, 0.9f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 122.42f + 0.00f, 0.9f, "q"));

            //scratch
            input.Notes.Add(new Data.NoteInfo(false, 120.90f + 1.87f, 0.9f, "p"));

            input.Notes.Add(new Data.NoteInfo(false, 121.36f + 1.87f, 0.9f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 121.48f + 1.87f, 0.9f, "p"));

            input.Notes.Add(new Data.NoteInfo(false, 121.83f + 1.87f, 0.9f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 121.95f + 1.87f, 0.9f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 122.07f + 1.87f, 0.9f, ";"));

            input.Notes.Add(new Data.NoteInfo(false, 122.30f + 1.87f, 0.9f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 122.42f + 1.87f, 0.9f, ";"));

            //scratch
            input.Notes.Add(new Data.NoteInfo(false, 120.90f + 3.75f, 0.9f, "q"));

            input.Notes.Add(new Data.NoteInfo(false, 121.36f + 3.75f, 0.9f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 121.48f + 3.75f, 0.9f, "p"));

            input.Notes.Add(new Data.NoteInfo(false, 121.83f + 3.75f, 0.9f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 121.95f + 3.75f, 0.9f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 122.07f + 3.75f, 0.9f, "q"));

            input.Notes.Add(new Data.NoteInfo(false, 122.30f + 3.75f, 0.9f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 122.42f + 3.75f, 0.9f, "a"));

            input.Notes.Add(new Data.NoteInfo(false, 126.52f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 126.75f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 126.99f, 0.9f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 127.46f, 0.9f, ";"));
            input.Notes.Add(new Data.NoteInfo(true, 127.93f, 130.74f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 130.74f, 0.9f, "space"));
        }
        else if (input.Difficulty.Equals("Hard"))
        {
            input.Notes.Add(new Data.NoteInfo(true, 0.0f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 0.9f, 6.52f, "space"));
            //first piano
            input.Notes.Add(new Data.NoteInfo(true, 0.9f + 0.00f, 1.13f + 0.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 1.25f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.48f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.72f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 1.95f + 0.00f, 2.30f + 0.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.42f + 0.00f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(true, 2.77f + 0.00f, 3.00f + 0.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.12f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.36f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.59f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 3.82f + 0.00f, 4.18f + 0.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 4.29f + 0.00f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(true, 4.65f + 0.00f, 4.88f + 0.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 5.00f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 5.23f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 5.47f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 5.70f + 0.00f, 6.05f + 0.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 6.17f + 0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 6.29f + 0.00f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(true, 6.52f + 0.00f, 6.75f + 0.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 6.87f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 7.11f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 7.34f + 0.00f, 2.0f, "f"));
            //
            input.Notes.Add(new Data.NoteInfo(true, 7.46f + 0.00f, 7.81f + 0.00f, "q"));
            input.Notes.Add(new Data.NoteInfo(true, 7.93f + 0.00f, 8.28f + 0.00f, "space"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 7.93f + 0.00f, 0.9f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 8.04f + 0.00f, 0.9f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 8.16f + 0.00f, 0.9f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 8.28f + 0.00f, 0.9f, "q"));
            //2nd piano
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.40f + 0.00f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 8.63f + 0.00f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 8.86f + 0.00f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 9.10f + 0.00f, 0.9f, "l"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.40f + 1.17f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.63f + 1.17f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.86f + 1.17f, 0.9f, "d"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.40f + 1.87f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 8.63f + 1.87f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 8.86f + 1.87f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 9.10f + 1.87f, 0.9f, "l"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.40f + 3.04f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 8.63f + 3.04f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 8.86f + 3.04f, 0.9f, "f"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.40f + 3.75f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.63f + 3.75f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 8.86f + 3.75f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 9.10f + 3.75f, 0.9f, "k"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.40f + 4.68f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 8.63f + 4.68f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 8.86f + 4.68f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 9.10f + 4.68f, 0.9f, "f"));

            input.Notes.Add(new Data.NoteInfo(true, 11.21f, 11.44f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 11.56f, 12.15f, "a"));
            input.Notes.Add(new Data.NoteInfo(true, 11.68f, 12.15f, "q"));

            input.Notes.Add(new Data.NoteInfo(false, 13.08f, 14.02f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 13.20f, 14.02f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 13.32f, 14.02f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 13.43f, 14.02f, "a"));
            input.Notes.Add(new Data.NoteInfo(true, 13.55f, 14.02f, "p"));

            input.Notes.Add(new Data.NoteInfo(false, 14.02f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 14.37f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 14.72f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 14.96f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 14.96f, 15.43f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 15.43f, 15.90f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 15.54f, 15.90f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 15.66f, 15.90f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 15.78f, 15.90f, ";"));

            input.Notes.Add(new Data.NoteInfo(true, 15.90f, 16.36f, "space"));

            input.Notes.Add(new Data.NoteInfo(false, 16.36f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 16.36f, 0.9f, "k"));

            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 23.86f  -7.03f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 24.33f  -7.03f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 24.80f  -7.03f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 25.27f  -7.03f, 0.9f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 23.86f -5.15f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 24.33f -5.15f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 24.80f -5.15f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 25.27f -5.15f, 0.9f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 23.86f -3.28f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 24.33f -3.28f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 24.80f -3.28f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 25.27f -3.28f, 0.9f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 23.86f -1.4f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 24.33f -1.4f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 24.80f -1.4f, 0.9f, "space"));

            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 17.30f + 0.00f, 0.9f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 18.24f + 0.00f, 0.9f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 19.18f + 0.00f, 0.9f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 20.11f + 0.00f, 0.9f, ";"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 17.30f + 3.75f, 0.9f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 18.24f + 3.75f, 0.9f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 19.18f + 3.75f, 0.9f, "a"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 0.00f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 0.00f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 0.00f, 0.9f, "s"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 0.47f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 0.47f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 0.47f, 0.9f, "f"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 0.94f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 0.94f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 0.94f, 0.9f, "l"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 1.40f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 1.40f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 1.40f, 0.9f, "j"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 1.87f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 1.87f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 1.87f, 0.9f, "f"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 2.34f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 2.34f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 2.34f, 0.9f, "j"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 2.81f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 2.81f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 2.81f, 0.9f, "j"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 3.28f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 3.28f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 3.28f, 0.9f, "d"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 3.75f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 3.75f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 3.75f, 0.9f, "f"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 4.22f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 4.22f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 4.22f, 0.9f, "k"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 4.69f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 4.69f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 4.69f, 0.9f, "s"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 5.15f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 5.15f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 5.15f, 0.9f, "f"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 5.62f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 5.62f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 5.62f, 0.9f, "l"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 6.09f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 6.09f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 6.09f, 0.9f, "j"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 6.56f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 6.56f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 6.56f, 0.9f, "f"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 23.86f + 0.00f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 24.33f + 0.00f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 24.80f + 0.00f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 25.27f + 0.00f, 0.9f, "s"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 23.86f + 1.88f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 24.33f + 1.88f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 24.80f + 1.88f, 0.9f, "k"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 23.86f + 0.00f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 24.33f + 0.00f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 24.80f + 0.00f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 25.27f + 0.00f, 0.9f, "f"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 23.86f + 1.88f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 24.33f + 1.88f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 24.80f + 1.88f, 0.9f, "s"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 17.30f + 6.56f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 18.24f + 6.56f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 19.18f + 6.56f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 20.11f + 6.56f, 0.9f, "space"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 17.30f + 6.56f, 0.9f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 18.24f + 6.56f, 0.9f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 19.18f + 6.56f, 0.9f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 20.11f + 6.56f, 0.9f, "p"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.40f + 18.75f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.63f + 18.75f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 8.86f + 18.75f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 9.10f + 18.75f, 0.9f, "j"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 11.48f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 11.48f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 11.48f, 0.9f, "l"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 11.83f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 11.83f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 11.83f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 28.79f, 0.9f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 29.02f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 29.37f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 29.61f, 0.9f, "l"));

            input.Notes.Add(new Data.NoteInfo(true, 29.96f, 30.31f, "a"));

            input.Notes.Add(new Data.NoteInfo(false, 30.43f, 30.78f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 30.54f, 30.78f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 30.66f, 30.78f, "p"));

            input.Notes.Add(new Data.NoteInfo(false, 30.90f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 31.01f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 31.36f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 31.60f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 31.83f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 32.18f, 32.65f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 32.77f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 33.00f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 33.36f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 33.59f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 33.82f, 34.29f, "s"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 17.81f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 17.81f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 17.81f, 0.9f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 34.88f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 35.11f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 35.23f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 35.47f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 35.70f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 35.93f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 36.17f, 36.52f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 36.64f, 37.34f, "f"));

            input.Notes.Add(new Data.NoteInfo(true, 37.46f, 37.81f, "q"));
            input.Notes.Add(new Data.NoteInfo(true, 37.93f, 38.28f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 38.40f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 38.51f, 0.9f, "f"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.40f + 30.35f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 8.63f + 30.35f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 8.86f + 30.35f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 9.10f + 30.35f, 0.9f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 39.68f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 39.80f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 40.04f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 40.27f, 40.97f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 41.06f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 41.32f, 0.9f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 41.91f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 42.15f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 42.26f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 42.50f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 42.61f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 42.85f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 43.20f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 43.43f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 43.67f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 43.90f, 0.9f, "s"));

            input.Notes.Add(new Data.NoteInfo(true, 44.02f, 45.78f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 44.49f, 0.9f, "k"));

            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 23.86f + 22.04f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 24.33f + 22.04f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 24.80f + 22.04f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 25.27f + 22.04f, 0.9f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 23.86f + 23.91f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 24.33f + 23.91f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 24.80f + 23.91f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 25.27f + 23.91f, 0.9f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 23.86f + 25.79f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 24.33f + 25.79f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 24.80f + 25.79f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 25.27f + 25.79f, 0.9f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 23.86f + 27.66f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 24.33f + 27.66f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 24.80f + 27.66f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 25.27f + 27.66f, 0.9f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 23.86f + 29.54f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 24.33f + 29.54f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 24.80f + 29.54f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 25.27f + 29.54f, 0.9f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 23.86f + 31.41f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 24.33f + 31.41f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 24.80f + 31.41f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 25.27f + 31.41f, 0.9f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 23.86f + 33.29f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 24.33f + 33.29f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 24.80f + 33.29f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 25.27f + 33.29f, 0.9f, "space"));
            //middle cyndi
            input.Notes.Add(new Data.NoteInfo(true, 45.90f + 0.00f, 46.13f + 0.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 46.36f + 0.00f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 46.60f + 0.00f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 46.83f + 0.00f, 0.9f, "j"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 30.35f + 0.00f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 30.35f + 0.00f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 30.35f + 0.00f, 0.9f, "s"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 30.7f + 0.00f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 30.7f + 0.00f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 30.7f + 0.00f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 47.65f + 0.00f, 0.9f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 48.00f + 0.00f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 48.24f + 0.00f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 48.47f + 0.00f, 0.9f, "d"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 32.11f + 0.00f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 32.11f + 0.00f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 32.11f + 0.00f, 0.9f, "j"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 32.46f + 0.00f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 32.46f + 0.00f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 32.46f + 0.00f, 0.9f, "j"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 32.81f + 0.00f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 32.81f + 0.00f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 32.81f + 0.00f, 0.9f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 49.76f + 0.00f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 50.00f + 0.00f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 50.23f + 0.00f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 50.47f + 0.00f, 0.9f, "d"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 34.1f + 0.00f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 34.1f + 0.00f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 34.1f + 0.00f, 0.9f, "d"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 34.45f + 0.00f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 34.45f + 0.00f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 34.45f + 0.00f, 0.9f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 51.52f + 0.00f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 51.87f + 0.00f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 52.11f + 0.00f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 52.34f + 0.00f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 52.57f + 0.00f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 52.81f + 0.00f, 53.28f + 0.00f, "f"));

            //middle cyndi
            input.Notes.Add(new Data.NoteInfo(true, 45.90f + 7.50f, 46.13f + 7.50f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 46.36f + 7.50f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 46.60f + 7.50f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 46.83f + 7.50f, 0.9f, "k"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 30.35f + 7.50f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 30.35f + 7.50f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 30.35f + 7.50f, 0.9f, "d"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 30.7f + 7.50f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 30.7f + 7.50f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 30.7f + 7.50f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 47.65f + 7.50f, 0.9f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 48.00f + 7.50f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 48.24f + 7.50f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 48.47f + 7.50f, 0.9f, "l"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 32.11f + 7.50f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 32.11f + 7.50f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 32.11f + 7.50f, 0.9f, "k"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 32.46f + 7.50f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 16.72f + 32.46f + 7.50f, 57.15f, "s"));


            input.Notes.Add(new Data.NoteInfo(false, 49.76f + 7.50f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 50.00f + 7.50f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 50.23f + 7.50f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 50.47f + 7.50f, 0.9f, "j"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 34.1f + 7.50f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 34.1f + 7.50f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 34.1f + 7.50f, 0.9f, "d"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 34.45f + 7.50f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 34.45f + 7.50f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 34.45f + 7.50f, 0.9f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 59.02f, 0.9f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 59.25f, 0.9f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 59.61f, 0.9f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 59.84f, 0.9f, ";"));
            input.Notes.Add(new Data.NoteInfo(true, 60.43f, 60.90f, "space"));
            //60s piano
            input.Notes.Add(new Data.NoteInfo(false, 60.9f + 0.00f, 0.9f, "l"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.40f + 52.85f + 0.00f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 8.63f + 52.85f + 0.00f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 8.86f + 52.85f + 0.00f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 9.10f + 52.85f + 0.00f, 0.9f, "j"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.40f + 53.78f + 0.00f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 8.63f + 53.78f + 0.00f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.86f + 53.78f + 0.00f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 9.10f + 53.78f + 0.00f, 0.9f, "s"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.40f + 54.72f + 0.00f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.63f + 54.72f + 0.00f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 8.86f + 54.72f + 0.00f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 63.71f + 0.00f, 64.65f + 0.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 64.65f + 0.00f, 65.58f + 0.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 65.70f + 0.00f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 65.82f + 0.00f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 66.05f + 0.00f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 66.29f + 0.00f, 0.9f, "d"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 49.92f + 0.00f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 49.92f + 0.00f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 49.92f + 0.00f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 66.99f + 0.00f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 67.34f + 0.00f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 67.81f + 0.00f, 0.9f, "f"));

            //60s piano
            input.Notes.Add(new Data.NoteInfo(false, 60.91f + 7.5f, 0.9f, "j"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.40f + 52.85f + 7.5f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 8.63f + 52.85f + 7.5f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.86f + 52.85f + 7.5f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 9.10f + 52.85f + 7.5f, 0.9f, "s"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.40f + 53.78f + 7.5f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.63f + 53.78f + 7.5f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 8.86f + 53.78f + 7.5f, 0.9f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 70.27f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 70.62f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 70.97f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 71.32f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 71.79f, 0.9f, "space"));
            //
            input.Notes.Add(new Data.NoteInfo(false, 70.27f, 0.9f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 70.62f, 0.9f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 70.97f, 0.9f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 71.32f, 0.9f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 71.79f, 0.9f, ";"));
            //
            input.Notes.Add(new Data.NoteInfo(false, 70.27f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 70.62f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 70.97f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 71.32f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 71.79f, 0.9f, "k"));

            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 23.86f + 48.29f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 24.33f + 48.29f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 24.80f + 48.29f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 25.27f + 48.29f, 0.9f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 23.86f + 50.16f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 24.33f + 50.16f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 24.80f + 50.16f, 0.9f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 23.86f + 50.16f, 0.9f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 24.33f + 50.16f, 0.9f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 24.80f + 50.16f, 0.9f, "a"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 55.55f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 55.55f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 55.55f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 72.61f, 0.9f, "d"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 56.48f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 56.48f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 56.48f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 73.55f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 73.67f, 0.9f, "j"));

            input.Notes.Add(new Data.NoteInfo(true, 74.02f + 0.00f, 74.25f + 0.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 74.49f + 0.00f, 74.72f + 0.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 74.96f + 0.00f, 75.43f + 0.00f, "f"));

            input.Notes.Add(new Data.NoteInfo(true, 75.43f + 0.00f, 75.9f + 0.00f, "q"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 7.93f + 67.5f, 0.9f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 8.04f + 67.5f, 0.9f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 8.16f + 67.5f, 0.9f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 8.28f + 67.5f, 0.9f, ";"));

            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 23.86f + 53.91f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 24.33f + 53.91f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 24.80f + 53.91f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 25.27f + 53.91f, 0.9f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 23.86f + 52.04f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 24.33f + 52.04f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 24.80f + 52.04f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 25.27f + 52.04f, 0.9f, "space"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 62.58f, 0.9f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 62.58f, 0.9f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 62.58f, 0.9f, "p"));

            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 23.86f + 55.79f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 24.33f + 55.79f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 24.80f + 55.79f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 25.27f + 55.79f, 0.9f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 23.86f + 57.66f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 24.33f + 57.66f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 24.80f + 57.66f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 25.27f + 57.66f, 0.9f, "space"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 66.33f, 0.9f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 66.33f, 0.9f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 66.33f, 0.9f, "p"));

            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 23.86f + 59.54f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 24.33f + 59.54f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 24.80f + 59.54f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 25.27f + 59.54f, 0.9f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 23.86f + 61.41f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 24.33f + 61.41f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 24.80f + 61.41f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 25.27f + 61.41f, 0.9f, "space"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 70.08f, 0.9f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 70.08f, 0.9f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 70.08f, 0.9f, "p"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 23.86f + 63.29f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 24.33f + 63.29f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 24.80f + 63.29f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 25.27f + 63.29f, 0.9f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 23.86f + 65.16f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 24.33f + 65.16f, 0.9f, "space"));
 
            //middle cyndi
            input.Notes.Add(new Data.NoteInfo(true, 45.90f + 30.00f, 46.13f + 30.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 46.36f + 30.00f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 46.60f + 30.00f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 46.83f + 30.00f, 0.9f, "s"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 30.35f + 30.00f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 30.35f + 30.00f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 30.35f + 30.00f, 0.9f, "f"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 30.7f + 30.00f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 30.7f + 30.00f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 30.7f + 30.00f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 47.65f + 30.00f, 0.9f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 48.00f + 30.00f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 48.24f + 30.00f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 48.47f + 30.00f, 0.9f, "d"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 32.11f + 30.00f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 32.11f + 30.00f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 32.11f + 30.00f, 0.9f, "d"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 32.46f + 30.00f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 32.46f + 30.00f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 32.46f + 30.00f, 0.9f, "k"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 32.81f + 30.00f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 32.81f + 30.00f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 32.81f + 30.00f, 0.9f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 49.76f + 30.00f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 50.00f + 30.00f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 50.23f + 30.00f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 50.47f + 30.00f, 0.9f, "f"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 34.1f + 30.00f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 34.1f + 30.00f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 34.1f + 30.00f, 0.9f, "d"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 34.45f + 30.00f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 34.45f + 30.00f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 34.45f + 30.00f, 0.9f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 51.52f + 30.00f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 51.87f + 30.00f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 52.11f + 30.00f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 52.34f + 30.00f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 52.57f + 30.00f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 52.81f + 30.00f, 53.28f + 30.00f, "d"));

            //middle cyndi
            input.Notes.Add(new Data.NoteInfo(true, 45.90f + 37.5f, 46.13f + 37.5f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 46.36f + 37.5f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 46.60f + 37.5f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 46.83f + 37.5f, 0.9f, "l"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 30.35f + 37.5f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 30.35f + 37.5f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 30.35f + 37.5f, 0.9f, "k"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 30.7f + 37.5f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 30.7f + 37.5f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 30.7f + 37.5f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 47.65f + 37.5f, 0.9f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 48.00f + 37.5f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 48.24f + 37.5f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 48.47f + 37.5f, 0.9f, "j"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 32.11f + 37.5f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 32.11f + 37.5f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 32.11f + 37.5f, 0.9f, "s"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 32.46f + 37.5f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 16.72f + 32.46f + 37.5f, 87.15f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 49.76f + 37.5f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 50.00f + 37.5f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 50.23f + 37.5f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 50.47f + 37.5f, 0.9f, "j"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 34.1f + 37.5f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 34.1f + 37.5f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 34.1f + 37.5f, 0.9f, "s"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 16.60f + 34.45f + 37.5f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 16.72f + 34.45f + 37.5f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 16.83f + 34.45f + 37.5f, 0.9f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 89.14f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 89.25f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 89.37f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 89.49f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 89.72f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 89.96f, 90.43f, "p"));
            input.Notes.Add(new Data.NoteInfo(true, 90.43f, 90.90f, "q"));
            //hard sc
            //scratch
            input.Notes.Add(new Data.NoteInfo(false, 120.90f - 30.0f, 0.9f, ";"));

            input.Notes.Add(new Data.NoteInfo(false, 121.36f - 30.0f, 0.9f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 121.48f - 30.0f, 0.9f, ";"));

            input.Notes.Add(new Data.NoteInfo(false, 121.83f - 30.0f, 0.9f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 121.95f - 30.0f, 0.9f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 122.07f - 30.0f, 0.9f, "p"));

            input.Notes.Add(new Data.NoteInfo(false, 122.30f - 30.0f, 0.9f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 122.42f - 30.0f, 0.9f, "p"));
            //scratch
            input.Notes.Add(new Data.NoteInfo(false, 120.90f - 28.13f, 0.9f, ";"));

            input.Notes.Add(new Data.NoteInfo(false, 121.36f - 28.13f, 0.9f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 121.48f - 28.13f, 0.9f, ";"));

            input.Notes.Add(new Data.NoteInfo(false, 121.83f - 28.13f, 0.9f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 121.95f - 28.13f, 0.9f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 122.07f - 28.13f, 0.9f, "p"));

            input.Notes.Add(new Data.NoteInfo(false, 122.30f - 28.13f, 0.9f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 122.42f - 28.13f, 0.9f, "p"));
            //scratch
            input.Notes.Add(new Data.NoteInfo(false, 120.90f - 26.25f, 0.9f, "q"));

            input.Notes.Add(new Data.NoteInfo(false, 121.36f - 26.25f, 0.9f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 121.48f - 26.25f, 0.9f, "q"));

            input.Notes.Add(new Data.NoteInfo(false, 121.83f - 26.25f, 0.9f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 121.95f - 26.25f, 0.9f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 122.07f - 26.25f, 0.9f, "q"));

            input.Notes.Add(new Data.NoteInfo(false, 122.30f - 26.25f, 0.9f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 122.42f - 26.25f, 0.9f, "q"));
            //scratch
            input.Notes.Add(new Data.NoteInfo(false, 120.90f - 24.38f, 0.9f, "a"));

            input.Notes.Add(new Data.NoteInfo(false, 121.36f - 24.38f, 0.9f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 121.48f - 24.38f, 0.9f, "a"));
        
            input.Notes.Add(new Data.NoteInfo(false, 121.83f - 24.38f, 0.9f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 121.95f - 24.38f, 0.9f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 122.07f - 24.38f, 0.9f, "q"));

            input.Notes.Add(new Data.NoteInfo(false, 122.30f - 24.38f, 0.9f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 122.42f - 24.38f, 0.9f, "q"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 23.86f + 67.04f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 24.33f + 67.04f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 24.80f + 67.04f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 25.27f + 67.04f, 0.9f, "f"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 23.86f + 67.04f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 24.33f + 67.04f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 24.80f + 67.04f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 25.27f + 67.04f, 0.9f, "d"));

            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 23.86f + 68.91f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 24.33f + 68.91f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 24.80f + 68.91f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 25.27f + 68.91f, 0.9f, "j"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 23.86f + 68.91f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 24.33f + 68.91f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 24.80f + 68.91f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 25.27f + 68.91f, 0.9f, "k"));

            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 23.86f + 70.79f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 24.33f + 70.79f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 24.80f + 70.79f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 25.27f + 70.79f, 0.9f, "k"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 23.86f + 70.79f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 24.33f + 70.79f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 24.80f + 70.79f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 25.27f + 70.79f, 0.9f, "s"));

            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 23.86f + 72.66f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 24.33f + 72.66f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 24.80f + 72.66f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 25.27f + 72.66f, 0.9f, "s"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 23.86f + 72.66f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 24.33f + 72.66f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 24.80f + 72.66f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 25.27f + 72.66f, 0.9f, "k"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.40f + 90.0f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.63f + 90.0f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.86f + 90.0f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 9.10f + 90.0f, 0.9f, "d"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.40f + 90.93f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 8.63f + 90.93f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 8.86f + 90.93f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 9.10f + 90.93f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 100.15f, 0.9f, "k"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.40f + 91.87f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 8.63f + 91.87f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 8.86f + 91.87f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 9.10f + 91.87f, 0.9f, "j"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.40f + 92.81f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.63f + 92.81f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.86f + 92.81f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 9.10f + 92.81f, 0.9f, "d"));

            //4com
            input.Notes.Add(new Data.NoteInfo(false, 7.93f + 94.22f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 8.04f + 94.22f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 8.16f + 94.22f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 8.28f + 94.22f, 0.9f, "k"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 7.93f + 94.68f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 8.04f + 94.68f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.16f + 94.68f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 8.28f + 94.68f, 0.9f, "d"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 7.93f + 95.15f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 8.04f + 95.15f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 8.16f + 95.15f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 8.28f + 95.15f, 0.9f, "k"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 7.93f + 95.62f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 8.04f + 95.62f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.16f + 95.62f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 8.28f + 95.62f, 0.9f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 104.02f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 104.61f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 104.84f, 0.9f, "space"));
            //
            input.Notes.Add(new Data.NoteInfo(false, 104.02f, 0.9f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 104.61f, 0.9f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 104.84f, 0.9f, "p"));
            //
            input.Notes.Add(new Data.NoteInfo(false, 104.02f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 104.61f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 104.84f, 0.9f, "k"));

            input.Notes.Add(new Data.NoteInfo(true, 105.43f, 105.90f, "space"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 7.93f + 97.5f, 0.9f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 8.04f + 97.5f, 0.9f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 8.16f + 97.5f, 0.9f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 8.28f + 97.5f, 0.9f, "a"));

            //first piano
            input.Notes.Add(new Data.NoteInfo(true, 0.9f + 105.0f, 1.13f + 105.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.25f + 105.0f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.48f + 105.0f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.72f + 105.0f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 1.95f + 105.0f, 2.30f + 105.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 2.42f + 105.0f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(true, 2.77f + 105.0f, 3.00f + 105.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 3.12f + 105.0f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.36f + 105.0f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.59f + 105.0f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 3.82f + 105.0f, 4.18f + 105.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 4.29f + 105.0f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(true, 4.65f + 105.0f, 4.88f + 105.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 5.00f + 105.0f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 5.23f + 105.0f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 5.47f + 105.0f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 5.70f + 105.0f, 6.05f + 105.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 6.17f + 105.0f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 6.29f + 105.0f, 2.0f, "p"));

            input.Notes.Add(new Data.NoteInfo(true, 6.52f + 105.0f, 6.75f + 105.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 6.87f + 105.0f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 7.11f + 105.0f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 7.34f + 105.0f, 2.0f, "k"));
            //
            input.Notes.Add(new Data.NoteInfo(false, 6.87f + 105.0f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 7.11f + 105.0f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 7.34f + 105.0f, 2.0f, "space"));
            //
            input.Notes.Add(new Data.NoteInfo(false, 6.87f + 105.0f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 7.11f + 105.0f, 2.0f, "q"));
            //
            input.Notes.Add(new Data.NoteInfo(false, 112.58f, 7.81f + 105.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 112.58f, 7.81f + 105.0f, "space"));
            //
            input.Notes.Add(new Data.NoteInfo(true, 7.93f + 105.0f, 8.28f + 105.0f, "space"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 7.93f + 105.0f, 0.9f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 8.04f + 105.0f, 0.9f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 8.16f + 105.0f, 0.9f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 8.28f + 105.0f, 0.9f, "p"));

            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 23.86f + 89.54f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 24.33f + 89.54f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 24.80f + 89.54f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 25.27f + 89.54f, 0.9f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 23.86f + 91.41f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 24.33f + 91.41f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 24.80f + 91.41f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 25.27f + 91.41f, 0.9f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 23.86f + 93.29f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 24.33f + 93.29f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 24.80f + 93.29f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 25.27f + 93.29f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 118.67f, 119.02f, "q"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 23.86f + 95.16f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 24.33f + 95.16f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 24.80f + 95.16f, 0.9f, "space"));

            //2nd piano
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.40f + 0.0f + 105f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.63f + 0.0f + 105f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 8.86f + 0.0f + 105f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 9.10f + 0.0f + 105f, 0.9f, "f"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.40f + 1.17f + 105f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 8.63f + 1.17f + 105f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 8.86f + 1.17f + 105f, 0.9f, "j"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.40f + 1.87f + 105f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 8.63f + 1.87f + 105f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 8.86f + 1.87f + 105f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 9.10f + 1.87f + 105f, 0.9f, "k"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.40f + 3.04f + 105f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.63f + 3.04f + 105f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 8.86f + 3.04f + 105f, 0.9f, "f"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.40f + 3.75f + 105f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 8.63f + 3.75f + 105f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.86f + 3.75f + 105f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 9.10f + 3.75f + 105f, 0.9f, "d"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 8.40f + 4.68f + 105f, 0.9f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 8.63f + 4.68f + 105f, 0.9f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 8.86f + 4.68f + 105f, 0.9f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 9.10f + 4.68f + 105f, 0.9f, "k"));

            input.Notes.Add(new Data.NoteInfo(true, 11.21f + 105f, 12.15f + 105f, ";"));
            input.Notes.Add(new Data.NoteInfo(true, 13.08f + 105f, 14.02f + 105f, "a"));

            input.Notes.Add(new Data.NoteInfo(false, 14.02f + 105f, 0.9f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 14.37f + 105f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 14.72f + 105f, 0.9f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 14.96f + 105f, 0.9f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 14.96f + 105.0f, 15.43f + 105.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(true, 15.43f + 105.0f, 15.90f + 105.0f, "space"));
            //scratch
            input.Notes.Add(new Data.NoteInfo(false, 120.90f + 0.00f, 0.9f, "a"));

            input.Notes.Add(new Data.NoteInfo(false, 121.36f + 0.00f, 0.9f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 121.48f + 0.00f, 0.9f, "a"));

            input.Notes.Add(new Data.NoteInfo(false, 121.83f + 0.00f, 0.9f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 121.95f + 0.00f, 0.9f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 122.07f + 0.00f, 0.9f, "q"));

            input.Notes.Add(new Data.NoteInfo(false, 122.30f + 0.00f, 0.9f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 122.42f + 0.00f, 0.9f, "q"));

            //scratch
            input.Notes.Add(new Data.NoteInfo(false, 120.90f + 1.87f, 0.9f, "p"));

            input.Notes.Add(new Data.NoteInfo(false, 121.36f + 1.87f, 0.9f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 121.48f + 1.87f, 0.9f, "p"));

            input.Notes.Add(new Data.NoteInfo(false, 121.83f + 1.87f, 0.9f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 121.95f + 1.87f, 0.9f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 122.07f + 1.87f, 0.9f, ";"));

            input.Notes.Add(new Data.NoteInfo(false, 122.30f + 1.87f, 0.9f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 122.42f + 1.87f, 0.9f, ";"));

            //scratch
            input.Notes.Add(new Data.NoteInfo(false, 120.90f + 3.75f, 0.9f, "q"));

            input.Notes.Add(new Data.NoteInfo(false, 121.36f + 3.75f, 0.9f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 121.48f + 3.75f, 0.9f, "p"));

            input.Notes.Add(new Data.NoteInfo(false, 121.83f + 3.75f, 0.9f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 121.95f + 3.75f, 0.9f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 122.07f + 3.75f, 0.9f, "q"));

            input.Notes.Add(new Data.NoteInfo(false, 122.30f + 3.75f, 0.9f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 122.42f + 3.75f, 0.9f, "a"));

            input.Notes.Add(new Data.NoteInfo(false, 126.52f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 126.75f, 0.9f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 126.99f, 0.9f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 127.46f, 0.9f, ";"));
            input.Notes.Add(new Data.NoteInfo(true, 127.93f, 130.74f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 130.74f, 0.9f, "space"));
        }
        else if (input.Difficulty.Equals("Extreme"))
        {
            input.Notes.Add(new Data.NoteInfo(false, 0.0f, 2.0f, "s"));
        }
    }
}
