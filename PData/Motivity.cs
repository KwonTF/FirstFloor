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
        normal.level = 2;
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
        hard.level = 8;
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
            input.Notes.Add(new Data.NoteInfo(false, 0f+0.0f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.14f+0.0f, 0.0f, "l"));
            
             input.Notes.Add(new Data.NoteInfo(false, 4.28f+0.0f, 0.0f, "s"));
             input.Notes.Add(new Data.NoteInfo(true, 6.42f, 7.49f, "k"));
             input.Notes.Add(new Data.NoteInfo(false, 8.03f+0.0f, 0.0f, "f"));

             //4bit
             input.Notes.Add(new Data.NoteInfo(false, 8.56f+0.0f+0.0f, 0.0f, "s"));
             input.Notes.Add(new Data.NoteInfo(false, 9.10f+0.0f+0.0f, 0.0f, "s"));
             input.Notes.Add(new Data.NoteInfo(false, 9.64f+0.0f+0.0f, 0.0f, "s"));
             input.Notes.Add(new Data.NoteInfo(false, 10.17f+0.0f+0.0f, 0.0f, "s"));
              //4bit
             input.Notes.Add(new Data.NoteInfo(false, 8.56f+2.15f+0.0f, 0.0f, "d"));
             input.Notes.Add(new Data.NoteInfo(false, 9.10f+2.15f+0.0f, 0.0f, "d"));
             input.Notes.Add(new Data.NoteInfo(false, 9.64f+2.15f+0.0f, 0.0f, "d"));
             input.Notes.Add(new Data.NoteInfo(false, 10.17f+2.15f+0.0f, 0.0f, "d"));
              //4bit
             input.Notes.Add(new Data.NoteInfo(false, 8.56f+4.29f+0.0f, 0.0f, "f"));
             input.Notes.Add(new Data.NoteInfo(false, 9.10f+4.29f+0.0f, 0.0f, "f"));
             input.Notes.Add(new Data.NoteInfo(false, 9.64f+4.29f+0.0f, 0.0f, "f"));
             input.Notes.Add(new Data.NoteInfo(false, 10.17f+4.29f+0.0f, 0.0f, "f"));

             input.Notes.Add(new Data.NoteInfo(false, 14.99f+0.0f, 0.0f, "k"));
             input.Notes.Add(new Data.NoteInfo(false, 16.06f+0.0f, 0.0f, "j"));
             //3bit + 2 bit
             input.Notes.Add(new Data.NoteInfo(false, 17.13f+0.0f+0.0f, 0.0f, "s"));
             input.Notes.Add(new Data.NoteInfo(false, 17.67f+0.0f+0.0f, 0.0f, "d"));
             input.Notes.Add(new Data.NoteInfo(false, 18.20f+0.0f+0.0f, 0.0f, "f"));
             input.Notes.Add(new Data.NoteInfo(false, 19.28f+0.0f+0.0f, 0.0f, "j"));
             input.Notes.Add(new Data.NoteInfo(false, 20.35f+0.0f+0.0f, 0.0f, "l"));
             //3bit + 2 bit
             input.Notes.Add(new Data.NoteInfo(false, 17.13f+4.29f+0.0f, 0.0f, "l"));
             input.Notes.Add(new Data.NoteInfo(false, 17.67f+4.29f+0.0f, 0.0f, "k"));
             input.Notes.Add(new Data.NoteInfo(false, 18.20f+4.29f+0.0f, 0.0f, "j"));
             input.Notes.Add(new Data.NoteInfo(false, 19.28f+4.29f+0.0f, 0.0f, "s"));
             input.Notes.Add(new Data.NoteInfo(false, 20.35f+4.29f+0.0f, 0.0f, "f"));
              //3bit + 2 bit
             input.Notes.Add(new Data.NoteInfo(false, 17.13f+8.58f+0.0f, 0.0f, "s"));
             input.Notes.Add(new Data.NoteInfo(false, 17.67f+8.58f+0.0f, 0.0f, "d"));
             input.Notes.Add(new Data.NoteInfo(false, 18.20f+8.58f+0.0f, 0.0f, "f"));
             input.Notes.Add(new Data.NoteInfo(false, 19.28f+8.58f+0.0f, 0.0f, "j"));
             input.Notes.Add(new Data.NoteInfo(false, 20.35f+8.58f+0.0f, 0.0f, "l"));

             input.Notes.Add(new Data.NoteInfo(true, 29.99f, 31.59f, "f"));
             input.Notes.Add(new Data.NoteInfo(false, 32.13f+0.0f, 0.0f, "j"));
              //3bit
             input.Notes.Add(new Data.NoteInfo(false, 17.13f+16.07f+0.0f, 0.0f, "s"));
             input.Notes.Add(new Data.NoteInfo(false, 17.67f+16.07f+0.0f, 0.0f, "f"));
             input.Notes.Add(new Data.NoteInfo(false, 18.20f+16.07f+0.0f, 0.0f, "j"));

             input.Notes.Add(new Data.NoteInfo(false, 38.02f+0.0f, 0.0f, "s"));
             input.Notes.Add(new Data.NoteInfo(false, 38.56f+0.0f, 0.0f, "k"));
             input.Notes.Add(new Data.NoteInfo(false, 42.84f+0.0f, 0.0f, "f"));
             input.Notes.Add(new Data.NoteInfo(false, 44.98f+0.0f, 0.0f, "s"));
             input.Notes.Add(new Data.NoteInfo(false, 47.13f+0.0f, 0.0f, "l"));
             input.Notes.Add(new Data.NoteInfo(false, 49.27f+0.0f, 0.0f, "j"));
             //3bit
             input.Notes.Add(new Data.NoteInfo(false, 17.13f+34.28f+0.0f, 0.0f, "s"));
             input.Notes.Add(new Data.NoteInfo(false, 17.67f+34.28f+0.0f, 0.0f, "d"));
             input.Notes.Add(new Data.NoteInfo(false, 18.20f+34.28f+0.0f, 0.0f, "f"));
             //3bit
             input.Notes.Add(new Data.NoteInfo(false, 17.13f+36.42f+0.0f, 0.0f, "f"));
             input.Notes.Add(new Data.NoteInfo(false, 17.67f+36.42f+0.0f, 0.0f, "d"));
             input.Notes.Add(new Data.NoteInfo(false, 18.20f+36.42f+0.0f, 0.0f, "s"));
             //3bit
             input.Notes.Add(new Data.NoteInfo(false, 17.13f+38.56f+0.0f, 0.0f, "j"));
             input.Notes.Add(new Data.NoteInfo(false, 17.67f+38.56f+0.0f, 0.0f, "k"));
             input.Notes.Add(new Data.NoteInfo(false, 18.20f+38.56f+0.0f, 0.0f, "l"));
             //3bit
             input.Notes.Add(new Data.NoteInfo(false, 17.13f+40.71f+0.0f, 0.0f, "l"));
             input.Notes.Add(new Data.NoteInfo(false, 17.67f+40.71f+0.0f, 0.0f, "k"));
             input.Notes.Add(new Data.NoteInfo(false, 18.20f+40.71f+0.0f, 0.0f, "j"));

             input.Notes.Add(new Data.NoteInfo(false, 59.98f+0.0f, 0.0f, "a"));
             input.Notes.Add(new Data.NoteInfo(false, 64.26f+0.0f, 0.0f, "q"));
             input.Notes.Add(new Data.NoteInfo(false, 66.41f+0.0f, 0.0f, ";"));
             input.Notes.Add(new Data.NoteInfo(false, 68.55f+0.0f, 0.0f, "p"));
             input.Notes.Add(new Data.NoteInfo(true, 72.30f, 74.44f, "space"));
             input.Notes.Add(new Data.NoteInfo(false, 74.97f+0.0f, 0.0f, "d"));
             input.Notes.Add(new Data.NoteInfo(false, 76.05f+0.0f, 0.0f, "j"));
             input.Notes.Add(new Data.NoteInfo(false, 77.12f+0.0f, 0.0f, "s"));
              //3bit
             input.Notes.Add(new Data.NoteInfo(false, 17.13f+60.54f+0.0f, 0.0f, "s"));
             input.Notes.Add(new Data.NoteInfo(false, 17.67f+60.54f+0.0f, 0.0f, "s"));
             input.Notes.Add(new Data.NoteInfo(false, 18.20f+60.54f+0.0f, 0.0f, "s"));
              //3bit
             input.Notes.Add(new Data.NoteInfo(false, 17.13f+62.15f+0.0f, 0.0f, "l"));
             input.Notes.Add(new Data.NoteInfo(false, 17.67f+62.15f+0.0f, 0.0f, "l"));
             input.Notes.Add(new Data.NoteInfo(false, 18.20f+62.15f+0.0f, 0.0f, "l"));
             input.Notes.Add(new Data.NoteInfo(false, 81.42f+0.0f, 0.0f, "d"));
             input.Notes.Add(new Data.NoteInfo(false, 83.54f+0.0f, 0.0f, "f"));
             input.Notes.Add(new Data.NoteInfo(false, 84.62f+0.0f, 0.0f, "j"));
               //4/2
             input.Notes.Add(new Data.NoteInfo(false, 85.69f+0.0f+0.0f, 0.0f, "d"));
             input.Notes.Add(new Data.NoteInfo(false, 86.76f+0.0f+0.0f, 0.0f, "j"));
             input.Notes.Add(new Data.NoteInfo(false, 87.83f+0.0f+0.0f, 0.0f, "s"));
             input.Notes.Add(new Data.NoteInfo(false, 88.90f+0.0f+0.0f, 0.0f, "l"));
             //4/2
             input.Notes.Add(new Data.NoteInfo(false, 85.69f+4.28f+0.0f, 0.0f, "f"));
             input.Notes.Add(new Data.NoteInfo(false, 86.76f+4.28f+0.0f, 0.0f, "j"));
             input.Notes.Add(new Data.NoteInfo(false, 87.83f+4.28f+0.0f, 0.0f, "l"));
             input.Notes.Add(new Data.NoteInfo(false, 88.90f+4.28f+0.0f, 0.0f, "d"));
              //4/2
             input.Notes.Add(new Data.NoteInfo(false, 85.69f+8.57f+0.0f, 0.0f, "f"));
             input.Notes.Add(new Data.NoteInfo(false, 86.76f+8.57f+0.0f, 0.0f, "j"));
             input.Notes.Add(new Data.NoteInfo(false, 87.83f+8.57f+0.0f, 0.0f, "f"));
             input.Notes.Add(new Data.NoteInfo(false, 88.90f+8.57f+0.0f, 0.0f, "l"));
              //4/2
             input.Notes.Add(new Data.NoteInfo(false, 85.69f+12.85f+0.0f, 0.0f, "f"));
             input.Notes.Add(new Data.NoteInfo(false, 86.76f+12.85f+0.0f, 0.0f, "space"));
             input.Notes.Add(new Data.NoteInfo(false, 87.83f+12.85f+0.0f, 0.0f, "k"));
             
             input.Notes.Add(new Data.NoteInfo(true, 102.82f, 103.90f, "f"));
             input.Notes.Add(new Data.NoteInfo(true, 104.97f, 106.04f, "s"));
             input.Notes.Add(new Data.NoteInfo(true, 107.11f, 108.18f, "j"));
             input.Notes.Add(new Data.NoteInfo(true, 109.25f, 110.32f, "l"));
             input.Notes.Add(new Data.NoteInfo(true, 111.39f, 112.46f, "d"));
               //3bit
             input.Notes.Add(new Data.NoteInfo(false, 17.13f+96.41f+0.0f, 0.0f, "j"));
             input.Notes.Add(new Data.NoteInfo(false, 17.67f+96.41f+0.0f, 0.0f, "k"));
             input.Notes.Add(new Data.NoteInfo(false, 18.20f+96.41f+0.0f, 0.0f, "l"));

             input.Notes.Add(new Data.NoteInfo(true, 115.68f, 116.75f, "k"));
              //3bit
             input.Notes.Add(new Data.NoteInfo(false, 17.13f+100.69f+0.0f, 0.0f, "s"));
             input.Notes.Add(new Data.NoteInfo(false, 17.67f+100.69f+0.0f, 0.0f, "d"));
             input.Notes.Add(new Data.NoteInfo(false, 18.20f+100.69f+0.0f, 0.0f, "f"));

             input.Notes.Add(new Data.NoteInfo(true, 119.96f, 121.07f, "d"));
             //3bit
             input.Notes.Add(new Data.NoteInfo(false, 17.13f+104.98f+0.0f, 0.0f, "l"));
             input.Notes.Add(new Data.NoteInfo(false, 17.67f+104.98f+0.0f, 0.0f, "k"));
             input.Notes.Add(new Data.NoteInfo(false, 18.20f+104.98f+0.0f, 0.0f, "j"));
             input.Notes.Add(new Data.NoteInfo(true, 124.25f, 125.85f, "space"));

              //4/2
             input.Notes.Add(new Data.NoteInfo(false, 85.69f+40.7f+0.0f, 0.0f, "f"));
             input.Notes.Add(new Data.NoteInfo(false, 86.76f+40.7f+0.0f, 0.0f, "s"));
             input.Notes.Add(new Data.NoteInfo(false, 87.83f+40.7f+0.0f, 0.0f, "j"));
             input.Notes.Add(new Data.NoteInfo(false, 132.28f+0.0f, 0.0f, "d"));
             input.Notes.Add(new Data.NoteInfo(false, 132.82f+0.0f, 0.0f, "k"));
             input.Notes.Add(new Data.NoteInfo(false, 137.01f+0.0f, 0.0f, "a"));
             input.Notes.Add(new Data.NoteInfo(false, 141.39f+0.0f, 0.0f, ";"));
            
             
        }
        else if (input.Difficulty.Equals("Hard")) {
            input.Notes.Add(new Data.NoteInfo(false, 0.00f+0.0f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.07f+0.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 2.14f+0.0f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 3.21f+0.0f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 4.28f+0.0f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 5.35f+0.0f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 6.42f, 7.5f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 7.5f+0.0f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 7.63f+0.0f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 7.76f+0.0f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 8.03f+0.0f, 0.0f, "l"));
            //half *5
            input.Notes.Add(new Data.NoteInfo(false, 8.57f+0.0f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 8.83f+0.0f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 9.10f+0.0f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 9.37f+0.0f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 9.64f+0.0f, 0.0f, "s"));
            //half *5
            input.Notes.Add(new Data.NoteInfo(false, 8.57f + 2.14f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 8.83f + 2.14f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 9.10f + 2.14f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 9.37f + 2.14f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 9.64f + 2.14f, 0.0f, "l"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 12.32f +4.28f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 12.45f +4.28f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 12.58f +4.28f, 0.0f, "space"));
            //half *5
            input.Notes.Add(new Data.NoteInfo(false, 8.57f + 4.28f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.83f + 4.28f, 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 9.10f + 4.28f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 9.37f + 4.28f, 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 9.64f + 4.28f, 0.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 15.0f+0.0f, 0.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 15.26f+0.0f, 0.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 15.66f+0.0f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 15.93f+0.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 16.20f+0.0f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 16.47f+0.0f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 16.74f+0.0f, 0.0f, "l"));
            //main1
            input.Notes.Add(new Data.NoteInfo(true, 17.14f+0.00f, 17.67f+0.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 17.67f+0.00f, 18.21f+0.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 18.21f+0.00f+0.0f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 19.01f+0.00f+0.0f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 19.28f+0.00f+0.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 19.41f+0.00f+0.0f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 19.55f+0.00f+0.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 19.68f+0.00f+0.0f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 19.82f+0.00f+0.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 19.95f+0.00f+0.0f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 20.35f+0.00f+0.0f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 20.49f+0.00f+0.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 20.62f+0.00f+0.0f, 0.0f, "j"));
            //main1
            input.Notes.Add(new Data.NoteInfo(true, 17.14f + 4.28f, 17.67f + 4.28f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 17.67f + 4.28f, 18.21f + 4.28f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 18.21f + 4.28f+0.0f, 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 19.01f + 4.28f+0.0f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 19.28f + 4.28f+0.0f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 19.41f + 4.28f+0.0f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 19.55f + 4.28f+0.0f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 19.68f + 4.28f+0.0f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 19.82f + 4.28f+0.0f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 19.95f + 4.28f+0.0f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 20.35f + 4.28f+0.0f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 20.49f + 4.28f+0.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 20.62f + 4.28f+0.0f, 0.0f, "l"));
            //main1
            input.Notes.Add(new Data.NoteInfo(true, 17.14f + 8.57f, 17.67f + 8.57f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 17.67f + 8.57f, 18.21f + 8.57f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 18.21f + 8.57f+0.0f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 19.01f + 8.57f+0.0f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 19.28f + 8.57f+0.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 19.41f + 8.57f+0.0f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 19.55f + 8.57f+0.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 19.68f + 8.57f+0.0f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 19.82f + 8.57f+0.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 19.95f + 8.57f+0.0f, 0.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(true, 28.92f, 29.46f, "p"));
            input.Notes.Add(new Data.NoteInfo(true, 30.0f, 31.60f, "a"));

            //half *5
            input.Notes.Add(new Data.NoteInfo(false, 8.57f + 23.57f+0.0f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.83f + 23.57f+0.0f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 9.10f + 23.57f+0.0f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 9.37f + 23.57f+0.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 9.64f + 23.57f+0.0f, 0.0f, "s"));
            //half *5
            input.Notes.Add(new Data.NoteInfo(false, 8.57f + 24.91f+0.0f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 8.83f + 24.91f+0.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 9.10f + 24.91f+0.0f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 9.37f + 24.91f+0.0f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 38.03f, 38.57f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 42.85f+0.0f, 0.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 45.0f+0.0f, 0.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 47.14f+0.0f, 0.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 49.28f+0.0f, 0.0f, "p"));

            //half *5
            input.Notes.Add(new Data.NoteInfo(false, 8.57f + 42.85f+0.0f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 8.83f + 42.85f+0.0f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 9.10f + 42.85f+0.0f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 9.37f + 42.85f+0.0f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 9.64f + 42.85f+0.0f, 0.0f, "d"));

            //half *5
            input.Notes.Add(new Data.NoteInfo(false, 8.57f + 45.0f+0.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 8.83f + 45.0f+0.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 9.10f + 45.0f+0.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 9.37f + 45.0f+0.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 9.64f + 45.0f+0.0f, 0.0f, "k"));

            //half *5
            input.Notes.Add(new Data.NoteInfo(false, 8.57f + 47.14f+0.0f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 8.83f + 47.14f+0.0f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 9.10f + 47.14f+0.0f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 9.37f + 47.14f+0.0f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 9.64f + 47.14f+0.0f, 0.0f, "s"));

            //half *5
            input.Notes.Add(new Data.NoteInfo(false, 8.57f + 49.28f+0.0f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 8.83f + 49.28f+0.0f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 9.10f + 49.28f+0.0f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 9.37f + 49.28f+0.0f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 9.64f + 49.28f+0.0f, 0.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 60.00f+0.0f, 0.0f, "j"));

            //funky base
            input.Notes.Add(new Data.NoteInfo(false, 60.00f+0.0f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 60.26f+0.0f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 60.53f+0.0f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 60.80f+0.0f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 61.07f+0.0f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 61.20f+0.0f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 61.33f+0.0f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 61.60f+0.0f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 61.87f+0.0f, 0.0f, "k"));
            //funky base
            input.Notes.Add(new Data.NoteInfo(false, 60.00f +2.14f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 60.26f +2.14f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 60.53f +2.14f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 60.80f +2.14f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 61.07f +2.14f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 61.20f +2.14f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 61.33f +2.14f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 61.60f +2.14f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 61.87f +2.14f, 0.0f, "d"));
            //funky base
            input.Notes.Add(new Data.NoteInfo(false, 60.00f +4.28f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 60.26f +4.28f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 60.53f +4.28f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 60.80f +4.28f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 61.07f +4.28f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 61.20f +4.28f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 61.33f +4.28f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 61.60f +4.28f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 61.87f +4.28f, 0.0f, "p"));
    
            //funky base
            input.Notes.Add(new Data.NoteInfo(false, 60.00f +6.42f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 60.26f +6.42f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 60.53f +6.42f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 60.80f +6.42f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 61.07f +6.42f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 61.20f +6.42f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 61.33f +6.42f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 61.60f +6.42f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 61.87f +6.42f, 0.0f, "d"));
            //violin
            input.Notes.Add(new Data.NoteInfo(false, 66.42f, 0.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 66.96f, 0.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 67.50f, 0.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 68.03f, 0.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 68.57f, 0.0f, "a"));
            //funky base
            input.Notes.Add(new Data.NoteInfo(false, 60.00f +8.57f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 60.26f +8.57f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 60.53f +8.57f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 60.80f +8.57f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 61.07f +8.57f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 61.20f +8.57f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 61.33f +8.57f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 61.60f +8.57f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 61.87f +8.57f, 0.0f, "s"));
            //funky base
            input.Notes.Add(new Data.NoteInfo(false, 60.00f +10.71f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 60.26f +10.71f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 60.53f +10.71f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 60.80f +10.71f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 61.07f +10.71f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 61.20f +10.71f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 61.33f +10.71f, 0.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(true, 72.12f, 74.46f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 75.0f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 76.07f, 0.0f, "q"));

            //one 4
            input.Notes.Add(new Data.NoteInfo(false, 77.14f + 0.0f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 77.67f + 0.0f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 78.21f + 0.0f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 78.75f + 0.0f, 0.0f, "s"));
            //one 4
            input.Notes.Add(new Data.NoteInfo(false, 77.14f +2.14f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 77.67f +2.14f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 78.21f +2.14f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 78.75f +2.14f, 0.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 80.89f, 0.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 81.16f, 0.0f, "p"));
            //one 4
            input.Notes.Add(new Data.NoteInfo(false, 77.14f +4.28f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 77.67f +4.28f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 78.21f +4.28f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 78.75f +4.28f, 0.0f, "d"));
            //one 4
            input.Notes.Add(new Data.NoteInfo(false, 77.14f + 6.43f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 77.67f + 6.43f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 78.21f + 6.43f, 0.0f, "l"));

            //trumpet
            input.Notes.Add(new Data.NoteInfo(false, 85.98f + 0.00f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 86.25f + 0.00f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 86.38f + 0.00f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 86.78f + 0.00f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 87.05f + 0.00f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 87.32f + 0.00f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 87.58f + 0.00f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 87.85f + 0.00f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 88.12f + 0.00f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 88.25f + 0.00f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 88.66f + 0.00f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 88.92f + 0.00f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 89.19f + 0.00f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 89.46f + 0.00f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 89.73f + 0.00f, 0.0f, "d"));
            //trumpet
            input.Notes.Add(new Data.NoteInfo(false, 85.98f + 4.28f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 86.25f + 4.28f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 86.38f + 4.28f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 86.78f + 4.28f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 87.05f + 4.28f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 87.32f + 4.28f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 87.58f + 4.28f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 87.85f + 4.28f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 88.12f + 4.28f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 88.25f + 4.28f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 88.66f + 4.28f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 88.92f + 4.28f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 89.19f + 4.28f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 89.46f + 4.28f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 89.73f + 4.28f, 0.0f, "j"));
            //trumpet
            input.Notes.Add(new Data.NoteInfo(false, 85.98f + 8.57f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 86.25f + 8.57f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 86.38f + 8.57f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 86.78f + 8.57f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 87.05f + 8.57f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 87.32f + 8.57f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 87.58f + 8.57f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 87.85f + 8.57f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 88.12f + 8.57f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 88.25f + 8.57f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 88.66f + 8.57f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 88.92f + 8.57f, 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 89.19f + 8.57f, 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 89.46f + 8.57f, 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 89.73f + 8.57f, 0.0f, "space"));
            //trumpet
            input.Notes.Add(new Data.NoteInfo(false, 85.98f + 12.85f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 86.25f + 12.85f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 86.38f + 12.85f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 86.78f + 12.85f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 87.05f + 12.85f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 87.32f + 12.85f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 87.58f + 12.85f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 87.85f + 12.85f, 0.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(true, 101.25f, 101.78f, ";"));

            //main2
            input.Notes.Add(new Data.NoteInfo(true, 17.14f + 85.71f, 17.67f + 85.71f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 17.67f + 85.71f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 18.21f + 85.71f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 18.21f + 85.71f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 19.01f + 85.71f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 19.28f + 85.71f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 19.41f + 85.71f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 19.55f + 85.71f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 19.68f + 85.71f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 19.82f + 85.71f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 19.95f + 85.71f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 20.35f + 85.71f, 20.62f+85.71f, "q"));

            input.Notes.Add(new Data.NoteInfo(true, 106.87f, 107.14f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 107.14f, 107.67f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 107.67f, 108.21f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 108.21f, 108.75f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 108.75f, 109.28f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 110.35f, 111.42f, ";"));

            input.Notes.Add(new Data.NoteInfo(false, 109.28f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 109.55f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 109.68f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 109.95f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 110.35f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 110.75f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 111.02f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 111.42f, 0.0f, "l"));

            //main1
            input.Notes.Add(new Data.NoteInfo(true, 17.14f + 94.28f, 17.67f + 94.28f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 17.67f + 94.28f, 18.21f + 94.28f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 18.21f + 94.28f + 0.0f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 19.01f + 94.28f + 0.0f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 19.28f + 94.28f + 0.0f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 19.41f + 94.28f + 0.0f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 19.55f + 94.28f + 0.0f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 19.68f + 94.28f + 0.0f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 19.82f + 94.28f + 0.0f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 19.95f + 94.28f + 0.0f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 20.35f + 94.28f + 0.0f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 20.49f + 94.28f + 0.0f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 20.62f + 94.28f + 0.0f, 0.0f, "f"));//
            input.Notes.Add(new Data.NoteInfo(true, 17.14f + 94.28f, 17.67f + 94.28f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 17.67f + 94.28f, 18.21f + 94.28f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 18.21f + 94.28f + 0.0f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 19.01f + 94.28f + 0.0f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 19.28f + 94.28f + 0.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 19.41f + 94.28f + 0.0f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 19.55f + 94.28f + 0.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 19.68f + 94.28f + 0.0f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 19.82f + 94.28f + 0.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 19.95f + 94.28f + 0.0f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 20.35f + 94.28f + 0.0f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 20.49f + 94.28f + 0.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 20.62f + 94.28f + 0.0f, 0.0f, "l"));


            //main1
            input.Notes.Add(new Data.NoteInfo(true, 17.14f + 98.57f, 17.67f + 98.57f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 17.67f + 98.57f, 18.21f + 98.57f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 18.21f + 98.57f + 0.0f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 19.01f + 98.57f + 0.0f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 19.28f + 98.57f + 0.0f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 19.41f + 98.57f + 0.0f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 19.55f + 98.57f + 0.0f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 19.68f + 98.57f + 0.0f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 19.82f + 98.57f + 0.0f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 19.95f + 98.57f + 0.0f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 20.35f + 98.57f + 0.0f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 20.49f + 98.57f + 0.0f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 20.62f + 98.57f + 0.0f, 0.0f, "f"));//
            input.Notes.Add(new Data.NoteInfo(true, 17.14f + 98.57f, 17.67f + 98.57f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 17.67f + 98.57f, 18.21f + 98.57f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 18.21f + 98.57f + 0.0f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 19.01f + 98.57f + 0.0f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 19.28f + 98.57f + 0.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 19.41f + 98.57f + 0.0f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 19.55f + 98.57f + 0.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 19.68f + 98.57f + 0.0f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 19.82f + 98.57f + 0.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 19.95f + 98.57f + 0.0f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 20.35f + 98.57f + 0.0f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 20.49f + 98.57f + 0.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 20.62f + 98.57f + 0.0f, 0.0f, "l"));

            //main1
            input.Notes.Add(new Data.NoteInfo(true, 17.14f + 102.86f, 17.67f + 102.86f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 17.67f + 102.86f, 18.21f + 102.86f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 18.21f + 102.86f + 0.0f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 19.01f + 102.86f + 0.0f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 19.28f + 102.86f + 0.0f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 19.41f + 102.86f + 0.0f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 19.55f + 102.86f + 0.0f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 19.68f + 102.86f + 0.0f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 19.82f + 102.86f + 0.0f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 19.95f + 102.86f + 0.0f, 0.0f, "s"));//
            input.Notes.Add(new Data.NoteInfo(true, 17.14f + 102.86f, 17.67f + 102.86f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 17.67f + 102.86f, 18.21f + 102.86f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 18.21f + 102.86f + 0.0f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 19.01f + 102.86f + 0.0f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 19.28f + 102.86f + 0.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 19.41f + 102.86f + 0.0f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 19.55f + 102.86f + 0.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 19.68f + 102.86f + 0.0f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 19.82f + 102.86f + 0.0f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 19.95f + 102.86f + 0.0f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 123.21f, 123.48f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 123.48f, 123.75f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 123.75f, 124.01f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 124.01f, 124.28f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 124.28f, 125.89f, "f"));

            input.Notes.Add(new Data.NoteInfo(true, 123.21f, 123.48f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 123.48f, 123.75f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 123.75f, 124.01f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 124.01f, 124.28f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 124.28f, 125.89f, "j"));


            //half *5
            input.Notes.Add(new Data.NoteInfo(false, 126.16f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 126.42f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 126.69f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 126.83f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 127.09f, 0.0f, "f"));
            //half *5
            input.Notes.Add(new Data.NoteInfo(false, 127.50f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 127.76f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 128.03f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 128.30f, 0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 128.57f, 0.0f, "s"));

            //half *5
            input.Notes.Add(new Data.NoteInfo(false, 126.16f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 126.42f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 126.69f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 126.83f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 127.09f, 0.0f, "j"));
            //half *5
            input.Notes.Add(new Data.NoteInfo(false, 127.50f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 127.76f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 128.03f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 128.30f, 0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 128.57f, 0.0f, "l"));
            //finale
            input.Notes.Add(new Data.NoteInfo(true, 132.32f, 132.85f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 132.85f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 135.0f, 136.07f, "p"));

            input.Notes.Add(new Data.NoteInfo(false, 136.47f + 0.0f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 136.74f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 137.0f, 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 137.27f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 137.54f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 137.67f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 137.94f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 138.21f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 140.62f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 140.89f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 141.16f, 0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 141.42f, 0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 144.91f, 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 145.17f, 0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 145.44f, 0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 145.71f, 0.0f, "l"));
        }
        else if (input.Difficulty.Equals("Extreme")) {
            input.Notes.Add(new Data.NoteInfo(false, 141.39f+0.0f, 0.0f, ";"));
        }
    }
    }
