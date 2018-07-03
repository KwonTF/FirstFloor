using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class Nothing_Else : MonoBehaviour {

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
        MusicInfo.key = 14;
        MusicInfo.name = "Nothing Else";
        MusicInfo.composer = "Diesel Eater";
        MusicInfo.visualizer = "PEENA";
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
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 0.00f, 2.0f, "d"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 1.93f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 1.93f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 1.93f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 1.93f, 2.0f, "j"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 3.85f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 3.85f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 3.85f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 3.85f, 2.0f, "s"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 5.77f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 5.77f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 5.77f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 5.77f, 2.0f, "l"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 7.69f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 7.69f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 7.69f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 7.69f, 2.0f, "k"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 9.61f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 9.61f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 9.61f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 9.61f, 2.0f, "s"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 11.53f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 11.53f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 11.53f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 11.53f, 2.0f, "f"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 13.45f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 13.45f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 13.45f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 13.45f, 2.0f, "d"));

            //1st cyndi
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 0.00f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 15.85f + 0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 16.09f + 0.00f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 16.45f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 16.57f + 0.00f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 16.81f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 17.05f + 0.00f, 2.0f, "l"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 1.92f + 0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 1.92f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 1.92f + 0.00f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 17.77f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 18.01f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 18.13f + 0.00f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 18.37f + 0.00f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 18.61f + 0.00f, 2.0f, "k"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 3.36f + 0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 3.36f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 3.36f + 0.00f, 2.0f, "j"));
            //

            //1st cyndi
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 3.84f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 3.84f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 3.84f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 15.85f + 3.84f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 16.09f + 3.84f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 16.45f + 3.84f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 16.57f + 3.84f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 16.81f + 3.84f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 17.05f + 3.84f, 2.0f, "l"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 1.92f + 3.84f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 1.92f + 3.84f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 1.92f + 3.84f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 17.77f + 3.84f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 18.01f + 3.84f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 18.13f + 3.84f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 18.37f + 3.84f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 18.61f + 3.84f, 2.0f, "k"));
        
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 3.36f + 3.84f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 3.36f + 3.84f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 3.36f + 3.84f, 2.0f, "j"));
            //

            //1st cyndi
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 7.68f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 7.68f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 7.68f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 15.85f + 7.68f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 16.09f + 7.68f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 16.45f + 7.68f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 16.57f + 7.68f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 16.81f + 7.68f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 17.05f + 7.68f, 2.0f, "l"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 1.92f + 7.68f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 1.92f + 7.68f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 1.92f + 7.68f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 17.77f + 7.68f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 18.01f + 7.68f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 18.13f + 7.68f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 18.37f + 7.68f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 18.61f + 7.68f, 2.0f, "k"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 3.36f + 7.68f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 3.36f + 7.68f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 3.36f + 7.68f, 2.0f, "j"));
            //

            //1st cyndi
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 11.52f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 11.52f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 11.52f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 15.85f + 11.52f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 16.09f + 11.52f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 16.45f + 11.52f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 16.57f + 11.52f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 16.81f + 11.52f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 17.05f + 11.52f, 2.0f, "l"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 1.92f + 11.52f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 1.92f + 11.52f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 1.92f + 11.52f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 17.77f + 11.52f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 18.01f + 11.52f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 18.13f + 11.52f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 18.37f + 11.52f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 18.61f + 11.52f, 2.0f, "k"));
            //

            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 0.00f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 0.00f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 0.00f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 30.61f + 0.00f, 2.0f, "a"));

            input.Notes.Add(new Data.NoteInfo(true, 28.81f, 29.89f, "space"));

            //2nd cyndi
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 15.36f+0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 15.36f+0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 15.36f+0.00f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 31.21f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 31.45f + 0.00f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 31.81f + 0.00f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 31.93f + 0.00f, 2.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 32.17f + 0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 32.41f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 32.53f + 0.00f, 2.0f, "d"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 17.28f+0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 17.28f+0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 17.28f+0.00f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 33.13f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 33.37f + 0.00f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 33.49f + 0.00f, 2.0f, "l"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 18.36f+0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 18.36f+0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 18.36f+0.00f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 34.09f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 34.33f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 34.45f + 0.00f, 2.0f, "d"));

            //2nd cyndi
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 15.36f + 3.84f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 15.36f + 3.84f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 15.36f + 3.84f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 31.21f + 3.84f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 31.45f + 3.84f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 31.81f + 3.84f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 31.93f + 3.84f, 2.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 32.17f + 3.84f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 32.41f + 3.84f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 32.53f + 3.84f, 2.0f, "d"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 17.28f + 3.84f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 17.28f + 3.84f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 17.28f + 3.84f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 33.13f + 3.84f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 33.37f + 3.84f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 33.49f + 3.84f, 2.0f, "l"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 18.36f + 3.84f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 18.36f + 3.84f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 18.36f + 3.84f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 34.09f + 3.84f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 34.33f + 3.84f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 34.45f + 3.84f, 2.0f, "d"));

            //2nd cyndi
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 15.36f + 7.68f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 15.36f + 7.68f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 15.36f + 7.68f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 31.21f + 7.68f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 31.45f + 7.68f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 31.81f + 7.68f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 31.93f + 7.68f, 2.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 32.17f + 7.68f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 32.41f + 7.68f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 32.53f + 7.68f, 2.0f, "d"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 17.28f + 7.68f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 17.28f + 7.68f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 17.28f + 7.68f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 33.13f + 7.68f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 33.37f + 7.68f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 33.49f + 7.68f, 2.0f, "l"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 18.36f + 7.68f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 18.36f + 7.68f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 18.36f + 7.68f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 34.09f + 7.68f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 34.33f + 7.68f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 34.45f + 7.68f, 2.0f, "d"));

            //2nd cyndi
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 15.36f + 11.52f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 15.36f + 11.52f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 15.36f + 11.52f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 31.21f + 11.52f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 31.45f + 11.52f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 31.81f + 11.52f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 31.93f + 11.52f, 2.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 32.17f + 11.52f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 32.41f + 11.52f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 32.53f + 11.52f, 2.0f, "d"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 17.28f + 11.52f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 17.28f + 11.52f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 17.28f + 11.52f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 33.13f + 11.52f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 33.37f + 11.52f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 33.49f + 11.52f, 2.0f, "l"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 18.36f + 11.52f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 18.36f + 11.52f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 18.36f + 11.52f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 34.09f + 11.52f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 34.33f + 11.52f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 34.45f + 11.52f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(true, 44.17f, 45.97f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 45.97f, 2.0f, ";"));

            //3rd cyndi
            input.Notes.Add(new Data.NoteInfo(false, 46.33f + 0.00f, 2.0f, "k"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 31.2f + 0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 31.2f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 31.2f + 0.00f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 47.05f + 0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 47.29f + 0.00f, 2.0f, "k"));

            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 17.28f + 0.00f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 17.28f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 17.28f + 0.00f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 30.61f + 17.28f + 0.00f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 48.01f + 0.00f, 2.0f, "d"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 48.25f + 0.00f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 48.49f + 0.00f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 48.73f + 0.00f + 0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 48.97f + 0.00f + 0.00f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 49.45f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 49.69f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 49.81f + 0.00f, 2.0f, "f"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 48.25f + 1.92f + 0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 48.49f + 1.92f + 0.00f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 48.73f + 1.92f + 0.00f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(true, 50.89f + 0.00f, 51.13f + 0.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 51.25f + 0.00f, 51.49f + 0.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 51.61f + 0.00f, 51.85f + 0.00f, "d"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 36.72f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 36.72f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 36.72f + 0.00f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 52.57f + 0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 52.81f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 53.17f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 53.53f + 0.00f, 2.0f, "f"));
            ///
            input.Notes.Add(new Data.NoteInfo(false, 53.77f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 53.89f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.13f + 0.00f, 2.0f, "j"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 39.0f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 39.0f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 39.0f + 0.00f, 2.0f, "s"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 39.36f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 39.36f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 39.36f + 0.00f, 2.0f, "k"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 39.72f + 0.00f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 39.72f + 0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 55.45f + 0.00f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 55.69f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 55.81f + 0.00f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 56.05f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 56.17f + 0.00f, 2.0f, "f"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 41.04f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 41.04f + 0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 41.04f + 0.00f, 2.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 57.01f + 0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 57.37f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 57.73f + 0.00f, 2.0f, "k"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 42.72f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 42.72f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 42.72f + 0.00f, 2.0f, "d"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 43.08f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 43.08f + 0.00f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 58.93f + 0.00f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 59.29f + 0.00f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 59.77f + 0.00f, 2.0f, "s"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 44.64f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 44.64f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 44.64f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 60.49f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 60.85f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 61.21f + 0.00f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(true, 59.53f, 61.63f, "space"));

            //3rd cyndi
            input.Notes.Add(new Data.NoteInfo(false, 46.33f + 15.36f, 2.0f, "k"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 31.2f + 15.36f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 31.2f + 15.36f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 31.2f + 15.36f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 47.05f + 15.36f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 47.29f + 15.36f, 2.0f, "k"));

            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 17.28f + 15.36f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 17.28f + 15.36f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 17.28f + 15.36f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 30.61f + 17.28f + 15.36f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 48.01f + 15.36f, 2.0f, "d"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 48.25f + 15.36f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 48.49f + 15.36f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 48.73f + 15.36f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 48.97f + 15.36f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 49.45f + 15.36f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 49.69f + 15.36f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 49.81f + 15.36f, 2.0f, "f"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 48.25f + 1.92f + 15.36f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 48.49f + 1.92f + 15.36f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 48.73f + 1.92f + 15.36f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(true, 50.89f + 15.36f, 51.13f + 15.36f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 51.25f + 15.36f, 51.49f + 15.36f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 51.61f + 15.36f, 51.85f + 15.36f, "d"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 36.72f + 15.36f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 36.72f + 15.36f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 36.72f + 15.36f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 52.57f + 15.36f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 52.81f + 15.36f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 53.17f + 15.36f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 53.53f + 15.36f, 2.0f, "f"));
            ///
            input.Notes.Add(new Data.NoteInfo(false, 53.77f + 15.36f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 53.89f + 15.36f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.13f + 15.36f, 2.0f, "j"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 39.0f + 15.36f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 39.0f + 15.36f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 39.0f + 15.36f, 2.0f, "s"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 39.36f + 15.36f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 39.36f + 15.36f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 39.36f + 15.36f, 2.0f, "k"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 39.72f + 15.36f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 39.72f + 15.36f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 55.45f + 15.36f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 55.69f + 15.36f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 55.81f + 15.36f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 56.05f + 15.36f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 56.17f + 15.36f, 2.0f, "f"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 41.04f + 15.36f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 41.04f + 15.36f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 41.04f + 15.36f, 2.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 57.01f + 15.36f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 57.37f + 15.36f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 57.73f + 15.36f, 2.0f, "k"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 42.72f + 15.36f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 42.72f + 15.36f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 42.72f + 15.36f, 2.0f, "d"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 43.08f + 15.36f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 43.08f + 15.36f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 58.93f + 15.36f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 59.29f + 15.36f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 59.77f + 15.36f, 2.0f, "s"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 44.64f + 15.36f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 44.64f + 15.36f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 44.64f + 15.36f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 60.49f + 15.36f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 60.85f + 15.36f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 61.21f + 15.36f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(true, 74.89f, 76.69f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 76.81f, 2.0f, ";"));
            //
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 46.56f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 46.56f, 2.0f, "f"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 46.92f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 46.92f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 46.92f, 2.0f, "d"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 47.4f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 47.4f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 47.4f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 30.61f + 47.4f, 2.0f, "f"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 48.0f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 48.0f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 48.0f, 2.0f, "d"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 48.48f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 48.48f, 2.0f, "f"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 48.84f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 48.84f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 48.84f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.61f + 48.84f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 79.57f, 2.0f, "j"));

            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 49.56f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 49.56f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 49.56f, 2.0f, "d"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 50.04f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 50.04f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 50.04f, 2.0f, "f"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 50.52f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 50.52f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 50.52f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 30.61f + 50.52f, 2.0f, "d"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 51.12f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 51.12f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 51.12f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 30.61f + 51.12f, 2.0f, "j"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 51.72f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 51.72f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 51.72f, 2.0f, "d"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 52.2f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 52.2f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 52.2f, 2.0f, "k"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 52.68f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 52.68f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 52.68f, 2.0f, "s"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 53.16f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 53.16f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 53.16f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.61f + 53.16f, 2.0f, "f"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 53.76f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 53.76f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 53.76f, 2.0f, "d"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 54.24f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 54.24f, 2.0f, "k"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 54.6f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 54.6f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 54.6f, 2.0f, "d"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 54.96f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 54.96f, 2.0f, "j"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 55.32f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 55.32f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 55.32f, 2.0f, "d"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 55.8f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 55.8f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 55.8f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 30.61f + 55.8f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 86.53f, 2.0f, "k"));

            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 56.52f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 56.52f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 56.52f, 2.0f, "k"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 56.88f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 56.88f, 2.0f, "d"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 57.24f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 57.24f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 57.24f, 2.0f, "f"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 57.6f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 57.6f, 2.0f, "l"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 57.96f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 57.96f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 57.96f, 2.0f, "l"));

            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 58.44f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 58.44f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 58.44f, 2.0f, "j"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 58.92f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 58.92f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 58.92f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.61f + 58.92f, 2.0f, "j"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 59.52f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 59.52f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 59.52f, 2.0f, "l"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 60.0f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 60.0f, 2.0f, "k"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 60.36f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 60.36f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 60.36f, 2.0f, "f"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 60.84f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 60.84f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 60.84f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 30.61f + 60.84f, 2.0f, "k"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 61.44f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 61.44f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 61.44f, 2.0f, "d"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 61.92f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 61.92f, 2.0f, "k"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 62.28f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 62.28f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 62.28f, 2.0f, "k"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 62.76f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 62.76f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 62.76f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 30.61f + 62.76f, 2.0f, "f"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 63.36f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 63.36f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 63.36f, 2.0f, "j"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 63.84f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 63.84f, 2.0f, "f"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 64.2f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 64.2f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 64.2f, 2.0f, "s"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 64.68f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 64.68f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 64.68f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 30.61f + 64.68f, 2.0f, "s"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 65.28f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 65.28f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 65.28f, 2.0f, "s"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 65.64f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 65.64f, 2.0f, "f"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 66.0f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 66.0f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 66.0f, 2.0f, "s"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 66.48f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 66.48f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 66.48f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.61f + 66.48f, 2.0f, "j"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 67.08f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 67.08f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 67.08f, 2.0f, "l"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 67.68f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 67.68f, 2.0f, "f"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 68.04f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 68.04f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 68.04f, 2.0f, "d"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 68.52f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 68.52f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 68.52f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.61f + 68.52f, 2.0f, "f"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 69.12f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 69.12f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 69.12f, 2.0f, "d"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 69.6f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 69.6f, 2.0f, "j"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 69.96f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 69.96f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 69.96f, 2.0f, "j"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 70.44f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 70.44f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 70.44f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.61f + 70.44f, 2.0f, "j"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 71.04f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 71.04f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 71.04f, 2.0f, "k"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 71.52f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 71.52f, 2.0f, "d"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 71.88f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 71.88f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 71.88f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.61f + 71.88f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 102.61f, 2.0f, "f"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 72.6f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 72.6f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 72.6f, 2.0f, "s"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 73.08f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 73.08f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 73.08f, 2.0f, "f"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 73.44f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 73.44f, 2.0f, "k"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 73.8f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 73.8f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 73.8f, 2.0f, "l"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 74.28f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 74.28f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 74.28f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.61f + 74.28f, 2.0f, "l"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 74.88f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 74.88f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 74.88f, 2.0f, "f"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 75.36f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 75.36f, 2.0f, "d"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 75.72f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 75.72f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 75.72f, 2.0f, "j"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 76.2f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 76.2f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 76.2f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.61f + 76.2f, 2.0f, "j"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 76.8f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 76.8f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 76.8f, 2.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(true, 105.61f, 107.41f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 107.53f, 2.0f, "a"));

            //3rd cyndi
            input.Notes.Add(new Data.NoteInfo(false, 46.33f + 61.44f, 2.0f, "k"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 31.2f + 61.44f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 31.2f + 61.44f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 31.2f + 61.44f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 47.05f + 61.44f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 47.29f + 61.44f, 2.0f, "k"));

            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 17.28f + 61.44f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 17.28f + 61.44f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 17.28f + 61.44f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 30.61f + 17.28f + 61.44f, 2.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 48.01f + 61.44f, 2.0f, "d"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 48.25f + 61.44f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 48.49f + 61.44f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 48.73f + 61.44f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 48.97f + 61.44f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 49.45f + 61.44f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 49.69f + 61.44f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 49.81f + 61.44f, 2.0f, "f"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 48.25f + 1.92f + 61.44f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 48.49f + 1.92f + 61.44f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 48.73f + 1.92f + 61.44f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(true, 50.89f + 61.44f, 51.13f + 61.44f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 51.25f + 61.44f, 51.49f + 61.44f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 51.61f + 61.44f, 51.85f + 61.44f, "d"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 36.72f + 61.44f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 36.72f + 61.44f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 36.72f + 61.44f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 52.57f + 61.44f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 52.81f + 61.44f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 53.17f + 61.44f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 53.53f + 61.44f, 2.0f, "f"));
            ///
            input.Notes.Add(new Data.NoteInfo(false, 53.77f + 61.44f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 53.89f + 61.44f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.13f + 61.44f, 2.0f, "j"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 39.0f + 61.44f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 39.0f + 61.44f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 39.0f + 61.44f, 2.0f, "s"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 39.36f + 61.44f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 39.36f + 61.44f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 39.36f + 61.44f, 2.0f, "k"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 39.72f + 61.44f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 39.72f + 61.44f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 55.45f + 61.44f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 55.69f + 61.44f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 55.81f + 61.44f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 56.05f + 61.44f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 56.17f + 61.44f, 2.0f, "f"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 41.04f + 61.44f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 41.04f + 61.44f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 41.04f + 61.44f, 2.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 57.01f + 61.44f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 57.37f + 61.44f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 57.73f + 61.44f, 2.0f, "k"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 42.72f + 61.44f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 42.72f + 61.44f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 42.72f + 61.44f, 2.0f, "d"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 43.08f + 61.44f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 43.08f + 61.44f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 58.93f + 61.44f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 59.29f + 61.44f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 59.77f + 61.44f, 2.0f, "s"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 44.64f + 61.44f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 44.64f + 61.44f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 44.64f + 61.44f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 60.49f + 61.44f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 60.85f + 61.44f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 61.21f + 61.44f, 2.0f, "j"));

            //
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 108.01f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 108.01f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 108.01f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 108.01f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 109.93f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 109.93f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 109.93f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 109.93f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 111.85f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 111.85f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 111.85f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 111.85f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 113.77f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 113.77f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 113.77f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 113.77f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 115.69f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 115.69f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 115.69f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 115.69f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 117.61f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 117.61f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 117.61f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 117.61f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 119.53f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 119.53f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 119.53f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 1.45f + 119.53f, 122.77f, "space"));
            //3rd cyndi
            input.Notes.Add(new Data.NoteInfo(false, 46.33f + 76.8f, 2.0f, "k"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 31.2f + 76.8f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 31.2f + 76.8f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 31.2f + 76.8f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 47.05f + 76.8f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 47.29f + 76.8f, 2.0f, "k"));

            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 17.28f + 76.8f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 17.28f + 76.8f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 17.28f + 76.8f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 30.61f + 17.28f + 76.8f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 48.01f + 76.8f, 2.0f, "d"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 48.25f + 76.8f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 48.49f + 76.8f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 48.73f + 76.8f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 48.97f + 76.8f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 49.45f + 76.8f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 49.69f + 76.8f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 49.81f + 76.8f, 2.0f, "f"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 48.25f + 1.92f + 76.8f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 48.49f + 1.92f + 76.8f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 48.73f + 1.92f + 76.8f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(true, 50.89f + 76.8f, 51.13f + 76.8f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 51.25f + 76.8f, 51.49f + 76.8f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 51.61f + 76.8f, 51.85f + 76.8f, "d"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 36.72f + 76.8f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 36.72f + 76.8f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 36.72f + 76.8f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 52.57f + 76.8f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 52.81f + 76.8f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 53.17f + 76.8f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 53.53f + 76.8f, 2.0f, "f"));
            ///
            input.Notes.Add(new Data.NoteInfo(false, 53.77f + 76.8f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 53.89f + 76.8f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.13f + 76.8f, 2.0f, "j"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 39.0f + 76.8f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 39.0f + 76.8f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 39.0f + 76.8f, 2.0f, "s"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 39.36f + 76.8f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 39.36f + 76.8f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 39.36f + 76.8f, 2.0f, "k"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 39.72f + 76.8f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 39.72f + 76.8f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 55.45f + 76.8f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 55.69f + 76.8f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 55.81f + 76.8f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 56.05f + 76.8f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 56.17f + 76.8f, 2.0f, "f"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 41.04f + 76.8f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 41.04f + 76.8f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 41.04f + 76.8f, 2.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 57.01f + 76.8f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 57.37f + 76.8f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 57.73f + 76.8f, 2.0f, "k"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 42.72f + 76.8f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 42.72f + 76.8f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 42.72f + 76.8f, 2.0f, "d"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 43.08f + 76.8f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 43.08f + 76.8f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 58.93f + 76.8f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 59.29f + 76.8f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 59.77f + 76.8f, 2.0f, "s"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 44.64f + 76.8f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 44.64f + 76.8f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 44.64f + 76.8f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 60.49f + 76.8f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 60.85f + 76.8f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 61.21f + 76.8f, 2.0f, "j"));
        }
        else if (input.Difficulty.Equals("Hard"))
        {
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 0.00f, 2.0f, "d"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 0.25f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 0.25f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 0.25f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 0.25f, 2.0f, "l"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 1.93f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 1.93f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 1.93f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 1.93f, 2.0f, "j"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 2.17f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 2.17f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 2.17f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 2.17f, 2.0f, "f"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 3.85f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 3.85f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 3.85f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 3.85f, 2.0f, "s"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 4.09f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 4.09f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 4.09f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 4.09f, 2.0f, "k"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 5.77f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 5.77f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 5.77f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 5.77f, 2.0f, "l"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 6.01f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 6.01f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 6.01f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 6.01f, 2.0f, "d"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 7.69f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 7.69f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 7.69f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 7.69f, 2.0f, "k"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 7.93f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 7.93f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 7.93f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 7.93f, 2.0f, "f"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 9.61f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 9.61f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 9.61f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 9.61f, 2.0f, "s"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 9.85f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 9.85f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 9.85f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 9.85f, 2.0f, "k"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 11.53f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 11.53f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 11.53f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 11.53f, 2.0f, "f"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 11.77f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 11.77f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 11.77f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 11.77f, 2.0f, "l"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 13.45f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 13.45f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 13.45f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 13.45f, 2.0f, "d"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 13.69f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 13.69f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 13.69f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 13.69f, 2.0f, "j"));
            //
            //hard drum
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 15.37f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 15.37f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 15.37f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 17.29f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 17.29f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 17.29f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 19.21f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 19.21f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 19.21f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 21.13f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 21.13f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 21.13f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 23.05f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 23.05f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 23.05f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 24.97f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 24.97f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 24.97f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 26.89f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 26.89f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 26.89f, 2.0f, "space"));
            //1st cyndi
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 0.00f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 15.85f + 0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 16.09f + 0.00f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 16.45f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 16.57f + 0.00f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 16.81f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 17.05f + 0.00f, 2.0f, "l"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 1.92f + 0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 1.92f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 1.92f + 0.00f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 17.77f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 18.01f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 18.13f + 0.00f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 18.37f + 0.00f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 18.61f + 0.00f, 2.0f, "k"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 3.36f + 0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 3.36f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 3.36f + 0.00f, 2.0f, "j"));
            //

            //1st cyndi
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 3.84f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 3.84f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 3.84f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 15.85f + 3.84f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 16.09f + 3.84f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 16.45f + 3.84f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 16.57f + 3.84f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 16.81f + 3.84f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 17.05f + 3.84f, 2.0f, "l"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 1.92f + 3.84f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 1.92f + 3.84f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 1.92f + 3.84f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 17.77f + 3.84f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 18.01f + 3.84f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 18.13f + 3.84f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 18.37f + 3.84f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 18.61f + 3.84f, 2.0f, "k"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 3.36f + 3.84f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 3.36f + 3.84f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 3.36f + 3.84f, 2.0f, "j"));
            //

            //1st cyndi
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 7.68f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 7.68f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 7.68f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 15.85f + 7.68f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 16.09f + 7.68f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 16.45f + 7.68f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 16.57f + 7.68f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 16.81f + 7.68f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 17.05f + 7.68f, 2.0f, "l"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 1.92f + 7.68f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 1.92f + 7.68f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 1.92f + 7.68f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 17.77f + 7.68f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 18.01f + 7.68f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 18.13f + 7.68f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 18.37f + 7.68f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 18.61f + 7.68f, 2.0f, "k"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 3.36f + 7.68f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 3.36f + 7.68f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 3.36f + 7.68f, 2.0f, "j"));
            //

            //1st cyndi
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 11.52f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 11.52f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 11.52f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 15.85f + 11.52f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 16.09f + 11.52f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 16.45f + 11.52f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 16.57f + 11.52f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 16.81f + 11.52f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 17.05f + 11.52f, 2.0f, "l"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 1.92f + 11.52f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 1.92f + 11.52f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 1.92f + 11.52f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 17.77f + 11.52f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 18.01f + 11.52f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 18.13f + 11.52f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 18.37f + 11.52f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 18.61f + 11.52f, 2.0f, "k"));
            //

            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 0.00f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 0.00f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 0.00f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 30.61f + 0.00f, 2.0f, "a"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.61f + 0.00f, 2.0f, "d"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 30.61f + 0.00f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 28.81f + 0.00f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 28.93f + 0.00f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 29.29f + 0.00f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(true, 28.81f, 29.89f, "space"));

            //hard drum
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 30.73f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 30.73f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 30.73f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 30.73f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 32.65f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 32.65f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 32.65f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 32.65f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 34.57f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 34.57f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 34.57f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 34.57f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 36.49f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 36.49f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 36.49f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 36.49f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 38.41f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 38.41f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 38.41f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 38.41f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 40.33f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 40.33f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 40.33f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 40.33f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 42.25f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 42.25f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 42.25f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 42.25f, 2.0f, "space"));
            //2nd cyndi
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 15.36f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 15.36f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 15.36f + 0.00f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 31.21f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 31.45f + 0.00f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 31.81f + 0.00f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 31.93f + 0.00f, 2.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 32.17f + 0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 32.41f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 32.53f + 0.00f, 2.0f, "d"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 17.28f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 17.28f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 17.28f + 0.00f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 33.13f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 33.37f + 0.00f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 33.49f + 0.00f, 2.0f, "l"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 18.36f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 18.36f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 18.36f + 0.00f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 34.09f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 34.33f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 34.45f + 0.00f, 2.0f, "d"));

            //2nd cyndi
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 15.36f + 3.84f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 15.36f + 3.84f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 15.36f + 3.84f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 31.21f + 3.84f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 31.45f + 3.84f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 31.81f + 3.84f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 31.93f + 3.84f, 2.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 32.17f + 3.84f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 32.41f + 3.84f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 32.53f + 3.84f, 2.0f, "d"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 17.28f + 3.84f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 17.28f + 3.84f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 17.28f + 3.84f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 33.13f + 3.84f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 33.37f + 3.84f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 33.49f + 3.84f, 2.0f, "l"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 18.36f + 3.84f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 18.36f + 3.84f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 18.36f + 3.84f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 34.09f + 3.84f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 34.33f + 3.84f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 34.45f + 3.84f, 2.0f, "d"));

            //2nd cyndi
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 15.36f + 7.68f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 15.36f + 7.68f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 15.36f + 7.68f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 31.21f + 7.68f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 31.45f + 7.68f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 31.81f + 7.68f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 31.93f + 7.68f, 2.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 32.17f + 7.68f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 32.41f + 7.68f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 32.53f + 7.68f, 2.0f, "d"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 17.28f + 7.68f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 17.28f + 7.68f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 17.28f + 7.68f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 33.13f + 7.68f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 33.37f + 7.68f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 33.49f + 7.68f, 2.0f, "l"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 18.36f + 7.68f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 18.36f + 7.68f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 18.36f + 7.68f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 34.09f + 7.68f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 34.33f + 7.68f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 34.45f + 7.68f, 2.0f, "d"));

            //2nd cyndi
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 15.36f + 11.52f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 15.36f + 11.52f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 15.36f + 11.52f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 31.21f + 11.52f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 31.45f + 11.52f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 31.81f + 11.52f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 31.93f + 11.52f, 2.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 32.17f + 11.52f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 32.41f + 11.52f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 32.53f + 11.52f, 2.0f, "d"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 17.28f + 11.52f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 17.28f + 11.52f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 17.28f + 11.52f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 33.13f + 11.52f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 33.37f + 11.52f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 33.49f + 11.52f, 2.0f, "l"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 18.36f + 11.52f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 18.36f + 11.52f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 18.36f + 11.52f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 34.09f + 11.52f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 34.33f + 11.52f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 34.45f + 11.52f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(true, 44.17f, 45.97f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 45.97f, 2.0f, ";"));

            //3rd cyndi
            input.Notes.Add(new Data.NoteInfo(false, 46.33f + 0.00f, 2.0f, "k"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 31.2f + 0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 31.2f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 31.2f + 0.00f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 47.05f + 0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 47.29f + 0.00f, 2.0f, "k"));

            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 17.28f + 0.00f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 17.28f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 17.28f + 0.00f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 30.61f + 17.28f + 0.00f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 48.01f + 0.00f, 2.0f, "d"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 48.25f + 0.00f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 48.49f + 0.00f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 48.73f + 0.00f + 0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 48.97f + 0.00f + 0.00f, 49.33f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 49.45f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 49.69f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 49.81f + 0.00f, 2.0f, "f"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 48.25f + 1.92f + 0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 48.49f + 1.92f + 0.00f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 48.73f + 1.92f + 0.00f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(true, 50.89f + 0.00f, 51.13f + 0.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 51.25f + 0.00f, 51.49f + 0.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 51.61f + 0.00f, 51.85f + 0.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 51.13f + 0.00f,0.02f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 51.49f + 0.00f,0.02f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 51.85f + 0.00f,0.02f, "f"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 36.72f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 36.72f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 36.72f + 0.00f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 52.57f + 0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 52.81f + 0.00f, 53.05f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 53.17f + 0.00f, 53.41f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 53.53f + 0.00f, 53.77f, "f"));
            ///
            input.Notes.Add(new Data.NoteInfo(false, 53.77f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 53.89f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.13f + 0.00f, 2.0f, "j"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 39.0f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 39.0f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 39.0f + 0.00f, 2.0f, "s"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 39.36f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 39.36f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 39.36f + 0.00f, 2.0f, "k"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 39.72f + 0.00f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 39.72f + 0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 55.45f + 0.00f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 55.69f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 55.81f + 0.00f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 56.05f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 56.17f + 0.00f, 2.0f, "f"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 41.04f + 0.00f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 41.04f + 0.00f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 15.61f + 41.04f + 0.00f, 56.89f, "l"));

            input.Notes.Add(new Data.NoteInfo(true, 57.01f + 0.00f, 57.25f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 57.37f + 0.00f, 57.61f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 57.73f + 0.00f, 57.97f, "k"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 42.72f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 42.72f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 42.72f + 0.00f, 2.0f, "d"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 43.08f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 43.08f + 0.00f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 58.93f + 0.00f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 59.29f + 0.00f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 59.77f + 0.00f, 2.0f, "s"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 44.64f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 44.64f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 44.64f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 60.49f + 0.00f, 60.73f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 60.85f + 0.00f, 61.09f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 61.21f + 0.00f, 61.45f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 60.73f, 0.02f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 61.09f, 0.02f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 61.45f, 0.02f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 59.53f, 61.45f, "space"));

            //hard drum
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 61.45f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 61.45f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 61.45f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 61.45f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 63.37f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 63.37f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 63.37f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 63.37f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 65.29f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 65.29f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 65.29f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 65.29f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 67.21f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 67.21f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 67.21f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 67.21f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 69.13f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 69.13f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 69.13f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 69.13f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 71.05f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 71.05f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 71.05f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 71.05f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 72.97f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 72.97f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 72.97f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 72.97f, 2.0f, "space"));
            //3rd cyndi
            input.Notes.Add(new Data.NoteInfo(false, 46.33f + 15.36f, 2.0f, "k"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 31.2f + 15.36f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 31.2f + 15.36f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 31.2f + 15.36f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 47.05f + 15.36f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 47.29f + 15.36f, 2.0f, "k"));

            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 17.28f + 15.36f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 17.28f + 15.36f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 17.28f + 15.36f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 30.61f + 17.28f + 15.36f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 48.01f + 15.36f, 2.0f, "d"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 48.25f + 15.36f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 48.49f + 15.36f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 48.73f + 15.36f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 48.97f + 15.36f, 64.69f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 49.45f + 15.36f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 49.69f + 15.36f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 49.81f + 15.36f, 2.0f, "f"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 48.25f + 1.92f + 15.36f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 48.49f + 1.92f + 15.36f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 48.73f + 1.92f + 15.36f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(true, 50.89f + 15.36f, 51.13f + 15.36f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 51.25f + 15.36f, 51.49f + 15.36f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 51.61f + 15.36f, 51.85f + 15.36f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 66.49f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 66.85f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 67.21f, 2.0f, "d"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 36.72f + 15.36f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 36.72f + 15.36f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 36.72f + 15.36f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 52.57f + 15.36f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 52.81f + 15.36f, 68.41f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 53.17f + 15.36f, 68.77f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 53.53f + 15.36f, 69.13f, "f"));
            ///
            input.Notes.Add(new Data.NoteInfo(false, 53.77f + 15.36f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 53.89f + 15.36f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.13f + 15.36f, 2.0f, "j"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 39.0f + 15.36f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 39.0f + 15.36f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 39.0f + 15.36f, 2.0f, "s"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 39.36f + 15.36f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 39.36f + 15.36f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 39.36f + 15.36f, 2.0f, "k"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 39.72f + 15.36f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 39.72f + 15.36f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 55.45f + 15.36f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 55.69f + 15.36f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 55.81f + 15.36f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 56.05f + 15.36f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 56.17f + 15.36f, 2.0f, "f"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 41.04f + 15.36f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 41.04f + 15.36f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 15.61f + 41.04f + 15.36f, 72.25f, "l"));

            input.Notes.Add(new Data.NoteInfo(true, 57.01f + 15.36f, 72.61f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 57.37f + 15.36f, 72.97f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 57.73f + 15.36f, 73.33f, "k"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 42.72f + 15.36f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 42.72f + 15.36f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 42.72f + 15.36f, 2.0f, "d"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 43.08f + 15.36f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 43.08f + 15.36f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 58.93f + 15.36f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 59.29f + 15.36f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 59.77f + 15.36f, 2.0f, "s"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 44.64f + 15.36f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 44.64f + 15.36f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 44.64f + 15.36f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 60.49f + 15.36f, 76.09f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 60.85f + 15.36f, 76.45f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 61.21f + 15.36f, 76.81f, "j"));

            input.Notes.Add(new Data.NoteInfo(true, 74.89f, 76.69f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 76.81f, 2.0f, ";"));
            //
            //hard added
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 76.81f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 76.81f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 76.81f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 76.81f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 78.73f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 78.73f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 78.73f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 78.73f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 80.65f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 80.65f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 80.65f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 80.65f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 82.57f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 82.57f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 82.57f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 82.57f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 84.49f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 84.49f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 84.49f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 84.49f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 86.41f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 86.41f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 86.41f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 86.41f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 88.33f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 88.33f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 88.33f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 88.33f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 90.25f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 90.25f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 90.25f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 90.25f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 92.17f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 92.17f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 92.17f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 92.17f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 94.09f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 94.09f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 94.09f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 94.09f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 96.01f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 96.01f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 96.01f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 96.01f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 97.93f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 97.93f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 97.93f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 97.93f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 99.85f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 99.85f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 99.85f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 99.85f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 101.77f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 101.77f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 101.77f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 101.77f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 103.69f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 103.69f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 103.69f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 103.69f, 2.0f, "space"));

            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 77.29f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 77.29f, 2.0f, "p"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 79.21f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 79.21f, 2.0f, ";"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 81.13f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 81.13f, 2.0f, "q"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 83.05f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 83.05f, 2.0f, "a"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 84.97f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 84.97f, 2.0f, "p"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 86.89f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 86.89f, 2.0f, ";"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 88.81f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 88.81f, 2.0f, "q"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 90.73f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 90.73f, 2.0f, "a"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 92.65f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 92.65f, 2.0f, "p"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 94.57f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 94.57f, 2.0f, ";"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 96.49f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 96.49f, 2.0f, "q"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 98.41f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 98.41f, 2.0f, "a"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 100.33f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 100.33f, 2.0f, "p"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 102.25f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 102.25f, 2.0f, ";"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 104.17f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 104.17f, 2.0f, "q"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 106.09f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 106.09f, 2.0f, "a"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 48.25f + 57.36f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 48.49f + 57.36f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 48.73f + 57.36f, 2.0f, "space"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 48.25f + 58.08f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 48.49f + 58.08f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 48.73f + 58.08f, 2.0f, "space"));
            //
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 46.56f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 46.56f, 2.0f, "f"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 46.92f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 46.92f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 46.92f, 2.0f, "d"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 47.4f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 47.4f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 47.4f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 30.61f + 47.4f, 2.0f, "f"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 48.0f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 48.0f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 48.0f, 2.0f, "d"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 48.48f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 48.48f, 2.0f, "f"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 48.84f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 48.84f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 48.84f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.61f + 48.84f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 79.57f, 2.0f, "j"));

            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 49.56f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 49.56f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 49.56f, 2.0f, "d"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 50.04f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 50.04f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 50.04f, 2.0f, "f"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 50.52f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 50.52f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 50.52f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 30.61f + 50.52f, 2.0f, "d"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 51.12f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 51.12f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 51.12f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 30.61f + 51.12f, 2.0f, "j"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 51.72f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 51.72f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 51.72f, 2.0f, "d"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 52.2f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 52.2f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 52.2f, 2.0f, "k"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 52.68f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 52.68f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 52.68f, 2.0f, "s"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 53.16f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 53.16f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 53.16f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.61f + 53.16f, 2.0f, "f"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 53.76f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 53.76f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 53.76f, 2.0f, "d"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 54.24f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 54.24f, 2.0f, "k"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 54.6f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 54.6f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 54.6f, 2.0f, "d"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 54.96f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 54.96f, 2.0f, "j"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 55.32f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 55.32f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 55.32f, 2.0f, "d"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 55.8f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 55.8f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 55.8f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 30.61f + 55.8f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 86.53f, 2.0f, "k"));

            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 56.52f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 56.52f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 56.52f, 2.0f, "k"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 56.88f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 56.88f, 2.0f, "d"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 57.24f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 57.24f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 57.24f, 2.0f, "f"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 57.6f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 57.6f, 2.0f, "l"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 57.96f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 57.96f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 57.96f, 2.0f, "l"));

            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 58.44f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 58.44f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 58.44f, 2.0f, "j"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 58.92f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 58.92f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 58.92f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.61f + 58.92f, 2.0f, "j"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 59.52f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 59.52f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 59.52f, 2.0f, "l"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 60.0f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 60.0f, 2.0f, "k"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 60.36f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 60.36f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 60.36f, 2.0f, "f"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 60.84f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 60.84f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 60.84f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 30.61f + 60.84f, 2.0f, "k"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 61.44f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 61.44f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 61.44f, 2.0f, "d"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 61.92f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 61.92f, 2.0f, "k"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 62.28f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 62.28f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 62.28f, 2.0f, "k"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 62.76f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 62.76f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 62.76f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 30.61f + 62.76f, 2.0f, "f"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 63.36f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 63.36f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 63.36f, 2.0f, "j"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 63.84f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 63.84f, 2.0f, "f"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 64.2f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 64.2f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 64.2f, 2.0f, "s"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 64.68f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 64.68f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 64.68f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 30.61f + 64.68f, 2.0f, "s"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 65.28f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 65.28f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 65.28f, 2.0f, "s"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 65.64f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 65.64f, 2.0f, "f"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 66.0f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 66.0f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 66.0f, 2.0f, "s"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 66.48f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 66.48f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 66.48f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.61f + 66.48f, 2.0f, "j"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 67.08f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 67.08f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 67.08f, 2.0f, "l"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 67.68f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 67.68f, 2.0f, "f"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 68.04f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 68.04f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 68.04f, 2.0f, "d"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 68.52f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 68.52f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 68.52f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.61f + 68.52f, 2.0f, "f"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 69.12f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 69.12f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 69.12f, 2.0f, "d"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 69.6f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 69.6f, 2.0f, "j"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 69.96f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 69.96f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 69.96f, 2.0f, "j"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 70.44f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 70.44f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 70.44f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.61f + 70.44f, 2.0f, "j"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 71.04f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 71.04f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 71.04f, 2.0f, "k"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 71.52f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 71.52f, 2.0f, "d"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 71.88f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 71.88f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 71.88f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.61f + 71.88f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 102.61f, 2.0f, "f"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 72.6f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 72.6f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 72.6f, 2.0f, "s"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 73.08f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 73.08f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 73.08f, 2.0f, "f"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 73.44f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 73.44f, 2.0f, "k"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 73.8f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 73.8f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 73.8f, 2.0f, "l"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 74.28f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 74.28f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 74.28f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.61f + 74.28f, 2.0f, "l"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 74.88f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 74.88f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 74.88f, 2.0f, "f"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 75.36f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 75.36f, 2.0f, "d"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 75.72f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 75.72f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 75.72f, 2.0f, "j"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 76.2f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 76.2f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 76.2f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.61f + 76.2f, 2.0f, "j"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 76.8f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 76.8f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 76.8f, 2.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(true, 107.05f, 107.53f, "space"));

            //hard add
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 107.53f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 107.53f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 107.53f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 109.45f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 109.45f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 109.45f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 109.45f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 111.37f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 111.37f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 111.37f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 111.37f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 113.29f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 113.29f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 113.29f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 113.29f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 115.21f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 115.21f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 115.21f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 115.21f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 117.13f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 117.13f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 117.13f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 117.13f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 119.05f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 119.05f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 119.05f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 119.05f, 2.0f, "space"));

            //disc
            input.Notes.Add(new Data.NoteInfo(false, 107.53f + 0.00f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 107.89f + 0.00f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 108.13f + 0.00f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 108.37f + 0.00f, 2.0f, "a"));
            //disc
            input.Notes.Add(new Data.NoteInfo(false, 107.53f + 1.92f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 107.89f + 1.92f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 108.13f + 1.92f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 108.37f + 1.92f, 2.0f, ";"));
            //disc
            input.Notes.Add(new Data.NoteInfo(false, 107.53f + 3.84f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 107.89f + 3.84f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 108.13f + 3.84f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 108.37f + 3.84f, 2.0f, "a"));
            //disc
            input.Notes.Add(new Data.NoteInfo(false, 107.53f + 5.76f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 107.89f + 5.76f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 108.13f + 5.76f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 108.37f + 5.76f, 2.0f, ";"));
            //disc
            input.Notes.Add(new Data.NoteInfo(false, 107.53f + 7.68f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 107.89f + 7.68f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 108.13f + 7.68f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 108.37f + 7.68f, 2.0f, "a"));
            //disc
            input.Notes.Add(new Data.NoteInfo(false, 107.53f + 9.6f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 107.89f + 9.6f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 108.13f + 9.6f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 108.37f + 9.6f, 2.0f, ";"));
            //disc
            input.Notes.Add(new Data.NoteInfo(false, 107.53f + 11.52f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 107.89f + 11.52f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 108.13f + 11.52f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 108.37f + 11.52f, 2.0f, "a"));
            //disc
            input.Notes.Add(new Data.NoteInfo(false, 107.53f + 13.44f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 107.89f + 13.44f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 108.13f + 13.44f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 108.37f + 13.44f, 2.0f, ";"));
            //disc
            input.Notes.Add(new Data.NoteInfo(false, 107.53f + 15.36f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 107.89f + 15.36f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 108.13f + 15.36f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 108.37f + 15.36f, 2.0f, "a"));
            //disc
            input.Notes.Add(new Data.NoteInfo(false, 107.53f + 17.4f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 107.89f + 17.4f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 108.13f + 17.4f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 108.37f + 17.4f, 2.0f, ";"));
            //disc
            input.Notes.Add(new Data.NoteInfo(false, 107.53f + 19.08f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 107.89f + 19.08f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 108.13f + 19.08f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 108.37f + 19.08f, 2.0f, "a"));
            //disc
            input.Notes.Add(new Data.NoteInfo(false, 107.53f + 21.12f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 107.89f + 21.12f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 108.13f + 21.12f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 108.37f + 21.12f, 2.0f, ";"));
            //disc
            input.Notes.Add(new Data.NoteInfo(false, 107.53f + 23.04f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 107.89f + 23.04f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 108.13f + 23.04f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 108.37f + 23.04f, 2.0f, "a"));
            //disc
            input.Notes.Add(new Data.NoteInfo(false, 107.53f + 24.96f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 107.89f + 24.96f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 108.13f + 24.96f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 108.37f + 24.96f, 2.0f, ";"));
            //disc
            input.Notes.Add(new Data.NoteInfo(false, 107.53f + 26.88f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 107.89f + 26.88f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 108.13f + 26.88f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 108.37f + 26.88f, 2.0f, "a"));
            //disc
            input.Notes.Add(new Data.NoteInfo(false, 107.53f + 28.8f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 107.89f + 28.8f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 108.13f + 28.8f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 108.37f + 28.8f, 2.0f, ";"));
          
            //
            //3rd cyndi
            input.Notes.Add(new Data.NoteInfo(false, 46.33f + 61.44f, 2.0f, "k"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 31.2f + 61.44f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 31.2f + 61.44f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 31.2f + 61.44f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 47.05f + 61.44f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 47.29f + 61.44f, 2.0f, "k"));

            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 17.28f + 61.44f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 17.28f + 61.44f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 17.28f + 61.44f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 30.61f + 17.28f + 61.44f, 2.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 48.01f + 61.44f, 2.0f, "d"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 48.25f + 61.44f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 48.49f + 61.44f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 48.73f + 61.44f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 48.97f + 61.44f, 110.77f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 49.45f + 61.44f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 49.69f + 61.44f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 49.81f + 61.44f, 2.0f, "f"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 48.25f + 1.92f + 61.44f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 48.49f + 1.92f + 61.44f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 48.73f + 1.92f + 61.44f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(true, 50.89f + 61.44f, 51.13f + 61.44f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 51.25f + 61.44f, 51.49f + 61.44f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 51.61f + 61.44f, 51.85f + 61.44f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 51.13f + 61.44f,0.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 51.49f + 61.44f,0.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 51.85f + 61.44f,0.00f, "j"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 36.72f + 61.44f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 36.72f + 61.44f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 36.72f + 61.44f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 52.57f + 61.44f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 52.81f + 61.44f, 114.49f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 53.17f + 61.44f, 114.85f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 53.53f + 61.44f, 115.21f, "f"));
            ///
            input.Notes.Add(new Data.NoteInfo(false, 53.77f + 61.44f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 53.89f + 61.44f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.13f + 61.44f, 2.0f, "j"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 39.0f + 61.44f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 39.0f + 61.44f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 39.0f + 61.44f, 2.0f, "s"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 39.36f + 61.44f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 39.36f + 61.44f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 39.36f + 61.44f, 2.0f, "k"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 39.72f + 61.44f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 39.72f + 61.44f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 55.45f + 61.44f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 55.69f + 61.44f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 55.81f + 61.44f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 56.05f + 61.44f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 56.17f + 61.44f, 2.0f, "f"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 41.04f + 61.44f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 41.04f + 61.44f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 15.61f + 41.04f + 61.44f, 118.33f, "l"));

            input.Notes.Add(new Data.NoteInfo(true, 57.01f + 61.44f, 118.69f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 57.37f + 61.44f, 119.05f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 57.73f + 61.44f, 119.41f, "k"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 42.72f + 61.44f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 42.72f + 61.44f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 42.72f + 61.44f, 2.0f, "d"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 43.08f + 61.44f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 43.08f + 61.44f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 58.93f + 61.44f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 59.29f + 61.44f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 59.77f + 61.44f, 2.0f, "s"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 44.64f + 61.44f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 44.64f + 61.44f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 44.64f + 61.44f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 60.49f + 61.44f, 121.93f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 60.85f + 61.44f, 122.53f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 61.21f + 61.44f, 122.89f, "j"));

            //
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 108.01f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 108.01f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 108.01f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 108.01f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 109.93f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 109.93f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 109.93f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 109.93f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 111.85f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 111.85f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 111.85f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 111.85f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 113.77f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 113.77f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 113.77f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 113.77f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 115.69f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 115.69f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 115.69f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 115.69f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 117.61f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 117.61f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 117.61f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 117.61f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 119.53f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 119.53f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 119.53f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 1.45f + 119.53f, 122.77f, "space"));
            //3rd cyndi
            input.Notes.Add(new Data.NoteInfo(false, 46.33f + 76.8f, 2.0f, "k"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 31.2f + 76.8f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 31.2f + 76.8f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 31.2f + 76.8f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 47.05f + 76.8f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 47.29f + 76.8f, 2.0f, "k"));

            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 17.28f + 76.8f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 17.28f + 76.8f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 17.28f + 76.8f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 30.61f + 17.28f + 76.8f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 48.01f + 76.8f, 2.0f, "d"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 48.25f + 76.8f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 48.49f + 76.8f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 48.73f + 76.8f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 48.97f + 76.8f, 126.13f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 49.45f + 76.8f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 49.69f + 76.8f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 49.81f + 76.8f, 2.0f, "f"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 48.25f + 1.92f + 76.8f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 48.49f + 1.92f + 76.8f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 48.73f + 1.92f + 76.8f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(true, 50.89f + 76.8f, 51.13f + 76.8f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 51.25f + 76.8f, 51.49f + 76.8f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 51.61f + 76.8f, 51.85f + 76.8f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 51.13f + 76.8f, 0.00f,"d"));
            input.Notes.Add(new Data.NoteInfo(false, 51.49f + 76.8f, 0.00f,"j"));
            input.Notes.Add(new Data.NoteInfo(false, 51.85f + 76.8f, 0.00f,"k"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 36.72f + 76.8f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 36.72f + 76.8f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 36.72f + 76.8f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 52.57f + 76.8f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 52.81f + 76.8f, 129.85f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 53.17f + 76.8f, 130.21f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 53.53f + 76.8f, 130.57f, "f"));
            ///
            input.Notes.Add(new Data.NoteInfo(false, 53.77f + 76.8f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 53.89f + 76.8f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.13f + 76.8f, 2.0f, "j"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 39.0f + 76.8f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 39.0f + 76.8f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 39.0f + 76.8f, 2.0f, "s"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 39.36f + 76.8f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 39.36f + 76.8f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 39.36f + 76.8f, 2.0f, "k"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 39.72f + 76.8f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 39.72f + 76.8f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 55.45f + 76.8f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 55.69f + 76.8f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 55.81f + 76.8f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 56.05f + 76.8f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 56.17f + 76.8f, 2.0f, "f"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 41.04f + 76.8f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 41.04f + 76.8f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 15.61f + 41.04f + 76.8f, 133.69f, "l"));

            input.Notes.Add(new Data.NoteInfo(true, 57.01f + 76.8f, 134.05f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 57.37f + 76.8f, 134.41f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 57.73f + 76.8f, 134.77f, "k"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 42.72f + 76.8f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 42.72f + 76.8f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 42.72f + 76.8f, 2.0f, "d"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 43.08f + 76.8f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 43.08f + 76.8f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 58.93f + 76.8f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 59.29f + 76.8f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 59.77f + 76.8f, 2.0f, "s"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 44.64f + 76.8f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 44.64f + 76.8f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 44.64f + 76.8f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 60.49f + 76.8f, 137.53f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 60.85f + 76.8f, 137.89f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 61.21f + 76.8f, 138.25f, "j"));
        }
        else if (input.Difficulty.Equals("Extreme"))
        {
            input.Notes.Add(new Data.NoteInfo(false, 0.0f, 2.0f, "s"));
        }
    }
         
}
