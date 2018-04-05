using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class Finale : MonoBehaviour {
    public static bool hiddenVid;
    public VideoClip normal;
    public VideoClip perfect;

    public VideoPlayer VideoPlayer;
	// Use this for initialization
	void Start () {
        if (hiddenVid)
        {
            VideoPlayer.clip = perfect;
            Invoke("Scenechange", 6.0f);
        }
        else
        {
            VideoPlayer.clip = normal;
            Invoke("Scenechange", 65.0f);
        }
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space))
        {
            Scenechange();
        }
	}

    void Scenechange()
    {
        SceneManager.LoadScene("ModeSelect");
    }
}
