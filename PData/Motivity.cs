using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Motivity : MonoBehaviour {

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
        MusicInfo.key = 1;
        MusicInfo.name = "MOTIVITY";
        MusicInfo.composer = "ESTi";
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
        if (input.Difficulty.Equals("Normal")) {
            input.Notes.Add(new Data.NoteInfo(false, 0f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.14f, 0.0f, "l"));
            
             input.Notes.Add(new Data.NoteInfo(false, 4.28f, 0.0f, "s"));
             input.Notes.Add(new Data.NoteInfo(true, 6.42f, 7.49f, "k"));
             input.Notes.Add(new Data.NoteInfo(false, 8.03f, 0.0f, "f"));

             //4bit
             input.Notes.Add(new Data.NoteInfo(false, 8.56f+0.0f, 0.0f, "s"));
             input.Notes.Add(new Data.NoteInfo(false, 9.10f+0.0f, 0.0f, "s"));
             input.Notes.Add(new Data.NoteInfo(false, 9.64f+0.0f, 0.0f, "s"));
             input.Notes.Add(new Data.NoteInfo(false, 10.17f+0.0f, 0.0f, "s"));
              //4bit
             input.Notes.Add(new Data.NoteInfo(false, 8.56f+2.15f, 0.0f, "d"));
             input.Notes.Add(new Data.NoteInfo(false, 9.10f+2.15f, 0.0f, "d"));
             input.Notes.Add(new Data.NoteInfo(false, 9.64f+2.15f, 0.0f, "d"));
             input.Notes.Add(new Data.NoteInfo(false, 10.17f+2.15f, 0.0f, "d"));
              //4bit
             input.Notes.Add(new Data.NoteInfo(false, 8.56f+4.29f, 0.0f, "f"));
             input.Notes.Add(new Data.NoteInfo(false, 9.10f+4.29f, 0.0f, "f"));
             input.Notes.Add(new Data.NoteInfo(false, 9.64f+4.29f, 0.0f, "f"));
             input.Notes.Add(new Data.NoteInfo(false, 10.17f+4.29f, 0.0f, "f"));

             input.Notes.Add(new Data.NoteInfo(false, 14.69f, 0.0f, "k"));
             input.Notes.Add(new Data.NoteInfo(false, 16.06f, 0.0f, "j"));
             //3bit + 2 bit
             input.Notes.Add(new Data.NoteInfo(false, 17.13f+0.0f, 0.0f, "s"));
             input.Notes.Add(new Data.NoteInfo(false, 17.67f+0.0f, 0.0f, "d"));
             input.Notes.Add(new Data.NoteInfo(false, 18.20f+0.0f, 0.0f, "f"));
             input.Notes.Add(new Data.NoteInfo(false, 19.28f+0.0f, 0.0f, "j"));
             input.Notes.Add(new Data.NoteInfo(false, 20.35f+0.0f, 0.0f, "l"));
             //3bit + 2 bit
             input.Notes.Add(new Data.NoteInfo(false, 17.13f+4.29f, 0.0f, "l"));
             input.Notes.Add(new Data.NoteInfo(false, 17.67f+4.29f, 0.0f, "k"));
             input.Notes.Add(new Data.NoteInfo(false, 18.20f+4.29f, 0.0f, "j"));
             input.Notes.Add(new Data.NoteInfo(false, 19.28f+4.29f, 0.0f, "s"));
             input.Notes.Add(new Data.NoteInfo(false, 20.35f+4.29f, 0.0f, "f"));
              //3bit + 2 bit
             input.Notes.Add(new Data.NoteInfo(false, 17.13f+7.97f, 0.0f, "s"));
             input.Notes.Add(new Data.NoteInfo(false, 17.67f+7.97f, 0.0f, "d"));
             input.Notes.Add(new Data.NoteInfo(false, 18.20f+7.97f, 0.0f, "f"));
             input.Notes.Add(new Data.NoteInfo(false, 19.28f+7.97f, 0.0f, "j"));
             input.Notes.Add(new Data.NoteInfo(false, 20.35f+7.97f, 0.0f, "l"));

             input.Notes.Add(new Data.NoteInfo(true, 29.99f, 31.59f, "f"));
             input.Notes.Add(new Data.NoteInfo(false, 32.13f, 0.0f, "j"));
              //3bit
             input.Notes.Add(new Data.NoteInfo(false, 17.13f+16.07f, 0.0f, "s"));
             input.Notes.Add(new Data.NoteInfo(false, 17.67f+16.07f, 0.0f, "f"));
             input.Notes.Add(new Data.NoteInfo(false, 18.20f+16.07f, 0.0f, "j"));

             input.Notes.Add(new Data.NoteInfo(false, 38.02f, 0.0f, "s"));
             input.Notes.Add(new Data.NoteInfo(false, 38.56f, 0.0f, "k"));
             input.Notes.Add(new Data.NoteInfo(false, 42.84f, 0.0f, "f"));
             input.Notes.Add(new Data.NoteInfo(false, 44.98f, 0.0f, "s"));
             input.Notes.Add(new Data.NoteInfo(false, 47.13f, 0.0f, "l"));
             input.Notes.Add(new Data.NoteInfo(false, 49.27f, 0.0f, "j"));
             //3bit
             input.Notes.Add(new Data.NoteInfo(false, 17.13f+34.28f, 0.0f, "s"));
             input.Notes.Add(new Data.NoteInfo(false, 17.67f+34.28f, 0.0f, "d"));
             input.Notes.Add(new Data.NoteInfo(false, 18.20f+34.28f, 0.0f, "f"));
             //3bit
             input.Notes.Add(new Data.NoteInfo(false, 17.13f+0.0f, 0.0f, "f"));
             input.Notes.Add(new Data.NoteInfo(false, 17.67f+0.0f, 0.0f, "d"));
             input.Notes.Add(new Data.NoteInfo(false, 18.20f+0.0f, 0.0f, "s"));
             //3bit
             input.Notes.Add(new Data.NoteInfo(false, 17.13f+0.0f, 0.0f, "j"));
             input.Notes.Add(new Data.NoteInfo(false, 17.67f+0.0f, 0.0f, "k"));
             input.Notes.Add(new Data.NoteInfo(false, 18.20f+0.0f, 0.0f, "l"));
             //3bit
             input.Notes.Add(new Data.NoteInfo(false, 17.13f+0.0f, 0.0f, "l"));
             input.Notes.Add(new Data.NoteInfo(false, 17.67f+0.0f, 0.0f, "k"));
             input.Notes.Add(new Data.NoteInfo(false, 18.20f+0.0f, 0.0f, "j"));

             input.Notes.Add(new Data.NoteInfo(false, 59.98f, 0.0f, "a"));
             input.Notes.Add(new Data.NoteInfo(false, 64.26f, 0.0f, "q"));
             input.Notes.Add(new Data.NoteInfo(false, 66.41f, 0.0f, ";"));
             input.Notes.Add(new Data.NoteInfo(false, 68.55f, 0.0f, "p"));
             input.Notes.Add(new Data.NoteInfo(true, 72.30f, 74.44f, "space"));
             input.Notes.Add(new Data.NoteInfo(false, 74.97f, 0.0f, "d"));
             input.Notes.Add(new Data.NoteInfo(false, 76.05f, 0.0f, "j"));
             input.Notes.Add(new Data.NoteInfo(false, 77.12f, 0.0f, "s"));
              //3bit
             input.Notes.Add(new Data.NoteInfo(false, 17.13f+61.59f, 0.0f, "s"));
             input.Notes.Add(new Data.NoteInfo(false, 17.67f+61.59f, 0.0f, "s"));
             input.Notes.Add(new Data.NoteInfo(false, 18.20f+61.59f, 0.0f, "s"));
              //3bit
             input.Notes.Add(new Data.NoteInfo(false, 17.13f+54.27f, 0.0f, "l"));
             input.Notes.Add(new Data.NoteInfo(false, 17.67f+54.27f, 0.0f, "l"));
             input.Notes.Add(new Data.NoteInfo(false, 18.20f+54.27f, 0.0f, "l"));
             input.Notes.Add(new Data.NoteInfo(false, 83.54f, 0.0f, "f"));
             input.Notes.Add(new Data.NoteInfo(false, 84.62f, 0.0f, "j"));
               //4/2
             input.Notes.Add(new Data.NoteInfo(false, 85.69f+0.0f, 0.0f, "d"));
             input.Notes.Add(new Data.NoteInfo(false, 86.76f+0.0f, 0.0f, "j"));
             input.Notes.Add(new Data.NoteInfo(false, 87.83f+0.0f, 0.0f, "s"));
             input.Notes.Add(new Data.NoteInfo(false, 88.90f+0.0f, 0.0f, "l"));
             //4/2
             input.Notes.Add(new Data.NoteInfo(false, 85.69f+4.28f, 0.0f, "f"));
             input.Notes.Add(new Data.NoteInfo(false, 86.76f+4.28f, 0.0f, "j"));
             input.Notes.Add(new Data.NoteInfo(false, 87.83f+4.28f, 0.0f, "l"));
             input.Notes.Add(new Data.NoteInfo(false, 88.90f+4.28f, 0.0f, "d"));
              //4/2
             input.Notes.Add(new Data.NoteInfo(false, 85.69f+8.57f, 0.0f, "f"));
             input.Notes.Add(new Data.NoteInfo(false, 86.76f+8.57f, 0.0f, "j"));
             input.Notes.Add(new Data.NoteInfo(false, 87.83f+8.57f, 0.0f, "f"));
             input.Notes.Add(new Data.NoteInfo(false, 88.90f+8.57f, 0.0f, "l"));
              //4/2
             input.Notes.Add(new Data.NoteInfo(false, 85.69f+12.85f, 0.0f, "f"));
             input.Notes.Add(new Data.NoteInfo(false, 86.76f+12.85f, 0.0f, "space"));
             input.Notes.Add(new Data.NoteInfo(false, 87.83f+12.85f, 0.0f, "k"));
             
             input.Notes.Add(new Data.NoteInfo(true, 102.82f, 103.90f, "f"));
             input.Notes.Add(new Data.NoteInfo(true, 104.97f, 106.04f, "s"));
             input.Notes.Add(new Data.NoteInfo(true, 107.11f, 108.18f, "j"));
             input.Notes.Add(new Data.NoteInfo(true, 109.25f, 110.32f, "l"));
             input.Notes.Add(new Data.NoteInfo(true, 111.39f, 112.46f, "d"));
               //3bit
             input.Notes.Add(new Data.NoteInfo(false, 17.13f+96.41f, 0.0f, "j"));
             input.Notes.Add(new Data.NoteInfo(false, 17.67f+96.41f, 0.0f, "k"));
             input.Notes.Add(new Data.NoteInfo(false, 18.20f+96.41f, 0.0f, "l"));

             input.Notes.Add(new Data.NoteInfo(true, 115.68f, 116.75f, "k"));
              //3bit
             input.Notes.Add(new Data.NoteInfo(false, 17.13f+100.69f, 0.0f, "s"));
             input.Notes.Add(new Data.NoteInfo(false, 17.67f+100.69f, 0.0f, "d"));
             input.Notes.Add(new Data.NoteInfo(false, 18.20f+100.69f, 0.0f, "f"));

             input.Notes.Add(new Data.NoteInfo(true, 119.96f, 121.39f, "d"));
             //3bit
             input.Notes.Add(new Data.NoteInfo(false, 17.13f+104.98f, 0.0f, "l"));
             input.Notes.Add(new Data.NoteInfo(false, 17.67f+104.98f, 0.0f, "k"));
             input.Notes.Add(new Data.NoteInfo(false, 18.20f+104.98f, 0.0f, "j"));
             input.Notes.Add(new Data.NoteInfo(true, 124.25f, 125.85f, "space"));

              //4/2
             input.Notes.Add(new Data.NoteInfo(false, 85.69f+40.7f, 0.0f, "f"));
             input.Notes.Add(new Data.NoteInfo(false, 86.76f+40.7f, 0.0f, "s"));
             input.Notes.Add(new Data.NoteInfo(false, 87.83f+40.7f, 0.0f, "j"));
             input.Notes.Add(new Data.NoteInfo(false, 132.28f, 0.0f, "d"));
             input.Notes.Add(new Data.NoteInfo(false, 132.82f, 0.0f, "k"));
             input.Notes.Add(new Data.NoteInfo(false, 137.01f, 0.0f, "a"));
             input.Notes.Add(new Data.NoteInfo(false, 141.39f, 0.0f, ";"));
            
             
        }
        else if (input.Difficulty.Equals("Hard")) {
            input.Notes.Add(new Data.NoteInfo(false, 141.39f, 0.0f, ";"));
        }
        else if (input.Difficulty.Equals("Extreme")) {
            input.Notes.Add(new Data.NoteInfo(false, 141.39f, 0.0f, ";"));
        }
    }
    }
