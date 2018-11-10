using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pictures : MonoBehaviour {
    GameObject startingscreen;
    List<GameObject> pictures;
    int curr;

   public Pictures(GameObject ss, GameObject p1, GameObject p2, GameObject p3)
    {
        pictures = new List<GameObject>();
        startingscreen = Instantiate(ss, new Vector2((float)0, (float)1.9), Quaternion.identity) as GameObject;
        pictures.Add(Instantiate(p1, new Vector2((float)0, (float)1.9), Quaternion.identity) as GameObject);
        pictures.Add(Instantiate(p2, new Vector2((float)0, (float)1.9), Quaternion.identity) as GameObject);
        pictures.Add(Instantiate(p3, new Vector2((float)0, (float)1.9), Quaternion.identity) as GameObject);
        curr = -1;
    }

    public void Open()
    {
        startingscreen.SetActive(true);
    }

    public void Play(int i)
    {
        if (curr == -1) startingscreen.SetActive(false);
        else pictures[curr].SetActive(false);
        pictures[i].SetActive(true);
        curr = i;
    }

    public void Close()
    {
        pictures[curr].SetActive(false);
    }



}
