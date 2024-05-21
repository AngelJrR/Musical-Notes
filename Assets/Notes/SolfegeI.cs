using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class SolfegeI : MonoBehaviour
{
    public string solfege;
    public int which;
    public NoteSounds Nsound;
    Spawn Manager;

    // Start is called before the first frame update
    void Start()
    {
        Manager = FindFirstObjectByType<Spawn>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //on instantiate/creation set what the solfege input should be
    public void setSolfege(string solfeged)
    {
        solfege = solfeged;
    }


    //checks the input of the player then returns to the NoteSounds the value so it can change color
    public void check()
    {

        string input = this.GetComponent<TMP_InputField>().text.ToString();
        // Debug.Log(solfege);
        if (input.Equals(solfege, StringComparison.InvariantCultureIgnoreCase))
        {
            Manager.setPoints(which, true);
            //Nsound.changeColor(0, which);
        }
        else
            Manager.setPoints(which, false);
            //Nsound.changeColor(1, false);


    }

    //i forgot
    public void setNsound(NoteSounds sound)
    { this.Nsound = sound; }
}
