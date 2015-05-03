using UnityEngine;
using System.Collections;

public class fenetre : MonoBehaviour {

	public static bool is_fullscreen = Screen.fullScreen;

	 void Start()
	{
		is_fullscreen = Screen.fullScreen;
	}
	public void change_windowed()
	{
		is_fullscreen = !is_fullscreen;
		Screen.fullScreen = is_fullscreen;
	}
}