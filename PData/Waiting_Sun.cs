using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class Waiting_Sun : MonoBehaviour
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
        MusicInfo.key = 12;
        MusicInfo.name = "Waitig for the sun";
        MusicInfo.composer = "MindCube";
        MusicInfo.visualizer = "ENTIA J";
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
            input.Notes.Add(new Data.NoteInfo(true, 1.36f, 3.56f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.90f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 3.56f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 4.01f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 4.23f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 4.67f, 2.0f, "s"));
            //1st rythm
            input.Notes.Add(new Data.NoteInfo(false, 5.33f+0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 5.99f+0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 6.43f+0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 6.65f+0.00f, 2.0f, "k"));
            //1st rythm
            input.Notes.Add(new Data.NoteInfo(false, 5.33f + 1.76f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 5.55f + 1.76f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 5.99f + 1.76f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 6.43f + 1.76f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 6.65f + 1.76f, 2.0f, "s"));
            //1st rythm
            input.Notes.Add(new Data.NoteInfo(false, 5.33f + 3.53f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 5.55f + 3.53f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 5.99f + 3.53f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 6.43f + 3.53f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 6.65f + 3.53f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 10.40f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 10.62f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 11.06f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 11.28f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 11.73f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 12.17f, 2.0f, "d"));
            //1st rythm
            input.Notes.Add(new Data.NoteInfo(false, 5.33f + 7.06f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 5.55f + 7.06f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 5.99f + 7.06f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 6.43f + 7.06f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 6.65f + 7.06f, 2.0f, "f"));
            //1st rythm
            input.Notes.Add(new Data.NoteInfo(false, 5.33f + 8.82f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 5.55f + 8.82f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 5.99f + 8.82f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 6.43f + 8.82f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 6.65f + 8.82f, 2.0f, "j"));
            //1st rythm
            input.Notes.Add(new Data.NoteInfo(false, 5.33f + 10.59f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 5.55f + 10.59f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 5.99f + 10.59f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 6.43f + 10.59f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 6.65f + 10.59f, 2.0f, "j"));

            //1st base
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 17.68f+0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 18.12f+0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 18.56f+0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 19.00f+0.00f, 2.0f, "d"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 18.12f+0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 19.00f+0.00f, 2.0f, "k"));
            //
            input.Notes.Add(new Data.NoteInfo(false, 19.23f+0.00f, 2.0f, "j"));
            //1st base
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 17.68f + 1.77f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 18.12f + 1.77f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 18.56f + 1.77f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 19.00f + 1.77f, 2.0f, "k"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 18.12f + 1.77f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 19.00f + 1.77f, 2.0f, "d"));
            //
            input.Notes.Add(new Data.NoteInfo(false, 19.23f + 1.77f, 2.0f, "f"));
            //1st base
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 17.68f + 3.53f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 18.12f + 3.53f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 18.56f + 3.53f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 19.00f + 3.53f, 2.0f, "s"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 18.12f + 3.53f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 19.00f + 3.53f, 2.0f, "f"));
            //
            input.Notes.Add(new Data.NoteInfo(false, 19.23f + 3.53f, 2.0f, "d"));
            //1st base
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 17.68f + 5.3f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 18.12f + 5.3f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 18.56f + 5.3f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 19.00f + 5.3f, 2.0f, "j"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 18.12f + 5.3f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 19.00f + 5.3f, 2.0f, "l"));
            //
            input.Notes.Add(new Data.NoteInfo(false, 19.23f + 5.3f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 24.74f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 25.18f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 25.40f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 25.84f, 2.0f, "k"));
            //1st base
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 17.68f + 8.82f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 18.12f + 8.82f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 18.56f + 8.82f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 19.00f + 8.82f, 2.0f, "f"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 18.12f + 8.82f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 19.00f + 8.82f, 2.0f, "space"));

            //2nd rythm
            input.Notes.Add(new Data.NoteInfo(false, 28.27f+0.00f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 28.49f+0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 28.60f+0.00f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 28.93f+0.00f, 2.0f, "l"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 29.15f+0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 29.37f+0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 29.59f+0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 29.81f + 0.00f, 2.0f, "d"));
            //
            //2nd rythm
            input.Notes.Add(new Data.NoteInfo(false, 28.27f + 1.76f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 28.49f + 1.76f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 28.60f + 1.76f, 2.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 28.93f + 1.76f, 2.0f, "f"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 29.15f + 1.76f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 29.37f + 1.76f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 29.59f + 1.76f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 29.81f + 1.76f, 2.0f, "s"));
            //
            //2nd rythm
            input.Notes.Add(new Data.NoteInfo(false, 28.27f + 3.53f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 32.24f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 29.04f + 3.53f, 2.0f, "f"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 29.37f + 3.53f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 29.59f + 3.53f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 29.81f + 3.53f, 2.0f, "d"));
            //
            //2nd rythm
            input.Notes.Add(new Data.NoteInfo(false, 28.27f + 5.29f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 28.49f + 5.29f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 28.60f + 5.29f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 28.93f + 5.29f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 29.04f + 5.29f, 2.0f, "k"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 29.15f + 5.29f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 29.37f + 5.29f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 29.59f + 5.29f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 29.81f + 5.29f, 2.0f, "j"));
            //
            //2nd rythm
            input.Notes.Add(new Data.NoteInfo(false, 28.27f + 7.06f, 2.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 28.49f + 7.06f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 28.60f + 7.06f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 28.93f + 7.06f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 29.04f + 7.06f, 2.0f, "d"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 29.15f + 7.06f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 29.37f + 7.06f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 29.59f + 7.06f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 29.81f + 7.06f, 2.0f, "s"));
            //
            //2nd rythm
            input.Notes.Add(new Data.NoteInfo(false, 28.27f + 8.82f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 28.49f + 8.82f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 28.60f + 8.82f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(true, 28.93f + 8.82f, 37.97f, "j"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 29.15f + 8.82f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 29.37f + 8.82f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 29.59f + 8.82f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 29.81f + 8.82f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 38.86f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 39.30f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 39.52f, 2.0f, "space"));

            //2nd rythm
            input.Notes.Add(new Data.NoteInfo(false, 28.27f + 12.35f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 28.49f + 12.35f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 28.60f + 12.35f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 28.93f + 12.35f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 29.04f + 12.35f, 2.0f, "k"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 29.15f + 12.35f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 29.37f + 12.35f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 29.59f + 12.35f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 29.81f + 12.35f, 2.0f, "l"));
            //
            //2nd rythm
            input.Notes.Add(new Data.NoteInfo(false, 28.27f + 14.12f, 2.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 28.49f + 14.12f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 28.60f + 14.12f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 28.93f + 14.12f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 29.04f + 14.12f, 2.0f, "j"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 29.15f + 14.12f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 29.37f + 14.12f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 29.59f + 14.12f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 29.81f + 14.12f, 2.0f, "space"));
            //
            //2nd rythm
            input.Notes.Add(new Data.NoteInfo(false, 28.27f + 15.88f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 28.49f + 15.88f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 28.60f + 15.88f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 28.93f + 15.88f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 29.04f + 15.88f, 2.0f, "j"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 29.15f + 15.88f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 29.37f + 15.88f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 29.59f + 15.88f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 29.81f + 15.88f, 2.0f, "k"));
            //

            //
            input.Notes.Add(new Data.NoteInfo(false, 45.92f+0.00f, 2.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 46.14f+0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 46.36f+0.00f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 46.80f+0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 47.02f+0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 47.13f+0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 47.24f+0.00f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 47.46f+0.00f, 2.0f, "j"));
            //
            //3rd rush
            input.Notes.Add(new Data.NoteInfo(false, 47.68f + 0.00f, 2.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 47.90f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 48.12f + 0.00f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 48.56f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 48.67f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 49.00f + 0.00f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 49.22f + 0.00f, 2.0f, "k"));
            //input.Notes.Add(new Data.NoteInfo(false, 49.33f + 0.00f, 2.0f, "s"));
            //
            //3rd rush
            input.Notes.Add(new Data.NoteInfo(false, 47.68f + 1.76f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 47.90f + 1.76f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 48.12f + 1.76f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 48.56f + 1.76f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 48.67f + 1.76f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 49.00f + 1.76f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 49.22f + 1.76f, 2.0f, "d"));
            //input.Notes.Add(new Data.NoteInfo(false, 49.33f + 1.76f, 2.0f, "s"));
            //
            //3rd rush
            input.Notes.Add(new Data.NoteInfo(false, 47.68f + 3.53f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 47.90f + 3.53f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 48.12f + 3.53f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 48.56f + 3.53f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 48.67f + 3.53f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 49.00f + 3.53f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 49.22f + 3.53f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 49.33f + 3.53f, 2.0f, "k"));
            //
            //3rd rush
            input.Notes.Add(new Data.NoteInfo(false, 47.68f + 5.29f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 47.90f + 5.29f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 48.12f + 5.29f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 48.56f + 5.29f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 48.67f + 5.29f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 49.00f + 5.29f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 49.22f + 5.29f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 49.33f + 5.29f, 2.0f, "k"));
            //
            //3rd rush
            input.Notes.Add(new Data.NoteInfo(false, 47.68f + 7.06f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 47.90f + 7.06f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 48.12f + 7.06f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 48.56f + 7.06f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 48.67f + 7.06f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 49.00f + 7.06f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 49.22f + 7.06f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 49.33f + 7.06f, 2.0f, "j"));
            //
            //3rd rush
            input.Notes.Add(new Data.NoteInfo(false, 47.68f + 8.82f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 47.90f + 8.82f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 48.12f + 8.82f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 48.56f + 8.82f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 48.67f + 8.82f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 49.00f + 8.82f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 49.22f + 8.82f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 49.33f + 8.82f, 2.0f, "f"));
            //
            //3rd rush
            input.Notes.Add(new Data.NoteInfo(false, 47.68f + 10.59f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 47.90f + 10.59f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 48.12f + 10.59f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 48.56f + 10.59f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 48.67f + 10.59f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 49.00f + 10.59f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 49.22f + 10.59f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 49.33f + 10.59f, 2.0f, "l"));
            //
            input.Notes.Add(new Data.NoteInfo(true, 60.03f, 63.12f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 60.03f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 61.69f, 64.66f, "p"));

            input.Notes.Add(new Data.NoteInfo(false, 65.33f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 65.55f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 65.99f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 66.32f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(true, 66.65f, 68.86f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 68.86f, 70.62f, "s"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 29.15f + 37.94f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 29.37f + 37.94f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 29.59f + 37.94f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 29.81f + 37.94f, 2.0f, "f"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 29.15f + 38.82f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 29.37f + 38.82f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 29.59f + 38.82f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 29.81f + 38.82f, 2.0f, "f"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 29.15f + 39.71f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 29.37f + 39.71f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 29.59f + 39.71f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 29.81f + 39.71f, 2.0f, "k"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 29.15f + 40.59f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 29.37f + 40.59f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 29.59f + 40.59f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 29.81f + 40.59f, 2.0f, "k"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 70.62f+0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 70.73f+0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 70.84f+0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 70.95f+0.00f, 2.0f, "k"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 70.62f + 0.44f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 70.73f + 0.44f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 70.84f + 0.44f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 70.95f + 0.44f, 2.0f, "k"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 70.62f + 0.88f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 70.73f + 0.88f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 70.84f + 0.88f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 70.95f + 0.88f, 2.0f, "d"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 70.62f + 1.32f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 70.73f + 1.32f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 70.84f + 1.32f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 70.95f + 1.32f, 2.0f, "d"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 70.62f + 1.76f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 70.73f + 1.76f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 70.84f + 1.76f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 70.95f + 1.76f, 2.0f, "k"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 70.62f + 2.21f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 70.73f + 2.21f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 70.84f + 2.21f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 70.95f + 2.21f, 2.0f, "d"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 70.62f + 2.65f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 70.73f + 2.65f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 70.84f + 2.65f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 70.95f + 2.65f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 73.71f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 73.71f, 2.0f, "k"));

            //3rd rush
            input.Notes.Add(new Data.NoteInfo(false, 47.68f + 26.47f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 47.90f + 26.47f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 48.12f + 26.47f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 48.56f + 26.47f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 48.67f + 26.47f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 49.00f + 26.47f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 49.22f + 26.47f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 49.33f + 26.47f, 2.0f, "d"));
            //
            //3rd rush
            input.Notes.Add(new Data.NoteInfo(false, 47.68f + 28.23f, 2.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 47.90f + 28.23f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 48.12f + 28.23f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 48.56f + 28.23f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 48.67f + 28.23f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 49.00f + 28.23f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 49.22f + 28.23f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 49.33f + 28.23f, 2.0f, "k"));
            //
            //3rd rush
            input.Notes.Add(new Data.NoteInfo(false, 47.68f + 30.0f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 47.90f + 30.0f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 48.12f + 30.0f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 48.56f + 30.0f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 48.67f + 30.0f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 49.00f + 30.0f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 49.22f + 30.0f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 49.33f + 30.0f, 2.0f, "l"));
            //
            //3rd rush
            input.Notes.Add(new Data.NoteInfo(false, 47.68f + 31.76f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 47.90f + 31.76f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 48.12f + 31.76f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 48.56f + 31.76f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 48.67f + 31.76f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 49.00f + 31.76f, 2.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 49.22f + 31.76f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 49.33f + 31.76f, 2.0f, "d"));
            //
            //3rd rush
            input.Notes.Add(new Data.NoteInfo(false, 47.68f + 33.53f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 47.90f + 33.53f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 48.12f + 33.53f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 48.56f + 33.53f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 48.67f + 33.53f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 49.00f + 33.53f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 49.22f + 33.53f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 49.33f + 33.53f, 2.0f, "f"));
            //
            //3rd rush
            input.Notes.Add(new Data.NoteInfo(false, 47.68f + 35.29f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 47.90f + 35.29f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 48.12f + 35.29f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 48.56f + 35.29f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 48.67f + 35.29f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 49.00f + 35.29f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 49.22f + 35.29f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 49.33f + 35.29f, 2.0f, "k"));
            //
            //3rd rush
            input.Notes.Add(new Data.NoteInfo(false, 47.68f + 37.06f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 47.90f + 37.06f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 48.12f + 37.06f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 48.56f + 37.06f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 48.67f + 37.06f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 49.00f + 37.06f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 49.22f + 37.06f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 49.33f + 37.06f, 2.0f, "l"));
            //
            //3rd rush
            input.Notes.Add(new Data.NoteInfo(false, 47.68f + 38.82f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 47.90f + 38.82f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 48.12f + 38.82f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 48.56f + 38.82f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 48.67f + 38.82f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 49.00f + 38.82f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 49.22f + 38.82f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 49.33f + 38.82f, 2.0f, "k"));
            //
            //3rd rush
            input.Notes.Add(new Data.NoteInfo(false, 47.68f + 40.59f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 47.90f + 40.59f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 48.12f + 40.59f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 48.56f + 40.59f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 48.67f + 40.59f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 49.00f + 40.59f, 2.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 49.22f + 40.59f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 49.33f + 40.59f, 2.0f, "j"));
            //
            //3rd rush
            input.Notes.Add(new Data.NoteInfo(false, 47.68f + 42.35f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 47.90f + 42.35f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 48.12f + 42.35f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 48.56f + 42.35f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 48.67f + 42.35f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 49.00f + 42.35f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 49.22f + 42.35f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 49.33f + 42.35f, 2.0f, "k"));
            //
            //3rd rush
            input.Notes.Add(new Data.NoteInfo(false, 47.68f + 44.12f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 47.90f + 44.12f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 48.12f + 44.12f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 48.56f + 44.12f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 48.67f + 44.12f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 49.00f + 44.12f, 2.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 49.22f + 44.12f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 49.33f + 44.12f, 2.0f, "d"));
            //
            //3rd rush
            input.Notes.Add(new Data.NoteInfo(false, 47.68f + 45.88f, 2.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 47.90f + 45.88f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 48.12f + 45.88f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 48.56f + 45.88f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 48.67f + 45.88f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 49.00f + 45.88f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 49.22f + 45.88f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 49.33f + 45.88f, 2.0f, "d"));
            //
            //3rd rush
            input.Notes.Add(new Data.NoteInfo(false, 47.68f + 47.64f, 2.0f, "j"));
        
            input.Notes.Add(new Data.NoteInfo(false, 47.90f + 47.64f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 48.12f + 47.64f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 48.56f + 47.64f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 48.67f + 47.64f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 49.00f + 47.64f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 49.22f + 47.64f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 49.33f + 47.64f, 2.0f, "s"));
            //
            //3rd rush
            input.Notes.Add(new Data.NoteInfo(false, 47.68f + 49.41f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 47.90f + 49.41f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 48.12f + 49.41f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 48.56f + 49.41f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 48.67f + 49.41f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 49.00f + 49.41f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 49.22f + 49.41f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 49.33f + 49.41f, 2.0f, "d"));
            //
            //3rd rush
            input.Notes.Add(new Data.NoteInfo(false, 47.68f + 51.17f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 47.90f + 51.17f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 48.12f + 51.17f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 48.56f + 51.17f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 48.67f + 51.17f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 49.00f + 51.17f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 49.22f + 51.17f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 49.33f + 51.17f, 2.0f, "d"));
            //
            //3rd rush
            input.Notes.Add(new Data.NoteInfo(false, 47.68f + 52.94f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 47.90f + 52.94f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 48.12f + 52.94f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 48.56f + 52.94f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 48.67f + 52.94f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 49.00f + 52.94f, 2.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 49.22f + 52.94f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 49.33f + 52.94f, 2.0f, "d"));
            //
            input.Notes.Add(new Data.NoteInfo(false, 102.38f, 2.0f, "s"));

            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 18.12f + 70.59f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 19.00f + 70.59f, 2.0f, "space"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 18.12f + 72.35f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 19.00f + 72.35f, 2.0f, "space"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 18.12f + 74.12f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 19.00f + 74.12f, 2.0f, "space"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 18.12f + 75.88f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 19.00f + 75.88f, 2.0f, "space"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 18.12f + 77.65f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 19.00f + 77.65f, 2.0f, "space"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 18.12f + 79.41f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 19.00f + 79.41f, 2.0f, "space"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 18.12f + 81.17f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 19.00f + 81.17f, 2.0f, "space"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 18.12f + 82.94f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 19.00f + 82.94f, 2.0f, "space"));
        }
        else if (input.Difficulty.Equals("Hard"))
        {
            input.Notes.Add(new Data.NoteInfo(true, 1.36f, 3.56f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.90f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 3.56f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 4.01f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 4.23f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 4.67f, 2.0f, "s"));
            //hd 1 ry
            input.Notes.Add(new Data.NoteInfo(false, 3.78f + 0.00f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 3.90f + 0.00f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 4.45f + 0.00f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 4.67f + 0.00f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 4.89f + 0.00f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 5.11f + 0.00f, 2.0f, ";"));
            //hd 1 ry
            input.Notes.Add(new Data.NoteInfo(false, 3.78f + 1.77f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 3.90f + 1.77f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 4.45f + 1.77f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 4.67f + 1.77f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 4.89f + 1.77f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 5.11f + 1.77f, 2.0f, ";"));
            //hd 1 ry
            input.Notes.Add(new Data.NoteInfo(false, 3.78f + 3.53f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 3.90f + 3.53f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 4.45f + 3.53f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 4.67f + 3.53f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 4.89f + 3.53f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 5.11f + 3.53f, 2.0f, ";"));
            //hd 1 ry
            input.Notes.Add(new Data.NoteInfo(false, 3.78f + 5.30f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 3.90f + 5.30f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 4.45f + 5.30f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 4.67f + 5.30f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 4.89f + 5.30f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 5.11f + 5.30f, 2.0f, ";"));
            //hd 1 ry
            input.Notes.Add(new Data.NoteInfo(false, 3.78f + 7.06f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 3.90f + 7.06f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 4.45f + 7.06f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 4.67f + 7.06f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 4.89f + 7.06f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 5.11f + 7.06f, 2.0f, ";"));
            //hd 1 ry
            input.Notes.Add(new Data.NoteInfo(false, 3.78f + 8.83f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 3.90f + 8.83f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 4.45f + 8.83f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 4.67f + 8.83f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 4.89f + 8.83f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 5.11f + 8.83f, 2.0f, ";"));
            //hd 1 ry
            input.Notes.Add(new Data.NoteInfo(false, 3.78f + 10.59f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 3.90f + 10.59f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 4.45f + 10.59f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 4.67f + 10.59f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 4.89f + 10.59f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 5.11f + 10.59f, 2.0f, ";"));
            //hd 1 ry
            input.Notes.Add(new Data.NoteInfo(false, 3.78f + 12.36f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 3.90f + 12.36f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 4.45f + 12.36f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 4.67f + 12.36f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 4.89f + 12.36f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 5.11f + 12.36f, 2.0f, ";"));
            //1st rythm
            input.Notes.Add(new Data.NoteInfo(false, 5.33f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 5.99f + 0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 6.43f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 6.65f + 0.00f, 2.0f, "k"));
            //1st rythm
            input.Notes.Add(new Data.NoteInfo(false, 5.33f + 1.76f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 5.55f + 1.76f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 5.99f + 1.76f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 6.43f + 1.76f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 6.65f + 1.76f, 2.0f, "s"));
            //1st rythm
            input.Notes.Add(new Data.NoteInfo(false, 5.33f + 3.53f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 5.55f + 3.53f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 5.99f + 3.53f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 6.43f + 3.53f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 6.65f + 3.53f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 10.40f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 10.62f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 11.06f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 11.28f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 11.73f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 12.17f, 2.0f, "d"));
            //1st rythm
            input.Notes.Add(new Data.NoteInfo(false, 5.33f + 7.06f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 5.55f + 7.06f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 5.99f + 7.06f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 6.43f + 7.06f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 6.65f + 7.06f, 2.0f, "f"));
            //1st rythm
            input.Notes.Add(new Data.NoteInfo(false, 5.33f + 8.82f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 5.55f + 8.82f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 5.99f + 8.82f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 6.43f + 8.82f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 6.65f + 8.82f, 2.0f, "j"));
            //1st rythm
            input.Notes.Add(new Data.NoteInfo(false, 5.33f + 10.59f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 5.55f + 10.59f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 5.99f + 10.59f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 6.43f + 10.59f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 6.65f + 10.59f, 2.0f, "j"));

            //1st base
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 17.68f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 18.12f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 18.56f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 19.00f + 0.00f, 2.0f, "d"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 18.12f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 19.00f + 0.00f, 2.0f, "k"));
            //
            input.Notes.Add(new Data.NoteInfo(false, 19.23f + 0.00f, 2.0f, "j"));
            //1st base
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 17.68f + 1.77f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 18.12f + 1.77f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 18.56f + 1.77f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 19.00f + 1.77f, 2.0f, "k"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 18.12f + 1.77f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 19.00f + 1.77f, 2.0f, "d"));
            //
            input.Notes.Add(new Data.NoteInfo(false, 19.23f + 1.77f, 2.0f, "f"));
            //1st base
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 17.68f + 3.53f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 18.12f + 3.53f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 18.56f + 3.53f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 19.00f + 3.53f, 2.0f, "s"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 18.12f + 3.53f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 19.00f + 3.53f, 2.0f, "f"));
            //
            input.Notes.Add(new Data.NoteInfo(false, 19.23f + 3.53f, 2.0f, "d"));
            //1st base
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 17.68f + 5.3f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 18.12f + 5.3f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 18.56f + 5.3f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 19.00f + 5.3f, 2.0f, "j"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 18.12f + 5.3f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 19.00f + 5.3f, 2.0f, "l"));
            //
            input.Notes.Add(new Data.NoteInfo(false, 19.23f + 5.3f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 24.74f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 25.18f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 25.40f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 25.84f, 2.0f, "k"));
            //1st base
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 17.68f + 8.82f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 18.12f + 8.82f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 18.56f + 8.82f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 19.00f + 8.82f, 2.0f, "f"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 18.12f + 8.82f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 19.00f + 8.82f, 2.0f, "space"));
            //hard add
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 18.12f + 14.12f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 19.00f + 14.12f, 2.0f, "space"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 18.12f + 15.88f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 19.00f + 15.88f, 2.0f, "space"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 18.12f + 17.65f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 19.00f + 17.65f, 2.0f, "space"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 18.12f + 19.41f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 19.00f + 19.41f, 2.0f, "space"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 18.12f + 21.18f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 19.00f + 21.18f, 2.0f, "space"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 18.12f + 22.94f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 19.00f + 22.94f, 2.0f, "space"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 18.12f + 24.71f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 19.00f + 24.71f, 2.0f, "space"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 18.12f + 26.47f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 19.00f + 26.47f, 2.0f, "space"));

            //2nd rythm
            input.Notes.Add(new Data.NoteInfo(false, 28.27f + 0.00f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 28.49f + 0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 28.60f + 0.00f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 28.93f + 0.00f, 2.0f, "l"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 29.15f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 29.37f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 29.59f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 29.81f + 0.00f, 2.0f, "d"));
            //
            //2nd rythm
            input.Notes.Add(new Data.NoteInfo(false, 28.27f + 1.76f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 28.49f + 1.76f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 28.60f + 1.76f, 2.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 28.93f + 1.76f, 2.0f, "f"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 29.15f + 1.76f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 29.37f + 1.76f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 29.59f + 1.76f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 29.81f + 1.76f, 2.0f, "s"));
            //
            //2nd rythm
            input.Notes.Add(new Data.NoteInfo(false, 28.27f + 3.53f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 32.24f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 29.04f + 3.53f, 2.0f, "f"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 29.37f + 3.53f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 29.59f + 3.53f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 29.81f + 3.53f, 2.0f, "d"));
            //
            //2nd rythm
            input.Notes.Add(new Data.NoteInfo(false, 28.27f + 5.29f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 28.49f + 5.29f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 28.60f + 5.29f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 28.93f + 5.29f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 29.04f + 5.29f, 2.0f, "k"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 29.15f + 5.29f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 29.37f + 5.29f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 29.59f + 5.29f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 29.81f + 5.29f, 2.0f, "j"));
            //
            //2nd rythm
            input.Notes.Add(new Data.NoteInfo(false, 28.27f + 7.06f, 2.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 28.49f + 7.06f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 28.60f + 7.06f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 28.93f + 7.06f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 29.04f + 7.06f, 2.0f, "d"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 29.15f + 7.06f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 29.37f + 7.06f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 29.59f + 7.06f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 29.81f + 7.06f, 2.0f, "s"));
            //
            //2nd rythm
            input.Notes.Add(new Data.NoteInfo(false, 28.27f + 8.82f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 28.49f + 8.82f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 28.60f + 8.82f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(true, 28.93f + 8.82f, 37.97f, "j"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 29.15f + 8.82f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 29.37f + 8.82f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 29.59f + 8.82f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 29.81f + 8.82f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 38.86f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 39.30f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 39.52f, 2.0f, "space"));

            //2nd rythm
            input.Notes.Add(new Data.NoteInfo(false, 28.27f + 12.35f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 28.49f + 12.35f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 28.60f + 12.35f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 28.93f + 12.35f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 29.04f + 12.35f, 2.0f, "k"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 29.15f + 12.35f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 29.37f + 12.35f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 29.59f + 12.35f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 29.81f + 12.35f, 2.0f, "l"));
            //
            //2nd rythm
            input.Notes.Add(new Data.NoteInfo(false, 28.27f + 14.12f, 2.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 28.49f + 14.12f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 28.60f + 14.12f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 28.93f + 14.12f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 29.04f + 14.12f, 2.0f, "j"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 29.15f + 14.12f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 29.37f + 14.12f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 29.59f + 14.12f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 29.81f + 14.12f, 2.0f, "d"));
            //
            //2nd rythm
            input.Notes.Add(new Data.NoteInfo(false, 28.27f + 15.88f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 28.49f + 15.88f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 28.60f + 15.88f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 28.93f + 15.88f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 29.04f + 15.88f, 2.0f, "j"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 29.15f + 15.88f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 29.37f + 15.88f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 29.59f + 15.88f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 29.81f + 15.88f, 2.0f, "k"));
            //
            //hard add
            input.Notes.Add(new Data.NoteInfo(false, 45.92f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(true, 46.69f, 50.99f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 51.21f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 51.54f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 51.87f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 52.42f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(true, 52.75f, 55.84f, "a"));
            input.Notes.Add(new Data.NoteInfo(true, 56.28f, 59.15f, "p"));
            //
            input.Notes.Add(new Data.NoteInfo(false, 45.92f + 0.00f, 2.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 46.14f + 0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 46.36f + 0.00f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 46.80f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 47.02f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 47.13f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 47.24f + 0.00f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 47.46f + 0.00f, 2.0f, "j"));
            //
            //3rd rush
            input.Notes.Add(new Data.NoteInfo(false, 47.68f + 0.00f, 2.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 47.90f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 48.12f + 0.00f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 48.56f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 48.67f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 49.00f + 0.00f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 49.22f + 0.00f, 2.0f, "k"));
            //input.Notes.Add(new Data.NoteInfo(false, 49.33f + 0.00f, 2.0f, "s"));
            //
            //3rd rush
            input.Notes.Add(new Data.NoteInfo(false, 47.68f + 1.76f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 47.90f + 1.76f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 48.12f + 1.76f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 48.56f + 1.76f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 48.67f + 1.76f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 49.00f + 1.76f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 49.22f + 1.76f, 2.0f, "d"));
            //input.Notes.Add(new Data.NoteInfo(false, 49.33f + 1.76f, 2.0f, "s"));
            //
            //3rd rush
            input.Notes.Add(new Data.NoteInfo(false, 47.68f + 3.53f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 47.90f + 3.53f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 48.12f + 3.53f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 48.56f + 3.53f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 48.67f + 3.53f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 49.00f + 3.53f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 49.22f + 3.53f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 49.33f + 3.53f, 2.0f, "k"));
            //
            //3rd rush
            input.Notes.Add(new Data.NoteInfo(false, 47.68f + 5.29f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 47.90f + 5.29f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 48.12f + 5.29f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 48.56f + 5.29f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 48.67f + 5.29f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 49.00f + 5.29f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 49.22f + 5.29f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 49.33f + 5.29f, 2.0f, "k"));
            //
            //3rd rush
            input.Notes.Add(new Data.NoteInfo(false, 47.68f + 7.06f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 47.90f + 7.06f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 48.12f + 7.06f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 48.56f + 7.06f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 48.67f + 7.06f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 49.00f + 7.06f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 49.22f + 7.06f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 49.33f + 7.06f, 2.0f, "j"));
            //
            //3rd rush
            input.Notes.Add(new Data.NoteInfo(false, 47.68f + 8.82f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 47.90f + 8.82f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 48.12f + 8.82f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 48.56f + 8.82f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 48.67f + 8.82f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 49.00f + 8.82f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 49.22f + 8.82f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 49.33f + 8.82f, 2.0f, "f"));
            //
            //3rd rush
            input.Notes.Add(new Data.NoteInfo(false, 47.68f + 10.59f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 47.90f + 10.59f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 48.12f + 10.59f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 48.56f + 10.59f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 48.67f + 10.59f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 49.00f + 10.59f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 49.22f + 10.59f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 49.33f + 10.59f, 2.0f, "l"));
            //
            input.Notes.Add(new Data.NoteInfo(true, 60.03f, 63.12f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 60.03f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 61.69f, 64.66f, "p"));
            //3rd rush
            input.Notes.Add(new Data.NoteInfo(false, 47.68f + 12.35f, 2.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 47.90f + 12.35f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 48.12f + 12.35f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 48.56f + 12.35f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 48.67f + 12.35f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 49.00f + 12.35f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 49.22f + 12.35f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 49.33f + 12.35f, 2.0f, "s"));
            //3rd rush
            input.Notes.Add(new Data.NoteInfo(false, 47.68f + 14.12f, 2.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 47.90f + 14.12f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 48.12f + 14.12f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 48.56f + 14.12f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 48.67f + 14.12f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 49.00f + 14.12f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 49.22f + 14.12f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 49.33f + 14.12f, 2.0f, "s"));
            //3rd rush
            input.Notes.Add(new Data.NoteInfo(false, 47.68f + 15.88f, 2.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 47.90f + 15.88f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 48.12f + 15.88f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 48.56f + 15.88f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 48.67f + 15.88f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 49.00f + 15.88f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 49.22f + 15.88f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 49.33f + 15.88f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 65.33f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 65.55f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 65.99f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 66.32f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(true, 66.65f, 68.86f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 68.86f, 70.62f, "s"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 29.15f + 37.94f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 29.37f + 37.94f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 29.59f + 37.94f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 29.81f + 37.94f, 2.0f, "f"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 29.15f + 38.82f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 29.37f + 38.82f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 29.59f + 38.82f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 29.81f + 38.82f, 2.0f, "f"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 29.15f + 39.71f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 29.37f + 39.71f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 29.59f + 39.71f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 29.81f + 39.71f, 2.0f, "k"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 29.15f + 40.59f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 29.37f + 40.59f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 29.59f + 40.59f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 29.81f + 40.59f, 2.0f, "k"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 70.62f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 70.73f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 70.84f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 70.95f + 0.00f, 2.0f, "k"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 70.62f + 0.44f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 70.73f + 0.44f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 70.84f + 0.44f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 70.95f + 0.44f, 2.0f, "k"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 70.62f + 0.88f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 70.73f + 0.88f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 70.84f + 0.88f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 70.95f + 0.88f, 2.0f, "d"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 70.62f + 1.32f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 70.73f + 1.32f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 70.84f + 1.32f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 70.95f + 1.32f, 2.0f, "d"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 70.62f + 1.76f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 70.73f + 1.76f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 70.84f + 1.76f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 70.95f + 1.76f, 2.0f, "k"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 70.62f + 2.21f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 70.73f + 2.21f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 70.84f + 2.21f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 70.95f + 2.21f, 2.0f, "d"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 70.62f + 2.65f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 70.73f + 2.65f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 70.84f + 2.65f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 70.95f + 2.65f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 73.71f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 73.71f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(true, 73.71f, 74.15f, "q"));
            input.Notes.Add(new Data.NoteInfo(true, 74.15f, 75.91f, ";"));
            input.Notes.Add(new Data.NoteInfo(true, 75.91f, 77.68f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 79.44f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 79.66f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 80.10f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 80.55f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(true, 80.77f, 81.21f, "p"));
            input.Notes.Add(new Data.NoteInfo(true, 81.21f, 81.65f, "a"));
            input.Notes.Add(new Data.NoteInfo(true, 81.65f, 85.18f, ";"));
            //3rd rush
            input.Notes.Add(new Data.NoteInfo(false, 47.68f + 26.47f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 47.90f + 26.47f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 48.12f + 26.47f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 48.56f + 26.47f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 48.67f + 26.47f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 49.00f + 26.47f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 49.22f + 26.47f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 49.33f + 26.47f, 2.0f, "d"));
            //
            //3rd rush
            input.Notes.Add(new Data.NoteInfo(false, 47.68f + 28.23f, 2.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 47.90f + 28.23f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 48.12f + 28.23f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 48.56f + 28.23f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 48.67f + 28.23f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 49.00f + 28.23f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 49.22f + 28.23f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 49.33f + 28.23f, 2.0f, "k"));
            //
            //3rd rush
            input.Notes.Add(new Data.NoteInfo(false, 47.68f + 30.0f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 47.90f + 30.0f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 48.12f + 30.0f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 48.56f + 30.0f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 48.67f + 30.0f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 49.00f + 30.0f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 49.22f + 30.0f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 49.33f + 30.0f, 2.0f, "l"));
            //
            //3rd rush
            input.Notes.Add(new Data.NoteInfo(false, 47.68f + 31.76f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 47.90f + 31.76f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 48.12f + 31.76f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 48.56f + 31.76f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 48.67f + 31.76f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 49.00f + 31.76f, 2.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 49.22f + 31.76f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 49.33f + 31.76f, 2.0f, "d"));
            //
            //3rd rush
            input.Notes.Add(new Data.NoteInfo(false, 47.68f + 33.53f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 47.90f + 33.53f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 48.12f + 33.53f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 48.56f + 33.53f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 48.67f + 33.53f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 49.00f + 33.53f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 49.22f + 33.53f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 49.33f + 33.53f, 2.0f, "f"));
            //
            //3rd rush
            input.Notes.Add(new Data.NoteInfo(false, 47.68f + 35.29f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 47.90f + 35.29f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 48.12f + 35.29f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 48.56f + 35.29f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 48.67f + 35.29f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 49.00f + 35.29f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 49.22f + 35.29f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 49.33f + 35.29f, 2.0f, "k"));
            //
            //3rd rush
            input.Notes.Add(new Data.NoteInfo(false, 47.68f + 37.06f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 47.90f + 37.06f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 48.12f + 37.06f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 48.56f + 37.06f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 48.67f + 37.06f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 49.00f + 37.06f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 49.22f + 37.06f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 49.33f + 37.06f, 2.0f, "l"));
            //
            //3rd rush
            input.Notes.Add(new Data.NoteInfo(false, 47.68f + 38.82f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 47.90f + 38.82f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 48.12f + 38.82f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 48.56f + 38.82f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 48.67f + 38.82f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 49.00f + 38.82f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 49.22f + 38.82f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 49.33f + 38.82f, 2.0f, "k"));
            //
            //3rd rush
            input.Notes.Add(new Data.NoteInfo(false, 47.68f + 40.59f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 47.90f + 40.59f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 48.12f + 40.59f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 48.56f + 40.59f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 48.67f + 40.59f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 49.00f + 40.59f, 2.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 49.22f + 40.59f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 49.33f + 40.59f, 2.0f, "j"));
            //
            //3rd rush
            input.Notes.Add(new Data.NoteInfo(false, 47.68f + 42.35f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 47.90f + 42.35f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 48.12f + 42.35f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 48.56f + 42.35f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 48.67f + 42.35f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 49.00f + 42.35f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 49.22f + 42.35f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 49.33f + 42.35f, 2.0f, "k"));
            //
            //3rd rush
            input.Notes.Add(new Data.NoteInfo(false, 47.68f + 44.12f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 47.90f + 44.12f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 48.12f + 44.12f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 48.56f + 44.12f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 48.67f + 44.12f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 49.00f + 44.12f, 2.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 49.22f + 44.12f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 49.33f + 44.12f, 2.0f, "d"));
            //
            //3rd rush
            input.Notes.Add(new Data.NoteInfo(false, 47.68f + 45.88f, 2.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 47.90f + 45.88f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 48.12f + 45.88f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 48.56f + 45.88f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 48.67f + 45.88f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 49.00f + 45.88f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 49.22f + 45.88f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 49.33f + 45.88f, 2.0f, "d"));
            //
            //3rd rush
            input.Notes.Add(new Data.NoteInfo(false, 47.68f + 47.64f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 47.90f + 47.64f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 48.12f + 47.64f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 48.56f + 47.64f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 48.67f + 47.64f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 49.00f + 47.64f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 49.22f + 47.64f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 49.33f + 47.64f, 2.0f, "s"));
            //
            //3rd rush
            input.Notes.Add(new Data.NoteInfo(false, 47.68f + 49.41f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 47.90f + 49.41f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 48.12f + 49.41f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 48.56f + 49.41f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 48.67f + 49.41f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 49.00f + 49.41f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 49.22f + 49.41f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 49.33f + 49.41f, 2.0f, "d"));
            //
            //3rd rush
            input.Notes.Add(new Data.NoteInfo(false, 47.68f + 51.17f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 47.90f + 51.17f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 48.12f + 51.17f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 48.56f + 51.17f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 48.67f + 51.17f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 49.00f + 51.17f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 49.22f + 51.17f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 49.33f + 51.17f, 2.0f, "d"));
            //
            //3rd rush
            input.Notes.Add(new Data.NoteInfo(false, 47.68f + 52.94f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 47.90f + 52.94f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 48.12f + 52.94f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 48.56f + 52.94f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 48.67f + 52.94f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 49.00f + 52.94f, 2.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 49.22f + 52.94f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 49.33f + 52.94f, 2.0f, "d"));
            //
            input.Notes.Add(new Data.NoteInfo(false, 102.38f, 2.0f, "s"));

            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 18.12f + 70.59f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 19.00f + 70.59f, 2.0f, "space"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 18.12f + 72.35f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 19.00f + 72.35f, 2.0f, "space"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 18.12f + 74.12f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 19.00f + 74.12f, 2.0f, "space"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 18.12f + 75.88f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 19.00f + 75.88f, 2.0f, "space"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 18.12f + 77.65f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 19.00f + 77.65f, 2.0f, "space"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 18.12f + 79.41f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 19.00f + 79.41f, 2.0f, "space"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 18.12f + 81.17f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 19.00f + 81.17f, 2.0f, "space"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 18.12f + 82.94f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 19.00f + 82.94f, 2.0f, "space"));
        }
        else if (input.Difficulty.Equals("Extreme"))
        {
            input.Notes.Add(new Data.NoteInfo(false, 0.0f, 2.0f, "s"));
        }
    }
}
