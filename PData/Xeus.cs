using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class Xeus : MonoBehaviour {

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
        MusicInfo.key = 32;
        MusicInfo.name = "Xeus";
        MusicInfo.composer = "XeoN";
        MusicInfo.visualizer = "Ukyo & HooN";
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
            input.Notes.Add(new Data.NoteInfo(false, 0.0f, 2.0f, "s"));

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
