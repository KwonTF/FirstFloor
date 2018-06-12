using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToewrofTech : MonoBehaviour {
    public Texture PVimg;
    public Texture image1;
    public Texture image2;
    public Texture image3;
    public Texture image4;
    public Entire entire;
    public Immortal immortal;
    public Deborah deborah;
    public Kamui kamui;
    UrbanData.courseData courseData = new UrbanData.courseData();
    public UrbanData.courseData getCourse()
    {
        courseData.CoursePV = PVimg;
        courseData.Courses = new List<Texture>();
        courseData.Courses.Add(image1);
        courseData.Courses.Add(image2);
        courseData.Courses.Add(image3);
        courseData.Courses.Add(image4);

        courseData.RouteLevel = 17;
        courseData.RouteInfo = "Pangyo Techno Plaza";
        courseData.RouteName = "Tower of Technika";
        List<int> levels = new List<int>();
        levels.Add(1);
        levels.Add(1);
        levels.Add(1);
        levels.Add(2);
        courseData.musicLevels = levels;
        List<Data.MusicInfo> coursemusic = new List<Data.MusicInfo>();
        coursemusic.Add(entire.GetInfo());
        coursemusic.Add(immortal.GetInfo());
        coursemusic.Add(deborah.GetInfo());
        coursemusic.Add(kamui.GetInfo());

        courseData.musics = coursemusic;
        return courseData;
    }
}
