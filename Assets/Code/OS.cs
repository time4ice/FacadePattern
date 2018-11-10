using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OS : MonoBehaviour {
    
    GameObject loadscreen;
   


public OS(GameObject ls)
    {
        loadscreen = Instantiate(ls, new Vector2((float)0, (float)1.9), Quaternion.identity) as GameObject;
            
    }

public void StartOS()
    {
        
        loadscreen.SetActive(true);
       
    }


    public void FinishOS()
    {
       
        loadscreen.SetActive(false);
    }


 
}
