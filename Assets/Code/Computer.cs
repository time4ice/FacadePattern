using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Computer: MonoBehaviour {

    public GameObject lights;
    public GameObject loadscreen;
    public GameObject screen;

    public GameObject nodepad;
    public GameObject menu;
    public GameObject choose;
    public GameObject text;

    public GameObject chrom;
    public GameObject serf;
    public GameObject facade;

    public GameObject p1;
    public GameObject p2;
    public GameObject p3;
    public GameObject startingscreen;

    PowerButton powerbutton;
    OS os;
    Note note; 
    Pictures pictures;
    Google google;
    Desktop desktop;
    bool isOn;
    public bool operation;

    IEnumerator WaitOn()
   {
         powerbutton.PushOn();
         yield return new WaitForSeconds(3);
         os.StartOS();
         yield return new WaitForSeconds(5);
         os.FinishOS();
        print("here");
         desktop.Openscreen();
    }

    IEnumerator WaitOff()
    {
        desktop.CloseScreen();
        yield return new WaitForSeconds(0);
        os.StartOS();
        yield return new WaitForSeconds(5);
        os.FinishOS();
        yield return new WaitForSeconds(3);
        powerbutton.PushOff();
    }

    IEnumerator WaitText()
    {
        desktop.CloseScreen();
        note.OpenNote();
        yield return new WaitForSeconds(2);
        note.OpenMenu();
        yield return new WaitForSeconds(1);
        note.ChooseFile();
        yield return new WaitForSeconds(2);
        note.ShowText();
        yield return new WaitForSeconds(4);
        note.Close();
        desktop.Openscreen();
    }

     IEnumerator WaitGoogle()
    {
        desktop.CloseScreen();
        google.OpenGoogle();
        yield return new WaitForSeconds(1);
        google.SearchFacade();
        yield return new WaitForSeconds(2);
        google.OpenPage();
        yield return new WaitForSeconds(3);
        google.Close();
        desktop.Openscreen();
    }

   IEnumerator WaitPictures()
    {
        yield return new WaitForSeconds(1);
        desktop.CloseScreen();
        pictures.Open();
        yield return new WaitForSeconds(1);
        for (int i=0;i<3; i++)
        {
            pictures.Play(i);
            yield return new WaitForSeconds(3);
        }
        pictures.Close();
        desktop.Openscreen();
    }


    void Start()
    {
        powerbutton = new PowerButton(lights);
        os = new OS(loadscreen);
        note = new Note(nodepad, menu, choose, text);
        pictures = new Pictures(startingscreen, p1, p2, p3);
        google = new Google(chrom, serf, facade);
        desktop = new Desktop(screen);
        isOn = false;
        operation = false;

    }

    public void On()
    {
        if (isOn || operation) return;
        operation = true;
        StartCoroutine(WaitOn());
        isOn = true;
        operation = false;

    }

   public void Off()
    {
        if (!isOn || operation) return;
        StartCoroutine(WaitOff());
        isOn = false;
        operation = false;
    }

    public void ShowText()
    {
        if (!isOn||operation) return;
        operation = true;
        StartCoroutine(WaitText());
        operation = false;
    }

    public void WatchPictures()
    {
        if (!isOn||operation) return;
        operation = true;
        StartCoroutine(WaitPictures());
       operation = false;
    }

    public void SearchInfoAboutFacade()
    {
        if (!isOn||operation) return;
        operation = true;
        StartCoroutine(WaitGoogle());
        operation = false;
    }
}
