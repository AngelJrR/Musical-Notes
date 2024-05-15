using Unity.VisualScripting;
using UnityEngine;

public class NoteSounds : MonoBehaviour
{
    //public AudioClip clip;
    public AudioSource source;
    //public string name;
    public AudioClip clip;
    public float position;
    public string solfegeO;
    public SpriteRenderer triangle;
    public Spawn Manager;

    private void Awake()
    {
        //name = GetComponent<string>();
        //e = string
        source = GetComponent<AudioSource>();
        //clip = GetComponent<AudioClip>();
        source.clip = clip;
        //triangle = GetComponent<SpriteRenderer>();
        Manager = FindFirstObjectByType<Spawn>();
            //GetComponent<Spawn>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    //play sound after the player clicks on the triangle
    public void playSound()
    {
        source.PlayOneShot(clip, 2f);
    }

    private void OnMouseDown()
    {
        playSound();
    }

    //returns the position as in height position for the note, like -1.5 to represent an f key
    public float getPosition()
    { return position; }

    //get the solfege from the note, for ease. So F is Do
    public string getSolfegeO()
    { return solfegeO; }


    //actually changes the color of the triangle, based on whether the players input
    public void changeColor(int Gameboy, int which)
    {
        if (Gameboy == 1)
        {
            triangle.color = new Color(1, 0, 0);
            Manager.setPoints(which, false);
        }
        else
        {
            triangle.color = new Color(0, 1, 0);
            Manager.setPoints(which, true);
        }
    }
   
    //returns the triangle to change color
    public SpriteRenderer returnTriangle () 
    { return triangle; }    

}
