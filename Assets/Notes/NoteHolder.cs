using System.Collections.Generic;
using UnityEngine;

public class NoteHolder : MonoBehaviour
{
    // Start is called before the first frame update

    public List<GameObject> sounds = new List<GameObject>();

    void Start()
    {


    }


    // Update is called once per frame
    void Update()
    {

    }

    public Object RandomNote(float spacing, int i)
    {
        int ugh = Random.Range(0, sounds.Count);

        GameObject currentOb = Instantiate(sounds[ugh], new Vector3(-4f + spacing * i, 0, -1), transform.rotation);
        float y = currentOb.GetComponent<NoteSounds>().getPosition();
        currentOb.transform.position = new Vector3(currentOb.transform.position.x, y, -1);
        return currentOb;
    }
}
