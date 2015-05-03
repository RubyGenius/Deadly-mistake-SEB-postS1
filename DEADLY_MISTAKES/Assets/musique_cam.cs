using UnityEngine;
using System.Collections;

public class musique_cam : MonoBehaviour {
    
    static public int first;
    private int last;
    public UnityEngine.UI.Slider slider;
    public GameObject cam;
    public AudioClip music1;
    public AudioClip music2;

    public void Start(){
        play(first);
        cam.GetComponent<AudioSource>().volume = slider.value;
        last = first;
    }
    void Update() {
        if (first != last)
        {
            play(first);
            last = first;
        }
        cam.GetComponent<AudioSource>().volume = slider.value;
    }
    public void play(int nb)
    {
        AudioClip[] playlist = new AudioClip[] { music1, music2 };
        cam.GetComponent<AudioSource>().clip = playlist[nb%2];
        cam.GetComponent<AudioSource>().Play();
    }
       
}
