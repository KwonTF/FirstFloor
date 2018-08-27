using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Data : MonoBehaviour {
    public MusicSelect console;
    //
    public Immortal immortal;
    public Kamui kamui;
    public Test test;
    public Motivity motivity;
    public Whiteblue whiteblue;
    public Brandnew_Days brandnew_Days;
    public Sapphire sapphire;
    public TheTalesRemix talesRemix;
    public Entire entire;
    public LazyDays lazyDays;
    public Deborah deborah;
    public ALie_Deep aLie_Deep;
    public For_Seasons_AGM For_Seasons_AGM;
    public Waiting_Sun waiting_Sun;
    public Houseplan houseplan;
    public Nothing_Else nothing;
    public Liquid_Cube liquid_Cube;
    public How_To_Enjoy How_To_Enjoy;
    public Tracking_Down tracking_Down;
    public Enjoy_The_World enjoy_;
    public Heaven_Tonight heaven_Tonight;
    public Love_N_Hate love_;
    public Push_It push_;
    public Raise_Me_Up raise;
    public Lost_n_Found lost_N_Found;
    public Fly_Away fly_Away;
    public Take_On_Me take_On_Me;
    public Kung_Fu_Rider Kung_Fu;
    public Supersonic2011 supersonic;
    public Flicker flicker;
    public MxMxM_Star star;
    //
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
        Musics.Add(motivity.GetInfo());
        Musics.Add(whiteblue.GetInfo());
        Musics.Add(brandnew_Days.GetInfo());
        Musics.Add(sapphire.GetInfo());
        Musics.Add(talesRemix.GetInfo());
        Musics.Add(entire.GetInfo());
        Musics.Add(lazyDays.GetInfo());
        Musics.Add(deborah.GetInfo());
        Musics.Add(aLie_Deep.GetInfo());
        Musics.Add(For_Seasons_AGM.GetInfo());
        Musics.Add(waiting_Sun.GetInfo());
        Musics.Add(houseplan.GetInfo());
        Musics.Add(nothing.GetInfo());
        Musics.Add(liquid_Cube.GetInfo());
        Musics.Add(How_To_Enjoy.GetInfo());
        Musics.Add(tracking_Down.GetInfo());
        Musics.Add(enjoy_.GetInfo());
        Musics.Add(heaven_Tonight.GetInfo());
        Musics.Add(love_.GetInfo());
        Musics.Add(push_.GetInfo());
        Musics.Add(raise.GetInfo());
        Musics.Add(lost_N_Found.GetInfo());
        Musics.Add(fly_Away.GetInfo());
        Musics.Add(take_On_Me.GetInfo());
        Musics.Add(Kung_Fu.GetInfo());
        Musics.Add(supersonic.GetInfo());
        Musics.Add(flicker.GetInfo());
        Musics.Add(star.GetInfo());
        Musics.Sort(delegate (MusicInfo a, MusicInfo b) {
            if (a.key > b.key) return 1;
            else if (a.key < b.key) return -1;
            else return 0;
        });
        console.init();
        console.musicRemotePlay();
    }
}