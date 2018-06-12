using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UrbanData : MonoBehaviour {
    public ToewrofTech toewrofTech;

    public RouteSelect urbanConsole;
    public class courseData
    {
        public List<Data.MusicInfo> musics;
        public Texture CoursePV;
        public List<Texture> Courses;
        public string RouteInfo;
        public string RouteName;
        public int RouteLevel;
        public List<int> musicLevels;
    }

    public List<courseData> courses = new List<courseData>();
	// Use this for initialization
	void Start () {
        courses.Add(toewrofTech.getCourse());
        urbanConsole.init();
	}
}
