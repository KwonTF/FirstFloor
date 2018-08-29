using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vast_Message : MonoBehaviour {

    public Texture PVimg;
    public Texture image1;
    public Texture image2;
    public Texture image3;
    public Texture image4;
    public Brandnew_Days brandnew;
    public For_Seasons_AGM _AGM;
    public Tracking_Down tracking;
    public Sapphire sapphire;
    UrbanData.courseData courseData = new UrbanData.courseData();
    public UrbanData.courseData getCourse()
    {
        courseData.CoursePV = PVimg;
        courseData.Courses = new List<Texture>();
        courseData.Courses.Add(image1);
        courseData.Courses.Add(image2);
        courseData.Courses.Add(image3);
        courseData.Courses.Add(image4);

        courseData.RouteLevel = 5;
        courseData.RouteInfo = "ICN, SFO, SEA, JFK";
        courseData.RouteName = "Vast Message";
        List<int> levels = new List<int>();
        levels.Add(0);
        levels.Add(0);
        levels.Add(0);
        levels.Add(0);
        courseData.musicLevels = levels;
        List<Data.MusicInfo> coursemusic = new List<Data.MusicInfo>();
        coursemusic.Add(brandnew.GetInfo());
        coursemusic.Add(_AGM.GetInfo());
        coursemusic.Add(tracking.GetInfo());
        coursemusic.Add(sapphire.GetInfo());

        courseData.musics = coursemusic;
        return courseData;
    }
}
