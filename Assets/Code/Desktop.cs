using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desktop : MonoBehaviour {
   
    GameObject screen;


    public Desktop( GameObject s)
    {
       screen = Instantiate(s, new Vector2((float)-0.025, (float)1.9), Quaternion.identity) as GameObject;
    }

    public void Openscreen()
    {
        screen.SetActive(true);
    }

    public void CloseScreen()
    {
        screen.SetActive(false);
    }

    

}
