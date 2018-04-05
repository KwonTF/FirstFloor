using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TotalResult : MonoBehaviour {
    public class TotalData
    {
        public string name;
        public Data.Playdata playdata;
        public int score;
        public float accuracy;
        public Texture rank;
        public TotalData(Data.Playdata input_playdata, string input_name, int input_score, float input_accuracy, Texture input_rank)
        {
            playdata = input_playdata;
            name = input_name;
            score = input_score;
            accuracy = input_accuracy;
            rank = input_rank;
        }
        
    }
    public static List<TotalData> totalDatas;

    public RawImage texture1;
    public RawImage texture2;
    public RawImage texture3;

    public Text name1;
    public Text name2;
    public Text name3;

    public Text difficulty1;
    public Text difficulty2;
    public Text difficulty3;

    public Text level1;
    public Text level2;
    public Text level3;

    public Text score1;
    public Text score2;
    public Text score3;

    public Text per1;
    public Text per2;
    public Text per3;

    public RawImage rank1;
    public RawImage rank2;
    public RawImage rank3;

    public Text TScore;
    public Text TAcc;
    public RawImage TRank;

    public RectTransform disc;
    public Texture S;
    public Texture A;
    public Texture B;
    public Texture C;
    public Texture D;
    public Texture F;
    void Start () {
        texture1.texture = totalDatas[0].playdata.catchParase;
        score1.text = totalDatas[0].score.ToString();
        per1.text = totalDatas[0].accuracy.ToString("N2");
        name1.text = totalDatas[0].name;
        difficulty1.text = totalDatas[0].playdata.Difficulty;
        level1.text = totalDatas[0].playdata.level.ToString();
        rank1.texture = totalDatas[0].rank;

        texture2.texture = totalDatas[1].playdata.catchParase;
        score2.text = totalDatas[1].score.ToString();
        per2.text = totalDatas[1].accuracy.ToString("N2");
        name2.text = totalDatas[1].name;
        difficulty2.text = totalDatas[1].playdata.Difficulty;
        level2.text = totalDatas[1].playdata.level.ToString();
        rank2.texture = totalDatas[1].rank;

        texture3.texture = totalDatas[2].playdata.catchParase;
        score3.text = totalDatas[2].score.ToString();
        per3.text = totalDatas[2].accuracy.ToString("N2");
        name3.text = totalDatas[2].name;
        difficulty3.text = totalDatas[2].playdata.Difficulty;
        level3.text = totalDatas[2].playdata.level.ToString();
        rank3.texture = totalDatas[2].rank;
            
        TScore.text = (totalDatas[0].score+totalDatas[1].score+totalDatas[2].score).ToString();
        float Acc = ((totalDatas[0].accuracy * totalDatas[0].playdata.max_combo + totalDatas[1].accuracy * totalDatas[1].playdata.max_combo + totalDatas[2].accuracy * totalDatas[2].playdata.max_combo) / (totalDatas[0].playdata.max_combo + totalDatas[1].playdata.max_combo + totalDatas[2].playdata.max_combo));
        TAcc.text = Acc.ToString("N2"); 
        if (Acc >= 95)
        {
            TRank.texture = S;
        }
        else if (Acc < 95 && Acc >= 93)
        {
            TRank.texture = A;
        }
        else if (Acc < 93 && Acc >= 90)
        {
            TRank.texture = B;
        }
        else if (Acc < 90 && Acc >= 80)
        {
            TRank.texture = C;
        }
        else if (Acc < 80 && Acc >= 70)
        {
            TRank.texture = D;
        }
        else
        {
            TRank.texture = F;
        }
    }
	
	// Update is called once per frame
	void Update () {
        disc.Rotate(0, 0, 3f);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (((totalDatas[0].accuracy * totalDatas[0].playdata.max_combo + totalDatas[1].accuracy * totalDatas[1].playdata.max_combo + totalDatas[2].accuracy * totalDatas[2].playdata.max_combo) / (totalDatas[0].playdata.max_combo + totalDatas[1].playdata.max_combo + totalDatas[2].playdata.max_combo)) >= 95.0f)
            {
                Finale.hiddenVid = true;
            }
            else
            {
                Finale.hiddenVid = false;
            }
            SceneManager.LoadScene("Finale");
        }
	}
}
