using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UrbanTotal : MonoBehaviour {
    public static string input_RName;
    public static string input_RInfo;
    public static Texture randText;
    public Text RName;
    public Text RInfo;

    public Text Name1;
    public Text Diff1;
    public Text Acc1;
    public RawImage Screen1;
    public RawImage Rank1;

    public Text Name2;
    public Text Diff2;
    public Text Acc2;
    public RawImage Screen2;
    public RawImage Rank2;

    public Text Name3;
    public Text Diff3;
    public Text Acc3;
    public RawImage Screen3;
    public RawImage Rank3;

    public Text Name4;
    public Text Diff4;
    public Text Acc4;
    public RawImage Screen4;
    public RawImage Rank4;

    public Text TAcc;
    public Text TScore;
    public RawImage TRank;

    public RawImage RandomBack;
    public RectTransform disc;

    public Texture S;
    public Texture A;
    public Texture B;
    public Texture C;
    public Texture D;
    public Texture F;

    public RawImage fader;
    // Use this for initialization
    void Start () {
        RName.text = input_RName;
        RInfo.text = input_RInfo;

        Name1.text = TotalResult.totalDatas[0].name;
        Name2.text = TotalResult.totalDatas[1].name;
        Name3.text = TotalResult.totalDatas[2].name;
        Name4.text = TotalResult.totalDatas[3].name;

        Diff1.text = TotalResult.totalDatas[0].playdata.Difficulty;
        Diff2.text = TotalResult.totalDatas[1].playdata.Difficulty;
        Diff3.text = TotalResult.totalDatas[2].playdata.Difficulty;
        Diff4.text = TotalResult.totalDatas[3].playdata.Difficulty;

        Acc1.text = TotalResult.totalDatas[0].accuracy.ToString("N2");
        Acc2.text = TotalResult.totalDatas[1].accuracy.ToString("N2");
        Acc3.text = TotalResult.totalDatas[2].accuracy.ToString("N2");
        Acc4.text = TotalResult.totalDatas[3].accuracy.ToString("N2");

        Screen1.texture = TotalResult.totalDatas[0].playdata.catchParase;
        Screen2.texture = TotalResult.totalDatas[1].playdata.catchParase;
        Screen3.texture = TotalResult.totalDatas[2].playdata.catchParase;
        Screen4.texture = TotalResult.totalDatas[3].playdata.catchParase;

        Rank1.texture = TotalResult.totalDatas[0].rank;
        Rank2.texture = TotalResult.totalDatas[1].rank;
        Rank3.texture = TotalResult.totalDatas[2].rank;
        Rank4.texture = TotalResult.totalDatas[3].rank;

        TAcc.text = UrbanWait.acc.ToString("N2");
        TScore.text = UrbanWait.score.ToString();

        RandomBack.texture = randText;

        if (UrbanWait.acc >= 95)
        {
            TRank.texture = S;
        }
        else if (UrbanWait.acc < 95 && UrbanWait.acc >= 93)
        {
            TRank.texture = A;
        }
        else if (UrbanWait.acc < 93 && UrbanWait.acc >= 90)
        {
            TRank.texture = B;
        }
        else if (UrbanWait.acc < 90 && UrbanWait.acc >= 80)
        {
            TRank.texture = C;
        }
        else if (UrbanWait.acc < 80 && UrbanWait.acc >= 70)
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
        disc.Rotate(disc.rotation.x, disc.rotation.y, disc.rotation.z + 4.0f);
        if (disc.rotation.z >= 360.0f)
        {
            disc.Rotate(disc.rotation.x, disc.rotation.y, 0.0f);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (UrbanWait.acc >= 95.0f)
            {
                Finale.hiddenVid = true;
            }
            else
            {
                Finale.hiddenVid = false;
            }
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
            toSelect("Finale");
        }
    }
    public void toSelect(string name)
    {
        SceneManager.LoadScene(name);
    }
}
