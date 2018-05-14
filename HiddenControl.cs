using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class HiddenControl : MonoBehaviour {

    public AudioSource source;
    public VideoPlayer player;
    public AudioClip mot_hid;
    public VideoClip WB_hid;
    public VideoClip BND_hid;
    public VideoClip LD_hid;
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
        if (music.name.Equals("WhiteBlue")&&Random.Range(0,3) == 0)
        {
            Debug.Log("hidden");
            player.clip = WB_hid;
        }
        if(music.name.Equals("Brandnew Days") && Random.Range(0, 2) == 0)
        {
            Debug.Log("hidden");
            player.clip = BND_hid;
        }
        if(music.name.Equals("Lazy Days") && Random.Range(0, 3) == 0)
        {
            Debug.Log("hidden");
            player.clip = LD_hid;
        }
    }
}
