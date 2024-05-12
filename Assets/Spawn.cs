using System;
using System.Collections;
using TMPro;
using UnityEngine; 

public class Spawn : MonoBehaviour
{
    public ArrayList spawnList = new ArrayList();
    public GameObject QuarterNote;
    public GameObject HalfNote;
    public GameObject WholeNote;

    bool first = true;
    int topthing = 4;
    float bottomthing = 4f;
    int howmanynotes = 4;
    public GameObject holder;
    NoteHolder ScriptH;
   /* public TMP_InputField t;
    public TMP_InputField h;
    public TMP_InputField b;
    */
    GameObject[] notes = new GameObject[3];

    public int switcheroo = 0;


    private void Awake()
    {
        ScriptH = holder.GetComponent<NoteHolder>();
        notes[0] = QuarterNote;
        notes[1] = HalfNote;
        notes[2] = WholeNote;

    }

    // Start is called before the first frame update
    void Start()
    {
        easy();
        Debug.Log(spawnList.Count);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void setTop()
    {
       // topthing = Int32.Parse(t.GetComponent<TMP_InputField>().text);


    }

    public void setBottom()
    {
       // bottomthing = Int32.Parse(b.GetComponent<TMP_InputField>().text);
    }

    public void setHowMany()
    {
      //  howmanynotes = Int32.Parse(h.GetComponent<TMP_InputField>().text);
    }


    public void easy()
    {


        float weight = bottomthing;
        float left = topthing;
        float spacing = (12f / topthing);
        float upPosition;

        for (int i = 0; i < 4; i++)
        {

            GameObject newObject;
            newObject = (GameObject)ScriptH.RandomNote(spacing, i);

            spawnList.Add(newObject);

            upPosition = newObject.transform.position.y;


            int place = UnityEngine.Random.Range(0, notes.Length);
            GameObject which = notes[place];

            string valueName = which.GetComponent<Notes>().getName();
            float valueNumber = which.GetComponent<Notes>().getNumber();
            spawnList.Add(Instantiate(QuarterNote, new Vector3(-4 + spacing * i, upPosition, 0), transform.rotation));

        }


    }


    public void begin()
    {

        float value = (topthing / bottomthing);

        float weight = bottomthing;
        float left = topthing;
        float spacing = (12f / topthing);
        float upPosition;

        int iteration = 0;
        //for (int i = 0; i < left; i++)
        while (left > 0)
        {
            GameObject newObject;
            newObject = (GameObject)ScriptH.RandomNote(spacing, iteration);

            spawnList.Add(newObject);
            upPosition = newObject.transform.position.y;


            int place = UnityEngine.Random.Range(0, notes.Length);
            GameObject which = notes[place];

            string valueName = which.GetComponent<Notes>().getName();
            float valueNumber = which.GetComponent<Notes>().getNumber();


           

            if ((left - (valueNumber * weight) < 0) || ((value - valueNumber) < 0))
            {

                while ((left - (valueNumber * weight) < 0) || ((value - valueNumber) < 0))
                {
                    place = UnityEngine.Random.Range(0, notes.Length);
                    which = notes[place];
                    valueNumber = which.GetComponent<Notes>().getNumber();

                }


            }

            value -= valueNumber;
            left -= (valueNumber * weight);


            /* while (bottomthing - valueNumber <= 0)
             {
                 place = UnityEngine.Random.Range(0, notes.Length);
                 which = notes[place];
                 valueNumber = which.GetComponent<Notes>().getNumber();
             } 

             */


            spawnList.Add(Instantiate(which, new Vector3(-4 + spacing * iteration, upPosition, 0), transform.rotation));
            iteration++;
            //spawnList.Add(Instantiate(QuarterNote, new Vector3(-8 + spacing * i, position1.y + heightVariance, position1.z), transform.rotation));
        }
        /*
        float heightVariance = Random.Range(-0.5f, 1.5f);
        float heightVariance2 = Random.Range(-0.5f, 1.5f);
        float heightVariance3 = Random.Range(-0.5f, 1.5f);
        float heightVariance4 = Random.Range(-0.5f, 1.5f);



        Vector3 position1 = Spawn1.transform.position;
        Vector3 position2 = Spawn2.transform.position;
        Vector3 position3 = Spawn3.transform.position;
        Vector3 position4 = Spawn4.transform.position;


        firstN = Instantiate(Note, new Vector3(position1.x, position1.y + heightVariance, position1.z), transform.rotation);
        secondN = Instantiate(Note, new Vector3(position2.x, position2.y + heightVariance2, position2.z), transform.rotation);
        thirdN = Instantiate(Note, new Vector3(position3.x, position3.y + heightVariance3, position3.z), transform.rotation);
        fourthN = Instantiate(Note, new Vector3(position4.x, position4.y + heightVariance4, position4.z), transform.rotation);
        */
    }


    public void newthings()
    {
        for (int i = 0; i < spawnList.Count; i++)
        {
            //DestroyObject((UnityEngine.Object)spawnList[i]);
            UnityEngine.Object.Destroy((UnityEngine.Object)spawnList[i]);
        }
        //Destroy(gameObject);

        spawnList.Clear();

        if (switcheroo == 0)
            easy();
        else begin();
    }

    public void Nintendo()
    {
        if (switcheroo == 0)
            switcheroo = 1;
        else switcheroo = 0;
    }

    private IEnumerator playyy()
    {


        for(int i = 0; i < spawnList.Count; i+=2)
        {
            Debug.Log("hi");
            GameObject current = (GameObject)spawnList[i];
            Debug.Log(current);

            current.GetComponent<NoteSounds>().playSound();

            yield return new WaitForSeconds(1f);
        }

        /*
        for (int i = 0; i < spawnList.Count; i++)
        {
            //spawnList(i).GetComponent<Notes>().playSound();
            
        }
        */


    }

    public void PlayAll()
    {
        StartCoroutine(playyy());
    }
    



}
