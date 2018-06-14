using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RouteSelect : MonoBehaviour {
    public UrbanData Routedata;

    public RawImage screen;

    public Text point;
    public Text point_1;
    public Text point_2;
    public Text point1;
    public Text point2;
    public Text level;
    public Text level_1;
    public Text level_2;
    public Text level1;
    public Text level2;
    int currentPoint = 0;

    public Text RInfo;
    private float speed;
    public Text speedText;

    public RawImage devdev;
    public Texture devon;
    public Texture devoff;

    public RawImage fader;
    // Use this for initialization
    void Start () {
        MusicSelect.devMode = false;
        speed = 5.0f;
        speedText.text = speed.ToString("N1") + "x";
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if (Input.GetKeyDown(KeyCode.Q) || Input.GetKeyDown(KeyCode.P))
        {
            if (speed >= 10.0f)
            {
                speed = 10.0f;
            }
            else
            {
                speed += 0.1f;
            }
            speedText.text = speed.ToString("N1") + "x";
        }
        else if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.Semicolon))
        {
            if (speed <= 1.0f)
            {
                speed = 1.0f;
            }
            else
            {
                speed -= 0.1f;
            }
            speedText.text = speed.ToString("N1") + "x";
        }
        else if (Input.GetKeyDown(KeyCode.F2))
        {
            MusicSelect.devMode = !MusicSelect.devMode;
            devDev(MusicSelect.devMode);
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            UrbanWait.courseData = Routedata.courses[currentPoint];
            UrbanWait.stageNum = 0;
            UrbanWait.musicAcc = new List<float>();
            UrbanWait.score = 0;
            UrbanWait.max_combo = 0;
            UrbanWait.combo = 0;
            UrbanWait.life_getter = 100.0f;
            NoteDrop.Speed = speed;
            UrbanTotal.input_RName = point.text;
            UrbanTotal.input_RInfo = RInfo.text;
            UrbanTotal.randText = Routedata.courses[currentPoint].Courses[Random.Range(0,3)];
            InvokeRepeating("dissolve", 0f, 0.05f);
        }
    }

    public void init()
    {
        screen.texture = Routedata.courses[currentPoint].CoursePV;
        point.text = Routedata.courses[currentPoint].RouteName;
        level.text = Routedata.courses[currentPoint].RouteLevel.ToString();
        RInfo.text = Routedata.courses[currentPoint].RouteInfo;
        if (currentPoint - 2 < 0)
        {
            point_2.text = "-----";
            level_2.text = "--";
            if (currentPoint - 1 < 0)
            {
                point_1.text = "-----";
                level_1.text = "--";
            }
            else
            {
                point_1.text = Routedata.courses[currentPoint - 1].RouteName;
                level_1.text = Routedata.courses[currentPoint - 1].RouteLevel.ToString();
            }
        }
        else
        {
            point_1.text = Routedata.courses[currentPoint - 1].RouteName;
            level_1.text = Routedata.courses[currentPoint - 1].RouteLevel.ToString();
            point_2.text = Routedata.courses[currentPoint - 2].RouteName;
            level_2.text = Routedata.courses[currentPoint - 2].RouteLevel.ToString();
        }
        if (Routedata.courses.Count < (currentPoint + 1) + 2)
        {
            point2.text = "-----";
            level2.text = "--";
            if (Routedata.courses.Count < (currentPoint + 1) + 1)
            {
                point1.text = "-----";
                level1.text = "--";
            }
            else
            {
                point1.text = Routedata.courses[currentPoint + 1].RouteName;
                level1.text = Routedata.courses[currentPoint + 1].RouteLevel.ToString();
            }
        }
        else
        {
            point1.text = Routedata.courses[currentPoint + 1].RouteName;
            level1.text = Routedata.courses[currentPoint + 1].RouteLevel.ToString();
            point2.text = Routedata.courses[currentPoint + 2].RouteName;
            level2.text = Routedata.courses[currentPoint + 2].RouteLevel.ToString();

        }
    }
    public void devDev(bool input)
    {
        CancelInvoke("devEff");
        if (input)
        {
            devdev.texture = devon;
        }
        else
        {
            devdev.texture = devoff;
        }
        devdev.color = new Color(1.0f, 1.0f, 1.0f, 2.5f);
        InvokeRepeating("devEff", 0.0f, 0.1f);
    }
    public void devEff()
    {
        Color temp = devdev.color;
        temp = new Color(temp.r, temp.g, temp.b, temp.a - 0.5f);
        devdev.color = temp;
        if (temp.a <= 0.0f)
        {
            CancelInvoke("devEff");
        }
    }

    void dissolve()
    {
        if (fader.color.a < 2.5f)
        {
            Color temp = fader.color;
            temp.a += 0.1f;
            fader.color = temp;
        }
        else
        {
            SceneManager.LoadScene("UrbanWating");
        }
    }
}
