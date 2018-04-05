using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class CautionScipt : MonoBehaviour {
    public Text kor;
    public Text eng;
    public SpriteRenderer fader;
	// Use this for initialization
	void Start () {
        Invoke("textChange",3.0f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void textChange()
    {
        kor.text = "이 작품을 무단으로 배포하실 경우 용도와는 상관없이 법적 처벌을 받으실 수 있습니다.";
        eng.text = "Regardless of usage, Distribute of this program with unauthorized can be cause of legal punishment";
        InvokeRepeating("dissolve",3.0f,0.05f); 
    }
    void dissolve()
    {
        if(fader.color.a < 2.5f)
        {
            Color temp = fader.color;
            temp.a+=0.1f;
            fader.color = temp;
        }
        else
        {
            toMain("Main");
        }
    }
    public void toMain(string name)
    {
        SceneManager.LoadScene(name);
    }
}
