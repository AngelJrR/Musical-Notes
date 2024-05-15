using UnityEngine;

public class Notes : MonoBehaviour
{
    public string Notename;
    public float Notenumber;



    private void Awake()
    {
        /*
        Notename = gameObject.name;


        if (string.Compare(Notename, w) == 0)
        {
            Notenumber = 1f;
        }
        else if (string.Compare(Notename, h) == 0)
        {
            Notenumber = .5f;
        }
        else if (string.Compare(Notename, q) == 0)
        {
            Notenumber = .25f;
        }
        else
        {
            Notenumber = .0625f;
        }
        */
    }

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }

    //get the name of the note, as in Quarter note
    public string getName()
    { return Notename; }

    
    //get the value of the note, as in .25 for quarter
    public float getNumber()
    { return Notenumber; }

}
