using UnityEngine;

public class NoteSounds : MonoBehaviour
{
    //public AudioClip clip;
    public AudioSource source;
    public string name;
    public AudioClip clip;
    public float position;

    private void Awake()
    {
        //name = GetComponent<string>();
        //e = string
        source = GetComponent<AudioSource>();
        //clip = GetComponent<AudioClip>();
        source.clip = clip;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void playSound()
    {
        source.Play();
    }

    private void OnMouseDown()
    {
        playSound();
    }

    public float getPosition()
    { return position; }



}
