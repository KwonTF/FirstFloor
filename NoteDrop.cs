using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoteDrop : MonoBehaviour {

    Vector3 constPos;
    public float hitTime;
    public float endTime;
    public float Speed;
    public bool isLong;
    private const float BASETIME = 5;
    private float downperMilsec;

	// Use this for initialization
    // Note Start 558/ Line-134 = 692height
	void Start (){
        //Debug.Log(Screen.height);
        Speed = 5;
        float calculatedTime = BASETIME/Speed;
        constPos = GetComponent<RectTransform>().position;
        GameObject temp = GameObject.Find("TimeLine");
        downperMilsec =(constPos.y - temp.GetComponent<RectTransform>().position.y)/(calculatedTime*100);
        InvokeRepeating("DropDown", hitTime-(calculatedTime), 0.01f);
        if (isLong)
        {
          //GetComponent<RectTransform>().rect.size.y = new Vector2(GetComponent<RectTransform>().rect.size.x, (endTime - hitTime) * 100 * downperMilsec);
            GetComponent<RectTransform>().sizeDelta = new Vector2(GetComponent<RectTransform>().sizeDelta.x,(endTime - hitTime) * 100 * downperMilsec);
            GetComponent<RectTransform>().position = new Vector3(GetComponent<RectTransform>().position.x, GetComponent<RectTransform>().position.y+ GetComponent<RectTransform>().sizeDelta.y/2);
            constPos = GetComponent<RectTransform>().position;
        }
	}
	
	// Update is called once per frame
	void Update (){
	}

    void DropDown(){

        constPos.y -= downperMilsec;
        GetComponent<RectTransform>().position = constPos;
    }
}
