using UnityEngine;
using System.Collections;

public class mute : MonoBehaviour {

    public GameObject music;

    public void mute_play() {
        if (this.music.GetComponent<AudioSource>().isPlaying)
            this.music.GetComponent<AudioSource>().Pause();
        else
            this.music.GetComponent<AudioSource>().Play();
    }
}
