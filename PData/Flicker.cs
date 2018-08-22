using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class Flicker : MonoBehaviour {

    public AudioClip clip;
    public VideoClip bga;
    public VideoClip bga_blur;
    public Texture normal_img;
    public Texture hard_img;
    public Texture extreme_img;


    Data.MusicInfo MusicInfo = new Data.MusicInfo();
    void Start()
    {
        MusicInfo.music = clip;
        MusicInfo.bga_blur = bga_blur;
        MusicInfo.bga = bga;
    }
    public Data.MusicInfo GetInfo()
    {
        MusicInfo.key = 28;
        MusicInfo.name = "Flicker";
        MusicInfo.composer = "Chelp";
        MusicInfo.visualizer = "Haru-Sabin & FOX-B";
        MusicInfo.music = clip;
        MusicInfo.bga_blur = bga_blur;
        MusicInfo.bga = bga;
        MusicInfo.list = new List<Data.Playdata>();
        ListInit();

        return MusicInfo;
    }
    void ListInit()
    {
        Data.Playdata normal = new Data.Playdata();
        normal.Difficulty = "Normal";
        normal.catchParase = normal_img;
        normal.level = 6;
        MusicInfo.list.Add(normal);

        Data.Playdata hard = new Data.Playdata();
        hard.Difficulty = "Hard";
        hard.level = 12;
        hard.catchParase = hard_img;
        MusicInfo.list.Add(hard);

        Data.Playdata extreme = new Data.Playdata();
        extreme.Difficulty = "Extreme";
        extreme.level = 3;
        extreme.catchParase = extreme_img;
        MusicInfo.list.Add(extreme);
    }
    public void getNote(Data.Playdata input)
    {
        CreateNote(input);
        input.max_combo = input.Notes.Count;
    }
    void CreateNote(Data.Playdata input)
    {
        input.Notes = new List<Data.NoteInfo>();
        if (input.Difficulty.Equals("Normal"))
        {
            input.Notes.Add(new Data.NoteInfo(false, 0.021f, 0.2f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 0.566f, 0.2f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 1.657f, 0.2f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 3.293f, 0.2f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 3.839f, 0.2f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 4.93f, 0.2f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 6.566f, 0.2f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 7.111f, 0.2f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 8.202f, 0.2f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 9.839f, 0.2f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 16.657f, 0.2f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 17.202f, 0.2f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 17.748f, 0.2f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 18.293f, 0.2f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 18.839f, 0.2f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 19.384f, 0.2f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 19.93f, 0.2f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 20.475f, 0.2f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 21.02f, 0.2f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 21.566f, 0.2f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 22.111f, 0.2f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 22.657f, 0.2f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 23.202f, 0.2f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 23.748f, 0.2f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 24.293f, 0.2f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 24.566f, 0.2f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 24.839f, 0.2f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 24.975f, 0.2f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 25.657f, 0.2f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 26.748f, 0.2f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 27.839f, 0.2f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 28.93f, 0.2f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 30.02f, 0.2f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 31.111f, 0.2f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 31.657f, 0.2f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 32.066f, 0.2f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 32.475f, 0.2f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 32.884f, 0.2f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 33.293f, 0.2f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 34.111f, 0.2f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 34.657f, 0.2f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 35.202f, 0.2f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 35.748f, 0.2f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 36.293f, 0.2f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 36.839f, 0.2f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 37.248f, 0.2f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 37.657f, 0.2f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 38.475f, 0.2f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 39.02f, 0.2f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 39.566f, 0.2f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 40.111f, 0.2f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 40.657f, 0.2f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 41.202f, 0.2f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 41.748f, 0.2f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 42.293f, 0.2f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 42.566f, 0.2f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 43.111f, 0.2f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 43.657f, 0.2f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 44.202f, 0.2f,"l"));
            input.Notes.Add(new Data.NoteInfo(false, 44.748f, 0.2f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 45.293f, 0.2f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 45.839f, 0.2f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 46.384f, 0.2f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 46.93f, 0.2f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 47.339f, 0.2f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 47.611f, 0.2f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 47.884f, 0.2f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 48.43f, 0.2f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 49.111f, 0.2f,"p"));
            input.Notes.Add(new Data.NoteInfo(false, 49.657f, 0.2f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 50.066f, 0.2f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 50.339f, 0.2f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 50.611f, 0.2f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 50.748f, 0.2f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 51.293f, 0.2f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 52.111f, 0.2f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 52.93f, 0.2f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 53.475f, 0.2f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 53.884f, 0.2f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 54.293f, 0.2f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 54.566f, 0.2f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 54.839f, 55.248f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 55.657f, 0.2f,";"));
            input.Notes.Add(new Data.NoteInfo(false, 56.475f, 0.2f,";"));
            input.Notes.Add(new Data.NoteInfo(false, 57.02f, 0.2f,";"));
            input.Notes.Add(new Data.NoteInfo(false, 57.43f, 0.2f,";"));
            input.Notes.Add(new Data.NoteInfo(false, 57.839f, 0.2f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 58.111f, 59.748f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 60.02f, 0.2f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 60.839f, 0.2f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 61.657f, 0.2f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 62.202f, 0.2f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 62.611f, 0.2f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 63.02f, 0.2f, "d"));
            input.Notes.Add(new Data.NoteInfo(true, 63.293f, 63.702f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 64.384f, 0.2f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 66.566f, 0.2f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 67.111f, 0.2f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 67.657f, 0.2f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 68.202f, 0.2f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 68.748f, 0.2f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 69.293f, 0.2f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 69.839f, 0.2f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 70.384f, 0.2f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 70.93f, 0.2f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 71.475f, 0.2f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 72.02f, 72.43f, ";"));
            input.Notes.Add(new Data.NoteInfo(false, 73.111f, 0.2f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 73.657f, 0.2f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 74.202f, 0.2f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 74.748f, 0.2f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 75.293f, 0.2f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 75.702f, 0.2f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 76.248f, 0.2f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 76.793f, 0.2f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 77.475f, 0.2f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 78.02f, 0.2f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 78.566f, 0.2f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 79.111f, 0.2f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 79.657f, 0.2f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 80.202f, 0.2f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 80.748f, 81.157f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 81.839f, 0.2f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 82.384f, 0.2f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 82.93f, 0.2f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 83.475f, 0.2f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 84.02f, 0.2f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 84.43f, 0.2f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 84.839f, 0.2f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 85.248f, 0.2f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 85.657f, 0.2f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 86.202f, 0.2f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 86.748f, 0.2f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 87.293f, 0.2f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 87.839f, 0.2f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 88.384f, 0.2f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 88.93f, 0.2f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 89.475f, 0.2f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 89.748f, 90.157f, "a"));
            input.Notes.Add(new Data.NoteInfo(false, 90.566f, 0.2f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 91.111f, 0.2f, "j"));
            input.Notes.Add(new Data.NoteInfo(false, 91.657f, 0.2f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 92.202f, 0.2f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 92.748f, 0.2f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 93.293f, 0.2f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 93.839f, 0.2f, "l"));
            input.Notes.Add(new Data.NoteInfo(false, 94.384f, 0.2f, "j"));
            input.Notes.Add(new Data.NoteInfo(true, 94.93f, 95.748f, "f"));
            input.Notes.Add(new Data.NoteInfo(true, 96.02f, 96.839f, "k"));
            input.Notes.Add(new Data.NoteInfo(true, 97.111f, 97.93f, "s"));
            input.Notes.Add(new Data.NoteInfo(false, 98.066f, 0.2f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 99.293f, 0.2f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 99.702f, 0.2f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 99.975f, 0.2f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 100.248f, 0.2f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 100.793f, 0.2f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 101.475f, 0.2f, "space"));
            input.Notes.Add(new Data.NoteInfo(false, 102.02f, 0.2f, "d"));
            input.Notes.Add(new Data.NoteInfo(false, 102.02f, 0.2f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 102.43f, 0.2f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 102.702f, 0.2f, "f"));
            input.Notes.Add(new Data.NoteInfo(false, 102.975f, 0.2f, "k"));
            input.Notes.Add(new Data.NoteInfo(false, 103.111f, 0.2f, "j"));

        }
        else if (input.Difficulty.Equals("Hard"))
        {
            input.Notes.Add(new Data.NoteInfo(false, 0.0f, 0.2f, "s"));
        }
        else if (input.Difficulty.Equals("Extreme"))
        {
            input.Notes.Add(new Data.NoteInfo(false, 0.0f, 0.2f, "s"));
        }
    }
}
