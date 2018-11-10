using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PowerButton : MonoBehaviour {

    GameObject lights;

    public PowerButton(GameObject l)
    {
        lights = Instantiate(l, new Vector2((float)2.5, (float)0.4), Quaternion.identity) as GameObject;
    }

    // Use this for initialization
    public void PushOn()
    {
         lights.SetActive(true);
    }

    public void PushOff()
    {
        lights.SetActive(false);
    }

}
