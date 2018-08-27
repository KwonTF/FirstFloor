using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Penta_Karaoke : MonoBehaviour {

    public Texture PVimg;
    public Texture image1;
    public Texture image2;
    public Texture image3;
    public Texture image4;
    public Fly_Away fly_;
    public Take_On_Me take_On_Me;
    public Kung_Fu_Rider kung_Fu_Rider;
    public Supersonic2011 supersonic;
    UrbanData.courseData courseData = new UrbanData.courseData();
    public UrbanData.courseData getCourse()
    {
        courseData.CoursePV = PVimg;
        courseData.Courses = new List<Texture>();
        courseData.Courses.Add(image1);
        courseData.Courses.Add(image2);
        courseData.Courses.Add(image3);
        courseData.Courses.Add(image4);

        courseData.RouteLevel = 8;
        courseData.RouteInfo = "JukJeon, Pangyo, GangNam";
        courseData.RouteName = "Penta Karaoke";
        List<int> levels = new List<int>();
        levels.Add(0);
        levels.Add(0);
        levels.Add(0);
        levels.Add(0);
        courseData.musicLevels = levels;
        List<Data.MusicInfo> coursemusic = new List<Data.MusicInfo>();
        coursemusic.Add(fly_.GetInfo());
        coursemusic.Add(take_On_Me.GetInfo());
        coursemusic.Add(kung_Fu_Rider.GetInfo());
        coursemusic.Add(supersonic.GetInfo());

        courseData.musics = coursemusic;
        return courseData;
    }
}
