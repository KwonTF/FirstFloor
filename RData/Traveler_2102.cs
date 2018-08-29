using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traveler_2102 : MonoBehaviour {

    public Texture PVimg;
    public Texture image1;
    public Texture image2;
    public Texture image3;
    public Texture image4;
    public ALie_Deep aLie;
    public Houseplan houseplan;
    public How_To_Enjoy how_;
    public LazyDays lazyDays;
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
        courseData.RouteInfo = "Nowon Dongil-ro";
        courseData.RouteName = "21:02 Traveler";
        List<int> levels = new List<int>();
        levels.Add(0);
        levels.Add(0);
        levels.Add(0);
        levels.Add(0);
        courseData.musicLevels = levels;
        List<Data.MusicInfo> coursemusic = new List<Data.MusicInfo>();
        coursemusic.Add(aLie.GetInfo());
        coursemusic.Add(houseplan.GetInfo());
        coursemusic.Add(how_.GetInfo());
        coursemusic.Add(lazyDays.GetInfo());

        courseData.musics = coursemusic;
        return courseData;
    }
}
