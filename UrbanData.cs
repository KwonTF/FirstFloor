using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UrbanData : MonoBehaviour {
    public ToewrofTech toewrofTech;
    public Thrillus_Returns thrillus_;
    public Penta_Karaoke penta_;
    public RouteSelect urbanConsole;
    public Traveler_2102 traveler_;
    public Vast_Message vast_;
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
        courses.Add(thrillus_.getCourse());
        courses.Add(penta_.getCourse());
        courses.Add(traveler_.getCourse());
        courses.Add(vast_.getCourse());
        urbanConsole.init();
	}
}
