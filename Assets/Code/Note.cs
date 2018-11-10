using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Note : MonoBehaviour {

    
    GameObject nodepad;
    GameObject menu;
    GameObject choose;
    GameObject text;

    public Note(GameObject n, GameObject m, GameObject c, GameObject t)
    {
        nodepad = Instantiate(n, new Vector2((float)0, (float)1.9), Quaternion.identity) as GameObject;
        menu = Instantiate(m, new Vector2((float)0, (float)1.9), Quaternion.identity) as GameObject;
        choose = Instantiate(c, new Vector2((float)0, (float)1.9), Quaternion.identity) as GameObject;
        text = Instantiate(t, new Vector2((float)0, (float)1.9), Quaternion.identity) as GameObject;

    }

    public void OpenNote()
    {
        nodepad.SetActive(true);
    }

    public void OpenMenu()
    {
        nodepad.SetActive(false);
        choose.SetActive(true);
    }

    public void ChooseFile()
    {
        menu.SetActive(false);
        choose.SetActive(true);
    }

    public void ShowText()
    {
        choose.SetActive(false);
        text.SetActive(true);
    }
   
    public void Close()
    {
        text.SetActive(false);
    }

}
