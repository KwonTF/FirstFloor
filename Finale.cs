﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Finale : MonoBehaviour {
    public static bool hiddenVid;
    public VideoClip normal;
    public VideoClip perfect;

    public VideoPlayer VideoPlayer;

    public RawImage fader;
    // Use this for initialization
    void Start () {
        if (hiddenVid)
        {
            VideoPlayer.clip = perfect;
            InvokeRepeating("dissolve", 6.0f, 0.05f);
        }
        else
        {
            VideoPlayer.clip = normal;
            InvokeRepeating("dissolve", 65.0f, 0.05f);
        }
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space))
        {
            InvokeRepeating("dissolve", 0f, 0.05f);
        }
	}
    public void dissolve()
    {
        if (fader.color.a < 2.5f)
        {
            Color temp = fader.color;
            temp.a += 0.1f;
            fader.color = temp;
        }
        else
        {
            Scenechange();
        }
    }
    void Scenechange()
    {
        SceneManager.LoadScene("ModeSelect");
    }
}
