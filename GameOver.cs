using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Invoke("Scenechange", 8.0f);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Scenechange();
        }
    }
    void Scenechange()
    {
        SceneManager.LoadScene("Main");
    }
}
