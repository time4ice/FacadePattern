using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Google : MonoBehaviour {

    GameObject chrom;
    GameObject serf;
    GameObject facade;
    

    public Google(GameObject c, GameObject s, GameObject f)
    {
        chrom = Instantiate(c, new Vector2((float)0, (float)1.9), Quaternion.identity) as GameObject;
        serf = Instantiate(s, new Vector2((float)0, (float)1.9), Quaternion.identity) as GameObject;
        facade = Instantiate(f, new Vector2((float)0, (float)1.9), Quaternion.identity) as GameObject;
        
    }

    public void OpenGoogle()
    {
        chrom.SetActive(true);
    }

    public void SearchFacade()
    {
        chrom.SetActive(false);
        serf.SetActive(true);
    }

    public void OpenPage()
    {
        serf.SetActive(false);
        facade.SetActive(true);
    }

   
    public void Close()
    {
        facade.SetActive(false);
    }
}
