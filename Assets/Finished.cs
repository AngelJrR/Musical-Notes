using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Finished : MonoBehaviour
{
    // Start is called before the first frame update
    public Spawn manager;
    public TMP_Text text;

    

    void Start()
    {
        manager = FindFirstObjectByType<Spawn>();
        text.text = ("Your final points are: " + manager.returnPoints());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
