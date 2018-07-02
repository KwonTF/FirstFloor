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
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 0.00f, 2.0f, "s"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 1.93f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 1.93f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 1.93f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 1.93f, 2.0f, "s"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 3.85f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 3.85f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 3.85f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 3.85f, 2.0f, "s"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 5.77f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 5.77f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 5.77f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 5.77f, 2.0f, "s"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 7.69f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 7.69f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 7.69f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 7.69f, 2.0f, "s"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 9.61f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 9.61f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 9.61f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 9.61f, 2.0f, "s"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 11.53f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 11.53f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 11.53f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 11.53f, 2.0f, "s"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 13.45f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.49f + 13.45f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 13.45f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 13.45f, 2.0f, "s"));

            //1st cyndi
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 0.00f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 15.85f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 16.09f + 0.00f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 16.45f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 16.57f + 0.00f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 16.81f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 17.05f + 0.00f, 2.0f, "s"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 1.92f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 1.92f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 1.92f + 0.00f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 17.77f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 18.01f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 18.13f + 0.00f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 18.37f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 18.61f + 0.00f, 2.0f, "s"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 3.36f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 3.36f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 3.36f + 0.00f, 2.0f, "s"));
            //

            //1st cyndi
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 3.84f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 3.84f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 3.84f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 15.85f + 3.84f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 16.09f + 3.84f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 16.45f + 3.84f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 16.57f + 3.84f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 16.81f + 3.84f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 17.05f + 3.84f, 2.0f, "s"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 1.92f + 3.84f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 1.92f + 3.84f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 1.92f + 3.84f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 17.77f + 3.84f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 18.01f + 3.84f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 18.13f + 3.84f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 18.37f + 3.84f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 18.61f + 3.84f, 2.0f, "s"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 3.36f + 3.84f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 3.36f + 3.84f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 3.36f + 3.84f, 2.0f, "s"));
            //

            //1st cyndi
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 7.68f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 7.68f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 7.68f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 15.85f + 7.68f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 16.09f + 7.68f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 16.45f + 7.68f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 16.57f + 7.68f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 16.81f + 7.68f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 17.05f + 7.68f, 2.0f, "s"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 1.92f + 7.68f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 1.92f + 7.68f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 1.92f + 7.68f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 17.77f + 7.68f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 18.01f + 7.68f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 18.13f + 7.68f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 18.37f + 7.68f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 18.61f + 7.68f, 2.0f, "s"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 3.36f + 7.68f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 3.36f + 7.68f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 3.36f + 7.68f, 2.0f, "s"));
            //

            //1st cyndi
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 11.52f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 11.52f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 11.52f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 15.85f + 11.52f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 16.09f + 11.52f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 16.45f + 11.52f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 16.57f + 11.52f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 16.81f + 11.52f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 17.05f + 11.52f, 2.0f, "s"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.37f + 1.92f + 11.52f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 15.49f + 1.92f + 11.52f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 15.61f + 1.92f + 11.52f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 17.77f + 11.52f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 18.01f + 11.52f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 18.13f + 11.52f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 18.37f + 11.52f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 18.61f + 11.52f, 2.0f, "s"));
            //

            //4com
            input.Notes.Add(new Data.NoteInfo(false, 30.25f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 30.37f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 30.49f + 0.00f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 30.61f + 0.00f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(true, 28.81f, 29.89f, "space"));
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
