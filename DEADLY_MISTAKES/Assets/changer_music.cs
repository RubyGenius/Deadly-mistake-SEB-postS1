using UnityEngine;
using System.Collections;

public class changer_music : MonoBehaviour {
    public void next()
    {
        GameObject cam = GameObject.Find("Main Camera");
        musique_cam.first++;
    }
}
