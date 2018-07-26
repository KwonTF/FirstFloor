using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thrillus_Returns : MonoBehaviour {

    public Texture PVimg;
    public Texture image1;
    public Texture image2;
    public Texture image3;
    public Texture image4;
    public Enjoy_The_World enjoy_;
    public Love_N_Hate love_;
    public Heaven_Tonight heaven;
    public Push_It push_;
    UrbanData.courseData courseData = new UrbanData.courseData();
    public UrbanData.courseData getCourse()
    {
        courseData.CoursePV = PVimg;
        courseData.Courses = new List<Texture>();
        courseData.Courses.Add(image1);
        courseData.Courses.Add(image2);
        courseData.Courses.Add(image3);
        courseData.Courses.Add(image4);

        courseData.RouteLevel = 11;
        courseData.RouteInfo = "Expo,Hansung Univ,Dogok-dong,Namsan";
        courseData.RouteName = "Thrillus Returns";
        List<int> levels = new List<int>();
        levels.Add(1);
        levels.Add(1);
        levels.Add(1);
        levels.Add(0);
        courseData.musicLevels = levels;
        List<Data.MusicInfo> coursemusic = new List<Data.MusicInfo>();
        coursemusic.Add(enjoy_.GetInfo());
        coursemusic.Add(love_.GetInfo());
        coursemusic.Add(heaven.GetInfo());
        coursemusic.Add(push_.GetInfo());

        courseData.musics = coursemusic;
        return courseData;
    }
}
