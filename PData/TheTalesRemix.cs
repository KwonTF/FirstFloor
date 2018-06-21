using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class TheTalesRemix : MonoBehaviour {

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
        MusicInfo.key = 6;
        MusicInfo.name = "The Tales Remix";
        MusicInfo.composer = "ESTi,Nam Goo Min";
        MusicInfo.visualizer = "Default";
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
        normal.level = 4;
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
        hard.level = 5;
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
        extreme.level = 20;
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
        CreateNote(input);
        input.max_combo = input.Notes.Count;
    }
    void CreateNote(Data.Playdata input)
    {
        input.Notes = new List<Data.NoteInfo>();
        if (input.Difficulty.Equals("Normal"))
        {
            //1st GXylo
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 0.00f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.93f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.37f, 2.00f, "d"));
            //1st GXylo
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 3.85f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 3.85f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 3.85f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.93f + 3.85f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 7.21f, 2.00f, "j"));
            //1st GXylo
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 7.69f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 7.69f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 7.69f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.93f + 7.69f, 2.00f, "s"));
            //3/1
            input.Notes.Add(new Data.NoteInfo(false, 10.57f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 11.05f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 11.53f + 0.00f, 2.00f, "space"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 12.01f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 12.25f + 0.00f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 12.49f + 0.00f, 2.00f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 12.97f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 13.45f, 2.00f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 15.37f, 2.00f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 15.85f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 16.09f, 2.00f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 17.05f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 17.29f, 2.00f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 17.77f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 18.01f, 2.00f, "k"));
            //3 non cor
            input.Notes.Add(new Data.NoteInfo(false, 19.21f+0.00f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 19.57f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 19.93f + 0.00f, 2.00f, "l"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 12.01f + 8.64f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 12.25f + 8.64f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 12.49f + 8.64f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 21.49f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 21.85f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 22.57f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 23.05f, 24.49f, "d"));
            //3/2
            input.Notes.Add(new Data.NoteInfo(false, 24.97f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 25.93f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 26.89f, 2.00f, "j"));
            //3 non cor
            input.Notes.Add(new Data.NoteInfo(false, 19.21f + 9.6f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 19.57f + 9.6f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 19.93f + 9.6f, 2.00f, "l"));
            //3/1
            input.Notes.Add(new Data.NoteInfo(false, 10.57f + 20.64f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 11.05f + 20.64f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 11.53f + 20.64f, 2.00f, "j"));
            //3/1
            input.Notes.Add(new Data.NoteInfo(false, 10.57f + 22.56f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 11.05f + 22.56f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 11.53f + 22.56f, 2.00f, "s"));
            //3/1
            input.Notes.Add(new Data.NoteInfo(false, 10.57f + 24.48f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 11.05f + 24.48f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 11.53f + 24.48f, 2.00f, "f"));
            //3/1
            input.Notes.Add(new Data.NoteInfo(false, 10.57f + 26.4f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 11.05f + 26.4f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 11.53f + 26.4f, 2.00f, "l"));
            //3/1
            input.Notes.Add(new Data.NoteInfo(false, 10.57f + 28.32f, 2.00f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 11.05f + 28.32f, 2.00f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 11.53f + 28.32f, 2.00f, "a"));
            //3/1
            input.Notes.Add(new Data.NoteInfo(false, 10.57f + 30.24f, 2.00f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 11.05f + 30.24f, 2.00f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 11.53f + 30.24f, 2.00f, "q"));

            input.Notes.Add(new Data.NoteInfo(false, 42.25f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 42.49f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 42.97f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 44.17f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 44.89f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 46.09f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 48.01f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 49.93f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 51.85f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 53.77f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 55.69f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 57.61f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 59.53f, 2.00f, "k"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 61.45f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 61.93f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 62.41f + 0.00f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 62.89f + 0.00f, 2.00f, ";"));
            //1st GXylo
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 63.37f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 63.37f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 63.37f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.93f + 63.37f, 2.00f, "d"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 12.01f + 54.72f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 12.25f + 54.72f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 12.49f + 54.72f, 2.00f, "j"));
            //3/1
            input.Notes.Add(new Data.NoteInfo(false, 10.57f + 57.6f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 11.05f + 57.6f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 11.53f + 57.6f, 2.00f, "k"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 12.01f + 58.56f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 12.25f + 58.56f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 12.49f + 58.56f, 2.00f, "f"));
            //3/1
            input.Notes.Add(new Data.NoteInfo(false, 10.57f + 61.44f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 11.05f + 61.44f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 11.53f + 61.44f, 2.00f, "k"));
            //3/1
            input.Notes.Add(new Data.NoteInfo(false, 10.57f + 63.36f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 11.05f + 63.36f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 11.53f + 63.36f, 2.00f, "k"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 12.01f + 63.36f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 12.25f + 63.36f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 12.49f + 63.36f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 76.33f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 76.81f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 78.25f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 78.73f, 2.00f, "s"));
            //3/1
            input.Notes.Add(new Data.NoteInfo(false, 10.57f + 69.12f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 11.05f + 69.12f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 11.53f + 69.12f, 2.00f, "k"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 12.01f + 70.08f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 12.25f + 70.08f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 12.49f + 70.08f, 2.00f, "s"));
            //3/1
            input.Notes.Add(new Data.NoteInfo(false, 10.57f + 72.96f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 11.05f + 72.96f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 11.53f + 72.96f, 2.00f, "k"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 12.01f + 73.92f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 12.25f + 73.92f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 12.49f + 73.92f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 87.37f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 88.33f, 2.00f, "j"));
            //3/1
            input.Notes.Add(new Data.NoteInfo(false, 10.57f + 78.72f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 11.05f + 78.72f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 11.53f + 78.72f, 2.00f, "d"));

            input.Notes.Add(new Data.NoteInfo(true, 92.18f, 94.09f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 94.09f, 95.53f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 95.53f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 96.01f, 97.93f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 97.93f, 99.61f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 99.61f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 99.85f, 2.00f, "k"));
            //3 non cor
            input.Notes.Add(new Data.NoteInfo(false, 19.21f + 81.6f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 19.57f + 81.6f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 19.93f + 81.6f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 101.77f, 103.21f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 103.57f, 2.00f, "l"));
            //3 non cor
            input.Notes.Add(new Data.NoteInfo(false, 19.21f + 85.44f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 19.57f + 85.44f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 19.93f + 85.44f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 105.61f, 2.00f, "k"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 12.01f + 95.04f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 12.25f + 95.04f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 12.49f + 95.04f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 108.97f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 109.21f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 109.45f, 111.37f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 111.37f, 113.29f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 113.29f, 116.17f, "f"));
            //3 non cor
            input.Notes.Add(new Data.NoteInfo(false, 19.21f + 96.96f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 19.57f + 96.96f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 19.93f + 96.96f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 117.13f, 118.57f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 119.05f, 2.00f, "d"));
            //3 non cor
            input.Notes.Add(new Data.NoteInfo(false, 19.21f + 100.8f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 19.57f + 100.8f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 19.93f + 100.8f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 120.97f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 121.93f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 122.89f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 124.33f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 124.57f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 124.81f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 128.65f, 2.00f, "j" ));
            input.Notes.Add(new Data.NoteInfo(false, 132.49f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 134.41f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 136.33f, 2.00f, "space"));
        }
        else if (input.Difficulty.Equals("Hard"))
        {
            //1st GXylo
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 0.00f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.93f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.37f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.61f, 2.00f, "f"));

            //1st GXylo
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 3.85f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 3.85f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 3.85f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.93f + 3.85f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 7.21f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 7.45f, 2.00f, "l"));

            //1st GXylo
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 7.69f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 7.69f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 7.69f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.93f + 7.69f, 2.00f, "s"));
            //3/1
            input.Notes.Add(new Data.NoteInfo(false, 10.57f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 11.05f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 11.53f + 0.00f, 2.00f, "space"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 12.01f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 12.25f + 0.00f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 12.49f + 0.00f, 2.00f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 12.97f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 13.45f, 15.37f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 15.37f, 2.00f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 15.85f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 16.09f, 2.00f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 17.05f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 17.29f, 2.00f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 17.77f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 18.01f, 2.00f, "k"));
            //3 non cor
            input.Notes.Add(new Data.NoteInfo(false, 19.21f + 0.00f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 19.57f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 19.93f + 0.00f, 2.00f, "l"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 12.01f + 8.64f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 12.25f + 8.64f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 12.49f + 8.64f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 21.49f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 21.85f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 22.57f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 23.05f, 24.01f, "d"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 12.01f + 12.24f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 12.25f + 12.24f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 12.49f + 12.24f, 2.00f, "l"));
            //3/2
            input.Notes.Add(new Data.NoteInfo(false, 24.97f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 25.93f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 26.89f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 25.45f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 26.41f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 26.89f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 27.37f, 2.00f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 27.85f, 2.00f, ";"));
            
            //3 non cor
            input.Notes.Add(new Data.NoteInfo(false, 19.21f + 9.6f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 19.57f + 9.6f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 19.93f + 9.6f, 2.00f, "l"));
            //3/1
            input.Notes.Add(new Data.NoteInfo(false, 10.57f + 20.16f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 11.05f + 20.16f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 11.53f + 20.16f, 2.00f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 12.01f + 20.4f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 12.25f + 20.4f, 2.00f, "j"));

            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 12.01f + 21.12f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 12.25f + 21.12f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 12.49f + 21.12f, 2.00f, "j"));
            //3/1
            input.Notes.Add(new Data.NoteInfo(false, 10.57f + 24.0f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 11.05f + 24.0f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 11.53f + 24.0f, 2.00f, "l"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 12.01f + 24.0f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 12.25f + 24.0f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 12.49f + 24.0f, 2.00f, "j"));
            //3/1
            input.Notes.Add(new Data.NoteInfo(false, 10.57f + 26.4f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 11.05f + 26.4f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 11.53f + 26.4f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 38.41f, 2.00f, "a"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 12.01f + 27.6f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 12.25f + 27.6f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 12.49f + 27.6f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 40.33f, 2.00f, "space"));
            //3/1
            input.Notes.Add(new Data.NoteInfo(false, 10.57f + 30.24f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 11.05f + 30.24f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 11.53f + 30.24f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 42.25f, 2.00f, "d"));
            //3/1
            input.Notes.Add(new Data.NoteInfo(false, 10.57f + 20.64f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 11.05f + 20.64f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 11.53f + 20.64f, 2.00f, "j"));
            //3/1
            input.Notes.Add(new Data.NoteInfo(false, 10.57f + 22.56f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 11.05f + 22.56f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 11.53f + 22.56f, 2.00f, "s"));
            //3/1
            input.Notes.Add(new Data.NoteInfo(false, 10.57f + 24.48f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 11.05f + 24.48f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 11.53f + 24.48f, 2.00f, "f"));
            //3/1
            input.Notes.Add(new Data.NoteInfo(false, 10.57f + 26.4f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 11.05f + 26.4f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 11.53f + 26.4f, 2.00f, "l"));
            //3/1
            input.Notes.Add(new Data.NoteInfo(false, 10.57f + 28.32f, 2.00f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 11.05f + 28.32f, 2.00f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 11.53f + 28.32f, 2.00f, "a"));
            //3/1
            input.Notes.Add(new Data.NoteInfo(false, 10.57f + 30.24f, 2.00f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 11.05f + 30.24f, 2.00f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 11.53f + 30.24f, 2.00f, "q"));

            input.Notes.Add(new Data.NoteInfo(false, 42.25f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 42.49f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 42.97f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 44.17f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 44.89f, 2.00f, "j"));

            input.Notes.Add(new Data.NoteInfo(true, 46.09f, 48.01f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 48.01f, 49.93f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 49.93f, 51.85f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 51.85f, 53.77f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 53.77f, 55.69f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 55.69f, 57.61f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 57.61f, 59.53f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 59.53f, 61.45f, "k"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 61.45f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 61.93f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 62.41f + 0.00f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 62.89f + 0.00f, 2.00f, ";"));
            //1st GXylo
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 63.37f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 0.97f + 63.37f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.45f + 63.37f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.93f + 63.37f, 2.00f, "d"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 12.01f + 54.72f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 12.25f + 54.72f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 12.49f + 54.72f, 2.00f, "j"));
            //3/1
            input.Notes.Add(new Data.NoteInfo(false, 10.57f + 57.6f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 11.05f + 57.6f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 11.53f + 57.6f, 2.00f, "k"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 12.01f + 58.56f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 12.25f + 58.56f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 12.49f + 58.56f, 2.00f, "f"));
            //3/1
            input.Notes.Add(new Data.NoteInfo(false, 10.57f + 61.44f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 11.05f + 61.44f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 11.53f + 61.44f, 2.00f, "k"));
            //3/1
            input.Notes.Add(new Data.NoteInfo(false, 10.57f + 63.36f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 11.05f + 63.36f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 11.53f + 63.36f, 2.00f, "k"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 12.01f + 63.36f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 12.25f + 63.36f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 12.49f + 63.36f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 76.33f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 76.81f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 78.25f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 78.73f, 2.00f, "s"));
            //3/1
            input.Notes.Add(new Data.NoteInfo(false, 10.57f + 69.12f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 11.05f + 69.12f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 11.53f + 69.12f, 2.00f, "k"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 12.01f + 70.08f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 12.25f + 70.08f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 12.49f + 70.08f, 2.00f, "s"));
            //3/1
            input.Notes.Add(new Data.NoteInfo(false, 10.57f + 72.96f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 11.05f + 72.96f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 11.53f + 72.96f, 2.00f, "k"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 12.01f + 73.92f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 12.25f + 73.92f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 12.49f + 73.92f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 87.37f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 88.33f, 2.00f, "j"));
            //3/1
            input.Notes.Add(new Data.NoteInfo(false, 10.57f + 78.72f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 11.05f + 78.72f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 11.53f + 78.72f, 2.00f, "d"));

            input.Notes.Add(new Data.NoteInfo(true, 92.18f, 94.09f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 94.09f, 95.53f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 95.53f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 96.01f, 97.93f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 97.93f, 99.61f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 99.61f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 99.85f, 2.00f, "k"));
            //3 non cor
            input.Notes.Add(new Data.NoteInfo(false, 19.21f + 81.6f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 19.57f + 81.6f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 19.93f + 81.6f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 101.77f, 103.21f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 103.57f, 2.00f, "l"));
            //3 non cor
            input.Notes.Add(new Data.NoteInfo(false, 19.21f + 85.44f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 19.57f + 85.44f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 19.93f + 85.44f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 105.61f, 2.00f, "k"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 12.01f + 95.04f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 12.25f + 95.04f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 12.49f + 95.04f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 108.97f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 109.21f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 109.45f, 111.37f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 111.37f, 113.29f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 113.29f, 114.73f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 114.73f, 116.17f, "d"));
            //3 non cor
            input.Notes.Add(new Data.NoteInfo(false, 19.21f + 96.96f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 19.57f + 96.96f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 19.93f + 96.96f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 117.13f, 118.57f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 119.05f, 2.00f, "d"));
            //3 non cor
            input.Notes.Add(new Data.NoteInfo(false, 19.21f + 100.8f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 19.57f + 100.8f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 19.93f + 100.8f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 120.97f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 121.93f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 122.89f, 124.57f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 124.33f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 124.57f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 124.81f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 128.65f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 132.49f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 134.41f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 136.33f, 2.00f, "space"));
        }
        else if (input.Difficulty.Equals("Extreme"))
        {
            input.Notes.Add(new Data.NoteInfo(true, 0.0f + 0.00f, 1.09f, "j"));
        }
    }
}
