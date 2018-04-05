using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UIScipt : MonoBehaviour {
    public SpriteRenderer fader;
    public void SceneChange(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    void Update()
    {
        if (Input.anyKeyDown)
        {
            InvokeRepeating("dissolve", 0f, 0.05f);
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
            toMain("ModeSelect");
        }
    }
    public void toMain(string name)
    {
        SceneManager.LoadScene(name);
    }
}
