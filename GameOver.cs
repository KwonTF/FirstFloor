using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameOver : MonoBehaviour {

    public RawImage fader;
    // Use this for initialization
    void Start () {
        InvokeRepeating("dissolve", 8.0f,0.05f);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
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
        SceneManager.LoadScene("Main");
    }
}
