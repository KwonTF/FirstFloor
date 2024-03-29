﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class Liquid_Cube : MonoBehaviour {

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
        MusicInfo.key = 15;
        MusicInfo.name = "Liquid Cube";
        MusicInfo.composer = "StaticSphere";
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
            input.Notes.Add(new Data.NoteInfo(false, 0.250f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 0.678f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 0.678f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.107f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.535f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.535f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.964f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.392f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.392f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 2.821f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.250f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.250f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.678f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 4.107f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 4.107f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 4.535f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 4.964f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 4.964f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 5.392f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 5.821f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 5.821f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 6.250f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 6.678f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 6.678f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 6.892f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 7.107f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 7.107f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 7.535f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 7.535f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 7.964f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 8.392f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 8.392f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 8.821f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 9.250f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 9.250f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 9.678f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 10.107f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 10.107f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 10.321f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 10.535f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 10.964f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 10.964f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 11.392f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 11.821f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 11.821f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 12.035f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 12.250f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 12.250f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 12.250f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 12.464f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 12.678f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 12.678f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 12.678f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 12.892f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 13.000f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 13.107f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 13.107f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 13.214f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 13.321f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 13.428f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 13.535f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 13.535f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 13.642f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 13.750f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 13.857f, 2.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 13.964f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 14.285f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 14.607f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 14.821f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 15.142f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 15.357f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.464f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 15.678f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 16.000f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 16.321f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 16.535f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 16.857f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 17.071f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 17.178f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 17.285f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 17.392f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 17.714f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 18.035f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 18.250f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 18.571f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 18.785f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 18.892f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 19.107f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 19.428f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 19.750f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 19.964f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 20.285f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 20.500f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 20.607f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 20.714f, 2.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 20.821f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 21.142f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 21.464f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 21.678f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 22.000f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 22.214f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 22.321f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 22.428f, 2.0f, "f"));
             
            input.Notes.Add(new Data.NoteInfo(false, 22.535f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 22.857f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 23.178f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 23.392f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 23.714f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 23.928f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 24.035f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 24.142f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 24.250f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 24.571f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 24.892f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 25.107f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 25.428f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 25.642f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 25.857f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 25.964f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 25.964f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 26.285f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 26.392f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 26.607f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 26.821f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 26.821f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.142f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 27.250f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.464f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 27.678f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.678f, 2.0f, "a"));

            input.Notes.Add(new Data.NoteInfo(false, 30.678f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.785f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 30.892f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 31.000f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 31.107f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 31.107f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 31.428f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 31.535f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 31.750f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 31.964f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 32.285f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 32.392f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 32.500f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 32.607f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 32.821f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 33.142f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 33.250f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 33.464f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 33.678f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 34.000f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 34.107f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 34.214f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 34.321f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 34.428f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 34.535f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 34.857f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 34.964f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 35.178f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 35.392f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 35.714f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 35.821f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 35.928f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 36.035f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 36.250f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 36.571f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 36.678f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 36.892f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 37.107f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 37.428f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 37.535f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 37.642f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 37.750f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 37.857f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 37.964f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 38.285f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 38.392f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 38.607f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 38.821f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 39.142f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 39.250f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 39.357f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 39.464f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 39.571f, 2.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 39.678f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 40.000f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 40.107f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 40.321f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 40.535f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 40.857f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 40.964f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 41.071f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 41.178f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 41.285f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 41.392f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 41.714f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 41.821f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 42.035f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 42.250f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 42.571f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 42.678f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 42.785f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 42.892f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 43.000f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 43.107f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 43.428f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 43.535f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 43.750f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 43.964f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 44.285f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 44.392f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 44.500f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 44.607f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 44.714f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 44.821f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 44.821f, 2.0f, "q"));

            input.Notes.Add(new Data.NoteInfo(false, 45.035f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 45.142f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 45.464f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 45.678f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 45.892f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 46.107f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 46.321f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 46.535f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 46.750f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 46.857f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 47.178f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 47.285f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 47.392f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 47.607f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 47.821f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 48.035f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 48.250f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 48.464f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 48.571f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 48.892f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 49.107f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 49.321f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 49.535f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 49.750f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 49.964f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 50.178f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 50.285f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 50.607f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 50.714f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 50.821f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 51.035f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 51.250f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 51.464f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 51.678f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 51.892f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 52.000f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 52.321f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 52.535f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 52.750f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 52.964f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 53.178f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 53.392f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 53.607f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 53.714f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.035f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.142f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.250f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.464f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.678f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.892f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 55.107f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 55.321f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 55.428f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 55.750f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 55.857f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 55.964f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 56.285f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 56.392f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 56.500f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 56.607f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 56.714f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 56.821f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 57.035f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 57.142f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 57.464f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 57.571f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 57.678f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 57.892f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 58.107f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 58.321f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 58.428f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 58.535f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 58.535f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 58.535f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 58.857f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 59.178f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 59.392f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 59.714f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 60.035f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 61.964f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 62.285f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 62.607f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 62.821f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 63.142f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 63.464f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 65.392f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 65.392f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 65.392f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 65.714f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 66.035f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 66.250f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 66.571f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 66.785f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 66.892f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 67.107f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 67.428f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 67.750f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 67.964f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 68.285f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 68.500f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 68.607f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 68.821f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 69.142f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 69.464f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 69.678f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 70.000f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 70.214f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 70.321f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 70.535f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 70.535f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 70.857f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 70.964f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 71.178f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 71.285f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 71.392f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 71.392f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 71.500f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 71.714f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 71.821f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 71.821f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 72.142f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 72.250f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 72.250f,73.642f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 72.250f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 72.678f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 72.678f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 73.107f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 73.535f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 73.535f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 73.750f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 73.964f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 73.964f,74.500f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 74.392f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 74.392f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(true, 74.607f,75.357f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 74.821f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 75.250f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 75.250f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 75.464f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 75.678f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 75.678f,76.214f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 76.107f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 76.107f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(true, 76.321f,76.857f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 76.535f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 76.964f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 76.964f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(true, 76.964f,77.285f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 77.392f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 77.392f,78.142f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 77.821f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 77.821f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 78.250f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 78.250f,78.785f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 78.678f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 78.678f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 78.892f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 79.107f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 79.107f,79.642f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 79.535f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 79.535f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(true, 79.750f,80.285f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 79.964f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 80.392f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 80.392f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(true, 80.392f,80.714f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 80.821f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 80.821f,81.035f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 81.035f,81.357f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 81.250f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 81.250f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(true, 81.464f,82.000f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 81.678f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 82.107f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 82.107f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(true, 82.107f,82.428f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 82.535f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 82.535f,84.142f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 82.964f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 82.964f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 83.392f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 83.821f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 83.821f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 84.250f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 84.250f,84.785f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 84.678f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 84.678f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(true, 84.892f,85.857f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 85.107f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 85.535f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 85.535f, 2.0f, "q"));

            input.Notes.Add(new Data.NoteInfo(false, 85.964f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 85.964f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 86.178f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 86.285f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 86.392f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 86.607f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 86.714f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 86.821f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 87.035f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 87.142f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 87.250f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 87.464f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 87.571f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 87.678f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 87.892f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 88.000f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 88.107f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 88.321f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 88.428f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 88.535f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 88.750f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 88.857f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 88.964f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 89.178f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 89.285f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 89.392f, 2.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 89.607f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 89.714f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 89.821f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 90.035f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 90.142f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 90.250f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 90.464f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 90.571f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 90.678f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 90.892f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 91.000f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 91.107f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 91.214f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 91.428f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 91.535f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 91.642f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 91.750f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 91.964f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 92.178f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 92.285f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 92.392f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 92.607f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 92.714f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 92.821f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 93.035f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 93.142f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 93.250f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 93.357f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 93.464f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 93.678f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 93.785f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 93.892f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 94.000f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 94.107f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 94.321f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 94.428f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 94.535f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 94.750f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 94.857f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 94.964f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 95.071f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 95.178f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 95.285f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 95.392f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 95.607f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 95.714f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 95.821f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 95.928f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 96.035f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 96.142f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 96.250f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 96.464f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 96.571f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 96.678f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 96.892f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 97.000f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 97.107f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 97.321f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 97.428f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 97.535f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 97.642f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 97.750f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 97.964f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 98.178f, 2.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 98.285f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 98.392f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 98.607f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 98.714f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 98.821f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 98.928f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 99.035f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 99.142f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 99.357f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 99.464f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 99.571f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 99.678f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 99.678f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 99.892f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 100.107f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 100.321f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 100.535f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 100.750f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 100.964f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 101.178f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 101.285f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 101.392f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 101.607f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 101.821f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 102.035f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 102.250f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 102.464f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 102.678f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 102.892f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 103.000f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 103.107f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 103.321f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 103.535f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 103.750f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 103.964f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 104.178f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 104.392f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 104.607f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 104.714f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 104.821f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 105.035f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 105.250f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 105.464f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 105.678f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 105.892f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 106.107f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 106.321f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 106.428f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 106.535f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 106.750f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 106.964f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 107.178f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 107.392f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 107.607f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 107.821f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 108.035f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 108.142f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 108.250f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 108.464f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 108.678f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 108.892f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 109.107f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 109.321f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 109.535f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 109.750f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 109.857f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 109.964f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 110.178f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 110.392f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 110.607f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 110.821f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 111.035f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 111.250f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 111.464f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 111.571f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 111.678f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 111.892f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 112.107f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 112.321f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 112.535f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 112.750f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 112.964f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 113.178f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 113.285f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 113.392f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 113.392f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 113.392f, 2.0f, ";"));

        }
        else if (input.Difficulty.Equals("Hard"))
        {
            //hard drum
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.46f + 0.00f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 0.89f + 0.00f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 1.32f + 0.00f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 1.75f + 0.00f, 2.0f, "a"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.46f + 1.71f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 0.89f + 1.71f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 1.32f + 1.71f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 1.75f + 1.71f, 2.0f, ";"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.46f + 3.43f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 0.89f + 3.43f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 1.32f + 3.43f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 1.75f + 3.43f, 2.0f, "a"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.46f + 5.14f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 0.89f + 5.14f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 1.32f + 5.14f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 1.75f + 5.14f, 2.0f, ";"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.46f + 6.86f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 0.89f + 6.86f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 1.32f + 6.86f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 1.75f + 6.86f, 2.0f, "a"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.46f + 8.57f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 0.89f + 8.57f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 1.32f + 8.57f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 1.75f + 8.57f, 2.0f, ";"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.46f + 10.29f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 0.89f + 10.29f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 1.32f + 10.29f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 1.75f + 10.29f, 2.0f, "a"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.46f + 12.0f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 0.89f + 12.0f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 1.32f + 12.0f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 1.75f + 12.0f, 2.0f, ";"));

            input.Notes.Add(new Data.NoteInfo(false, 0.250f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 0.678f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 0.678f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 1.107f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.535f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 1.535f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 1.964f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.392f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 2.392f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 2.821f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.250f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.250f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.678f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 4.107f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 4.107f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 4.535f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 4.964f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 4.964f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 5.392f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 5.821f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 5.821f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 6.250f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 6.678f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 6.678f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 6.892f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 7.107f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 7.107f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 7.535f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 7.535f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 7.964f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 8.392f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 8.392f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 8.821f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 9.250f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 9.250f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 9.678f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 10.107f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 10.107f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 10.321f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 10.535f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 10.964f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 10.964f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 11.392f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 11.821f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 11.821f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 12.035f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 12.250f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 12.250f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 12.250f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 12.464f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 12.678f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 12.678f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 12.678f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 12.892f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 13.000f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 13.107f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 13.107f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 13.214f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 13.321f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 13.428f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 13.535f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 13.535f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 13.642f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 13.750f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 13.857f, 2.0f, "l"));
            //hard add
            //base1
            input.Notes.Add(new Data.NoteInfo(false, 13.964f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 14.285f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 14.607f + 0.00f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 14.821f + 0.00f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.142f + 0.00f, 2.0f, "d"));
            //base1
            input.Notes.Add(new Data.NoteInfo(false, 13.964f + 1.71f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 14.285f + 1.71f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 14.607f + 1.71f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 14.821f + 1.71f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.142f + 1.71f, 2.0f, "k"));
            //base1
            input.Notes.Add(new Data.NoteInfo(false, 13.964f + 3.43f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 14.285f + 3.43f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 14.607f + 3.43f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 14.821f + 3.43f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 15.142f + 3.43f, 2.0f, "f"));
            //base1
            input.Notes.Add(new Data.NoteInfo(false, 13.964f + 5.14f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 14.285f + 5.14f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 14.607f + 5.14f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 14.821f + 5.14f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.142f + 5.14f, 2.0f, "k"));
            //base1
            input.Notes.Add(new Data.NoteInfo(false, 13.964f + 6.86f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 14.285f + 6.86f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 14.607f + 6.86f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 14.821f + 6.86f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.142f + 6.86f, 2.0f, "k"));
            //base1
            input.Notes.Add(new Data.NoteInfo(false, 13.964f + 8.57f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 14.285f + 8.57f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 14.607f + 8.57f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 14.821f + 8.57f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.142f + 8.57f, 2.0f, "d"));
            //base1
            input.Notes.Add(new Data.NoteInfo(false, 13.964f + 10.29f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 14.285f + 10.29f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 14.607f + 10.29f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 14.821f + 10.29f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 15.142f + 10.29f, 2.0f, "s"));
            //base1
            input.Notes.Add(new Data.NoteInfo(false, 13.964f + 12.0f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 14.285f + 12.0f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 14.607f + 12.0f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 14.821f + 12.0f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 15.142f + 12.0f, 2.0f, "j"));
            //
            input.Notes.Add(new Data.NoteInfo(false, 13.964f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 14.285f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 14.607f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 14.821f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 15.142f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 15.357f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.464f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 15.678f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 16.000f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 16.321f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 16.535f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 16.857f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 17.071f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 17.178f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 17.285f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 17.392f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 17.714f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 18.035f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 18.250f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 18.571f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 18.785f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 18.892f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 19.107f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 19.428f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 19.750f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 19.964f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 20.285f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 20.500f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 20.607f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 20.714f, 2.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 20.821f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 21.142f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 21.464f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 21.678f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 22.000f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 22.214f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 22.321f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 22.428f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 22.535f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 22.857f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 23.178f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 23.392f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 23.714f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 23.928f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 24.035f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 24.142f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 24.250f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 24.571f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 24.892f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 25.107f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 25.428f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 25.642f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 25.857f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 25.964f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 25.964f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 26.285f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 26.392f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 26.607f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 26.821f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 26.821f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.142f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 27.250f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.464f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 27.678f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 27.678f, 2.0f, "a"));

            input.Notes.Add(new Data.NoteInfo(false, 30.678f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 30.785f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 30.892f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 31.000f, 2.0f, "k"));
            //hard add
            //base1
            input.Notes.Add(new Data.NoteInfo(false, 13.964f + 17.14f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 14.285f + 17.14f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 14.607f + 17.14f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 14.821f + 17.14f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 15.142f + 17.14f, 2.0f, "s"));
            //base1
            input.Notes.Add(new Data.NoteInfo(false, 13.964f + 18.86f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 14.285f + 18.86f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 14.607f + 18.86f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 14.821f + 18.86f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 15.142f + 18.86f, 2.0f, "l"));
            //base1
            input.Notes.Add(new Data.NoteInfo(false, 13.964f + 20.57f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 14.285f + 20.57f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 14.607f + 20.57f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 14.821f + 20.57f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 15.142f + 20.57f, 2.0f, "d"));
            //base1
            input.Notes.Add(new Data.NoteInfo(false, 13.964f + 22.29f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 14.285f + 22.29f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 14.607f + 22.29f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 14.821f + 22.29f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 15.142f + 22.29f, 2.0f, "j"));
            //base1
            input.Notes.Add(new Data.NoteInfo(false, 13.964f + 24.0f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 14.285f + 24.0f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 14.607f + 24.0f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 14.821f + 24.0f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 15.142f + 24.0f, 2.0f, "s"));
            //base1
            input.Notes.Add(new Data.NoteInfo(false, 13.964f + 25.71f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 14.285f + 25.71f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 14.607f + 25.71f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 14.821f + 25.71f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 15.142f + 25.71f, 2.0f, "k"));
            //base1
            input.Notes.Add(new Data.NoteInfo(false, 13.964f + 27.43f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 14.285f + 27.43f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 14.607f + 27.43f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 14.821f + 27.43f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 15.142f + 27.43f, 2.0f, "s"));
            //base1
            input.Notes.Add(new Data.NoteInfo(false, 13.964f + 29.14f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 14.285f + 29.14f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 14.607f + 29.14f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 14.821f + 29.14f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 15.142f + 29.14f, 2.0f, "l"));

            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.46f + 30.64f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.89f + 30.64f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.32f + 30.64f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.75f + 30.64f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.46f + 32.36f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.89f + 32.36f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.32f + 32.36f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.75f + 32.36f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.46f + 34.07f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.89f + 34.07f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.32f + 34.07f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.75f + 34.07f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.46f + 35.79f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.89f + 35.79f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.32f + 35.79f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.75f + 35.79f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.46f + 37.5f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.89f + 37.5f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.32f + 37.5f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.75f + 37.5f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.46f + 39.21f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.89f + 39.21f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.32f + 39.21f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.75f + 39.21f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.46f + 40.93f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.89f + 40.93f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.32f + 40.93f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.75f + 40.93f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.46f + 42.64f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.89f + 42.64f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.32f + 42.64f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.75f + 42.64f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.46f + 44.36f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.89f + 44.36f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.32f + 44.36f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.75f + 44.36f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.46f + 46.07f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.89f + 46.07f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.32f + 46.07f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.75f + 46.07f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.46f + 47.79f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.89f + 47.79f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.32f + 47.79f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.75f + 47.79f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.46f + 49.5f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.89f + 49.5f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.32f + 49.5f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.75f + 49.5f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.46f + 51.21f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.89f + 51.21f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.32f + 51.21f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.75f + 51.21f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.46f + 52.93f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.89f + 52.93f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.32f + 52.93f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.75f + 52.93f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.46f + 54.64f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.89f + 54.64f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.32f + 54.64f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.75f + 54.64f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.46f + 56.36f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.89f + 56.36f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.32f + 56.36f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.75f + 56.36f, 2.0f, "space"));

            input.Notes.Add(new Data.NoteInfo(false, 31.107f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 31.107f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 31.428f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 31.535f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 31.750f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 31.964f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 32.285f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 32.392f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 32.500f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 32.607f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 32.821f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 33.142f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 33.250f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 33.464f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 33.678f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 34.000f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 34.107f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 34.214f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 34.321f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 34.428f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 34.535f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 34.857f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 34.964f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 35.178f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 35.392f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 35.714f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 35.821f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 35.928f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 36.035f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 36.250f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 36.571f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 36.678f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 36.892f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 37.107f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 37.428f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 37.535f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 37.642f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 37.750f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 37.857f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 37.964f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 38.285f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 38.392f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 38.607f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 38.821f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 39.142f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 39.250f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 39.357f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 39.464f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 39.571f, 2.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 39.678f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 40.000f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 40.107f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 40.321f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 40.535f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 40.857f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 40.964f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 41.071f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 41.178f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 41.285f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 41.392f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 41.714f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 41.821f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 42.035f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 42.250f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 42.571f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 42.678f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 42.785f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 42.892f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 43.000f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 43.107f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 43.428f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 43.535f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 43.750f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 43.964f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 44.285f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 44.392f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 44.500f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 44.607f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 44.714f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 44.821f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 44.821f, 2.0f, "q"));

            input.Notes.Add(new Data.NoteInfo(false, 45.035f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 45.142f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 45.464f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 45.678f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 45.892f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 46.107f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 46.321f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 46.535f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 46.750f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 46.857f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 47.178f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 47.285f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 47.392f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 47.607f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 47.821f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 48.035f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 48.250f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 48.464f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 48.571f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 48.892f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 49.107f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 49.321f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 49.535f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 49.750f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 49.964f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 50.178f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 50.285f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 50.607f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 50.714f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 50.821f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 51.035f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 51.250f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 51.464f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 51.678f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 51.892f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 52.000f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 52.321f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 52.535f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 52.750f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 52.964f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 53.178f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 53.392f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 53.607f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 53.714f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.035f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.142f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.250f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.464f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 54.678f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 54.892f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 55.107f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 55.321f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 55.428f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 55.750f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 55.857f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 55.964f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 56.285f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 56.392f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 56.500f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 56.607f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 56.714f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 56.821f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 57.035f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 57.142f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 57.464f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 57.571f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 57.678f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 57.892f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 58.107f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 58.321f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 58.428f, 2.0f, "k"));
            
            input.Notes.Add(new Data.NoteInfo(false, 58.535f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 58.535f, 2.0f, "p"));

            input.Notes.Add(new Data.NoteInfo(false, 58.535f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 58.857f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 59.178f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 59.392f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 59.714f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 60.035f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 58.535f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 58.857f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 59.178f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 59.392f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 59.714f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 60.035f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 58.535f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 58.857f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 59.178f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 59.392f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 59.714f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 60.035f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 61.964f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 62.285f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 62.607f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 62.821f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 63.142f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 63.464f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 61.964f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 62.285f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 62.607f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 62.821f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 63.142f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 63.464f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 61.964f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 62.285f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 62.607f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 62.821f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 63.142f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 63.464f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 65.392f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 65.392f, 2.0f, ";"));

            input.Notes.Add(new Data.NoteInfo(false, 65.392f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 65.714f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 66.035f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 66.250f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 66.571f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 66.785f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 66.892f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 65.392f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 65.714f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 66.035f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 66.250f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 66.571f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 65.392f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 65.714f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 66.035f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 66.250f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 66.571f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 66.892f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 67.107f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 67.428f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 67.750f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 67.964f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 68.285f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 68.500f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 68.607f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 67.107f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 67.428f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 67.750f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 67.964f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 68.285f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 67.107f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 67.428f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 67.750f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 67.964f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 68.285f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 68.607f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 68.821f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 69.142f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 69.464f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 69.678f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 70.000f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 70.214f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 70.321f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 68.821f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 69.142f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 69.464f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 69.678f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 70.000f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 68.821f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 69.142f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 69.464f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 69.678f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 70.000f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 70.321f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 70.535f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 70.535f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 70.535f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 70.535f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 70.857f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 70.857f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 70.857f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 70.964f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 71.178f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 71.178f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 71.178f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 71.285f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 71.392f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 71.392f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 71.500f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 71.714f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 71.821f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 71.821f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 72.142f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 72.250f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 72.250f, 73.642f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 72.250f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 72.678f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 72.678f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 73.107f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 73.535f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 73.535f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 73.750f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 73.964f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 73.964f, 74.500f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 74.392f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 74.392f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(true, 74.607f, 75.357f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 74.821f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 75.250f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 75.250f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 75.464f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 75.678f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(true, 75.678f, 76.214f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 76.107f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 76.107f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(true, 76.321f, 76.857f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 76.535f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 76.964f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 76.964f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(true, 76.964f, 77.285f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 77.392f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 77.392f, 78.142f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 77.821f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 77.821f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 78.250f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 78.250f, 78.785f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 78.678f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 78.678f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 78.892f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 79.107f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 79.107f, 79.642f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 79.535f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 79.535f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(true, 79.750f, 80.285f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 79.964f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 80.392f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 80.392f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(true, 80.392f, 80.714f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 80.821f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 80.821f, 81.035f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 81.035f, 81.357f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 81.250f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 81.250f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(true, 81.464f, 82.000f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 81.678f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 82.107f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 82.107f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(true, 82.107f, 82.428f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 82.535f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 82.535f, 84.142f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 82.964f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 82.964f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 83.392f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 83.821f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 83.821f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 84.250f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(true, 84.250f, 84.785f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 84.678f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 84.678f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(true, 84.892f, 85.857f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 85.107f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 85.535f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 85.535f, 2.0f, "q"));

            input.Notes.Add(new Data.NoteInfo(false, 85.964f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 85.964f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 86.178f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 86.285f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 86.392f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 86.607f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 86.714f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 86.821f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 87.035f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 87.142f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 87.250f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 87.464f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 87.571f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 87.678f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 87.892f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 88.000f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 88.107f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 88.321f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 88.428f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 88.535f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 88.750f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 88.857f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 88.964f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 89.178f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 89.285f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 89.392f, 2.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 89.607f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 89.714f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 89.821f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 90.035f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 90.142f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 90.250f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 90.464f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 90.571f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 90.678f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 90.892f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 91.000f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 91.107f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 91.214f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 91.428f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 91.535f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 91.642f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 91.750f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 91.964f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 92.178f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 92.285f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 92.392f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 92.607f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 92.714f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 92.821f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 93.035f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 93.142f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 93.250f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 93.357f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 93.464f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 93.678f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 93.785f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 93.892f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 94.000f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 94.107f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 94.321f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 94.428f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 94.535f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 94.750f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 94.857f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 94.964f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 95.071f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 95.178f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 95.285f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 95.392f, 2.0f, "j"));

            input.Notes.Add(new Data.NoteInfo(false, 95.607f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 95.714f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 95.821f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 95.928f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 96.035f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 96.142f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 96.250f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 96.464f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 96.571f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 96.678f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 96.892f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 97.000f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 97.107f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 97.321f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 97.428f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 97.535f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 97.642f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 97.750f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 97.964f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 98.178f, 2.0f, "l"));

            input.Notes.Add(new Data.NoteInfo(false, 98.285f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 98.392f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 98.607f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 98.714f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 98.821f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 98.928f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 99.035f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 99.142f, 2.0f, "s"));

            input.Notes.Add(new Data.NoteInfo(false, 99.357f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 99.464f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 99.571f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 99.678f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 99.678f, 2.0f, "p"));
            input.Notes.Add(new Data.NoteInfo(false, 99.892f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 100.107f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 100.321f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 100.535f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 100.750f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 100.964f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 101.178f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 101.285f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 101.392f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 101.607f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 101.821f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 102.035f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 102.250f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 102.464f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 102.678f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 102.892f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 103.000f, 2.0f, "f"));

            input.Notes.Add(new Data.NoteInfo(false, 103.107f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 103.321f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 103.535f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 103.750f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 103.964f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 104.178f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 104.392f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 104.607f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 104.714f, 2.0f, "k"));

            input.Notes.Add(new Data.NoteInfo(false, 104.821f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 105.035f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 105.250f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 105.464f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 105.678f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 105.892f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 106.107f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 106.321f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 106.428f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 106.535f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 106.750f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 106.964f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 107.178f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 107.392f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 107.607f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 107.821f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 108.035f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 108.142f, 2.0f, "d"));

            input.Notes.Add(new Data.NoteInfo(false, 108.250f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 108.464f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 108.678f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 108.892f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 109.107f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 109.321f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 109.535f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 109.750f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 109.857f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 109.964f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 110.178f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 110.392f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 110.607f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 110.821f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 111.035f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 111.250f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 111.464f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 111.571f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 111.678f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 111.892f, 2.0f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 112.107f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 112.321f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 112.535f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 112.750f, 2.0f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 112.964f, 2.0f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 113.178f, 2.0f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 113.285f, 2.0f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 113.392f, 2.0f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 113.392f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 113.392f, 2.0f, ";"));

            //hard add
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.46f + 30.64f + 54.864f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.89f + 30.64f + 54.864f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.32f + 30.64f + 54.864f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.75f + 30.64f + 54.864f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.46f + 32.36f + 54.864f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.89f + 32.36f + 54.864f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.32f + 32.36f + 54.864f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.75f + 32.36f + 54.864f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.46f + 34.07f + 54.864f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.89f + 34.07f + 54.864f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.32f + 34.07f + 54.864f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.75f + 34.07f + 54.864f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.46f + 35.79f + 54.864f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.89f + 35.79f + 54.864f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.32f + 35.79f + 54.864f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.75f + 35.79f + 54.864f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.46f + 37.5f + 54.864f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.89f + 37.5f + 54.864f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.32f + 37.5f + 54.864f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.75f + 37.5f + 54.864f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.46f + 39.21f + 54.864f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.89f + 39.21f + 54.864f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.32f + 39.21f + 54.864f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.75f + 39.21f + 54.864f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.46f + 40.93f + 54.864f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.89f + 40.93f + 54.864f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.32f + 40.93f + 54.864f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.75f + 40.93f + 54.864f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.46f + 42.64f + 54.864f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.89f + 42.64f + 54.864f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.32f + 42.64f + 54.864f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.75f + 42.64f + 54.864f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.46f + 44.36f + 54.864f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.89f + 44.36f + 54.864f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.32f + 44.36f + 54.864f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.75f + 44.36f + 54.864f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.46f + 46.07f + 54.864f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.89f + 46.07f + 54.864f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.32f + 46.07f + 54.864f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.75f + 46.07f + 54.864f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.46f + 47.79f + 54.864f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.89f + 47.79f + 54.864f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.32f + 47.79f + 54.864f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.75f + 47.79f + 54.864f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.46f + 49.5f + 54.864f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.89f + 49.5f + 54.864f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.32f + 49.5f + 54.864f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.75f + 49.5f + 54.864f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.46f + 51.21f + 54.864f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.89f + 51.21f + 54.864f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.32f + 51.21f + 54.864f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.75f + 51.21f + 54.864f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.46f + 52.93f + 54.864f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.89f + 52.93f + 54.864f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.32f + 52.93f + 54.864f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.75f + 52.93f + 54.864f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.46f + 54.64f + 54.864f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.89f + 54.64f + 54.864f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.32f + 54.64f + 54.864f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.75f + 54.64f + 54.864f, 2.0f, "space"));
            //4/1
            input.Notes.Add(new Data.NoteInfo(false, 0.46f + 56.36f + 54.864f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 0.89f + 56.36f + 54.864f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.32f + 56.36f + 54.864f, 2.0f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 1.75f + 56.36f + 54.864f, 2.0f, "space"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 100.107f + 0.00f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 100.96f + 0.00f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 101.82f + 0.00f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 102.67f + 0.00f, 2.0f, "p"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 100.107f + 3.428f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 100.96f + 3.428f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 101.82f + 3.428f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 102.67f + 3.428f, 2.0f, "p"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 100.107f + 6.857f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 100.96f + 6.857f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 101.82f + 6.857f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 102.67f + 6.857f, 2.0f, "p"));
            //4/2
            input.Notes.Add(new Data.NoteInfo(false, 100.107f + 10.285f, 2.0f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 100.96f + 10.285f, 2.0f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 101.82f + 10.285f, 2.0f, "q"));
            input.Notes.Add(new Data.NoteInfo(false, 102.67f + 10.285f, 2.0f, "p"));
        }
        else if (input.Difficulty.Equals("Extreme"))
        {
            input.Notes.Add(new Data.NoteInfo(false, 0.0f, 2.0f, "s"));
        }
    }
}
