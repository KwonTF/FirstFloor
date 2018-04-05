using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EffectorControl : MonoBehaviour {

    public KeyCode keyCodeUp;
    public KeyCode keyCodeDown;

    public Texture nonActiveTexture;
    public Texture UPActiveTexture;
    public Texture DownActiveTexture;

    RawImage curentImage;
	// Use this for initialization
	void Start () {
        curentImage = GetComponent<RawImage>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(keyCodeUp))
        {
            curentImage.texture = UPActiveTexture;
        }
        else if (Input.GetKeyUp(keyCodeUp))
        {
            curentImage.texture = nonActiveTexture;
        }

        if (Input.GetKeyDown(keyCodeDown))
        {
            curentImage.texture = DownActiveTexture;
        }
        else if (Input.GetKeyUp(keyCodeDown))
        {
            curentImage.texture = nonActiveTexture;
        }
    }
}
