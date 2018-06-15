using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Test: MonoBehaviour{

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
        MusicInfo.key = 100;
        MusicInfo.name = "Test";
        MusicInfo.composer = "Kwontf";
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
        hard.level = 2;
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
        extreme.level = 3;
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
        int comboCalc = 0;
        CreateNote(input);
        foreach (Data.NoteInfo notes in input.Notes)
        {
                comboCalc++;
        }
        input.max_combo = comboCalc;
    }
    void CreateNote(Data.Playdata input)
    {
        input.Notes = new List<Data.NoteInfo>();
        if (input.Difficulty.Equals("Normal"))
        {
            input.Notes.Add(new Data.NoteInfo(false, 2.0f, 2.0f, "s"));
        }
        else if (input.Difficulty.Equals("Hard"))
        {
            input.Notes.Add(new Data.NoteInfo(false, 2.0f, 2.0f, "space"));
        }
        else if (input.Difficulty.Equals("Extreme"))
        {
            //input.Notes.Add(new Data.NoteInfo(false, 1.0f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 1.0f, 2.0f, "d"));
            //input.Notes.Add(new Data.NoteInfo(false, 2.0f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 3.0f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 3.0f, 5.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 5.0f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 6.0f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 6.0f, 9.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 9.0f, 2.0f, "s"));
        }
    }
   
}
