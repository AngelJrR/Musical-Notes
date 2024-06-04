using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class roundstuff : MonoBehaviour
{

    public TMP_Dropdown dropdown;
    int rounds = 5;

    private void Awake()
    {
        DontDestroyOnLoad(this);

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeRounds()
    {
       // dropdown = GetComponent<Dropdown>();
        if(dropdown.value == 0) 
        { rounds = 5; }
        else if(dropdown.value == 1) {  rounds = 10; }
        else {rounds = 20; }

    }


    public int getRounds()
    {  return rounds; }
}
