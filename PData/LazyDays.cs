using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class LazyDays : MonoBehaviour
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
        MusicInfo.key = 8;
        MusicInfo.name = "Lazy Days";
        MusicInfo.composer = "HousePlan";
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
        normal.level = 4;
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
        hard.level = 9;
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
            input.Notes.Add(new Data.NoteInfo(false, 1.85f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 2.19f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 2.65f, 3.68f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 4.83f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 5.06f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 5.52f, 0.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 6.20f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 6.89f, 8.26f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 8.26f, 0.65f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 8.49f, 0.65f, "a"));

            input.Notes.Add(new Data.NoteInfo(false, 9.18f, 0.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 9.52f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 9.87f, 11.47f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 12.27f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 12.39f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 12.61f, 0.65f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 12.96f, 0.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 13.30f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 13.53f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 13.87f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 14.22f, 15.36f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 15.59f, 0.65f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 16.05f, 0.65f, ";"));

            input.Notes.Add(new Data.NoteInfo(false, 16.51f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 16.97f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 17.19f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 17.54f, 18.34f, "d"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 19.03f + 0.00f, 0.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 19.14f + 0.00f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 19.26f + 0.00f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 19.71f + 0.00f, 0.65f, "space"));

            input.Notes.Add(new Data.NoteInfo(false, 20.40f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 20.97f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 21.43f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 21.77f, 22.92f, "k"));

            input.Notes.Add(new Data.NoteInfo(true, 23.15f, 23.84f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 23.84f, 0.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 23.95f, 0.65f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 24.29f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 24.41f, 0.65f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 24.64f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 24.98f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 25.32f, 26.47f, "d"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 26.81f + 0.00f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 27.04f + 0.00f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 27.27f + 0.00f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 27.50f + 0.00f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 27.84f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 28.19f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 28.53f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 28.87f, 30.25f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 31.16f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 31.51f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 31.85f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 31.97f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 32.19f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 32.42f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 32.65f, 33.80f, "l"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 26.81f + 7.33f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 27.04f + 7.33f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 27.27f + 7.33f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.50f + 7.33f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 35.17f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 35.52f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 35.86f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 36.20f, 37.58f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 36.66f, 37.58f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 37.81f, 0.65f, "space"));
            //1st groove
            input.Notes.Add(new Data.NoteInfo(true, 38.49f+0.00f, 38.84f+0.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 38.84f+0.00f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 39.22f + 0.00f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 39.52f + 0.00f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 39.87f+ 0.00f, 40.32f + 0.00f, "f"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 26.81f + 13.51f + 0.00f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 27.04f + 13.51f + 0.00f, 0.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 27.27f + 13.51f + 0.00f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 27.50f + 13.51f + 0.00f, 0.65f, "l"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 26.81f + 14.43f + 0.00f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 27.04f + 14.43f + 0.00f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 27.27f + 14.43f + 0.00f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 27.50f + 14.43f + 0.00f, 0.65f, "f"));

            input.Notes.Add(new Data.NoteInfo(true, 42.16f + 0.00f, 42.61f + 0.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 42.84f + 0.00f, 43.07f + 0.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 43.19f + 0.00f, 43.42f + 0.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 43.53f + 0.00f, 43.76f + 0.00f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 43.99f + 0.00f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 44.22f + 0.00f, 44.45f + 0.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 44.68f + 0.00f, 44.90f + 0.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 45.02f + 0.00f, 45.25f + 0.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 45.48f + 0.00f, 45.71f + 0.00f, "l"));

            //1st groove
            input.Notes.Add(new Data.NoteInfo(true, 38.49f + 7.33f, 38.84f + 7.33f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 38.84f + 7.33f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 39.22f + 7.33f, 0.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 39.52f + 7.33f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 39.87f + 7.33f, 40.32f + 7.33f, "space"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 26.81f + 13.51f + 7.33f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 27.04f + 13.51f + 7.33f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 27.27f + 13.51f + 7.33f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 27.50f + 13.51f + 7.33f, 0.65f, "f"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 26.81f + 14.43f + 7.33f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 27.04f + 14.43f + 7.33f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 27.27f + 14.43f + 7.33f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 27.50f + 14.43f + 7.33f, 0.65f, "k"));

            input.Notes.Add(new Data.NoteInfo(true, 42.16f + 7.33f, 42.61f + 7.33f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 42.84f + 7.33f, 43.07f + 7.33f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 43.19f + 7.33f, 43.42f + 7.33f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 43.53f + 7.33f, 43.76f + 7.33f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 43.99f + 7.33f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 44.22f + 7.33f, 44.45f + 7.33f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 44.68f + 7.33f, 44.90f + 7.33f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 45.02f + 7.33f, 45.25f + 7.33f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 52.69f, 0.65f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 52.92f, 0.65f, "p"));

            //2nd groove
            input.Notes.Add(new Data.NoteInfo(true, 53.15f + 0.00f, 53.38f + 0.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 53.49f + 0.00f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 53.84f + 0.00f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.18f + 0.00f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 54.52f + 0.00f, 54.75f + 0.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.87f + 0.00f, 0.65f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 55.21f + 0.00f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 55.44f + 0.00f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 55.55f + 0.00f, 0.65f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 55.90f + 0.00f, 0.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 56.13f + 0.00f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 56.35f + 0.00f, 56.81f + 0.00f, "j"));

            input.Notes.Add(new Data.NoteInfo(true, 56.81f + 0.00f, 57.04f + 0.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 57.16f + 0.00f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 57.50f + 0.00f, 0.65f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 57.84f + 0.00f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 58.19f + 0.00f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 58.53f + 0.00f, 0.65f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 58.87f + 0.00f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 59.10f + 0.00f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 59.22f + 0.00f, 0.65f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 59.56f + 0.00f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 59.79f + 0.00f, 60.02f + 0.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 60.13f + 0.00f, 60.48f + 0.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 59.56f + 0.00f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 59.79f + 0.00f, 60.02f + 0.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 60.13f + 0.00f, 60.48f + 0.00f, "j"));

            //2nd groove
            input.Notes.Add(new Data.NoteInfo(true, 53.15f + 7.33f, 53.38f + 7.33f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 53.49f + 7.33f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 53.84f + 7.33f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.18f + 7.33f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 54.52f + 7.33f, 54.75f + 7.33f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 54.87f + 7.33f, 0.65f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 55.21f + 7.33f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 55.44f + 7.33f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 55.55f + 7.33f, 0.65f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 55.90f + 7.33f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 56.13f + 7.33f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 56.35f + 7.33f, 56.81f + 7.33f, "l"));

            input.Notes.Add(new Data.NoteInfo(true, 56.81f + 7.33f, 57.04f + 7.33f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 57.16f + 7.33f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 57.50f + 7.33f, 0.65f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 57.84f + 7.33f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 58.19f + 7.33f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 58.53f + 7.33f, 0.65f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 65.97f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 66.66f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 66.89f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 67.35f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 65.97f, 0.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 66.66f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 66.89f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 67.35f, 0.65f, "j"));

            input.Notes.Add(new Data.NoteInfo(true, 67.81f, 69.64f, "a"));

            input.Notes.Add(new Data.NoteInfo(false, 71.47f, 0.65f, "space"));

            input.Notes.Add(new Data.NoteInfo(true, 73.30f, 75.13f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 75.13f, 0.65f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 76.74f, 0.65f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 78.80f, 0.65f, "f"));

            input.Notes.Add(new Data.NoteInfo(true, 80.40f, 81.77f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 82.12f, 82.46f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 82.46f, 0.65f, "d"));

            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 82.92f + 0.00f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 83.84f + 0.00f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 84.75f + 0.00f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 85.67f + 0.00f, 0.65f, "space"));

            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 26.81f + 57.25f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 27.04f + 57.25f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 27.27f + 57.25f, 0.65f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 86.13f, 0.65f, "l"));

            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 82.92f + 3.66f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 83.84f + 3.66f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 84.75f + 3.66f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 85.67f + 3.66f, 0.65f, "space"));

            input.Notes.Add(new Data.NoteInfo(false, 87.96f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 88.19f, 0.65f, "k"));

            input.Notes.Add(new Data.NoteInfo(true, 89.79f, 93.23f, "space"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 82.92f + 7.33f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 83.84f + 7.33f, 0.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 84.75f + 7.33f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 85.67f + 7.33f, 0.65f, "l"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 26.81f + 66.64f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 27.04f + 66.64f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 27.27f + 66.64f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 27.50f + 66.64f, 0.65f, "k"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 26.81f + 67.56f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 27.04f + 67.56f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 27.27f + 67.56f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 27.50f + 67.56f, 0.65f, "j"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 26.81f + 68.48f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 27.04f + 68.48f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 27.27f + 68.48f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 27.50f + 68.48f, 0.65f, "j"));

            input.Notes.Add(new Data.NoteInfo(true, 96.2f, 96.66f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 96.66f, 0.65f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 96.89f, 0.65f, "p"));

            //finale1
            input.Notes.Add(new Data.NoteInfo(true, 97.12f + 0.00f + 0.00f, 97.35f + 0.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 97.46f + 0.00f, 0.65f + 0.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 97.81f + 0.00f, 0.65f + 0.00f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 98.15f + 0.00f, 0.65f + 0.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 98.49f + 0.00f, 0.65f + 0.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 98.72f + 0.00f, 0.65f + 0.00f, "space"));

            input.Notes.Add(new Data.NoteInfo(false, 99.18f + 0.00f, 0.65f + 0.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 99.41f + 0.00f, 0.65f + 0.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 99.52f + 0.00f, 0.65f + 0.00f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 99.87f + 0.00f, 0.65f + 0.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 100.10f + 0.00f, 0.65f + 0.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 100.32f + 0.00f, 100.67f + 0.00f, "space"));

            input.Notes.Add(new Data.NoteInfo(false, 100.78f + 0.00f, 0.65f + 0.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 101.13f + 0.00f, 0.65f + 0.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 101.47f + 0.00f, 0.65f + 0.00f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 101.81f + 0.00f, 0.65f + 0.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 102.16f + 0.00f, 0.65f + 0.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 102.39f + 0.00f, 0.65f + 0.00f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 102.84f + 0.00f, 0.65f + 0.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 103.07f + 0.00f, 0.65f + 0.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 103.19f + 0.00f, 0.65f + 0.00f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 103.53f + 0.00f, 0.65f + 0.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 103.76f + 0.00f, 103.99f + 0.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 104.10f + 0.00f, 104.33f + 0.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 103.53f + 0.00f, 0.65f + 0.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 103.76f + 0.00f, 103.99f + 0.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 104.10f + 0.00f, 104.33f + 0.00f, "j"));

            //finale1
            input.Notes.Add(new Data.NoteInfo(true, 97.12f+ 7.33f, 97.35f + 7.33f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 97.46f + 7.33f, 0.65f + 7.33f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 97.81f + 7.33f, 0.65f + 7.33f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 98.15f + 7.33f, 0.65f + 7.33f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 98.49f + 7.33f, 0.65f + 7.33f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 98.72f + 7.33f, 0.65f + 7.33f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 99.18f + 7.33f, 0.65f + 7.33f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 99.41f + 7.33f, 0.65f + 7.33f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 99.52f + 7.33f, 0.65f + 7.33f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 99.87f + 7.33f, 0.65f + 7.33f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 100.10f + 7.33f, 0.65f + 7.33f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 100.32f + 7.33f, 100.67f + 7.33f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 100.78f + 7.33f, 0.65f + 7.33f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 101.13f + 7.33f, 0.65f + 7.33f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 101.47f + 7.33f, 0.65f + 7.33f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 101.81f + 7.33f, 0.65f + 7.33f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 102.16f + 7.33f, 0.65f + 7.33f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 102.39f + 7.33f, 0.65f + 7.33f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 102.84f + 7.33f, 0.65f + 7.33f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 103.07f + 7.33f, 0.65f + 7.33f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 103.19f + 7.33f, 0.65f + 7.33f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 103.53f + 7.33f, 0.65f + 7.33f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 103.76f + 7.33f, 103.99f + 7.33f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 104.10f + 7.33f, 104.33f + 7.33f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 103.53f + 7.33f, 0.65f + 7.33f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 103.76f + 7.33f, 103.99f + 7.33f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 104.10f + 7.33f, 104.33f + 7.33f, "k"));

            input.Notes.Add(new Data.NoteInfo(true, 111.77f, 113.61f, "space"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 26.81f + 84.96f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 27.04f + 84.96f, 0.65f, "s"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 26.81f + 85.88f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 27.04f + 85.88f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 27.27f + 85.88f, 0.65f, "j"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 26.81f + 86.8f, 0.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 27.04f + 86.8f, 0.65f, "l"));

            input.Notes.Add(new Data.NoteInfo(true, 114.52f, 114.98f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 114.98f, 0.65f, "s"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 26.81f + 88.63f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 27.04f + 88.63f, 0.65f, "l"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 26.81f + 89.77f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 27.04f + 89.77f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 26.81f + 90.23f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 27.04f + 90.23f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 27.27f + 90.23f, 0.65f, "j"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 26.81f + 91.15f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 27.04f + 91.15f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 27.27f + 91.15f, 0.65f, "s"));
            //4/0.75
            input.Notes.Add(new Data.NoteInfo(false, 119.10f + 0.00f, 44.45f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 119.45f + 0.00f, 44.90f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 119.79f + 0.00f, 45.25f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 120.13f + 0.00f, 45.71f, "d"));

            //4/0.75
            input.Notes.Add(new Data.NoteInfo(false, 119.10f + 1.38f, 44.45f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 119.45f + 1.38f, 44.90f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 119.79f + 1.38f, 45.25f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 120.13f + 1.38f, 45.71f, "l"));

            //4/0.75
            input.Notes.Add(new Data.NoteInfo(false, 119.10f + 2.75f, 44.45f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 119.45f + 2.75f, 44.90f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 119.79f + 2.75f, 45.25f, "j"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 26.81f + 95.96f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 27.04f + 95.96f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 27.27f + 95.96f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 27.50f + 95.96f, 0.65f, "j"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 26.81f + 96.87f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 27.04f + 96.87f, 0.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 27.27f + 96.87f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 27.50f + 96.87f, 0.65f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 124.60f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 124.94f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 125.29f, 0.65f, "space"));

            input.Notes.Add(new Data.NoteInfo(false, 124.94f, 0.65f, "q"));

            input.Notes.Add(new Data.NoteInfo(false, 125.52f, 0.65f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 125.52f, 0.65f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 125.97f, 0.65f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 125.97f, 0.65f, "p"));
        }
        else if (input.Difficulty.Equals("Hard"))
        {
            input.Notes.Add(new Data.NoteInfo(false, 1.85f, 0.65f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 1.85f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 2.08f, 0.65f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 2.42f, 0.65f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 2.65f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 2.77f, 0.65f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 3.11f, 0.65f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 3.23f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 3.57f, 0.65f, ";"));

            input.Notes.Add(new Data.NoteInfo(false, 4.83f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 5.06f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 5.52f, 0.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 6.20f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 6.89f, 8.26f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 8.26f, 0.65f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 8.49f, 0.65f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 8.61f, 0.65f, ";"));

            input.Notes.Add(new Data.NoteInfo(false, 9.18f, 0.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 9.52f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 9.87f, 11.47f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 10.21f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 10.55f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 10.67f, 11.47f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 11.01f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 11.35f, 0.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 11.70f, 11.47f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 12.04f, 0.65f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 12.27f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 12.39f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 12.61f, 0.65f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 12.96f, 0.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 13.30f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 13.53f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 13.87f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 14.22f, 15.36f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 14.33f, 15.36f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 14.56f, 15.36f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 14.68f, 15.36f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.02f, 15.36f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.59f, 0.65f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 16.05f, 0.65f, ";"));

            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 16.51f + 0.00f, 0.65f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 16.97f + 0.00f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 17.42f + 0.00f, 0.65f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 17.88f + 0.00f, 0.65f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 16.51f + 1.83f, 0.65f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 16.97f + 1.83f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 17.42f + 1.83f, 0.65f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 17.88f + 1.83f, 0.65f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 16.51f + 3.66f, 0.65f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 16.97f + 3.66f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 17.42f + 3.66f, 0.65f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 17.88f + 3.66f, 0.65f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 16.51f + 5.49f, 0.65f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 16.97f + 5.49f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 17.42f + 5.49f, 0.65f, ";"));
            input.Notes.Add(new Data.NoteInfo(true, 22.94f,17.88f + 5.49f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 16.51f + 7.33f, 0.65f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 16.97f + 7.33f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 17.42f + 7.33f, 0.65f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 17.88f + 7.33f, 0.65f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 16.51f + 9.16f, 0.65f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 16.97f + 9.16f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 17.42f + 9.16f, 0.65f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 17.88f + 9.16f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 26.81f, 0.65f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 16.51f + 10.99f, 0.65f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 17.42f + 10.99f, 0.65f, ";"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 16.51f + 12.82f, 0.65f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 17.42f + 12.82f, 0.65f, ";"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 16.51f + 12.82f, 0.65f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 16.51f + 12.82f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 17.42f + 12.82f, 0.65f, ";"));
            input.Notes.Add(new Data.NoteInfo(true, 17.42f + 12.82f, 17.88f + 12.82f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 16.51f + 14.65f, 0.65f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 16.97f + 14.65f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 17.42f + 14.65f, 0.65f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 17.88f + 14.65f, 0.65f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 16.51f + 16.49f, 0.65f, "a"));

            input.Notes.Add(new Data.NoteInfo(false, 34.14f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 34.37f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 34.60f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 34.14f, 0.65f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 34.37f, 0.65f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 34.60f, 0.65f, "q"));

            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 16.51f + 18.32f, 0.65f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 16.97f + 18.32f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 17.42f + 18.32f, 0.65f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 17.88f + 18.32f, 0.65f, "space"));
            //interance
            input.Notes.Add(new Data.NoteInfo(false, 16.51f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 16.97f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 17.19f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 17.54f, 18.34f, "d"));

            //3com
            input.Notes.Add(new Data.NoteInfo(false, 19.03f + 0.00f, 0.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 19.14f + 0.00f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 19.26f + 0.00f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 19.71f + 0.00f, 0.65f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 20.40f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 20.97f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 21.43f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 21.77f, 22.92f, "k"));

            input.Notes.Add(new Data.NoteInfo(true, 23.15f, 23.84f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 23.84f, 0.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 23.95f, 0.65f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 24.29f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 24.41f, 0.65f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 24.64f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 24.98f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 25.32f, 26.47f, "d"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 26.81f + 0.00f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 27.04f + 0.00f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 27.27f + 0.00f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 27.50f + 0.00f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 27.84f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 28.19f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 28.53f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 28.87f, 30.25f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 31.16f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 31.51f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 31.85f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 31.97f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 32.19f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 32.42f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 32.65f, 33.80f, "l"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 26.81f + 7.33f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 27.04f + 7.33f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 27.27f + 7.33f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 27.50f + 7.33f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 35.17f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 35.52f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 35.86f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 36.20f, 37.58f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 36.66f, 37.58f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 37.58f, 38.49f, "p"));
            //1st groove
            input.Notes.Add(new Data.NoteInfo(true, 38.49f + 0.00f, 38.84f + 0.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 38.84f + 0.00f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 39.22f + 0.00f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 39.52f + 0.00f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 39.87f + 0.00f, 40.32f + 0.00f, "f"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 26.81f + 13.51f + 0.00f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 27.04f + 13.51f + 0.00f, 0.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 27.27f + 13.51f + 0.00f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 27.50f + 13.51f + 0.00f, 0.65f, "l"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 26.81f + 14.43f + 0.00f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 27.04f + 14.43f + 0.00f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 27.27f + 14.43f + 0.00f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 27.50f + 14.43f + 0.00f, 0.65f, "f"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 26.81f + 15.35f + 0.00f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.04f + 15.35f + 0.00f, 0.65f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 27.27f + 15.35f + 0.00f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.50f + 15.35f + 0.00f, 0.65f, ";"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 26.81f + 16.26f + 0.00f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.04f + 16.26f + 0.00f, 0.65f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 27.27f + 16.26f + 0.00f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.50f + 16.26f + 0.00f, 0.65f, ";"));

            input.Notes.Add(new Data.NoteInfo(true, 42.16f + 0.00f, 42.61f + 0.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 42.84f + 0.00f, 43.07f + 0.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 43.19f + 0.00f, 43.42f + 0.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 43.53f + 0.00f, 43.76f + 0.00f, "j"));

            input.Notes.Add(new Data.NoteInfo(true, 43.99f + 0.00f, 44.45f + 0.00f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 44.90f + 0.00f, 0.65f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 45.36f + 0.00f, 0.65f, "q"));

            input.Notes.Add(new Data.NoteInfo(false, 43.99f + 0.00f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 44.22f + 0.00f, 44.45f + 0.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 44.68f + 0.00f, 44.90f + 0.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 45.02f + 0.00f, 45.25f + 0.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 45.48f + 0.00f, 45.71f + 0.00f, "l"));

            //1st groove
            input.Notes.Add(new Data.NoteInfo(true, 38.49f + 7.33f, 38.84f + 7.33f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 38.84f + 7.33f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 39.22f + 7.33f, 0.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 39.52f + 7.33f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 39.87f + 7.33f, 40.32f + 7.33f, "space"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 26.81f + 13.51f + 7.33f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 27.04f + 13.51f + 7.33f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 27.27f + 13.51f + 7.33f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 27.50f + 13.51f + 7.33f, 0.65f, "f"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 26.81f + 14.43f + 7.33f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 27.04f + 14.43f + 7.33f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 27.27f + 14.43f + 7.33f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 27.50f + 14.43f + 7.33f, 0.65f, "k"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 26.81f + 15.35f + 7.33f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.04f + 15.35f + 7.33f, 0.65f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 27.27f + 15.35f + 7.33f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.50f + 15.35f + 7.33f, 0.65f, ";"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 26.81f + 16.26f + 7.33f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.04f + 16.26f + 7.33f, 0.65f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 27.27f + 16.26f + 7.33f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.50f + 16.26f + 7.33f, 0.65f, ";"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 26.81f + 17.18f + 7.33f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.04f + 17.18f + 7.33f, 0.65f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 27.27f + 17.18f + 7.33f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.50f + 17.18f + 7.33f, 0.65f, ";"));

            input.Notes.Add(new Data.NoteInfo(true, 42.16f + 7.33f, 42.61f + 7.33f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 42.84f + 7.33f, 43.07f + 7.33f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 43.19f + 7.33f, 43.42f + 7.33f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 43.53f + 7.33f, 43.76f + 7.33f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 43.99f + 7.33f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 44.22f + 7.33f, 44.45f + 7.33f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 44.68f + 7.33f, 44.90f + 7.33f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 45.02f + 7.33f, 45.25f + 7.33f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 52.23f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 52.46f, 0.65f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 52.69f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 52.69f, 0.65f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 52.81f, 0.65f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 52.92f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 52.92f, 0.65f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 53.03f, 0.65f, "q"));

            //2nd groove
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 16.51f + 36.64f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 16.97f + 36.64f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 17.42f + 36.64f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 17.88f + 36.64f, 0.65f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 16.51f + 38.47f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 16.97f + 38.47f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 17.42f + 38.47f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 17.88f + 38.47f, 0.65f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 16.51f + 40.3f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 16.97f + 40.3f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 17.42f + 40.3f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 17.88f + 40.3f, 0.65f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 16.51f + 42.13f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 16.97f + 42.13f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 17.42f + 42.13f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 17.88f + 42.13f, 0.65f, "space"));

            input.Notes.Add(new Data.NoteInfo(true, 53.15f + 0.00f, 53.38f + 0.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 53.49f + 0.00f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 53.84f + 0.00f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.18f + 0.00f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 54.52f + 0.00f, 54.75f + 0.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 54.87f + 0.00f, 0.65f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 55.21f + 0.00f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 55.44f + 0.00f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 55.55f + 0.00f, 0.65f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 55.90f + 0.00f, 0.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 56.13f + 0.00f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 56.35f + 0.00f, 56.81f + 0.00f, "j"));

            input.Notes.Add(new Data.NoteInfo(true, 56.81f + 0.00f, 57.04f + 0.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 57.16f + 0.00f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 57.50f + 0.00f, 0.65f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 57.84f + 0.00f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 58.19f + 0.00f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 58.53f + 0.00f, 0.65f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 58.87f + 0.00f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 59.10f + 0.00f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 59.22f + 0.00f, 0.65f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 59.56f + 0.00f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 59.79f + 0.00f, 60.02f + 0.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 60.13f + 0.00f, 60.48f + 0.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 59.56f + 0.00f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 59.79f + 0.00f, 60.02f + 0.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 60.13f + 0.00f, 60.48f + 0.00f, "j"));

            //2nd groove
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 16.51f + 36.64f + 7.33f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 16.97f + 36.64f + 7.33f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 17.42f + 36.64f + 7.33f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 17.88f + 36.64f + 7.33f, 0.65f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 16.51f + 38.47f + 7.33f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 16.97f + 38.47f + 7.33f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 17.42f + 38.47f + 7.33f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 17.88f + 38.47f + 7.33f, 0.65f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 16.51f + 40.3f + 7.33f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 16.97f + 40.3f + 7.33f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 17.42f + 40.3f + 7.33f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 17.88f + 40.3f + 7.33f, 0.65f, "space"));

            input.Notes.Add(new Data.NoteInfo(true, 53.15f + 7.33f, 53.38f + 7.33f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 53.49f + 7.33f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 53.84f + 7.33f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.18f + 7.33f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 54.52f + 7.33f, 54.75f + 7.33f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 54.87f + 7.33f, 0.65f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 55.21f + 7.33f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 55.44f + 7.33f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 55.55f + 7.33f, 0.65f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 55.90f + 7.33f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 56.13f + 7.33f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 56.35f + 7.33f, 56.81f + 7.33f, "l"));

            input.Notes.Add(new Data.NoteInfo(true, 56.81f + 7.33f, 57.04f + 7.33f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 57.16f + 7.33f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 57.50f + 7.33f, 0.65f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 57.84f + 7.33f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 58.19f + 7.33f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 58.53f + 7.33f, 0.65f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 65.97f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 66.20f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 66.66f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 66.89f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 67.35f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 65.97f, 0.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 66.66f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 66.66f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 66.89f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 67.35f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 65.97f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 66.20f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 66.66f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 66.89f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 67.35f, 0.65f, "space"));

            input.Notes.Add(new Data.NoteInfo(true, 67.81f, 69.64f, "a"));

            input.Notes.Add(new Data.NoteInfo(false, 71.47f, 0.65f, "space"));

            input.Notes.Add(new Data.NoteInfo(true, 73.30f, 75.13f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 75.13f, 0.65f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 76.74f, 0.65f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 78.80f, 0.65f, "f"));

            input.Notes.Add(new Data.NoteInfo(true, 80.40f, 81.77f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 82.12f, 82.46f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 82.46f, 0.65f, "d"));

            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 82.92f + 0.00f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 83.84f + 0.00f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 84.75f + 0.00f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 85.67f + 0.00f, 0.65f, "space"));

            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 26.81f + 57.25f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 27.04f + 57.25f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 27.27f + 57.25f, 0.65f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 86.13f, 0.65f, "l"));
            //3/0.5
            input.Notes.Add(new Data.NoteInfo(false, 26.81f + 57.25f, 0.65f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 27.04f + 57.25f, 0.65f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 27.27f + 57.25f, 0.65f, "q"));

            input.Notes.Add(new Data.NoteInfo(false, 86.13f, 0.65f, "p"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 82.92f + 3.66f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 83.84f + 3.66f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 84.75f + 3.66f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 85.67f + 3.66f, 0.65f, "space"));

            input.Notes.Add(new Data.NoteInfo(false, 87.96f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 88.19f, 0.65f, "k"));

            input.Notes.Add(new Data.NoteInfo(true, 89.79f, 93.23f, "space"));

            input.Notes.Add(new Data.NoteInfo(false, 87.96f, 0.65f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 88.19f, 0.65f, ";"));

            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 82.92f + 7.33f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 83.84f + 7.33f, 0.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 84.75f + 7.33f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 85.67f + 7.33f, 0.65f, "l"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 26.81f + 66.64f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 27.04f + 66.64f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 27.27f + 66.64f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 27.50f + 66.64f, 0.65f, "s"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 26.81f + 66.76f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 27.04f + 66.76f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 27.27f + 66.76f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 27.50f + 66.76f, 0.65f, "d"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 26.81f + 67.56f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 27.04f + 67.56f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 27.27f + 67.56f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 27.50f + 67.56f, 0.65f, "d"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 26.81f + 67.67f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 27.04f + 67.67f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 27.27f + 67.67f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 27.50f + 67.67f, 0.65f, "l"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 26.81f + 68.48f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 27.04f + 68.48f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 27.27f + 68.48f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 27.50f + 68.48f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 96.20f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 96.43f, 0.65f, "k"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 26.81f + 68.48f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 27.04f + 68.48f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 27.27f + 68.48f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.50f + 68.48f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 96.20f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 96.43f, 0.65f, "l"));
            //4com
            input.Notes.Add(new Data.NoteInfo(false, 96.66f+0.00f, 0.65f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 96.77f + 0.00f, 0.65f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 96.89f + 0.00f, 0.65f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 97.00f + 0.00f , 0.65f, "a"));
            //finale1
            input.Notes.Add(new Data.NoteInfo(true, 97.12f + 0.00f + 0.00f, 97.35f + 0.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 97.46f + 0.00f, 0.65f + 0.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 97.81f + 0.00f, 0.65f + 0.00f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 98.15f + 0.00f, 0.65f + 0.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 98.49f + 0.00f, 0.65f + 0.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 98.72f + 0.00f, 0.65f + 0.00f, "space"));

            input.Notes.Add(new Data.NoteInfo(false, 99.18f + 0.00f, 0.65f + 0.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 99.41f + 0.00f, 0.65f + 0.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 99.52f + 0.00f, 0.65f + 0.00f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 99.87f + 0.00f, 0.65f + 0.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 100.10f + 0.00f, 0.65f + 0.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 100.32f + 0.00f, 100.67f + 0.00f, "space"));

            input.Notes.Add(new Data.NoteInfo(false, 100.78f + 0.00f, 0.65f + 0.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 101.13f + 0.00f, 0.65f + 0.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 101.47f + 0.00f, 0.65f + 0.00f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 101.81f + 0.00f, 0.65f + 0.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 102.16f + 0.00f, 0.65f + 0.00f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 102.39f + 0.00f, 0.65f + 0.00f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 102.84f + 0.00f, 0.65f + 0.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 103.07f + 0.00f, 0.65f + 0.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 103.19f + 0.00f, 0.65f + 0.00f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 103.53f + 0.00f, 0.65f + 0.00f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 103.76f + 0.00f, 103.99f + 0.00f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 104.10f + 0.00f, 104.33f + 0.00f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 103.53f + 0.00f, 0.65f + 0.00f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 103.76f + 0.00f, 103.99f + 0.00f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 104.10f + 0.00f, 104.33f + 0.00f, "j"));

            //finale1
            input.Notes.Add(new Data.NoteInfo(true, 97.12f + 7.33f, 97.35f + 7.33f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 97.46f + 7.33f, 0.65f + 7.33f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 97.81f + 7.33f, 0.65f + 7.33f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 98.15f + 7.33f, 0.65f + 7.33f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 98.49f + 7.33f, 0.65f + 7.33f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 98.72f + 7.33f, 0.65f + 7.33f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 99.18f + 7.33f, 0.65f + 7.33f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 99.41f + 7.33f, 0.65f + 7.33f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 99.52f + 7.33f, 0.65f + 7.33f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 99.87f + 7.33f, 0.65f + 7.33f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 100.10f + 7.33f, 0.65f + 7.33f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 100.32f + 7.33f, 100.67f + 7.33f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 100.78f + 7.33f, 0.65f + 7.33f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 101.13f + 7.33f, 0.65f + 7.33f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 101.47f + 7.33f, 0.65f + 7.33f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 101.81f + 7.33f, 0.65f + 7.33f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 102.16f + 7.33f, 0.65f + 7.33f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 102.39f + 7.33f, 0.65f + 7.33f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 102.84f + 7.33f, 0.65f + 7.33f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 103.07f + 7.33f, 0.65f + 7.33f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 103.19f + 7.33f, 0.65f + 7.33f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 103.53f + 7.33f, 0.65f + 7.33f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 103.76f + 7.33f, 103.99f + 7.33f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 104.10f + 7.33f, 104.33f + 7.33f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 103.53f + 7.33f, 0.65f + 7.33f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 103.76f + 7.33f, 103.99f + 7.33f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 104.10f + 7.33f, 104.33f + 7.33f, "k"));

            //finale1
            input.Notes.Add(new Data.NoteInfo(true, 97.12f + 14.65f, 97.35f + 14.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 97.46f + 14.65f, 0.65f + 14.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 97.81f + 14.65f, 0.65f + 14.65f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 98.15f + 14.65f, 0.65f + 14.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 98.49f + 14.65f, 0.65f + 14.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 98.72f + 14.65f, 0.65f + 14.65f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 99.18f + 14.65f, 0.65f + 14.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 99.41f + 14.65f, 0.65f + 14.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 99.52f + 14.65f, 0.65f + 14.65f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 99.87f + 14.65f, 0.65f + 14.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 100.10f + 14.65f, 0.65f + 14.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 100.32f + 14.65f, 100.67f + 14.65f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 100.78f + 14.65f, 0.65f + 14.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 101.13f + 14.65f, 0.65f + 14.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 101.47f + 14.65f, 0.65f + 14.65f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 101.81f + 14.65f, 0.65f + 14.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 102.16f + 14.65f, 0.65f + 14.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 102.39f + 14.65f, 0.65f + 14.65f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 102.84f + 14.65f, 0.65f + 14.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 103.07f + 14.65f, 0.65f + 14.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 103.19f + 14.65f, 0.65f + 14.65f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 103.53f + 14.65f, 0.65f + 14.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 103.76f + 14.65f, 103.99f + 14.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 104.10f + 14.65f, 104.33f + 14.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 103.53f + 14.65f, 0.65f + 14.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 103.76f + 14.65f, 103.99f + 14.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(true, 104.10f + 14.65f, 104.33f + 14.65f, "j"));

            input.Notes.Add(new Data.NoteInfo(true, 111.77f, 113.61f, "space"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 26.81f + 84.96f, 0.65f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 27.04f + 84.96f, 0.65f, "q"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 26.81f + 85.88f, 0.65f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 27.04f + 85.88f, 0.65f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 27.27f + 85.88f, 0.65f, ";"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 26.81f + 86.8f, 0.65f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 27.04f + 86.8f, 0.65f, "a"));

            input.Notes.Add(new Data.NoteInfo(true, 114.52f, 114.98f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 114.98f, 0.65f, "a"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 26.81f + 88.63f, 0.65f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 27.04f + 88.63f, 0.65f, "space"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 26.81f + 89.77f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.04f + 89.77f, 0.65f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 26.81f + 90.23f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.04f + 90.23f, 0.65f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 27.27f + 90.23f, 0.65f, "q"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 26.81f + 91.15f, 0.65f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 27.04f + 91.15f, 0.65f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 27.27f + 91.15f, 0.65f, "p"));
            //4/0.75
            input.Notes.Add(new Data.NoteInfo(false, 119.10f + 0.00f, 44.45f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 119.45f + 0.00f, 44.90f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 119.79f + 0.00f, 45.25f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 120.13f + 0.00f, 45.71f, "d"));

            //4/0.75
            input.Notes.Add(new Data.NoteInfo(false, 119.10f + 1.38f, 44.45f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 119.45f + 1.38f, 44.90f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 119.79f + 1.38f, 45.25f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 120.13f + 1.38f, 45.71f, "l"));

            //4/0.75
            input.Notes.Add(new Data.NoteInfo(false, 119.10f + 2.75f, 44.45f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 119.45f + 2.75f, 44.90f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 119.79f + 2.75f, 45.25f, "j"));

            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 26.81f + 95.96f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 27.04f + 95.96f, 0.65f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 27.27f + 95.96f, 0.65f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 27.50f + 95.96f, 0.65f, "f"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 26.81f + 96.07f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 27.04f + 96.07f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 27.27f + 96.07f, 0.65f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 27.50f + 96.07f, 0.65f, "d"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 26.81f + 96.87f, 0.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 27.04f + 96.87f, 0.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 27.27f + 96.87f, 0.65f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 27.50f + 96.87f, 0.65f, "j"));
            //4/0.5
            input.Notes.Add(new Data.NoteInfo(false, 26.81f + 96.99f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 27.04f + 96.99f, 0.65f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 27.27f + 96.99f, 0.65f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 27.50f + 96.99f, 0.65f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 124.60f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 124.60f, 0.65f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 124.83f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 124.94f, 0.65f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 124.94f, 0.65f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 125.29f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 125.29f, 0.65f, "p"));

            input.Notes.Add(new Data.NoteInfo(false, 125.52f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 125.52f, 0.65f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 125.97f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 126.2f, 0.65f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 125.97f, 0.65f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 126.09f, 0.65f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 126.2f, 0.65f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 126.32f, 0.65f, "a"));
        }
        else if (input.Difficulty.Equals("Extreme"))
        {
            input.Notes.Add(new Data.NoteInfo(true, 0.00f, 0.65f, "k"));
        }
    }
}
