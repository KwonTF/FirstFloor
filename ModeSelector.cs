using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ModeSelector : MonoBehaviour {
    List<VideoClip> mode = new List<VideoClip>();
    List<AudioClip> systemSound = new List<AudioClip>();
    List<string> copyright = new List<string>();
    int currentMode;
    public Text text; 
    public VideoPlayer video;
    public AudioSource audios;
    public VideoClip Clip1;
    public AudioClip AudioClip1;
    public VideoClip Clip2;
    public AudioClip AudioClip2;
    public VideoClip Clip3;
    public AudioClip AudioClip3;

    public SpriteRenderer fader;
	// Use this for initialization
	void Start () {
        mode.Add(Clip1);
        mode.Add(Clip2);
        mode.Add(Clip3);
        systemSound.Add(AudioClip1);
        systemSound.Add(AudioClip2);
        systemSound.Add(AudioClip3);
        copyright.Add("LunaticSound - Enterance");
        copyright.Add("StudioEIM-This is how we do");
        copyright.Add("Disel Eater - Nowhere Land");
        currentMode = 0;
        TotalResult.totalDatas = new List<TotalResult.TotalData>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            currentMode++;
            video.clip = mode[Mathf.Abs(currentMode)%3];
            audios.clip = systemSound[Mathf.Abs(currentMode) % 3];
            audios.Play();
            text.text = copyright[Mathf.Abs(currentMode) % 3];
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            currentMode--;
            if(currentMode < 0)
            {
                currentMode = 2;
            }
            video.clip = mode[Mathf.Abs(currentMode)%3];
            audios.clip = systemSound[Mathf.Abs(currentMode) % 3];
            text.text = copyright[Mathf.Abs(currentMode) % 3];
            audios.Play();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            switch (Mathf.Abs(currentMode) % 3)
            {
                case 0:
                    InvokeRepeating("dissolve", 0f, 0.05f);
                    break;
                case 1:
                    Debug.Log("Access Denied");
                    break;
                case 2:
                    Application.Quit();
                    break;
                default:
                    break;
            } 
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
            toSelect("MusicSelect");
        }
    }
    public void toSelect(string name)
    {
        SceneManager.LoadScene(name);
        MusicSelect.stagenum = 1;
    }
}
