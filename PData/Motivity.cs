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
        MusicInfo.key = 2;
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
            input.Notes.Add(new Data.NoteInfo(false, 0.20f + 0.0f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.46f + 0.0f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 0.60f + 0.0f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 0.86f + 0.0f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.13f + 0.0f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.80f + 0.0f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.94f + 0.0f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 2.07f + 0.0f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 2.34f + 0.0f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 2.47f + 0.0f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.61f + 0.0f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 2.87f + 0.0f, 4.48f+0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 3.01f + 0.0f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.28f + 0.0f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.68f + 0.0f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 3.95f + 0.0f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 4.21f + 0.0f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 4.48f + 0.0f, 2.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 4.75f + 0.0f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 4.88f + 0.0f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 5.15f + 0.0f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 5.42f + 0.0f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 6.09f + 0.0f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 6.22f + 0.0f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 6.36f + 0.0f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 6.62f + 0.0f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(true, 6.62f + 0.0f, 7.70f + 0.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 6.76f + 0.0f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 6.89f + 0.0f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 7.29f + 0.0f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 7.56f + 0.0f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 7.70f + 0.0f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 7.83f + 0.0f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 7.96f + 0.0f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 7.96f + 0.0f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 8.23f + 0.0f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 8.23f + 0.0f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 8.50f + 0.0f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 8.50f + 0.0f, 2.0f, ";"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 8.77f + 0.0f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 9.30f + 0.0f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 9.84f + 0.0f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 10.37f + 0.0f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 8.77f + 2.14f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 9.30f + 2.14f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 9.84f + 2.14f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 10.37f + 2.14f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 8.77f + 4.28f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 9.30f + 4.28f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 9.84f + 4.28f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 10.37f + 4.28f, 2.0f, "space"));
            
            input.Notes.Add(new Data.NoteInfo(false, 9.03f + 0.0f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 9.57f + 0.0f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 9.84f + 0.0f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 10.11f + 0.0f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 11.98f + 0.0f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 12.52f + 0.0f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 12.65f + 0.0f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 12.78f + 0.0f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 14.12f + 0.0f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 14.93f + 0.0f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 8.77f + 0.0f, 13.05f+0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 13.05f + 0.0f,15.20f+0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 15.20f + 0.0f, 16.27f+0.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(true, 16.27f + 0.0f, 16.80f+0.0f, "p"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.20f + 0.0f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 15.33f + 0.0f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.46f + 0.0f, 2.0f, "s"));
             //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.20f + 0.4f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.33f + 0.4f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.46f + 0.4f, 2.0f, "d"));
             //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.20f + 1.07f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.33f + 1.07f, 2.0f, "k"));
             //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.20f + 1.6f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 15.33f + 1.6f, 2.0f, "j"));

            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 8.77f + 8.57f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 9.30f + 8.57f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 9.84f + 8.57f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 10.37f + 8.57f, 2.0f, "space"));

           //4/1
            input.Notes.Add(new Data.NoteInfo(false, 8.77f + 10.71f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 9.30f + 10.71f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 9.84f + 10.71f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 10.37f + 10.71f, 2.0f, "space"));
               //4/1
            input.Notes.Add(new Data.NoteInfo(false, 8.77f + 12.85f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 9.30f + 12.85f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 9.84f + 12.85f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 10.37f + 12.85f, 2.0f, "space"));
               //4/1
            input.Notes.Add(new Data.NoteInfo(false, 8.77f + 15.0f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 9.30f + 15.0f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 9.84f + 15.0f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 10.37f + 15.0f, 2.0f, "space"));
               //4/1
            input.Notes.Add(new Data.NoteInfo(false, 8.77f + 17.14f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 9.30f + 17.14f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 9.84f + 17.14f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 10.37f + 17.14f, 2.0f, "space"));
               //4/1
            input.Notes.Add(new Data.NoteInfo(false, 8.77f + 19.28f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 9.30f + 19.28f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 9.84f + 19.28f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 10.37f + 19.28f, 2.0f, "space"));
               //4/1
            input.Notes.Add(new Data.NoteInfo(false, 8.77f + 21.43f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 9.30f + 21.43f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 9.84f + 21.43f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 10.37f + 21.43f, 2.0f, "space"));
            //first trumpet
            input.Notes.Add(new Data.NoteInfo(false, 17.07f + 0.0f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 17.34f + 0.0f, 17.87f+0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 17.87f + 0.0f, 18.41f+0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 18.41f + 0.0f, 2.0f, "j"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 18.41f + 0.0f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 18.68f + 0.0f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 18.95f + 0.0f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 19.21f + 0.0f, 2.0f, ";"));

            input.Notes.Add(new Data.NoteInfo(false, 19.21f + 0.0f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 19.48f + 0.0f, 19.75f+0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 19.75f + 0.0f, 20.02f+0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 20.02f + 0.0f, 20.28f+0.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(true, 20.55f + 0.0f, 20.82f+0.0f, ";"));

            input.Notes.Add(new Data.NoteInfo(false, 20.55f + 0.0f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 20.69f + 0.0f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 20.82f + 0.0f, 2.0f, "s"));
             //first trumpet
            input.Notes.Add(new Data.NoteInfo(false, 17.07f + 4.29f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 17.34f + 4.29f, 17.87f+4.29f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 17.87f + 4.29f, 18.41f+4.29f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 18.41f + 4.29f, 2.0f, "j"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 18.41f + 4.29f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 18.68f + 4.29f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 18.95f + 4.29f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 19.21f + 4.29f, 2.0f, ";"));

            input.Notes.Add(new Data.NoteInfo(false, 19.21f + 4.29f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 19.48f + 4.29f, 19.75f+4.29f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 19.75f + 4.29f, 20.02f+4.29f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 20.02f + 4.29f, 20.28f+4.29f, "k"));

            input.Notes.Add(new Data.NoteInfo(true, 20.55f + 4.29f, 20.82f+4.29f, ";"));
             input.Notes.Add(new Data.NoteInfo(true, 20.55f + 4.29f, 25.64f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 20.55f + 4.29f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 20.69f + 4.29f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 20.82f + 4.29f, 2.0f, "s"));


                    //first trumpet
            input.Notes.Add(new Data.NoteInfo(false, 17.07f + 8.57f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 17.34f + 8.57f, 17.87f+8.57f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 17.87f + 8.57f, 18.41f+8.57f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 18.41f + 8.57f, 2.0f, "l"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 18.41f + 8.57f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 18.68f + 8.57f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 18.95f + 8.57f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 19.21f + 8.57f, 2.0f, "a"));

            input.Notes.Add(new Data.NoteInfo(false, 19.21f + 8.57f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 19.48f + 8.57f, 19.75f+8.57f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 19.75f + 8.57f, 20.02f+8.57f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 20.02f+ 8.57f, 20.28f+8.57f, "d"));

            //first trumpet finale
            input.Notes.Add(new Data.NoteInfo(true, 29.12f + 0.0f, 29.39f+0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 29.39f + 0.0f, 29.66f+0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 29.66f + 0.0f, 29.93f+0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 29.93f + 0.0f, 30.20f+0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 30.20f + 0.0f, 31.80f+0.0f, "l"));
       
            input.Notes.Add(new Data.NoteInfo(true, 32.07f + 0.0f, 32.34f+0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 32.34f + 0.0f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 32.61f + 0.0f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 32.74f + 0.0f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 33.01f + 0.0f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 33.28f + 0.0f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 33.68f + 0.0f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 33.95f + 0.0f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 34.21f + 0.0f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 34.48f + 0.0f, 38.23f+0.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(true, 38.23f + 0.0f, 38.50f+0.0f, "space"));
             //4com
            input.Notes.Add(new Data.NoteInfo(false, 15.20f + 22.9f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 15.33f + 22.9f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 15.46f + 22.9f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 15.59f + 22.9f, 2.0f, ";"));
            //3com
            input.Notes.Add(new Data.NoteInfo(false, 15.20f + 23.3f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.33f + 23.3f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.46f + 23.3f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(true, 39.3f + 0.0f, 39.57f+0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 39.57f + 0.0f, 41.45f+0.0f, "s"));
            //middle xylophone
            input.Notes.Add(new Data.NoteInfo(false, 43.05f + 0.0f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 43.32f + 0.0f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 43.45f + 0.0f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 43.72f + 0.0f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 43.99f + 0.0f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 44.66f + 0.0f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 45.2f + 0.0f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 45.46f + 0.0f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 45.6f + 0.0f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 45.86f + 0.0f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 46.13f + 0.0f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 46.53f + 0.0f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 46.8f + 0.0f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 47.07f + 0.0f, 2.0f, "f"));
            //middle xylophone
            input.Notes.Add(new Data.NoteInfo(false, 43.05f + 4.29f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 43.32f + 4.29f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 43.45f + 4.29f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 43.72f + 4.29f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 43.99f + 4.29f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 44.66f + 4.29f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 45.2f + 4.29f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 45.46f + 4.29f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 45.6f + 4.29f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 45.86f + 4.29f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 46.13f + 4.29f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 46.53f + 4.29f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 46.8f + 4.29f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 47.07f + 4.29f, 2.0f, "k"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 15.20f + 32.14f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 15.33f + 32.14f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 15.46f + 32.14f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 15.59f + 32.14f, 2.0f, "q"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 15.20f + 32.67f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 15.33f + 32.67f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 15.46f + 32.67f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 15.59f + 32.67f, 2.0f, "p"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 15.20f + 33.21f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 15.33f + 33.21f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 15.46f + 33.21f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 15.59f + 33.21f, 2.0f, "q"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 15.20f + 33.75f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 15.33f + 33.75f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 15.46f + 33.75f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 15.59f + 33.75f, 2.0f, "p"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 15.20f + 34.28f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 15.33f + 34.28f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 15.46f + 34.28f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 15.59f + 34.28f, 2.0f, "q"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 15.20f + 34.82f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 15.33f + 34.82f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 15.46f + 34.82f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 15.59f + 34.82f, 2.0f, "p"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 15.20f + 35.35f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 15.33f + 35.35f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 15.46f + 35.35f, 2.0f, "a"));
            //middle xylophon
            input.Notes.Add(new Data.NoteInfo(false, 43.05f + 8.57f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 43.32f + 8.57f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 43.45f + 8.57f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 43.72f + 8.57f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 43.99f + 8.57f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 44.66f + 8.57f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 45.2f + 8.57f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 45.46f + 8.57f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 45.6f + 8.57f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 45.86f + 8.57f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 46.13f + 8.57f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 46.53f + 8.57f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 46.8f + 8.57f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 47.07f + 8.57f, 2.0f, "f"));
            //middle xylophone
            input.Notes.Add(new Data.NoteInfo(false, 43.05f + 12.86f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 43.32f + 12.86f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 43.45f + 12.86f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 43.72f + 12.86f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 43.99f + 12.86f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 44.66f + 12.86f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 45.2f + 12.86f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 45.46f + 12.86f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 45.6f + 12.86f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 45.86f + 12.86f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 46.13f + 12.86f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 46.53f + 12.86f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 46.8f + 12.86f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 47.07f + 12.86f, 2.0f, "l"));
             //5/2
            input.Notes.Add(new Data.NoteInfo(false, 18.41f + 33.21f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 18.68f + 33.21f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 18.95f + 33.21f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 19.21f + 33.21f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 19.48f + 33.21f, 2.0f, "space"));
              //5/2
            input.Notes.Add(new Data.NoteInfo(false, 18.41f + 35.36f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 18.68f + 35.36f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 18.95f + 35.36f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 19.21f + 35.36f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 19.48f + 35.36f, 2.0f, "space"));
              //5/2
            input.Notes.Add(new Data.NoteInfo(false, 18.41f + 37.5f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 18.68f + 37.5f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 18.95f + 37.5f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 19.21f + 37.5f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 19.48f + 37.5f, 2.0f, "space"));

            input.Notes.Add(new Data.NoteInfo(true, 58.05f + 0.0f, 59.12f+0.0f, "space"));
            //guitar
            input.Notes.Add(new Data.NoteInfo(true, 51.09f + 0.0f, 51.62f+0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 51.62f + 0.0f, 55.37f+0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 55.37f + 0.0f, 55.91f+0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 55.91f + 0.0f, 59.12f+0.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(true, 59.36f + 0.0f, 59.66f+0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 59.66f + 0.0f, 59.93f+0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 59.93f + 0.0f, 60.2f+0.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 60.20f + 0.0f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 60.46f + 0.0f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 60.60f + 0.0f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 60.73f + 0.0f, 61.13f+0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 61.27f + 0.0f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 61.53f + 0.0f, 62.34f+0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 62.61f + 0.0f, 63.14f+0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 63.28f + 0.0f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 63.54f + 0.0f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 63.81f + 0.0f, 64.88f+0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 65.02f + 0.0f, 65.28f+0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 65.42f + 0.0f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 65.69f + 0.0f, 66.49f+0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 66.62f + 0.0f, 67.03f+0.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 67.16f + 0.0f, 67.43f+0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 67.56f + 0.0f, 68.5f+0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 68.77f + 0.0f, 69.17f+0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 69.30f + 0.0f, 69.57f+0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 69.7f + 0.0f, 70.11f+0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 70.37f + 0.0f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 70.64f + 0.0f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 70.91f + 0.0f, 71.45f+0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 71.98f + 0.0f, 73.05f+0.0f, "d"));
             //4com
            input.Notes.Add(new Data.NoteInfo(false, 15.20f + 57.99f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 15.33f + 57.99f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.46f + 57.99f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.59f + 57.99f, 2.0f, "d"));
             //4com
            input.Notes.Add(new Data.NoteInfo(false, 15.20f + 58.52f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.33f + 58.52f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 15.46f + 58.52f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.59f + 58.52f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 74.26f + 0.0f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 74.39f + 0.0f, 75.2f+0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 75.33f + 0.0f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 75.46f + 0.0f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 75.6f + 0.0f, 76.13f+0.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 76.27f + 0.0f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 76.4f + 0.0f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 76.53f + 0.0f, 76.94f+0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 77.07f + 0.0f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 77.2f + 0.0f, 79.48f+0.0f, "k"));
            //
            //basefunky
            input.Notes.Add(new Data.NoteInfo(false, 18.41f + 41.79f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 18.68f + 41.79f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 18.95f + 41.79f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 19.21f + 41.79f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 19.48f + 41.79f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 18.41f + 43.12f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 18.68f + 43.12f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 18.95f + 43.12f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 19.49f + 43.12f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 19.76f + 43.12f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 15.20f + 48.21f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 15.33f + 48.21f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 15.46f + 48.21f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 63.95f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 64.21f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 18.41f + 46.07f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 18.68f + 46.07f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 18.95f + 46.07f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 19.21f + 46.07f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 19.48f + 46.07f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 18.41f + 47.41f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 18.68f + 47.41f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 18.95f + 47.41f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 19.21f + 47.41f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 19.48f + 47.41f, 2.0f, "p"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 8.77f + 58.39f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 9.30f + 58.39f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 9.84f + 58.39f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 10.37f + 58.39f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 8.77f + 60.53f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 9.30f + 60.53f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 9.84f + 60.53f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 10.37f + 60.53f, 2.0f, "space"));
             //4/1
            input.Notes.Add(new Data.NoteInfo(false, 8.77f + 62.68f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 9.30f + 62.68f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 9.84f + 62.68f, 2.0f, "space"));

            input.Notes.Add(new Data.NoteInfo(false, 67.7f + 0.0f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 69.03f + 0.0f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 69.44f + 0.0f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 69.7f + 0.0f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 71.98f + 0.0f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 72.78f + 0.0f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(true, 73.05f + 0.0f, 75.2f+0.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 75.2f + 0.0f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 75.46f + 0.0f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 75.6f + 0.0f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 75.86f + 0.0f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 76.27f + 0.0f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 76.53f + 0.0f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 76.80f + 0.0f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 77.07f + 0.0f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 77.34f + 0.0f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(true, 77.34f + 0.0f, 77.87f+0.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 77.87f + 0.0f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 78.01f + 0.0f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 78.14f + 0.0f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 78.28f + 0.0f, 78.95f+0.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 78.95f + 0.0f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 79.21f + 0.0f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 79.48f + 0.0f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 79.75f + 0.0f, 2.0f, "d"));
              //4com
            input.Notes.Add(new Data.NoteInfo(false, 15.20f + 64.82f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.33f + 64.82f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.46f + 64.82f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 15.59f + 64.82f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 81.09f + 0.0f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 81.36f + 0.0f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 81.62f + 0.0f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 81.09f + 0.0f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 81.36f + 0.0f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 81.62f + 0.0f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 81.89f + 0.0f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 82.03f + 0.0f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 82.29f + 0.0f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 82.56f + 0.0f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 83.23f + 0.0f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 83.5f + 0.0f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 83.77f + 0.0f, 84.3f+0.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 84.3f + 0.0f, 84.84f+0.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 84.84f + 0.0f, 85.91f+0.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 82.16f + 0.0f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 82.7f + 0.0f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 83.23f + 0.0f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 83.77f + 0.0f, 84.84f+0.0f, "space"));

            //mid trum
            input.Notes.Add(new Data.NoteInfo(false, 86.18f + 0.0f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 86.45f + 0.0f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 86.58f + 0.0f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 86.98f + 0.0f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 87.25f + 0.0f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 87.52f + 0.0f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 87.78f + 0.0f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 88.05f + 0.0f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 88.19f + 0.0f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 88.32f + 0.0f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 88.59f + 0.0f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 89.12f + 0.0f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 89.39f + 0.0f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 89.66f + 0.0f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 89.93f + 0.0f, 2.0f, "k"));

            //mid trum
            input.Notes.Add(new Data.NoteInfo(false, 86.18f + 4.28f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 86.45f + 4.28f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 86.58f + 4.28f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 86.98f + 4.28f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 87.25f + 4.28f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 87.52f + 4.28f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 87.78f + 4.28f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 88.05f + 4.28f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 88.19f + 4.28f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 88.32f + 4.28f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 88.59f + 4.28f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 89.12f + 4.28f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 89.39f + 4.28f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 89.66f + 4.28f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 89.93f + 4.28f, 2.0f, "p"));
            //mid trum
            input.Notes.Add(new Data.NoteInfo(false, 86.18f + 8.57f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 86.45f + 8.57f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 86.58f + 8.57f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 86.98f + 8.57f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 87.25f + 8.57f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 87.52f + 8.57f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 87.78f + 8.57f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 88.05f + 8.57f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 88.19f + 8.57f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 88.32f + 8.57f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 88.59f + 8.57f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 89.12f + 8.57f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 89.39f + 8.57f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 89.66f + 8.57f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 89.93f + 8.57f, 2.0f, ";"));
            //mid trum
            input.Notes.Add(new Data.NoteInfo(false, 86.18f + 12.85f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 86.45f + 12.85f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 86.58f + 12.85f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 86.98f + 12.85f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 87.25f + 12.85f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 87.52f + 12.85f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 87.78f + 12.85f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 88.05f + 12.85f, 2.0f, "q"));
           
            input.Notes.Add(new Data.NoteInfo(true, 101.45f + 0.0f, 101.98f, "space"));

            //first trumpet
            input.Notes.Add(new Data.NoteInfo(false, 17.07f + 85.71f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 17.34f + 85.71f, 17.87f+85.71f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 17.87f + 85.71f, 18.41f+85.71f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 18.41f + 85.71f, 2.0f, ";"));

            input.Notes.Add(new Data.NoteInfo(false, 19.21f + 85.71f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 19.48f + 85.71f, 19.75f+85.71f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 19.75f + 85.71f, 20.02f+85.71f, "p"));
            input.Notes.Add(new Data.NoteInfo(true, 20.02f + 85.71f, 20.28f+85.71f, "space"));

            input.Notes.Add(new Data.NoteInfo(false, 20.55f + 85.71f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 20.69f + 85.71f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 20.82f + 85.71f, 2.0f, ";"));

            input.Notes.Add(new Data.NoteInfo(true, 107.07f, 107.34f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 107.34f, 107.87f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 107.87f, 108.41f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 108.41f, 108.95f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 108.95f, 109.48f, "a"));

            input.Notes.Add(new Data.NoteInfo(false, 109.48f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 109.75f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 109.88f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 110.15f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 110.42f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 110.69f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 110.95f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 111.22f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 110.55f, 111.09f, "space"));
             //first trumpet
            input.Notes.Add(new Data.NoteInfo(false, 17.07f + 94.29f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 17.34f + 94.29f, 17.87f+94.29f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 17.87f + 94.29f, 18.41f+94.29f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 18.41f + 94.29f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 19.21f + 94.29f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 19.48f + 94.29f, 19.75f+94.29f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 19.75f + 94.29f, 20.02f+94.29f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 20.02f + 94.29f, 20.28f+94.29f, "space"));

            input.Notes.Add(new Data.NoteInfo(false, 20.55f + 94.29f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 20.69f + 94.29f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 20.82f + 94.29f, 2.0f, "f"));
             //first trumpet
            input.Notes.Add(new Data.NoteInfo(false, 17.07f + 98.57f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 17.34f + 98.57f, 17.87f+98.57f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 17.87f + 98.57f, 18.41f+98.57f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 18.41f + 98.57f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 19.21f + 98.57f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 19.48f + 98.57f, 19.75f+98.57f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 19.75f + 98.57f, 20.02f+98.57f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 20.02f + 98.57f, 20.28f+98.57f, "space"));

            input.Notes.Add(new Data.NoteInfo(false, 20.55f + 98.57f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 20.69f + 98.57f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 20.82f + 98.57f, 2.0f, "j"));
             //first trumpet
            input.Notes.Add(new Data.NoteInfo(false, 17.07f + 102.86f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 17.34f + 102.86f, 17.87f+102.86f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 17.87f + 102.86f, 18.41f+102.86f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 18.41f + 102.86f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 19.21f + 102.86f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 19.48f + 102.86f, 19.75f+102.86f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 19.75f + 102.86f, 20.02f+102.86f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 20.02f + 102.86f, 20.28f+102.86f, "space"));
            //2
            //first trumpet
            input.Notes.Add(new Data.NoteInfo(false, 17.07f + 94.29f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(true, 17.34f + 94.29f, 17.87f+94.29f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 17.87f + 94.29f, 18.41f+94.29f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 18.41f + 94.29f, 2.0f, "a"));

            input.Notes.Add(new Data.NoteInfo(false, 19.21f + 94.29f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 19.48f + 94.29f, 19.75f+94.29f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 19.75f + 94.29f, 20.02f+94.29f, "a"));
            input.Notes.Add(new Data.NoteInfo(true, 20.02f + 94.29f, 20.28f+94.29f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 20.55f + 94.29f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 20.69f + 94.29f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 20.82f + 94.29f, 2.0f, "a"));
             //first trumpet
            input.Notes.Add(new Data.NoteInfo(false, 17.07f + 98.57f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 17.34f + 98.57f, 17.87f+98.57f, "a"));
            input.Notes.Add(new Data.NoteInfo(true, 17.87f + 98.57f, 18.41f+98.57f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 18.41f + 98.57f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 19.21f + 98.57f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(true, 19.48f + 98.57f, 19.75f+98.57f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 19.75f + 98.57f, 20.02f+98.57f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 20.02f + 98.57f, 20.28f+98.57f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 20.55f + 98.57f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 20.69f + 98.57f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 20.82f + 98.57f, 2.0f, "d"));
             //first trumpet
            input.Notes.Add(new Data.NoteInfo(false, 17.07f + 102.86f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(true, 17.34f + 102.86f, 17.87f+102.86f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 17.87f + 102.86f, 18.41f+102.86f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 18.41f + 102.86f, 2.0f, "a"));

            input.Notes.Add(new Data.NoteInfo(false, 19.21f + 102.86f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 19.48f + 102.86f, 19.75f+102.86f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 19.75f + 102.86f, 20.02f+102.86f, "a"));
            input.Notes.Add(new Data.NoteInfo(true, 20.02f + 102.86f, 20.28f+102.86f, "s"));
            //3
            //first trumpet
            input.Notes.Add(new Data.NoteInfo(false, 17.07f + 94.29f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 17.34f + 94.29f, 17.87f+94.29f, ";"));
            input.Notes.Add(new Data.NoteInfo(true, 17.87f + 94.29f, 18.41f+94.29f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 18.41f + 94.29f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 19.21f + 94.29f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(true, 19.48f + 94.29f, 19.75f+94.29f, "l"));//rev
            input.Notes.Add(new Data.NoteInfo(true, 19.75f + 94.29f, 20.02f+94.29f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 20.02f + 94.29f, 20.28f+94.29f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 20.55f + 94.29f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 20.69f + 94.29f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 20.82f + 94.29f, 2.0f, "k"));
             //first trumpet
            input.Notes.Add(new Data.NoteInfo(false, 17.07f + 98.57f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(true, 17.34f + 98.57f, 17.87f+98.57f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 17.87f + 98.57f, 18.41f+98.57f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 18.41f + 98.57f, 2.0f, ";"));

            input.Notes.Add(new Data.NoteInfo(false, 19.21f + 98.57f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 19.48f + 98.57f, 19.75f+98.57f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 19.75f + 98.57f, 20.02f+98.57f, ";"));
            input.Notes.Add(new Data.NoteInfo(true, 20.02f + 98.57f, 20.28f+98.57f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 20.55f + 98.57f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 20.69f + 98.57f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 20.82f + 98.57f, 2.0f, ";"));
             //first trumpet
            input.Notes.Add(new Data.NoteInfo(false, 17.07f + 102.86f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 17.34f + 102.86f, 17.87f+102.86f, ";"));
            input.Notes.Add(new Data.NoteInfo(true, 17.87f + 102.86f, 18.41f+102.86f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 18.41f + 102.86f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 19.21f + 102.86f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(true, 19.48f + 102.86f, 19.75f+102.86f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 19.75f + 102.86f, 20.02f+102.86f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 20.02f + 102.86f, 20.28f+102.86f, "l"));

              //first trumpet finale
            input.Notes.Add(new Data.NoteInfo(true, 29.12f + 94.29f, 29.39f+94.29f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 29.39f + 94.29f, 29.66f+94.29f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 29.66f + 94.29f, 29.93f+94.29f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 29.93f + 94.29f, 30.20f+94.29f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 30.20f + 94.29f, 31.80f+94.29f, "space"));
       
            input.Notes.Add(new Data.NoteInfo(true, 32.07f + 94.29f, 32.34f+94.29f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 32.34f + 94.29f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 32.61f + 94.29f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 32.74f + 94.29f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 33.01f + 94.29f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 33.28f + 94.29f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 33.68f + 94.29f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 33.95f + 94.29f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 34.21f + 94.29f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 34.48f + 94.29f, 131.98f, "j"));
            //2
              //first trumpet finale
            input.Notes.Add(new Data.NoteInfo(true, 29.12f + 94.29f, 29.39f+94.29f, "a"));
            input.Notes.Add(new Data.NoteInfo(true, 29.39f + 94.29f, 29.66f+94.29f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 29.66f + 94.29f, 29.93f+94.29f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 29.93f + 94.29f, 30.20f+94.29f, "a"));
            input.Notes.Add(new Data.NoteInfo(true, 30.20f + 94.29f, 31.80f+94.29f, "s"));
       
            input.Notes.Add(new Data.NoteInfo(true, 32.07f + 94.29f, 32.34f+94.29f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 32.34f + 94.29f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 32.61f + 94.29f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 32.74f + 94.29f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 33.01f + 94.29f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 33.28f + 94.29f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 33.68f + 94.29f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 33.95f + 94.29f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 34.21f + 94.29f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 34.48f + 94.29f, 131.98f, "d"));
            //3
              //first trumpet finale
            input.Notes.Add(new Data.NoteInfo(true, 29.12f + 94.29f, 29.39f+94.29f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 29.39f + 94.29f, 29.66f+94.29f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 29.66f + 94.29f, 29.93f+94.29f, ";"));
            input.Notes.Add(new Data.NoteInfo(true, 29.93f + 94.29f, 30.20f+94.29f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 30.20f + 94.29f, 31.80f+94.29f, "l"));
       
            input.Notes.Add(new Data.NoteInfo(true, 32.07f + 94.29f, 32.34f+94.29f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 32.34f + 94.29f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 32.61f + 94.29f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 32.74f + 94.29f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 33.01f + 94.29f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 33.28f + 94.29f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 33.68f + 94.29f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 33.95f + 94.29f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 34.21f + 94.29f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 34.48f + 94.29f, 131.98f, ";"));

            input.Notes.Add(new Data.NoteInfo(false, 132.25f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 132.38f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 132.52f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 132.65f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 132.78f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(true, 132.52f, 133.05f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 133.05f, 134.66f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 135.2f, 136.27f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 136.53f + 0.0f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 136.8f + 0.0f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 137.07f + 0.0f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 137.34f + 0.0f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 137.61f + 0.0f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 137.74f + 0.0f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 138.01f + 0.0f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 138.28f + 0.0f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 140.82f + 0.0f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 141.09f + 0.0f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 141.36f + 0.0f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 141.62f + 0.0f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 145.11f + 0.0f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 145.37f + 0.0f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 145.64f + 0.0f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 145.91f + 0.0f, 2.0f, "s"));//*/
            
        }
    }
    }
