using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenControl : MonoBehaviour {

    public AudioSource source;
    public AudioClip mot_hid;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void init(Data.MusicInfo music, string difficult)
    {
        if(music.name.Equals("MOTIVITY")&&difficult.Equals("Extreme"))
        {
            Debug.Log("hidden");
            source.clip = mot_hid;
        }
    }
}
