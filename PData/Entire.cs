using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class Entire : MonoBehaviour
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
        MusicInfo.key = 7;
        MusicInfo.name = "Entire";
        MusicInfo.composer = "KIEN";
        MusicInfo.visualizer = "Flow.D";
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
        normal.level = 9;
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
        hard.level = 16;
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
        if (input.Difficulty.Equals("Normal"))
        {
            input.Notes.Add(new Data.NoteInfo(true, 0.00f, 0.65f, "k"));
            //first Ry
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 0.00f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 0.00f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 0.00f, 2.00f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 1.37f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.58f + 0.00f, 2.00f, "k"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 0.82f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 0.82f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 0.82f + 0.00f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 0.82f + 0.00f, 2.00f, "l"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 1.65f + 0.00f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 1.65f + 0.00f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 1.65f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 1.65f + 0.00f, 2.00f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 2.82f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.02f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.13f + 0.00f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 3.33f + 0.00f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 3.54f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.64f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.85f + 0.00f, 2.00f, "d"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 3.31f + 0.00f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 3.31f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 3.31f + 0.00f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 3.31f + 0.00f, 2.00f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 4.68f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 4.89f + 0.00f, 2.00f, "d"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 4.13f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 4.13f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 4.13f + 0.00f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 4.13f + 0.00f, 2.00f, "s"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 4.96f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 4.96f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 4.96f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 4.96f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 6.13f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 6.33f + 0.00f, 2.00f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 6.44f + 0.00f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 6.54f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 6.64f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 6.75f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 6.85f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 6.95f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 7.06f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 7.16f + 0.00f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 7.27f + 0.00f, 2.00f, "a"));
            input.Notes.Add(new Data.NoteInfo(true, 6.44f + 0.00f, 7.27f + 0.00f, ";"));
            //first Ry
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 6.62f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 6.62f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 6.62f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 6.62f, 2.00f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 1.37f + 6.62f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.58f + 6.62f, 2.00f, "k"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 0.82f + 6.62f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 0.82f + 6.62f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 0.82f + 6.62f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 0.82f + 6.62f, 2.00f, "l"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 1.65f + 6.62f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 1.65f + 6.62f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 1.65f + 6.62f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 1.65f + 6.62f, 2.00f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 2.82f + 6.62f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.02f + 6.62f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.13f + 6.62f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 3.33f + 6.62f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 3.54f + 6.62f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.64f + 6.62f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.85f + 6.62f, 2.00f, "d"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 3.31f + 6.62f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 3.31f + 6.62f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 3.31f + 6.62f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 3.31f + 6.62f, 2.00f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 4.68f + 6.62f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 4.89f + 6.62f, 2.00f, "d"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 4.13f + 6.62f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 4.13f + 6.62f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 4.13f + 6.62f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 4.13f + 6.62f, 2.00f, "s"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 4.96f + 6.62f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 4.96f + 6.62f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 4.96f + 6.62f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 4.96f + 6.62f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 6.13f + 6.62f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 6.33f + 6.62f, 2.00f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 6.44f + 6.62f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 6.54f + 6.62f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 6.64f + 6.62f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 6.75f + 6.62f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 6.85f + 6.62f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 6.95f + 6.62f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 7.06f + 6.62f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 7.16f + 6.62f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 7.27f + 6.62f, 2.00f, "a"));
            input.Notes.Add(new Data.NoteInfo(true, 6.44f + 6.62f, 7.27f + 6.62f, ";"));
            //first Ry
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 13.24f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 13.24f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 13.24f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 13.24f, 2.00f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 1.37f + 13.24f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.58f + 13.24f, 2.00f, "k"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 0.82f + 13.24f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 0.82f + 13.24f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 0.82f + 13.24f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 0.82f + 13.24f, 2.00f, "l"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 1.65f + 13.24f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 1.65f + 13.24f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 1.65f + 13.24f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 1.65f + 13.24f, 2.00f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 2.82f + 13.24f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.02f + 13.24f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.13f + 13.24f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 3.33f + 13.24f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 3.54f + 13.24f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.64f + 13.24f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.85f + 13.24f, 2.00f, "d"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 3.31f + 13.24f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 3.31f + 13.24f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 3.31f + 13.24f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 3.31f + 13.24f, 2.00f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 4.68f + 13.24f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 4.89f + 13.24f, 2.00f, "d"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 4.13f + 13.24f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 4.13f + 13.24f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 4.13f + 13.24f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 4.13f + 13.24f, 2.00f, "s"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 4.96f + 13.24f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 4.96f + 13.24f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 4.96f + 13.24f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 4.96f + 13.24f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 6.13f + 13.24f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 6.33f + 13.24f, 2.00f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 6.44f + 13.24f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 6.54f + 13.24f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 6.64f + 13.24f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 6.75f + 13.24f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 6.85f + 13.24f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 6.95f + 13.24f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 7.06f + 13.24f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 7.16f + 13.24f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 7.27f + 13.24f, 2.00f, "a"));
            input.Notes.Add(new Data.NoteInfo(true, 6.44f + 13.24f, 7.27f + 13.24f, ";"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 14.30f + 0.00f, 2.00f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 15.13f + 0.00f, 2.00f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 15.95f + 0.00f, 2.00f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 16.78f + 0.00f, 2.00f, "p"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 14.30f + 3.31f, 2.00f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 15.13f + 3.31f, 2.00f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 15.95f + 3.31f, 2.00f, ";"));
            //first Ry
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 19.86f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 19.86f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 19.86f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 19.86f, 2.00f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 1.37f + 19.86f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.58f + 19.86f, 2.00f, "k"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 0.82f + 19.86f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 0.82f + 19.86f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 0.82f + 19.86f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 0.82f + 19.86f, 2.00f, "l"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 1.65f + 19.86f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 1.65f + 19.86f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 1.65f + 19.86f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 1.65f + 19.86f, 2.00f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 2.82f + 19.86f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.02f + 19.86f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.13f + 19.86f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 3.33f + 19.86f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 3.54f + 19.86f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.64f + 19.86f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.85f + 19.86f, 2.00f, "d"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 3.31f + 19.86f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 3.31f + 19.86f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 3.31f + 19.86f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 3.31f + 19.86f, 2.00f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 4.68f + 19.86f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 4.89f + 19.86f, 2.00f, "d"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 4.13f + 19.86f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 4.13f + 19.86f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 4.13f + 19.86f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 4.13f + 19.86f, 2.00f, "s"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 4.96f + 19.86f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 4.96f + 19.86f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 4.96f + 19.86f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 4.96f + 19.86f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 6.13f + 19.86f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 6.33f + 19.86f, 2.00f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 6.44f + 19.86f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 6.54f + 19.86f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 6.64f + 19.86f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 6.75f + 19.86f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 6.85f + 19.86f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 6.95f + 19.86f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 7.06f + 19.86f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 7.16f + 19.86f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 7.27f + 19.86f, 2.00f, "a"));
            input.Notes.Add(new Data.NoteInfo(true, 6.44f + 19.86f, 7.27f + 19.86f, ";"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 14.30f + 6.62f, 2.00f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 15.13f + 6.62f, 2.00f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 15.95f + 6.62f, 2.00f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 16.78f + 6.62f, 2.00f, ";"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 14.30f + 9.93f, 2.00f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 15.13f + 9.93f, 2.00f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 15.95f + 9.93f, 2.00f, "p"));
            //first Ry
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 26.48f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 26.48f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 26.48f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 26.48f, 2.00f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 1.37f + 26.48f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.58f + 26.48f, 2.00f, "k"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 0.82f + 26.48f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 0.82f + 26.48f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 0.82f + 26.48f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 0.82f + 26.48f, 2.00f, "l"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 1.65f + 26.48f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 1.65f + 26.48f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 1.65f + 26.48f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 1.65f + 26.48f, 2.00f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 2.82f + 26.48f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.02f + 26.48f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.13f + 26.48f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 3.33f + 26.48f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 3.54f + 26.48f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.64f + 26.48f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.85f + 26.48f, 2.00f, "d"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 3.31f + 26.48f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 3.31f + 26.48f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 3.31f + 26.48f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 3.31f + 26.48f, 2.00f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 4.68f + 26.48f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 4.89f + 26.48f, 2.00f, "d"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 4.13f + 26.48f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 4.13f + 26.48f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 4.13f + 26.48f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 4.13f + 26.48f, 2.00f, "s"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 4.96f + 26.48f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 4.96f + 26.48f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 4.96f + 26.48f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 4.96f + 26.48f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 6.13f + 26.48f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 6.33f + 26.48f, 2.00f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 6.44f + 26.48f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 6.54f + 26.48f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 6.64f + 26.48f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 6.75f + 26.48f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 6.85f + 26.48f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 6.95f + 26.48f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 7.06f + 26.48f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 7.16f + 26.48f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 7.27f + 26.48f, 2.00f, "a"));
            input.Notes.Add(new Data.NoteInfo(true, 6.44f + 26.48f, 7.27f + 26.48f, ";"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 27.13f + 0.00f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.54f + 0.00f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.95f + 0.00f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 28.37f + 0.00f, 2.00f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 27.13f + 1.65f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.54f + 1.65f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.95f + 1.65f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 28.37f + 1.65f, 2.00f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 27.13f + 3.31f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.54f + 3.31f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.95f + 3.31f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 28.37f + 3.31f, 2.00f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 27.13f + 4.96f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.54f + 4.96f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.95f + 4.96f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 28.37f + 4.96f, 2.00f, "space"));
            //first Ry
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 33.1f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 33.1f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 33.1f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 33.1f, 2.00f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 1.37f + 33.1f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.58f + 33.1f, 2.00f, "k"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 0.82f + 33.1f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 0.82f + 33.1f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 0.82f + 33.1f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 0.82f + 33.1f, 2.00f, "l"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 1.65f + 33.1f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 1.65f + 33.1f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 1.65f + 33.1f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 1.65f + 33.1f, 2.00f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 2.82f + 33.1f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.02f + 33.1f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.13f + 33.1f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 3.33f + 33.1f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 3.54f + 33.1f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.64f + 33.1f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.85f + 33.1f, 2.00f, "d"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 3.31f + 33.1f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 3.31f + 33.1f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 3.31f + 33.1f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 3.31f + 33.1f, 2.00f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 4.68f + 33.1f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 4.89f + 33.1f, 2.00f, "d"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 4.13f + 33.1f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 4.13f + 33.1f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 4.13f + 33.1f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 4.13f + 33.1f, 2.00f, "s"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 4.96f + 33.1f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 4.96f + 33.1f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 4.96f + 33.1f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 4.96f + 33.1f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 6.13f + 33.1f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 6.33f + 33.1f, 2.00f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 6.44f + 33.1f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 6.54f + 33.1f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 6.64f + 33.1f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 6.75f + 33.1f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 6.85f + 33.1f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 6.95f + 33.1f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 7.06f + 33.1f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 7.16f + 33.1f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 7.27f + 33.1f, 2.00f, "a"));
            input.Notes.Add(new Data.NoteInfo(true, 6.44f + 33.1f, 7.27f + 33.1f, ";"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 27.13f + 6.62f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.54f + 6.62f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.95f + 6.62f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 28.37f + 6.62f, 2.00f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 27.13f + 8.27f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.54f + 8.27f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.95f + 8.27f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 28.37f + 8.27f, 2.00f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 27.13f + 9.93f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.54f + 9.93f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.95f + 9.93f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 28.37f + 9.93f, 2.00f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 27.13f + 11.58f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.54f + 11.58f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.95f + 11.58f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 28.37f + 11.58f, 2.00f, "space"));

            //bridge
            input.Notes.Add(new Data.NoteInfo(false, 40.37f, 2.00f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 40.57f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 40.68f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 40.78f, 2.00f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 40.88f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 40.99f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 41.09f, 2.00f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 41.30f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 41.40f, 2.00f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 41.61f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 41.76f, 2.00f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 41.92f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 42.02f, 2.00f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 42.23f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 42.33f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 42.44f, 2.00f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 42.54f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 42.64f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 42.75f, 2.00f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 42.95f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 43.06f, 2.00f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 43.26f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 43.37f, 2.00f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 43.47f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 43.57f, 2.00f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 43.88f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 43.99f, 2.00f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 44.19f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 44.30f, 2.00f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 44.50f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 44.61f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 44.71f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 44.81f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 44.92f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 45.02f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 45.12f, 2.00f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 45.33f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 45.43f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 45.54f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 45.64f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 45.75f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 45.85f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 45.95f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 46.06f, 2.00f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 46.16f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 46.26f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 46.37f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 46.47f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 46.57f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 46.68f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 46.78f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 46.88f, 2.00f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 46.99f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 47.09f, 2.00f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 47.40f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 47.50f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 47.61f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 47.71f, 2.00f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 47.92f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 48.02f, 2.00f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 48.23f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 48.33f, 2.00f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 48.43f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 48.54f, 2.00f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 48.74f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 48.85f, 2.00f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 49.06f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 49.16f, 2.00f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 49.37f, 2.00f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 49.57f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 49.68f, 2.00f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 49.88f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 49.99f, 2.00f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 50.09f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 50.19f, 2.00f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 50.40f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 50.50f, 2.00f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 50.71f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 50.81f, 2.00f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 51.12f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 51.23f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 51.33f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 51.43f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 51.54f, 2.00f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 51.64f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 51.74f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 51.85f, 2.00f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 52.06f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 52.16f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 52.26f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 52.37f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 52.47f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 52.57f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 52.68f, 2.00f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 52.88f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 52.99f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 53.09f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 53.19f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 53.30f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 53.40f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 53.50f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 53.61f, 2.00f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 7.27f + 46.36f, 2.00f, "a"));
            input.Notes.Add(new Data.NoteInfo(true, 6.44f + 46.36f, 7.27f + 46.36f, ";"));

            //continus
            input.Notes.Add(new Data.NoteInfo(false, 53.71f+0.00f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 53.81f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 53.92f + 0.00f, 2.00f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.74f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.85f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.95f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 55.05f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 55.16f + 0.00f, 2.00f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 1.24f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 1.24f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 1.24f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 1.24f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 1.24f + 0.00f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 1.24f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 1.24f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.74f + 1.24f + 0.00f, 2.00f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 2.07f + 0.00f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 2.07f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 2.07f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 2.07f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 2.07f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 2.07f + 0.00f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 2.07f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.74f + 2.07f + 0.00f, 2.00f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 2.9f + 0.00f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 2.9f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 2.9f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 2.9f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 2.9f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 2.9f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 2.9f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.74f + 2.9f + 0.00f, 2.00f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 3.83f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 3.83f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 3.83f + 0.00f, 2.00f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 4.14f + 0.00f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 4.14f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 4.14f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 4.14f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 4.14f + 0.00f, 2.00f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 4.66f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 4.66f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 4.66f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 4.66f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 4.66f + 0.00f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 4.66f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 4.66f + 0.00f, 2.00f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 5.38f + 0.00f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 5.38f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 5.38f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 5.38f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 5.38f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 5.38f + 0.00f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 5.38f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.74f + 5.38f + 0.00f, 2.00f, "f"));

            //continus
            input.Notes.Add(new Data.NoteInfo(false, 53.71f + 6.51f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 53.81f + 6.51f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 53.92f + 6.51f, 2.00f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 6.51f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 6.51f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 6.51f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 6.51f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 6.51f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 6.51f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 6.51f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.74f + 6.51f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.85f + 6.51f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.95f + 6.51f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 55.05f + 6.51f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 55.16f + 6.51f, 2.00f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 1.24f + 6.51f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 1.24f + 6.51f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 1.24f + 6.51f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 1.24f + 6.51f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 1.24f + 6.51f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 1.24f + 6.51f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 1.24f + 6.51f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.74f + 1.24f + 6.51f, 2.00f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 2.07f + 6.51f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 2.07f + 6.51f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 2.07f + 6.51f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 2.07f + 6.51f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 2.07f + 6.51f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 2.07f + 6.51f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 2.07f + 6.51f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.74f + 2.07f + 6.51f, 2.00f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 2.9f + 6.51f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 2.9f + 6.51f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 2.9f + 6.51f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 2.9f + 6.51f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 2.9f + 6.51f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 2.9f + 6.51f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 2.9f + 6.51f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.74f + 2.9f + 6.51f, 2.00f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 3.83f + 6.51f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 3.83f + 6.51f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 3.83f + 6.51f, 2.00f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 4.14f + 6.51f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 4.14f + 6.51f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 4.14f + 6.51f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 4.14f + 6.51f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 4.14f + 6.51f, 2.00f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 4.66f + 6.51f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 4.66f + 6.51f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 4.66f + 6.51f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 4.66f + 6.51f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 4.66f + 6.51f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 4.66f + 6.51f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 4.66f + 6.51f, 2.00f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 5.38f + 6.51f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 5.38f + 6.51f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 5.38f + 6.51f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 5.38f + 6.51f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 5.38f + 6.51f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 5.38f + 6.51f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 5.38f + 6.51f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.74f + 5.38f + 6.51f, 2.00f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 7.27f + 58.75f, 2.00f, "a"));
            input.Notes.Add(new Data.NoteInfo(true, 6.44f + 58.75f, 7.27f + 58.75f, ";"));
            //final pattern
            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 12.83f + 0.00f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 12.83f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 12.83f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 12.83f + 0.00f, 2.00f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 13.24f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 13.24f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 13.24f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 13.24f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 13.24f + 0.00f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 13.24f + 0.00f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 13.24f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.74f + 13.24f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 14.07f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 14.07f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 14.07f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 14.07f + 0.00f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 14.07f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 14.07f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 14.07f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.74f + 14.07f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 14.9f + 0.00f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 14.9f + 0.00f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 14.9f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 14.9f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 14.9f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 14.9f + 0.00f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 14.9f + 0.00f, 2.00f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 15.72f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 15.72f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 15.72f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 15.72f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 15.72f + 0.00f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 15.72f + 0.00f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 15.72f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.74f + 15.72f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 16.55f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 16.55f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 16.55f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 16.55f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 16.55f + 0.00f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 16.55f + 0.00f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 16.55f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.74f + 16.55f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 17.38f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 17.38f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 17.38f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 17.38f + 0.00f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 17.38f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 17.38f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 17.38f + 0.00f, 2.00f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 18.21f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 18.21f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 18.21f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 18.21f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 18.21f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 18.21f + 0.00f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 18.21f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.74f + 18.21f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 19.03f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 19.03f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 19.03f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 19.03f + 0.00f, 2.00f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 19.45f + 0.00f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 19.45f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 19.45f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 19.45f + 0.00f, 2.00f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 73.88f + 0.00f, 2.00f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 20.07f + 0.00f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 20.07f + 0.00f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 20.07f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 20.07f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 20.07f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 20.07f + 0.00f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 20.07f + 0.00f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.74f + 20.07f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 20.9f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 20.9f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 20.9f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 20.9f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 20.9f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 20.9f + 0.00f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 20.9f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.74f + 20.9f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 21.72f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 21.72f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 21.72f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 21.72f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 21.72f + 0.00f, 2.00f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 22.34f + 0.00f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 22.34f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 22.34f + 0.00f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 22.34f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 22.34f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 22.34f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 22.34f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.74f + 22.34f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 23.17f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 23.17f + 0.00f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 23.17f + 0.00f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 23.17f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 23.17f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 23.17f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 23.17f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.74f + 23.17f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 24.0f + 0.00f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 24.0f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 24.0f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 24.0f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 24.0f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 24.0f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 24.0f + 0.00f, 2.00f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 24.83f + 0.00f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 24.83f + 0.00f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 24.83f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 24.83f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 24.83f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 24.83f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 24.83f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.74f + 24.83f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 25.65f + 0.00f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 25.65f + 0.00f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 25.65f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 25.65f + 0.00f, 2.00f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 7.27f + 72.82f, 2.00f, "a"));
            input.Notes.Add(new Data.NoteInfo(true, 6.44f + 72.82f, 7.27f + 72.82f, ";"));

            //final pattern
            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 12.83f + 13.24f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 12.83f + 13.24f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 12.83f + 13.24f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 12.83f + 13.24f, 2.00f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 13.24f + 13.24f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 13.24f + 13.24f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 13.24f + 13.24f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 13.24f + 13.24f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 13.24f + 13.24f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 13.24f + 13.24f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 13.24f + 13.24f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.74f + 13.24f + 13.24f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 14.07f + 13.24f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 14.07f + 13.24f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 14.07f + 13.24f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 14.07f + 13.24f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 14.07f + 13.24f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 14.07f + 13.24f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 14.07f + 13.24f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.74f + 14.07f + 13.24f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 14.9f + 13.24f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 14.9f + 13.24f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 14.9f + 13.24f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 14.9f + 13.24f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 14.9f + 13.24f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 14.9f + 13.24f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 14.9f + 13.24f, 2.00f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 15.72f + 13.24f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 15.72f + 13.24f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 15.72f + 13.24f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 15.72f + 13.24f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 15.72f + 13.24f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 15.72f + 13.24f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 15.72f + 13.24f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.74f + 15.72f + 13.24f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 16.55f + 13.24f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 16.55f + 13.24f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 16.55f + 13.24f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 16.55f + 13.24f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 16.55f + 13.24f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 16.55f + 13.24f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 16.55f + 13.24f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.74f + 16.55f + 13.24f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 17.38f + 13.24f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 17.38f + 13.24f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 17.38f + 13.24f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 17.38f + 13.24f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 17.38f + 13.24f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 17.38f + 13.24f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 17.38f + 13.24f, 2.00f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 18.21f + 13.24f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 18.21f + 13.24f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 18.21f + 13.24f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 18.21f + 13.24f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 18.21f + 13.24f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 18.21f + 13.24f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 18.21f + 13.24f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.74f + 18.21f + 13.24f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 19.03f + 13.24f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 19.03f + 13.24f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 19.03f + 13.24f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 19.03f + 13.24f, 2.00f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 19.45f + 13.24f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 19.45f + 13.24f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 19.45f + 13.24f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 19.45f + 13.24f, 2.00f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 73.88f + 13.24f, 2.00f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 20.07f + 13.24f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 20.07f + 13.24f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 20.07f + 13.24f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 20.07f + 13.24f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 20.07f + 13.24f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 20.07f + 13.24f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 20.07f + 13.24f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.74f + 20.07f + 13.24f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 20.9f + 13.24f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 20.9f + 13.24f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 20.9f + 13.24f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 20.9f + 13.24f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 20.9f + 13.24f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 20.9f + 13.24f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 20.9f + 13.24f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.74f + 20.9f + 13.24f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 21.72f + 13.24f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 21.72f + 13.24f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 21.72f + 13.24f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 21.72f + 13.24f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 21.72f + 13.24f, 2.00f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 22.34f + 13.24f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 22.34f + 13.24f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 22.34f + 13.24f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 22.34f + 13.24f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 22.34f + 13.24f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 22.34f + 13.24f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 22.34f + 13.24f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.74f + 22.34f + 13.24f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 23.17f + 13.24f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 23.17f + 13.24f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 23.17f + 13.24f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 23.17f + 13.24f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 23.17f + 13.24f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 23.17f + 13.24f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 23.17f + 13.24f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.74f + 23.17f + 13.24f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 24.0f + 13.24f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 24.0f + 13.24f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 24.0f + 13.24f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 24.0f + 13.24f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 24.0f + 13.24f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 24.0f + 13.24f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 24.0f + 13.24f, 2.00f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 24.83f + 13.24f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 24.83f + 13.24f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 24.83f + 13.24f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 24.83f + 13.24f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 24.83f + 13.24f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 24.83f + 13.24f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 24.83f + 13.24f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.74f + 24.83f + 13.24f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 25.65f + 13.24f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 25.65f + 13.24f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 25.65f + 13.24f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 25.65f + 13.24f, 2.00f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 7.27f + 86.06f, 2.00f, "a"));
            input.Notes.Add(new Data.NoteInfo(true, 6.44f + 86.06f, 7.27f + 86.06f, ";"));

            input.Notes.Add(new Data.NoteInfo(true, 93.22f, 94.16f, "f"));
        }
        else if (input.Difficulty.Equals("Hard"))
        {
            input.Notes.Add(new Data.NoteInfo(true, 0.00f, 0.65f, "k"));
            //first Ry
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 0.00f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 0.00f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 0.00f, 2.00f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 1.37f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.58f + 0.00f, 2.00f, "k"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 0.82f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 0.82f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 0.82f + 0.00f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 0.82f + 0.00f, 2.00f, "l"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 1.65f + 0.00f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 1.65f + 0.00f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 1.65f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 1.65f + 0.00f, 2.00f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 2.82f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.02f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.13f + 0.00f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 3.33f + 0.00f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 3.54f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.64f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.85f + 0.00f, 2.00f, "d"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 3.31f + 0.00f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 3.31f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 3.31f + 0.00f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 3.31f + 0.00f, 2.00f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 4.68f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 4.89f + 0.00f, 2.00f, "d"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 4.13f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 4.13f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 4.13f + 0.00f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 4.13f + 0.00f, 2.00f, "s"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 4.96f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 4.96f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 4.96f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 4.96f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 6.13f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 6.33f + 0.00f, 2.00f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 6.44f + 0.00f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 6.54f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 6.64f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 6.75f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 6.85f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 6.95f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 7.06f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 7.16f + 0.00f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 7.27f + 0.00f, 2.00f, "a"));
            input.Notes.Add(new Data.NoteInfo(true, 6.44f + 0.00f, 7.27f + 0.00f, ";"));
            //first Ry
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 6.62f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 6.62f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 6.62f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 6.62f, 2.00f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 1.37f + 6.62f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.58f + 6.62f, 2.00f, "k"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 0.82f + 6.62f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 0.82f + 6.62f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 0.82f + 6.62f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 0.82f + 6.62f, 2.00f, "l"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 1.65f + 6.62f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 1.65f + 6.62f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 1.65f + 6.62f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 1.65f + 6.62f, 2.00f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 2.82f + 6.62f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.02f + 6.62f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.13f + 6.62f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 3.33f + 6.62f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 3.54f + 6.62f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.64f + 6.62f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.85f + 6.62f, 2.00f, "d"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 3.31f + 6.62f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 3.31f + 6.62f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 3.31f + 6.62f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 3.31f + 6.62f, 2.00f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 4.68f + 6.62f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 4.89f + 6.62f, 2.00f, "d"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 4.13f + 6.62f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 4.13f + 6.62f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 4.13f + 6.62f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 4.13f + 6.62f, 2.00f, "s"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 4.96f + 6.62f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 4.96f + 6.62f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 4.96f + 6.62f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 4.96f + 6.62f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 6.13f + 6.62f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 6.33f + 6.62f, 2.00f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 6.44f + 6.62f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 6.54f + 6.62f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 6.64f + 6.62f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 6.75f + 6.62f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 6.85f + 6.62f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 6.95f + 6.62f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 7.06f + 6.62f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 7.16f + 6.62f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 7.27f + 6.62f, 2.00f, "a"));
            input.Notes.Add(new Data.NoteInfo(true, 6.44f + 6.62f, 7.27f + 6.62f, ";"));
            //first Ry
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 13.24f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 13.24f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 13.24f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 13.24f, 2.00f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 1.37f + 13.24f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.58f + 13.24f, 2.00f, "k"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 0.82f + 13.24f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 0.82f + 13.24f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 0.82f + 13.24f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 0.82f + 13.24f, 2.00f, "l"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 1.65f + 13.24f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 1.65f + 13.24f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 1.65f + 13.24f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 1.65f + 13.24f, 2.00f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 2.82f + 13.24f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.02f + 13.24f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.13f + 13.24f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 3.33f + 13.24f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 3.54f + 13.24f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.64f + 13.24f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.85f + 13.24f, 2.00f, "d"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 3.31f + 13.24f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 3.31f + 13.24f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 3.31f + 13.24f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 3.31f + 13.24f, 2.00f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 4.68f + 13.24f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 4.89f + 13.24f, 2.00f, "d"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 4.13f + 13.24f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 4.13f + 13.24f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 4.13f + 13.24f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 4.13f + 13.24f, 2.00f, "s"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 4.96f + 13.24f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 4.96f + 13.24f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 4.96f + 13.24f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 4.96f + 13.24f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 6.13f + 13.24f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 6.33f + 13.24f, 2.00f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 6.44f + 13.24f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 6.54f + 13.24f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 6.64f + 13.24f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 6.75f + 13.24f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 6.85f + 13.24f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 6.95f + 13.24f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 7.06f + 13.24f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 7.16f + 13.24f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 7.27f + 13.24f, 2.00f, "a"));
            input.Notes.Add(new Data.NoteInfo(true, 6.44f + 13.24f, 7.27f + 13.24f, ";"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 14.30f + 0.00f, 2.00f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 15.13f + 0.00f, 2.00f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 15.95f + 0.00f, 2.00f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 16.78f + 0.00f, 2.00f, "p"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 14.30f + 3.31f, 2.00f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 15.13f + 3.31f, 2.00f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 15.95f + 3.31f, 2.00f, ";"));

            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 14.30f + 0.41f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 15.13f + 0.41f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 15.95f + 0.41f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 16.78f + 0.41f, 2.00f, "space"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 14.30f + 3.72f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 15.13f + 3.72f, 2.00f, "space"));
            //first Ry
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 19.86f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 19.86f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 19.86f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 19.86f, 2.00f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 1.37f + 19.86f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.58f + 19.86f, 2.00f, "k"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 0.82f + 19.86f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 0.82f + 19.86f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 0.82f + 19.86f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 0.82f + 19.86f, 2.00f, "l"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 1.65f + 19.86f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 1.65f + 19.86f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 1.65f + 19.86f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 1.65f + 19.86f, 2.00f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 2.82f + 19.86f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.02f + 19.86f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.13f + 19.86f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 3.33f + 19.86f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 3.54f + 19.86f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.64f + 19.86f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.85f + 19.86f, 2.00f, "d"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 3.31f + 19.86f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 3.31f + 19.86f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 3.31f + 19.86f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 3.31f + 19.86f, 2.00f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 4.68f + 19.86f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 4.89f + 19.86f, 2.00f, "d"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 4.13f + 19.86f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 4.13f + 19.86f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 4.13f + 19.86f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 4.13f + 19.86f, 2.00f, "s"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 4.96f + 19.86f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 4.96f + 19.86f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 4.96f + 19.86f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 4.96f + 19.86f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 6.13f + 19.86f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 6.33f + 19.86f, 2.00f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 6.44f + 19.86f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 6.54f + 19.86f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 6.64f + 19.86f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 6.75f + 19.86f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 6.85f + 19.86f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 6.95f + 19.86f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 7.06f + 19.86f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 7.16f + 19.86f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 7.27f + 19.86f, 2.00f, "a"));
            input.Notes.Add(new Data.NoteInfo(true, 6.44f + 19.86f, 7.27f + 19.86f, ";"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 14.30f + 6.62f, 2.00f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 15.13f + 6.62f, 2.00f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 15.95f + 6.62f, 2.00f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 16.78f + 6.62f, 2.00f, ";"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 14.30f + 9.93f, 2.00f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 15.13f + 9.93f, 2.00f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 15.95f + 9.93f, 2.00f, "p"));

            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 14.30f + 7.03f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 15.13f + 7.03f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 15.95f + 7.03f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 16.78f + 7.03f, 2.00f, "space"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 14.30f + 10.34f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 15.13f + 10.34f, 2.00f, "space"));

            //first Ry
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 26.48f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 26.48f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 26.48f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 26.48f, 2.00f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 1.37f + 26.48f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.58f + 26.48f, 2.00f, "k"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 0.82f + 26.48f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 0.82f + 26.48f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 0.82f + 26.48f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 0.82f + 26.48f, 2.00f, "l"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 1.65f + 26.48f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 1.65f + 26.48f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 1.65f + 26.48f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 1.65f + 26.48f, 2.00f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 2.82f + 26.48f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.02f + 26.48f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.13f + 26.48f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 3.33f + 26.48f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 3.54f + 26.48f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.64f + 26.48f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.85f + 26.48f, 2.00f, "d"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 3.31f + 26.48f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 3.31f + 26.48f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 3.31f + 26.48f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 3.31f + 26.48f, 2.00f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 4.68f + 26.48f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 4.89f + 26.48f, 2.00f, "d"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 4.13f + 26.48f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 4.13f + 26.48f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 4.13f + 26.48f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 4.13f + 26.48f, 2.00f, "s"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 4.96f + 26.48f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 4.96f + 26.48f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 4.96f + 26.48f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 4.96f + 26.48f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 6.13f + 26.48f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 6.33f + 26.48f, 2.00f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 6.44f + 26.48f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 6.54f + 26.48f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 6.64f + 26.48f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 6.75f + 26.48f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 6.85f + 26.48f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 6.95f + 26.48f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 7.06f + 26.48f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 7.16f + 26.48f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 7.27f + 26.48f, 2.00f, "a"));
            input.Notes.Add(new Data.NoteInfo(true, 6.44f + 26.48f, 7.27f + 26.48f, ";"));

            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 14.30f + 13.24f, 2.00f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 15.13f + 13.24f, 2.00f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 15.95f + 13.24f, 2.00f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 16.78f + 13.24f, 2.00f, ";"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 14.30f + 16.55f, 2.00f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 15.13f + 16.55f, 2.00f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 15.95f + 16.55f, 2.00f, "a"));

            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 27.13f + 0.00f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.54f + 0.00f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.95f + 0.00f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 28.37f + 0.00f, 2.00f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 27.13f + 1.65f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.54f + 1.65f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.95f + 1.65f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 28.37f + 1.65f, 2.00f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 27.13f + 3.31f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.54f + 3.31f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.95f + 3.31f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 28.37f + 3.31f, 2.00f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 27.13f + 4.96f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.54f + 4.96f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.95f + 4.96f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 28.37f + 4.96f, 2.00f, "space"));
            //first Ry
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 33.1f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 33.1f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 33.1f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 33.1f, 2.00f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 1.37f + 33.1f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.58f + 33.1f, 2.00f, "k"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 0.82f + 33.1f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 0.82f + 33.1f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 0.82f + 33.1f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 0.82f + 33.1f, 2.00f, "l"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 1.65f + 33.1f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 1.65f + 33.1f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 1.65f + 33.1f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 1.65f + 33.1f, 2.00f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 2.82f + 33.1f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.02f + 33.1f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.13f + 33.1f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 3.33f + 33.1f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 3.54f + 33.1f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.64f + 33.1f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 3.85f + 33.1f, 2.00f, "d"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 3.31f + 33.1f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 3.31f + 33.1f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 3.31f + 33.1f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 3.31f + 33.1f, 2.00f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 4.68f + 33.1f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 4.89f + 33.1f, 2.00f, "d"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 4.13f + 33.1f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 4.13f + 33.1f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 4.13f + 33.1f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 4.13f + 33.1f, 2.00f, "s"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 0.65f + 4.96f + 33.1f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 0.85f + 4.96f + 33.1f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.06f + 4.96f + 33.1f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 1.27f + 4.96f + 33.1f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 6.13f + 33.1f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 6.33f + 33.1f, 2.00f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 6.44f + 33.1f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 6.54f + 33.1f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 6.64f + 33.1f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 6.75f + 33.1f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 6.85f + 33.1f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 6.95f + 33.1f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 7.06f + 33.1f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 7.16f + 33.1f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 7.27f + 33.1f, 2.00f, "a"));
            input.Notes.Add(new Data.NoteInfo(true, 6.44f + 33.1f, 7.27f + 33.1f, ";"));

            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 14.30f + 19.86f, 2.00f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 15.13f + 19.86f, 2.00f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 15.95f + 19.86f, 2.00f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 16.78f + 19.86f, 2.00f, ";"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 14.30f + 23.17f, 2.00f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 15.13f + 23.17f, 2.00f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 15.95f + 23.17f, 2.00f, "a"));

            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 27.13f + 6.62f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.54f + 6.62f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.95f + 6.62f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 28.37f + 6.62f, 2.00f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 27.13f + 8.27f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.54f + 8.27f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.95f + 8.27f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 28.37f + 8.27f, 2.00f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 27.13f + 9.93f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.54f + 9.93f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.95f + 9.93f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 28.37f + 9.93f, 2.00f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 27.13f + 11.58f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.54f + 11.58f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.95f + 11.58f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 28.37f + 11.58f, 2.00f, "space"));

            //bridge
            input.Notes.Add(new Data.NoteInfo(false, 40.37f, 2.00f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 40.57f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 40.68f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 40.78f, 2.00f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 40.88f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 40.99f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 41.09f, 2.00f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 41.30f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 41.40f, 2.00f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 41.61f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 41.76f, 2.00f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 41.92f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 42.02f, 2.00f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 42.23f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 42.33f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 42.44f, 2.00f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 42.54f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 42.64f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 42.75f, 2.00f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 42.95f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 43.06f, 2.00f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 43.26f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 43.37f, 2.00f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 43.47f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 43.57f, 2.00f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 43.88f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 43.99f, 2.00f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 44.19f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 44.30f, 2.00f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 44.50f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 44.61f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 44.71f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 44.81f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 44.92f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 45.02f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 45.12f, 2.00f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 45.33f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 45.43f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 45.54f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 45.64f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 45.75f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 45.85f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 45.95f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 46.06f, 2.00f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 46.16f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 46.26f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 46.37f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 46.47f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 46.57f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 46.68f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 46.78f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 46.88f, 2.00f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 46.99f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 47.09f, 2.00f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 47.40f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 47.50f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 47.61f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 47.71f, 2.00f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 47.92f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 48.02f, 2.00f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 48.23f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 48.33f, 2.00f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 48.43f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 48.54f, 2.00f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 48.74f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 48.85f, 2.00f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 49.06f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 49.16f, 2.00f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 49.37f, 2.00f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 49.57f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 49.68f, 2.00f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 49.88f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 49.99f, 2.00f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 50.09f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 50.19f, 2.00f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 50.40f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 50.50f, 2.00f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 50.71f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 50.81f, 2.00f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 51.12f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 51.23f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 51.33f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 51.43f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 51.54f, 2.00f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 51.64f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 51.74f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 51.85f, 2.00f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 52.06f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 52.16f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 52.26f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 52.37f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 52.47f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 52.57f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 52.68f, 2.00f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 52.88f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 52.99f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 53.09f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 53.19f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 53.30f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 53.40f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 53.50f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 53.61f, 2.00f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 7.27f + 46.36f, 2.00f, "a"));
            input.Notes.Add(new Data.NoteInfo(true, 6.44f + 46.36f, 7.27f + 46.36f, ";"));

            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 27.13f + 26.48f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.54f + 26.48f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.95f + 26.48f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 28.37f + 26.48f, 2.00f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 27.13f + 28.13f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.54f + 28.13f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.95f + 28.13f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 28.37f + 28.13f, 2.00f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 27.13f + 29.79f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.54f + 29.79f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.95f + 29.79f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 28.37f + 29.79f, 2.00f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 27.13f + 31.44f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.54f + 31.44f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.95f + 31.44f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 28.37f + 31.44f, 2.00f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 27.13f + 33.1f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.54f + 33.1f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.95f + 33.1f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 28.37f + 33.1f, 2.00f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 27.13f + 34.75f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.54f + 34.75f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.95f + 34.75f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 28.37f + 34.75f, 2.00f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 27.13f + 36.41f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.54f + 36.41f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.95f + 36.41f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 28.37f + 36.41f, 2.00f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 27.13f + 38.06f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.54f + 38.06f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.95f + 38.06f, 2.00f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 28.37f + 38.06f, 2.00f, "space"));
            //continus
            input.Notes.Add(new Data.NoteInfo(false, 53.71f + 0.00f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 53.81f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 53.92f + 0.00f, 2.00f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.74f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.85f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.95f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 55.05f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 55.16f + 0.00f, 2.00f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 1.24f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 1.24f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 1.24f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 1.24f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 1.24f + 0.00f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 1.24f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 1.24f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.74f + 1.24f + 0.00f, 2.00f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 2.07f + 0.00f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 2.07f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 2.07f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 2.07f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 2.07f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 2.07f + 0.00f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 2.07f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.74f + 2.07f + 0.00f, 2.00f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 2.9f + 0.00f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 2.9f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 2.9f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 2.9f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 2.9f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 2.9f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 2.9f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.74f + 2.9f + 0.00f, 2.00f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 3.83f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 3.83f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 3.83f + 0.00f, 2.00f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 4.14f + 0.00f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 4.14f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 4.14f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 4.14f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 4.14f + 0.00f, 2.00f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 4.66f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 4.66f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 4.66f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 4.66f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 4.66f + 0.00f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 4.66f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 4.66f + 0.00f, 2.00f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 5.38f + 0.00f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 5.38f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 5.38f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 5.38f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 5.38f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 5.38f + 0.00f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 5.38f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.74f + 5.38f + 0.00f, 2.00f, "f"));
            //continus trick /2
            input.Notes.Add(new Data.NoteInfo(false, 66.85f + 0.00f, 2.00f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 67.47f + 0.00f, 2.00f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 68.09f + 0.00f, 2.00f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 68.52f + 0.00f, 2.00f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 69.12f + 0.00f, 2.00f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 69.74f + 0.00f, 2.00f, "p"));
            //continus trick /2
            input.Notes.Add(new Data.NoteInfo(false, 66.85f + 3.31f, 2.00f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 67.47f + 3.31f, 2.00f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 68.09f + 3.31f, 2.00f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 68.52f + 3.31f, 2.00f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 69.12f + 3.31f, 2.00f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 69.74f + 3.31f, 2.00f, "p"));
            //continus trick /2
            input.Notes.Add(new Data.NoteInfo(false, 66.85f + 6.62f, 2.00f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 67.47f + 6.62f, 2.00f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 68.09f + 6.62f, 2.00f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 68.52f + 6.62f, 2.00f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 69.12f + 6.62f, 2.00f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 69.74f + 6.62f, 2.00f, "p"));
            //continus trick /2
            input.Notes.Add(new Data.NoteInfo(false, 66.85f + 9.93f, 2.00f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 67.47f + 9.93f, 2.00f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 68.09f + 9.93f, 2.00f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 68.52f + 9.93f, 2.00f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 69.12f + 9.93f, 2.00f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 69.74f + 9.93f, 2.00f, "p"));

            //continus trick /2
            input.Notes.Add(new Data.NoteInfo(false, 66.85f + 13.24f, 2.00f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 67.47f + 13.24f, 2.00f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 68.09f + 13.24f, 2.00f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 68.52f + 13.24f, 2.00f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 69.12f + 13.24f, 2.00f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 69.74f + 13.24f, 2.00f, "p"));
            //continus trick /2
            input.Notes.Add(new Data.NoteInfo(false, 66.85f + 16.55f, 2.00f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 67.47f + 16.55f, 2.00f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 68.09f + 16.55f, 2.00f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 68.52f + 16.55f, 2.00f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 69.12f + 16.55f, 2.00f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 69.74f + 16.55f, 2.00f, "p"));
            //continus trick /2
            input.Notes.Add(new Data.NoteInfo(false, 66.85f + 19.86f, 2.00f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 67.47f + 19.86f, 2.00f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 68.09f + 19.86f, 2.00f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 68.52f + 19.86f, 2.00f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 69.12f + 19.86f, 2.00f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 69.74f + 19.86f, 2.00f, "p"));
            //continus trick /2
            input.Notes.Add(new Data.NoteInfo(false, 66.85f + 23.17f, 2.00f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 67.47f + 23.17f, 2.00f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 68.09f + 23.17f, 2.00f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 68.52f + 23.17f, 2.00f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 69.12f + 23.17f, 2.00f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 69.74f + 23.17f, 2.00f, "p"));
            //continus
            input.Notes.Add(new Data.NoteInfo(false, 53.71f + 6.51f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 53.81f + 6.51f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 53.92f + 6.51f, 2.00f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 6.51f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 6.51f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 6.51f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 6.51f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 6.51f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 6.51f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 6.51f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.74f + 6.51f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.85f + 6.51f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.95f + 6.51f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 55.05f + 6.51f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 55.16f + 6.51f, 2.00f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 1.24f + 6.51f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 1.24f + 6.51f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 1.24f + 6.51f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 1.24f + 6.51f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 1.24f + 6.51f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 1.24f + 6.51f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 1.24f + 6.51f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.74f + 1.24f + 6.51f, 2.00f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 2.07f + 6.51f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 2.07f + 6.51f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 2.07f + 6.51f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 2.07f + 6.51f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 2.07f + 6.51f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 2.07f + 6.51f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 2.07f + 6.51f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.74f + 2.07f + 6.51f, 2.00f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 2.9f + 6.51f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 2.9f + 6.51f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 2.9f + 6.51f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 2.9f + 6.51f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 2.9f + 6.51f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 2.9f + 6.51f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 2.9f + 6.51f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.74f + 2.9f + 6.51f, 2.00f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 3.83f + 6.51f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 3.83f + 6.51f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 3.83f + 6.51f, 2.00f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 4.14f + 6.51f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 4.14f + 6.51f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 4.14f + 6.51f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 4.14f + 6.51f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 4.14f + 6.51f, 2.00f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 4.66f + 6.51f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 4.66f + 6.51f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 4.66f + 6.51f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 4.66f + 6.51f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 4.66f + 6.51f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 4.66f + 6.51f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 4.66f + 6.51f, 2.00f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 5.38f + 6.51f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 5.38f + 6.51f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 5.38f + 6.51f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 5.38f + 6.51f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 5.38f + 6.51f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 5.38f + 6.51f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 5.38f + 6.51f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.74f + 5.38f + 6.51f, 2.00f, "f"));

            //input.Notes.Add(new Data.NoteInfo(false, 7.27f + 58.75f, 2.00f, "a"));
            input.Notes.Add(new Data.NoteInfo(true, 6.44f + 58.75f, 7.27f + 58.75f, ";"));
            //final pattern
            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 12.83f + 0.00f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 12.83f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 12.83f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 12.83f + 0.00f, 2.00f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 13.24f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 13.24f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 13.24f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 13.24f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 13.24f + 0.00f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 13.24f + 0.00f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 13.24f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.74f + 13.24f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 14.07f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 14.07f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 14.07f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 14.07f + 0.00f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 14.07f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 14.07f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 14.07f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.74f + 14.07f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 14.9f + 0.00f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 14.9f + 0.00f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 14.9f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 14.9f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 14.9f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 14.9f + 0.00f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 14.9f + 0.00f, 2.00f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 15.72f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 15.72f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 15.72f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 15.72f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 15.72f + 0.00f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 15.72f + 0.00f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 15.72f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.74f + 15.72f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 16.55f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 16.55f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 16.55f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 16.55f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 16.55f + 0.00f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 16.55f + 0.00f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 16.55f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.74f + 16.55f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 17.38f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 17.38f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 17.38f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 17.38f + 0.00f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 17.38f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 17.38f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 17.38f + 0.00f, 2.00f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 18.21f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 18.21f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 18.21f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 18.21f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 18.21f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 18.21f + 0.00f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 18.21f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.74f + 18.21f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 19.03f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 19.03f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 19.03f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 19.03f + 0.00f, 2.00f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 19.45f + 0.00f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 19.45f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 19.45f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 19.45f + 0.00f, 2.00f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 73.88f + 0.00f, 2.00f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 20.07f + 0.00f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 20.07f + 0.00f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 20.07f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 20.07f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 20.07f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 20.07f + 0.00f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 20.07f + 0.00f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.74f + 20.07f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 20.9f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 20.9f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 20.9f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 20.9f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 20.9f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 20.9f + 0.00f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 20.9f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.74f + 20.9f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 21.72f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 21.72f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 21.72f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 21.72f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 21.72f + 0.00f, 2.00f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 22.34f + 0.00f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 22.34f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 22.34f + 0.00f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 22.34f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 22.34f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 22.34f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 22.34f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.74f + 22.34f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 23.17f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 23.17f + 0.00f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 23.17f + 0.00f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 23.17f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 23.17f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 23.17f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 23.17f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.74f + 23.17f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 24.0f + 0.00f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 24.0f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 24.0f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 24.0f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 24.0f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 24.0f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 24.0f + 0.00f, 2.00f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 24.83f + 0.00f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 24.83f + 0.00f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 24.83f + 0.00f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 24.83f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 24.83f + 0.00f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 24.83f + 0.00f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 24.83f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.74f + 24.83f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 25.65f + 0.00f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 25.65f + 0.00f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 25.65f + 0.00f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 25.65f + 0.00f, 2.00f, "d"));

            //input.Notes.Add(new Data.NoteInfo(false, 7.27f + 72.82f, 2.00f, "a"));
            input.Notes.Add(new Data.NoteInfo(true, 6.44f + 72.82f, 7.27f + 72.82f, "space"));

            //final pattern
            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 12.83f + 13.24f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 12.83f + 13.24f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 12.83f + 13.24f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 12.83f + 13.24f, 2.00f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 13.24f + 13.24f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 13.24f + 13.24f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 13.24f + 13.24f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 13.24f + 13.24f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 13.24f + 13.24f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 13.24f + 13.24f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 13.24f + 13.24f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.74f + 13.24f + 13.24f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 14.07f + 13.24f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 14.07f + 13.24f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 14.07f + 13.24f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 14.07f + 13.24f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 14.07f + 13.24f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 14.07f + 13.24f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 14.07f + 13.24f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.74f + 14.07f + 13.24f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 14.9f + 13.24f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 14.9f + 13.24f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 14.9f + 13.24f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 14.9f + 13.24f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 14.9f + 13.24f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 14.9f + 13.24f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 14.9f + 13.24f, 2.00f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 15.72f + 13.24f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 15.72f + 13.24f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 15.72f + 13.24f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 15.72f + 13.24f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 15.72f + 13.24f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 15.72f + 13.24f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 15.72f + 13.24f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.74f + 15.72f + 13.24f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 16.55f + 13.24f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 16.55f + 13.24f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 16.55f + 13.24f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 16.55f + 13.24f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 16.55f + 13.24f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 16.55f + 13.24f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 16.55f + 13.24f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.74f + 16.55f + 13.24f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 17.38f + 13.24f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 17.38f + 13.24f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 17.38f + 13.24f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 17.38f + 13.24f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 17.38f + 13.24f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 17.38f + 13.24f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 17.38f + 13.24f, 2.00f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 18.21f + 13.24f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 18.21f + 13.24f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 18.21f + 13.24f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 18.21f + 13.24f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 18.21f + 13.24f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 18.21f + 13.24f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 18.21f + 13.24f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.74f + 18.21f + 13.24f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 19.03f + 13.24f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 19.03f + 13.24f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 19.03f + 13.24f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 19.03f + 13.24f, 2.00f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 19.45f + 13.24f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 19.45f + 13.24f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 19.45f + 13.24f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 19.45f + 13.24f, 2.00f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 73.88f + 13.24f, 2.00f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 20.07f + 13.24f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 20.07f + 13.24f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 20.07f + 13.24f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 20.07f + 13.24f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 20.07f + 13.24f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 20.07f + 13.24f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 20.07f + 13.24f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.74f + 20.07f + 13.24f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 20.9f + 13.24f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 20.9f + 13.24f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 20.9f + 13.24f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 20.9f + 13.24f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 20.9f + 13.24f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 20.9f + 13.24f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 20.9f + 13.24f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.74f + 20.9f + 13.24f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 21.72f + 13.24f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 21.72f + 13.24f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 21.72f + 13.24f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 21.72f + 13.24f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 21.72f + 13.24f, 2.00f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 22.34f + 13.24f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 22.34f + 13.24f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 22.34f + 13.24f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 22.34f + 13.24f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 22.34f + 13.24f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 22.34f + 13.24f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 22.34f + 13.24f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.74f + 22.34f + 13.24f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 23.17f + 13.24f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 23.17f + 13.24f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 23.17f + 13.24f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 23.17f + 13.24f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 23.17f + 13.24f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 23.17f + 13.24f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 23.17f + 13.24f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.74f + 23.17f + 13.24f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 24.0f + 13.24f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 24.0f + 13.24f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 24.0f + 13.24f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 24.0f + 13.24f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 24.0f + 13.24f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 24.0f + 13.24f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 24.0f + 13.24f, 2.00f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 24.83f + 13.24f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 24.83f + 13.24f, 2.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 24.83f + 13.24f, 2.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 24.83f + 13.24f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.43f + 24.83f + 13.24f, 2.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.54f + 24.83f + 13.24f, 2.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.64f + 24.83f + 13.24f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.74f + 24.83f + 13.24f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.02f + 25.65f + 13.24f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.12f + 25.65f + 13.24f, 2.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.23f + 25.65f + 13.24f, 2.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.33f + 25.65f + 13.24f, 2.00f, "d"));

            //input.Notes.Add(new Data.NoteInfo(false, 7.27f + 86.06f, 2.00f, "a"));
            input.Notes.Add(new Data.NoteInfo(true, 6.44f + 86.06f, 7.27f + 86.06f, "space"));

            input.Notes.Add(new Data.NoteInfo(true, 93.22f, 94.16f, "f"));
        }
        else if (input.Difficulty.Equals("Extreme"))
        {
            input.Notes.Add(new Data.NoteInfo(false, 0.0f + 0.00f, 2.00f, "k"));
        }
    }
}
