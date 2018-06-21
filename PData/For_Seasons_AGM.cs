using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class For_Seasons_AGM : MonoBehaviour
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
        MusicInfo.key = 11;
        MusicInfo.name = "For Seasons (Air Guitar Mix)";
        MusicInfo.composer = "Makou & Planetboom";
        MusicInfo.visualizer = "TARI&ETER";
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
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 0.00f + 0.0f, 2.00f + 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.04f + 0.0f, 2.00f + 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.07f + 0.0f, 2.00f + 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 3.11f + 0.0f, 2.00f + 0.0f, "l"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 0.00f + 4.14f, 2.00f + 4.14f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.04f + 4.14f, 2.00f + 4.14f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 2.07f + 4.14f, 2.00f + 4.14f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.11f + 4.14f, 2.00f + 0.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 7.51f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 7.76f, 2.0f, "space"));

            input.Notes.Add(new Data.NoteInfo(false, 8.28f, 2.0f, "s"));

            //2com
            input.Notes.Add(new Data.NoteInfo(false, 8.80f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.93f + 0.00f, 2.0f, "f"));

            //3/1
            input.Notes.Add(new Data.NoteInfo(false, 9.32f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 9.83f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 10.35f, 2.0f, "l"));

            //2com
            input.Notes.Add(new Data.NoteInfo(false, 8.80f + 2.07f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 8.93f + 2.07f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(true, 11.38f, 12.42f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 12.42f, 2.0f, "s"));

            //2com
            input.Notes.Add(new Data.NoteInfo(false, 8.80f + 4.14f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.93f + 4.14f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 13.45f, 12.42f, "k"));
            //2com
            input.Notes.Add(new Data.NoteInfo(false, 8.80f + 5.17f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 8.93f + 5.17f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 14.49f, 12.42f, "l"));
            //2com
            input.Notes.Add(new Data.NoteInfo(false, 8.80f + 6.21f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 8.93f + 6.21f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 15.52f, 16.56f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 16.56f, 12.42f, "d"));

            //2com
            input.Notes.Add(new Data.NoteInfo(false, 8.80f + 8.27f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 8.93f + 8.27f, 2.0f, "d"));

            //3/1
            input.Notes.Add(new Data.NoteInfo(false, 9.32f + 8.27f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 9.83f + 8.27f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 10.35f + 8.27f, 2.0f, "l"));

            //2com
            input.Notes.Add(new Data.NoteInfo(false, 8.80f + 10.34f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 8.93f + 10.34f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(true, 19.66f, 20.69f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 20.69f, 2.0f, "space"));
            //3/1/0.5
            input.Notes.Add(new Data.NoteInfo(false, 21.73f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 22.25f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 22.51f, 2.0f, "a"));

            input.Notes.Add(new Data.NoteInfo(false, 23.80f, 2.0f, "s"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 24.32f + 0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 24.44f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 24.57f + 0.00f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 24.83f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 25.35f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 25.48f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 25.74f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 26.38f, 2.0f, "space"));

            //2com
            input.Notes.Add(new Data.NoteInfo(false, 8.80f + 18.1f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 8.93f + 18.1f, 2.0f, "j"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 27.29f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 27.55f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 27.81f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 28.07f + 0.00f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 28.58f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 28.97f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 29.49f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 29.62f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 29.88f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 30.26f, 2.0f, "d"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 24.32f + 6.2f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 24.44f + 6.2f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 24.57f + 6.2f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(true, 32.07f, 33.11f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 33.11f, 2.0f, "j"));

            //2com
            input.Notes.Add(new Data.NoteInfo(false, 8.80f + 24.83f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 8.93f + 24.83f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 34.14f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 34.66f, 2.0f, "space"));

            input.Notes.Add(new Data.NoteInfo(false, 35.18f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 35.31f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 35.57f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 35.82f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 36.08f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 36.34f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 36.73f, 2.0f, "space"));

            input.Notes.Add(new Data.NoteInfo(false, 37.25f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 37.76f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 37.89f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 38.15f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 38.54f, 2.0f, "f"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 24.32f + 14.48f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 24.44f + 14.48f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 24.57f + 14.48f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 40.35f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 40.87f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 41.38f, 43.45f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 43.97f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 44.49f, 2.0f, ";"));

            //4com
            input.Notes.Add(new Data.NoteInfo(false, 44.88f + 0.00f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 45.01f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 45.13f + 0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 45.26f + 0.00f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(true, 45.52f, 46.04f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 46.56f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 46.94f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(true, 47.33f, 48.50f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 49.14f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 49.66f, 2.0f, "j"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 24.32f + 27.93f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 24.44f + 27.93f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 24.57f + 27.93f, 2.0f, "s"));

            //2com
            input.Notes.Add(new Data.NoteInfo(false, 8.80f + 43.96f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 8.93f + 43.96f, 2.0f, "l"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 24.32f + 28.96f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 24.44f + 28.96f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 24.57f + 28.96f, 2.0f, "f"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 24.32f + 29.48f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 24.44f + 29.48f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 24.57f + 29.48f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 56.9f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 57.29f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 57.68f, 2.0f, "j"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 24.32f + 33.62f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 24.44f + 33.62f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 24.57f + 33.62f, 2.0f, "j"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 24.32f + 34.65f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 24.44f + 34.65f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 24.57f + 34.65f, 2.0f, "f"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 27.29f + 32.72f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 27.55f + 32.72f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 27.81f + 32.72f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 61.56f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 61.82f, 62.59f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 63.11f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 63.50f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 63.88f, 64.66f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 64.66f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 64.92f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(true, 65.69f, 66.47f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 66.47f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 66.73f, 2.0f, "d"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 24.32f + 43.7f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 24.44f + 43.7f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 24.57f + 43.7f, 2.0f, "j"));

            //4com
            input.Notes.Add(new Data.NoteInfo(false, 44.88f + 24.18f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 45.01f + 24.18f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 45.13f + 24.18f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 45.26f + 24.18f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 69.57f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 69.83f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 69.96f, 2.0f, "f"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 24.32f + 46.03f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 24.44f + 46.03f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 24.57f + 46.03f, 2.0f, "j"));

            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 9.32f + 61.55f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 9.83f + 61.55f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 10.35f + 61.55f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 10.87f + 61.55f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 73.45f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 73.84f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 74.23f, 2.0f, "f"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 24.32f + 50.17f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 24.44f + 50.17f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 24.57f + 50.17f, 2.0f, "f"));

            //5/0.5
            input.Notes.Add(new Data.NoteInfo(false, 75.78f+0.00f , 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 76.04f+0.00f , 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 76.30f+0.00f , 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 76.56f+0.00f , 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 76.82f+0.00f , 2.0f, "j"));

            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 9.32f + 68.79f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 9.83f + 68.79f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 10.35f + 68.79f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 10.87f + 68.79f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(true, 78.63f, 82.25f, "d"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 9.32f + 70.86f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 9.83f + 70.86f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 10.35f + 70.86f, 2.0f, "j"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 24.32f + 57.93f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 24.44f + 57.93f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 24.57f + 57.93f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 82.76f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 83.15f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 83.67f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 84.32f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 84.44f, 2.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(true, 84.83f, 85.87f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 85.61f, 86.90f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 86.90f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(true, 87.42f, 88.97f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 88.97f, 90.01f, "d"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 24.32f + 65.94f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 24.44f + 65.94f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 24.57f + 65.94f, 2.0f, "k"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 24.32f + 66.33f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 24.44f + 66.33f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 24.57f + 66.33f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 91.04f, 2.0f, "s"));

            //3/0.75
            input.Notes.Add(new Data.NoteInfo(false, 92.07f + 0.00f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 92.46f + 0.00f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 92.85f + 0.00f, 2.0f, "space"));

            input.Notes.Add(new Data.NoteInfo(true, 94.40f, 95.18f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 95.18f, 96.47f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 97.12f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 97.25f, 98.28f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 98.28f, 98.80f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 98.80f, 99.32f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 99.57f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 99.83f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(true, 101.13f, 101.90f, "s"));

            input.Notes.Add(new Data.NoteInfo(true, 102.42f, 103.19f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 103.45f, 103.97f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 104.23f, 2.0f, "k"));

            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 75.78f + 28.97f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 76.04f + 28.97f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 76.30f + 28.97f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 105.39f,2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 105.52f, 106.04f, "l"));

            input.Notes.Add(new Data.NoteInfo(true, 106.30f, 107.33f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 107.59f, 109.14f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 109.14f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 109.27f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 109.66f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 109.92f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 110.18f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 110.31f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 110.44f, 111.47f, "f"));

            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 75.78f + 35.95f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 76.04f + 35.95f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 76.30f + 35.95f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 112.51f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 112.63f, 113.28f, "f"));

            input.Notes.Add(new Data.NoteInfo(true, 113.54f, 114.32f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 114.32f, 2.0f, "j"));

            //2com
            input.Notes.Add(new Data.NoteInfo(false, 8.80f + 106.03f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 8.93f + 106.03f, 2.0f, "d"));
            //2com2
            //2com
            input.Notes.Add(new Data.NoteInfo(false, 8.80f + 106.81f + 0.00f , 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 8.93f + 106.81f + 0.00f , 2.0f, "d"));
            //2com
            input.Notes.Add(new Data.NoteInfo(false, 8.80f + 107.2f + 0.00f , 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 8.93f + 107.2f + 0.00f , 2.0f, "k"));
            //2com2
            //2com
            input.Notes.Add(new Data.NoteInfo(false, 8.80f + 106.81f + 0.77f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 8.93f + 106.81f + 0.77f, 2.0f, "d"));
            //2com
            input.Notes.Add(new Data.NoteInfo(false, 8.80f + 107.2f + 0.77f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 8.93f + 107.2f + 0.77f, 2.0f, "k"));
            //2com2
            //2com
            input.Notes.Add(new Data.NoteInfo(false, 8.80f + 106.81f + 1.55f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 8.93f + 106.81f + 1.55f, 2.0f, "d"));
            //2com
            input.Notes.Add(new Data.NoteInfo(false, 8.80f + 107.2f + 1.55f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 8.93f + 107.2f + 1.55f, 2.0f, "k"));

            //5/0.5
            input.Notes.Add(new Data.NoteInfo(false, 75.78f + 42.16f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 76.04f + 42.16f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 76.30f + 42.16f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 76.56f + 42.16f, 2.0f, "k"));
            //5/0.5
            input.Notes.Add(new Data.NoteInfo(false, 75.78f + 43.19f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 76.04f + 43.19f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 76.30f + 43.19f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 76.56f + 43.19f, 2.0f, "s"));
            //5/0.5
            input.Notes.Add(new Data.NoteInfo(false, 75.78f + 43.84f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 76.04f + 43.84f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(true, 120.01f, 121.04f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 121.04f, 122.07f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 122.07f, 122.85f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 122.85f, 123.88f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 123.88f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 124.01f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(true, 124.14f, 124.92f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 124.92f, 2.0f, "k"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 24.32f + 100.86f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 24.44f + 100.86f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 24.57f + 100.86f, 2.0f, "s"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 24.32f + 101.37f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 24.44f + 101.37f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 24.57f + 101.37f, 2.0f, "j"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 24.32f + 101.89f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 24.44f + 101.89f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 24.57f + 101.89f, 2.0f, "s"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 24.32f + 102.41f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 24.44f + 102.41f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 24.57f + 102.41f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 127.25f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 127.38f, 128.28f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 128.28f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 128.54f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 128.80f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(true, 129.06f, 129.83f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 129.57f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 129.83f, 2.0f, "space"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 24.32f + 106.29f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 24.44f + 106.29f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 24.57f + 106.29f, 2.0f, "s"));
            //5/0.5
            input.Notes.Add(new Data.NoteInfo(false, 75.78f + 55.22f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 76.04f + 55.22f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 76.30f + 55.22f, 2.0f, "j"));

            //5/0.5
            input.Notes.Add(new Data.NoteInfo(false, 75.78f + 56.64f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 76.04f + 56.64f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 76.30f + 56.64f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(true, 133.19f, 134.23f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 134.23f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 134.36f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(true, 134.49f, 135.52f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 135.52f, 136.56f, "f"));

            //5/0.5
            input.Notes.Add(new Data.NoteInfo(false, 75.78f + 60.78f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 76.04f + 60.78f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 76.30f + 60.78f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(true, 137.33f, 138.37f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 139.14f, 139.66f, "k"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 24.32f + 115.34f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 24.44f + 115.34f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 24.57f + 115.34f, 2.0f, "f"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 24.32f + 115.73f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 24.44f + 115.73f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 24.57f + 115.73f, 2.0f, "d"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 24.32f + 116.12f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 24.44f + 116.12f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 24.57f + 116.12f, 2.0f, "l"));
            //5/0.5
            input.Notes.Add(new Data.NoteInfo(false, 75.78f + 65.17f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 76.04f + 65.17f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 76.30f + 65.17f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 76.56f + 65.17f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 76.82f + 65.17f, 2.0f, "d"));

            //5/0.5
            input.Notes.Add(new Data.NoteInfo(false, 75.78f + 66.98f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 76.04f + 66.98f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 76.30f + 66.98f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 143.54f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 143.67f, 2.0f, "a"));

            input.Notes.Add(new Data.NoteInfo(true, 144.83f, 146.38f, "f"));

            //5/0.5
            input.Notes.Add(new Data.NoteInfo(false, 75.78f + 72.67f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 76.04f + 72.67f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 76.30f + 72.67f, 2.0f, "j"));
              
            input.Notes.Add(new Data.NoteInfo(false, 150.01f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(true, 151.04f, 152.07f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 152.59f, 156.21f, "j"));
        }
        else if (input.Difficulty.Equals("Hard"))
        {
            //guitar1

            input.Notes.Add(new Data.NoteInfo(false, 0.00f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 0.26f+0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 0.39f+0.00f, 2.0f, "j"));
            //5/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f+0.0f+0.00f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 0.91f+0.0f+0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.17f+0.0f+0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.43f+0.0f+0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.69f+0.0f+0.00f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 1.94f+0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 2.07f+0.00f, 2.0f, "l"));

            //5/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 1.68f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 0.91f + 1.68f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.17f + 1.68f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.43f + 1.68f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.69f + 1.68f + 0.00f, 2.0f, "j"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 3.65f+0.0f+0.00f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 3.76f+0.0f+0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.88f+0.0f+0.00f, 2.0f, "j"));

            //guitar1

            input.Notes.Add(new Data.NoteInfo(false, 4.14f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 0.26f + 4.14f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 0.39f + 4.14f, 2.0f, "s"));
            //5/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 0.0f + 4.14f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 0.91f + 0.0f + 4.14f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 1.17f + 0.0f + 4.14f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.43f + 0.0f + 4.14f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.69f + 0.0f + 4.14f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 1.94f + 4.14f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.07f + 4.14f, 2.0f, "f"));

            //5/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 1.68f + 4.14f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 0.91f + 1.68f + 4.14f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.17f + 1.68f + 4.14f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 1.43f + 1.68f + 4.14f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.69f + 1.68f + 4.14f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 7.76f, 2.0f, "j"));
            //4/0.5//2/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.0f+0.00f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.26f+0.00f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.04f+0.00f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.30f+0.00f, 2.0f, "space"));
            //4/0.5//2/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 2.07f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.26f + 2.07f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.04f + 2.07f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.30f + 2.07f, 2.0f, "space"));
            //4/0.5//2/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 4.14f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.26f + 4.14f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.04f + 4.14f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.30f + 4.14f, 2.0f, "space"));
            //4/0.5//2/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 7.51f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.26f + 7.51f, 2.0f, "space"));

            input.Notes.Add(new Data.NoteInfo(true, 6.21f, 7.25f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 7.25f, 8.28f, "s"));

            input.Notes.Add(new Data.NoteInfo(true, 8.28f, 11.38f, "s"));
            //first piano
            input.Notes.Add(new Data.NoteInfo(false, 8.28f+0.00f, 2.0f, "f"));

            //2com
            input.Notes.Add(new Data.NoteInfo(false, 8.80f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.93f + 0.00f, 2.0f, "f"));

            //3/1
            input.Notes.Add(new Data.NoteInfo(false, 9.32f + 0.00f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 9.83f + 0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 10.35f + 0.00f, 2.0f, "l"));

            //2com
            input.Notes.Add(new Data.NoteInfo(false, 8.80f + 2.07f + 0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 8.93f + 2.07f + 0.00f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(true, 11.38f + 0.00f, 11.90f + 0.00f, "l"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 11.90f+0.00f,2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 12.03f+0.00f,2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 12.16f+0.00f,2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 12.29f+0.00f,2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(true, 12.42f + 0.00f, 15.52f + 0.00f, "l"));
            //first piano
            input.Notes.Add(new Data.NoteInfo(false, 12.42f, 2.0f, "s"));

            //2com
            input.Notes.Add(new Data.NoteInfo(false, 8.80f + 4.14f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.93f + 4.14f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 13.45f, 12.42f, "k"));
            //2com
            input.Notes.Add(new Data.NoteInfo(false, 8.80f + 5.17f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 8.93f + 5.17f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 14.49f, 12.42f, "f"));
            //2com
            input.Notes.Add(new Data.NoteInfo(false, 8.80f + 6.21f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 8.93f + 6.21f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 15.52f, 16.56f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 16.56f, 12.42f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 16.94f, 12.42f, "a"));
            input.Notes.Add(new Data.NoteInfo(true, 17.33f, 18.50f, "a"));
            //first piano
            input.Notes.Add(new Data.NoteInfo(false, 16.56f, 12.42f, "d"));

            //2com
            input.Notes.Add(new Data.NoteInfo(false, 8.80f + 8.27f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 8.93f + 8.27f, 2.0f, "d"));

            //3/1
            input.Notes.Add(new Data.NoteInfo(false, 9.32f + 8.27f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 9.83f + 8.27f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 10.35f + 8.27f, 2.0f, "l"));

            /**/
            input.Notes.Add(new Data.NoteInfo(true, 18.63f, 19.66f, ";"));
            /**/
            //2com
            input.Notes.Add(new Data.NoteInfo(false, 8.80f + 10.34f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 8.93f + 10.34f, 2.0f, "f"));
            //end piano
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 11.90f + 7.76f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 12.03f + 7.76f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 12.16f + 7.76f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 12.29f + 7.76f, 2.0f, "k"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 11.90f + 8.28f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 12.03f + 8.28f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(true, 20.69f, 21.73f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 20.69f, 21.73f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 21.73f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 21.73f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 22.12f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 22.12f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(true, 22.51f, 24.83f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 22.51f, 23.54f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 23.80f, 2.0f, "space"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 24.32f + 0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 24.44f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 24.57f + 0.00f, 2.0f, "j"));

            //main1
            input.Notes.Add(new Data.NoteInfo(false, 24.83f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 25.35f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 25.48f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 25.74f, 26.38f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 26.38f, 2.0f, "d"));

            //2com
            input.Notes.Add(new Data.NoteInfo(false, 8.80f + 18.1f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 8.93f + 18.1f, 2.0f, "j"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 27.29f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 27.55f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 27.81f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 28.07f + 0.00f, 28.58f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 28.58f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 28.97f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 29.49f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 29.62f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 29.88f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 30.26f, 2.0f, "d"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 24.32f + 6.2f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 24.44f + 6.2f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 24.57f + 6.2f, 32.07f, "s"));

            //4com
            input.Notes.Add(new Data.NoteInfo(false, 11.90f + 20.43f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 12.03f + 20.43f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 12.16f + 20.43f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 12.29f + 20.43f, 2.0f, "k"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 11.90f + 20.95f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 12.03f + 20.95f, 2.0f, "l"));
            
            //main1
            input.Notes.Add(new Data.NoteInfo(false, 33.11f, 2.0f, "j"));

            //2com
            input.Notes.Add(new Data.NoteInfo(false, 8.80f + 24.83f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 8.93f + 24.83f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 34.01f, 34.66f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 34.66f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 35.18f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 35.31f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 35.57f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 35.82f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 36.08f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 36.34f, 36.86f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 37.25f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 37.76f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 37.89f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 38.15f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 38.54f, 2.0f, "f"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 24.32f + 14.48f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 24.44f + 14.48f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 24.57f + 14.48f, 40.35f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 40.35f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 40.87f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 40.35f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 40.87f, 2.0f, "f"));
            //main1 end

            input.Notes.Add(new Data.NoteInfo(true, 41.38f, 43.45f, "f"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 41.40f+0.00f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 41.90f+0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 42.42f+0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 42.94f+0.00f, 2.0f, "s"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 41.40f + 2.05f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 41.90f + 2.05f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 42.42f + 2.05f, 2.0f, "l"));

            //4com
            input.Notes.Add(new Data.NoteInfo(false, 44.88f + 0.00f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 45.01f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 45.13f + 0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 45.26f + 0.00f, 2.0f, "k"));
            //3/1/2
            input.Notes.Add(new Data.NoteInfo(false, 24.83f+0.00f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 25.35f+0.00f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 26.38f+0.00f, 2.0f, "space"));
            //3/1/2
            input.Notes.Add(new Data.NoteInfo(false, 24.83f + 2.07f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 25.35f + 2.07f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 26.38f + 2.07f, 2.0f, "space"));
            //3/1/2
            input.Notes.Add(new Data.NoteInfo(false, 24.83f + 4.14f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 25.35f + 4.14f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 26.38f + 4.14f, 2.0f, "space"));
            //3/1/2
            input.Notes.Add(new Data.NoteInfo(false, 24.83f + 6.21f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 25.35f + 6.21f, 2.0f, "space"));
            //3/1/2
            input.Notes.Add(new Data.NoteInfo(false, 24.83f + 8.28f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 25.35f + 8.28f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 26.38f + 8.28f, 2.0f, "space"));
            //3/1/2
            input.Notes.Add(new Data.NoteInfo(false, 24.83f + 10.35f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 25.35f + 10.35f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 26.38f + 10.35f, 2.0f, "space"));
            //3/1/2
            input.Notes.Add(new Data.NoteInfo(false, 24.83f + 12.42f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 25.35f + 12.42f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 26.38f + 12.42f, 2.0f, "space"));
            //3/1/2
            input.Notes.Add(new Data.NoteInfo(false, 24.83f + 14.49f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 25.35f + 14.49f, 2.0f, "space"));

            //main2
            input.Notes.Add(new Data.NoteInfo(true, 45.52f, 46.04f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 46.56f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 46.94f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(true, 47.33f, 48.50f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 49.14f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 49.66f, 52.12f, "j"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 24.32f + 27.93f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 24.44f + 27.93f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 24.57f + 27.93f, 2.0f, "j"));

            //2com
            input.Notes.Add(new Data.NoteInfo(false, 8.80f + 43.96f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 8.93f + 43.96f, 2.0f, "j"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 24.32f + 28.96f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 24.57f + 28.96f, 2.0f, "f"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 24.32f + 29.48f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 24.44f + 29.48f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 24.57f + 29.48f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(true, 54.32f, 54.83f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 54.83f, 55.35f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 55.35f, 55.87f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 55.87f, 56.90f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 56.9f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 57.29f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 57.68f, 2.0f, "j"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 24.32f + 33.62f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 24.44f + 33.62f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 24.57f + 33.62f, 58.97f, "space"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 24.32f + 34.65f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 24.44f + 34.65f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 24.57f + 34.65f, 60.01f, "space"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 27.29f + 32.72f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 27.55f + 32.72f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 27.81f + 32.72f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 61.56f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 61.82f, 62.59f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 63.11f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 63.50f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 63.88f, 64.66f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 64.66f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(true, 64.92f, 65.69f, "d"));

            input.Notes.Add(new Data.NoteInfo(true, 65.69f, 66.47f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 66.47f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(true, 66.73f, 68.02f, "d"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 24.32f + 43.7f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 24.44f + 43.7f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 24.57f + 43.7f, 2.0f, "j"));

            //4com
            input.Notes.Add(new Data.NoteInfo(false, 44.88f + 24.18f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 45.01f + 24.18f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 45.13f + 24.18f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 45.26f + 24.18f, 2.0f, "space"));

            input.Notes.Add(new Data.NoteInfo(false, 69.57f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 69.83f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 69.96f, 2.0f, "f"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 24.32f + 46.03f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 24.44f + 46.03f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 24.57f + 46.03f, 72.42f, "space"));

            //4/1
            input.Notes.Add(new Data.NoteInfo(true, 9.32f + 61.55f, 71.38f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 9.83f + 61.55f, 71.90f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 10.35f + 61.55f, 72.42f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 10.87f + 61.55f, 73.45f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 73.45f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 73.84f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 74.23f, 2.0f, "f"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 24.32f + 50.17f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 24.44f + 50.17f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 24.57f + 50.17f, 75.65f, "space"));

            //5/0.5
            input.Notes.Add(new Data.NoteInfo(false, 75.78f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 76.04f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 76.30f + 0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 76.56f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 76.82f + 0.00f, 78.11f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 78.11f + 0.00f, 2.0f, "k"));
            //main2 end
            //4/1/2com
            input.Notes.Add(new Data.NoteInfo(false, 45.52f+0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 46.04f+0.00f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 46.56f+0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 46.69f+0.00f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 47.07f+0.00f, 2.0f, "s"));
            //4/1/2com
            input.Notes.Add(new Data.NoteInfo(false, 45.52f + 2.07f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 46.04f + 2.07f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 47.07f + 2.07f, 2.0f, "s"));
            //4/1/2com
            input.Notes.Add(new Data.NoteInfo(false, 45.52f + 4.14f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 46.04f + 4.14f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 46.56f + 4.14f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 46.69f + 4.14f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 47.07f + 4.14f, 2.0f, "l"));
            //4/1/2com
            input.Notes.Add(new Data.NoteInfo(false, 45.52f + 8.28f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 46.04f + 8.28f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 46.56f + 8.28f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 46.69f + 8.28f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 47.07f + 8.28f, 2.0f, "s"));
            //4/1/2com
            input.Notes.Add(new Data.NoteInfo(false, 45.52f + 10.35f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 46.04f + 10.35f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 56.51f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 46.56f + 10.35f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 47.07f + 10.35f, 2.0f, "l"));
            //4/1/2com
            input.Notes.Add(new Data.NoteInfo(false, 45.52f + 12.42f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 46.04f + 12.42f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 46.56f + 12.42f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 47.07f + 12.42f, 2.0f, "s"));
            //4/1/2com
            input.Notes.Add(new Data.NoteInfo(false, 45.52f + 14.49f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 46.04f + 14.49f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 46.56f + 14.49f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 61.30f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 47.07f + 14.49f, 2.0f, "s"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 41.40f + 20.67f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 41.90f + 20.67f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 62.72f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 42.42f + 20.67f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 42.94f + 20.67f, 2.0f, "s"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 41.40f + 22.74f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 41.90f + 22.74f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 64.79f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 42.42f + 22.74f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 42.94f + 22.74f, 2.0f, "l"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 41.40f + 24.81f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 41.90f + 24.81f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 66.86f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 42.42f + 24.81f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 42.94f + 24.81f, 2.0f, "l"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 41.40f + 31.54f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 41.90f + 31.54f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 42.42f + 31.54f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 42.94f + 31.54f, 2.0f, "s"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 41.40f + 33.61f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 41.90f + 33.61f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 42.42f + 33.61f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 42.94f + 33.61f, 2.0f, "l"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 41.40f + 35.67f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 41.90f + 35.67f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 77.85f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 42.42f + 35.67f, 2.0f, "l"));

            //piano1
            input.Notes.Add(new Data.NoteInfo(false, 78.63f + 0.00f, 2.0f, "s"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 24.32f + 54.69f + 0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 24.44f + 54.69f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 24.57f + 54.69f + 0.00f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 79.53f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 79.66f + 0.00f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 80.18f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 80.69f + 0.00f, 2.0f, "l"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 24.32f + 56.76f + 0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 24.44f + 56.76f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 24.57f + 56.76f + 0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 81.73f + 0.00f, 2.0f, "j"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 24.32f + 57.67f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 24.44f + 57.67f + 0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 24.57f + 57.67f + 0.00f, 2.0f, "d"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 24.32f + 58.06f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 24.44f + 58.06f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 24.57f + 58.06f + 0.00f, 2.0f, "l"));
            //piano1
            input.Notes.Add(new Data.NoteInfo(false, 78.63f + 4.13f, 2.0f, "s"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 24.32f + 54.69f + 4.13f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 24.44f + 54.69f + 4.13f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 24.57f + 54.69f + 4.13f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 79.53f + 4.13f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 79.66f + 4.13f, 2.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 80.18f + 4.13f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 80.69f + 4.13f, 2.0f, "d"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 24.32f + 56.76f + 4.13f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 24.44f + 56.76f + 4.13f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 24.57f + 56.76f + 4.13f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 81.73f + 4.13f, 2.0f, "k"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 24.32f + 57.67f + 4.13f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 24.44f + 57.67f + 4.13f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 24.57f + 57.67f + 4.13f, 2.0f, "d"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 24.32f + 58.06f + 4.13f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 24.44f + 58.06f + 4.13f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 24.57f + 58.06f + 4.13f, 2.0f, "l"));
            //piano1
            input.Notes.Add(new Data.NoteInfo(false, 78.63f + 8.27f, 2.0f, "s"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 24.32f + 54.69f + 8.27f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 24.44f + 54.69f + 8.27f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 24.57f + 54.69f + 8.27f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 79.53f + 8.27f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 79.66f + 8.27f, 2.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 80.18f + 8.27f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 80.69f + 8.27f, 2.0f, "d"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 24.32f + 56.76f + 8.27f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 24.44f + 56.76f + 8.27f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 24.57f + 56.76f + 8.27f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 81.73f + 8.27f, 2.0f, "f"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 24.32f + 57.67f + 8.27f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 24.44f + 57.67f + 8.27f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 24.57f + 57.67f + 8.27f, 2.0f, "d"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 24.32f + 58.06f + 8.27f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 24.44f + 58.06f + 8.27f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 24.57f + 58.06f + 8.27f, 2.0f, "l"));
       

            input.Notes.Add(new Data.NoteInfo(false, 79.14f + 0.00f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 80.18f + 0.00f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 81.21f + 0.00f, 2.0f, "space"));

            input.Notes.Add(new Data.NoteInfo(false, 79.14f + 4.14f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 80.18f + 4.14f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 81.21f + 4.14f, 2.0f, "space"));

            input.Notes.Add(new Data.NoteInfo(false, 79.14f + 8.28f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 80.18f + 8.28f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 81.21f + 8.28f, 2.0f, "space"));

            //piano ended
            //3/2
            input.Notes.Add(new Data.NoteInfo(true, 91.04f, 92.07f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 91.04f, 92.07f, "j"));
            //3/0.75
            input.Notes.Add(new Data.NoteInfo(false, 92.07f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 92.46f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 92.85f + 0.00f, 2.0f, "s"));
            //3/0.75
            input.Notes.Add(new Data.NoteInfo(false, 92.07f + 0.00f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 92.46f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 92.85f + 0.00f, 2.0f, "j"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 24.32f + 68.79f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 24.44f + 68.79f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 24.57f + 68.79f, 2.0f, "f"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 24.32f + 69.18f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 24.44f + 69.18f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 24.57f + 69.18f, 2.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 94.14f, 95.18f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 94.40f, 95.18f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 94.66f, 95.18f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 94.79f, 95.18f, "l"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 24.32f + 70.6f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 24.44f + 70.6f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 24.57f + 70.6f, 96.47f, "f"));
            //g lead
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 24.32f + 72.8f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 24.44f + 72.8f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 24.57f + 72.8f, 2.0f, "s"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 24.32f + 73.19f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 24.44f + 73.19f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 24.57f + 73.19f, 2.0f, "f"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 24.32f + 73.57f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 24.44f + 73.57f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 24.57f + 73.57f, 2.0f, "s"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 24.32f + 73.96f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 24.44f + 73.96f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 24.57f + 73.96f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(true, 98.80f, 99.32f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 99.57f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 99.83f, 101.13f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 101.13f, 101.90f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 101.26f, 101.90f, "f"));

            input.Notes.Add(new Data.NoteInfo(true, 101.38f, 101.77f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 101.77f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 101.90f, 102.29f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 102.29f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 102.42f, 102.81f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 102.81f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 102.94f, 103.32f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 103.32f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(true, 103.45f, 103.97f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 104.23f, 104.75f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 104.75f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 105.01f, 2.0f, "space"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 24.32f + 80.94f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 24.44f + 80.94f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 24.57f + 80.94f, 2.0f, "f"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 24.32f + 81.33f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 24.44f + 81.33f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 24.57f + 81.33f, 106.30f, "j"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 24.32f + 81.98f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 24.44f + 81.98f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 24.57f + 81.98f, 2.0f, "j"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 24.32f + 82.37f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 24.44f + 82.37f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 24.57f + 82.37f, 2.0f, "f"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 24.32f + 82.75f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 24.44f + 82.75f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 24.57f + 82.75f, 2.0f, "space"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 24.32f + 83.27f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 24.44f + 83.27f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 24.57f + 83.27f, 2.0f, "j"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 24.32f + 83.66f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 24.44f + 83.66f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 24.57f + 83.66f, 2.0f, "s"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 24.32f + 84.05f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 24.44f + 84.05f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 24.57f + 84.05f, 2.0f, "s"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 24.32f + 84.44f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 24.44f + 84.44f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 109.14f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 109.27f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 109.53f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 109.79f, 2.0f, "f"));

            //5/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 0.0f + 109.27f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 0.91f + 0.0f + 109.27f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 1.17f + 0.0f + 109.27f, 111.47f, "q"));

            input.Notes.Add(new Data.NoteInfo(true, 111.47f, 111.73f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 111.73f, 112.12f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 112.12f, 2.0f, "l"));

            //4com
            input.Notes.Add(new Data.NoteInfo(false, 44.88f + 67.5f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 45.01f + 67.5f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 45.13f + 67.5f, 113.54f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 113.54f, 114.32f, "p"));
            input.Notes.Add(new Data.NoteInfo(true, 114.32f, 114.83f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 114.83f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 115.09f, 2.0f, "f"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 3.65f + 0.0f + 111.96f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 3.76f + 0.0f + 111.96f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.88f + 0.0f + 111.96f, 2.0f, "j"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 3.65f + 0.0f + 112.35f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.76f + 0.0f + 112.35f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.88f + 0.0f + 112.35f, 2.0f, "space"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 3.65f + 0.0f + 112.73f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.76f + 0.0f + 112.73f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 3.88f + 0.0f + 112.73f, 2.0f, "f"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 3.65f + 0.0f + 113.12f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 3.76f + 0.0f + 113.12f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.88f + 0.0f + 113.12f, 2.0f, "d"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 3.65f + 0.0f + 113.51f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.76f + 0.0f + 113.51f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.88f + 0.0f + 113.51f, 2.0f, "s"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 3.65f + 0.0f + 113.9f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.76f + 0.0f + 113.9f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 3.88f + 0.0f + 113.9f, 2.0f, "s"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 11.90f + 106.04f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 12.03f + 106.04f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 12.16f + 106.04f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 12.29f + 106.04f, 2.0f, "s"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 11.90f + 106.55f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 12.03f + 106.55f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 12.16f + 106.55f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 12.29f + 106.55f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 118.97f, 112.12f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 119.10f, 119.49f, "space"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 3.65f + 0.0f + 115.97f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.76f + 0.0f + 115.97f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.88f + 0.0f + 115.97f, 2.0f, "k"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 3.65f + 0.0f + 116.36f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 3.76f + 0.0f + 116.36f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.88f + 0.0f + 116.36f, 2.0f, "j"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 3.65f + 0.0f + 116.74f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 3.76f + 0.0f + 116.74f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.88f + 0.0f + 116.74f, 2.0f, "j"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 3.65f + 0.0f + 117.13f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.76f + 0.0f + 117.13f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.88f + 0.0f + 117.13f, 2.0f, "d"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 3.65f + 0.0f + 117.52f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 3.76f + 0.0f + 117.52f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.88f + 0.0f + 117.52f, 2.0f, "s"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 3.65f + 0.0f + 117.91f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.76f + 0.0f + 117.91f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.88f + 0.0f + 117.91f, 2.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 121.94f, 112.12f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 122.07f, 122.85f, "a"));
            input.Notes.Add(new Data.NoteInfo(true, 122.85f, 123.88f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 123.88f, 112.12f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 124.01f, 112.12f, "k"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 3.65f + 0.0f + 120.62f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.76f + 0.0f + 120.62f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.88f + 0.0f + 120.62f, 2.0f, "space"));
    
            input.Notes.Add(new Data.NoteInfo(false, 124.92f, 112.12f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 125.18f, 112.12f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 125.44f, 112.12f, "d"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 3.65f + 0.0f + 122.04f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.76f + 0.0f + 122.04f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.88f + 0.0f + 122.04f, 2.0f, "space"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 3.65f + 0.0f + 122.56f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.76f + 0.0f + 122.56f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 3.88f + 0.0f + 122.56f, 2.0f, "j"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 3.65f + 0.0f + 123.08f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 3.76f + 0.0f + 123.08f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.88f + 0.0f + 123.08f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 127.25f, 112.12f, "l"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 3.65f + 0.0f + 123.86f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 3.76f + 0.0f + 123.86f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.88f + 0.0f + 123.86f, 2.0f, "d"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 3.65f + 0.0f + 124.24f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.76f + 0.0f + 124.24f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.88f + 0.0f + 124.24f, 2.0f, "l"));
            //5/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 0.0f + 127.63f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 0.91f + 0.0f + 127.63f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.17f + 0.0f + 127.63f, 2.0f, "space"));
        
            input.Notes.Add(new Data.NoteInfo(true, 129.06f, 129.83f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 129.19f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 129.57f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 129.83f, 2.0f, "q"));

            //4com
            input.Notes.Add(new Data.NoteInfo(false, 11.90f + 118.71f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 12.03f + 118.71f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 12.16f + 118.71f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 12.29f + 118.71f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 131.26f, 2.0f, "j"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 3.65f + 0.0f + 127.86f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 3.76f + 0.0f + 127.86f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.88f + 0.0f + 127.86f, 2.0f, "d"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 3.65f + 0.0f + 128.25f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.76f + 0.0f + 128.25f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.88f + 0.0f + 128.25f, 2.0f, "l"));

            //5/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 0.0f + 131.77f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 0.91f + 0.0f + 131.77f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 1.17f + 0.0f + 131.77f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 1.43f + 0.0f + 131.77f, 134.23f, ";"));
            input.Notes.Add(new Data.NoteInfo(true, 134.23f, 134.49f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 134.49f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 134.62f, 2.0f, "d"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 3.65f + 0.0f + 131.1f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 3.76f + 0.0f + 131.1f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.88f + 0.0f + 131.1f, 2.0f, "f"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 3.65f + 0.0f + 131.48f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.76f + 0.0f + 131.48f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.88f + 0.0f + 131.48f, 2.0f, "space"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 3.65f + 0.0f + 131.87f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.76f + 0.0f + 131.87f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 3.88f + 0.0f + 131.87f, 2.0f, "j"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 3.65f + 0.0f + 132.26f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 3.76f + 0.0f + 132.26f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 3.88f + 0.0f + 132.26f, 136.43f, "k"));

            //5/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 0.0f + 135.91f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 0.91f + 0.0f + 135.91f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 1.17f + 0.0f + 135.91f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 1.43f + 0.0f + 135.91f, 138.37f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 137.33f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 137.85f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 138.11f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 138.37f, 2.0f, "space"));

            //4com
            input.Notes.Add(new Data.NoteInfo(false, 11.90f + 127.24f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 12.03f + 127.24f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 12.16f + 127.24f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 12.29f + 127.24f, 2.0f, "f"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 11.90f + 127.76f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 12.03f + 127.76f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 12.16f + 127.76f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 12.29f + 127.76f, 2.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(true, 140.18f, 140.57f, "d"));
            //5/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 0.0f + 140.04f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 0.91f + 0.0f + 140.04f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.17f + 0.0f + 140.04f, 2.0f, "k"));
            //5/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 0.0f + 140.82f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 0.65f + 0.0f + 140.82f, 142.63f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 0.91f + 0.0f + 140.82f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.17f + 0.0f + 140.82f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 142.76f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 142.89f, 2.0f, "d"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 3.65f + 0.0f + 139.5f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 3.76f + 0.0f + 139.5f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.88f + 0.0f + 139.5f, 2.0f, "j"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 3.65f + 0.0f + 139.89f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.76f + 0.0f + 139.89f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 3.88f + 0.0f + 139.89f, 2.0f, "f"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 3.65f + 0.0f + 140.28f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.76f + 0.0f + 140.28f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.88f + 0.0f + 140.28f, 2.0f, "j"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 3.65f + 0.0f + 140.67f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 3.76f + 0.0f + 140.67f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.88f + 0.0f + 140.67f, 2.0f, "s"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 3.65f + 0.0f + 141.05f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 3.76f + 0.0f + 141.05f, 146.38f, "k"));
            input.Notes.Add(new Data.NoteInfo(false,146.38f,0.2f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 146.90f, 0.2f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 147.16f, 0.2f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 147.29f, 0.2f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 147.55f, 0.2f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 147.94f, 0.2f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 148.19f, 0.2f, "space"));

            //4com
            input.Notes.Add(new Data.NoteInfo(false, 11.90f + 136.55f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 12.03f + 136.55f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 12.16f + 136.55f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 12.29f + 136.55f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(true, 149.10f, 149.88f, "f"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 3.65f + 0.0f + 146.36f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.76f + 0.0f + 146.36f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 3.88f + 0.0f + 146.36f, 150.78f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 150.78f, 149.88f, "space"));

            input.Notes.Add(new Data.NoteInfo(true, 151.04f, 152.07f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 151.30f, 154.66f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 152.59f, 154.66f, "l"));
            //

          
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