using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Data: MonoBehaviour{
    public MusicSelect console;

    public Immortal immortal;
    public Kamui kamui;
    public Test test;
    public class NoteInfo
    {
        public bool isLong;
        public float hitTime;
        public float endTime;
        public string notePos;
        public NoteInfo(bool islong, float hittime, float endtime, string notepos)
        {
            isLong = islong;
            hitTime = hittime;
            endTime = endtime;
            notePos = notepos;
        }
    }
    public class Playdata
    {
        public string Difficulty;
        public int level;
        public Texture catchParase;
        public int max_combo;
        public List<NoteInfo> Notes;
    }
    public class MusicInfo
    {
        public int key;
        public string name;
        public string composer;
        public string visualizer;
        public AudioClip music;
        public VideoClip bga;
        public VideoClip bga_blur;
        public List<Playdata> list;
    }
    public List<MusicInfo> Musics = new List<MusicInfo>();

    void Start()
    {
        Musics.Add(immortal.GetInfo());
        Musics.Add(kamui.GetInfo());
        Musics.Add(test.GetInfo());
        console.init();
    }
}