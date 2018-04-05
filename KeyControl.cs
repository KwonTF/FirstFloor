using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class KeyControl : MonoBehaviour {
	public KeyCode keyCode;
    public Texture nonActiveTexture;
    public Texture ActiveTexture;
    RawImage curentImage;
    // Use this for initialization
    void Start () {
            curentImage = GetComponent<RawImage>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(keyCode))
        {
            curentImage.texture = ActiveTexture;
            
        }
        else if (Input.GetKeyUp(keyCode))
        {
            curentImage.texture = nonActiveTexture;
        }
	}
}
