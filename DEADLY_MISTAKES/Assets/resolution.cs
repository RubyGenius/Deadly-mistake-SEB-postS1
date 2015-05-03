using UnityEngine;
using System.Collections;

public class resolution : MonoBehaviour {
	public int w;
	public int h;

	public void change_resol()
	{
		Screen.SetResolution (w, h, fenetre.is_fullscreen);
	}
}