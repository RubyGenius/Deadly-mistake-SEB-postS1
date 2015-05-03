using UnityEngine;
using System.Collections;

public class MenuPause : MonoBehaviour 
{
	private bool isPaused = false;
	public MouseLook scriptML;
	public Transform spawn;
	public GameObject perso;

	void Start(){
		scriptML = GetComponent<MouseLook> ();
	}

	// Use this for initialization
	void Update () 
	{


		if (Input.GetKeyDown (KeyCode.Escape))
		    isPaused = !isPaused;
			AudioListener.pause = isPaused;
		
		if (isPaused) {
			Time.timeScale = 0f;
			Cursor.visible = true;

		} 
		else {
			Time.timeScale = 1.0f;
			Cursor.visible = false;
			foreach (MouseLook scriptML in GetComponentsInChildren<MouseLook>()) 
				scriptML.enabled = true;
		}

	}
	void OnGUI()
	{
		if (isPaused) {
			foreach (MouseLook scriptML in GetComponentsInChildren<MouseLook>())
				scriptML.enabled = false;

			if (Input.GetKeyDown (KeyCode.R)) {
				perso.transform.position = spawn.position;
				isPaused = false;
				Cursor.visible = false;
				foreach (MouseLook scriptML in GetComponentsInChildren<MouseLook>()) 
					scriptML.enabled = true;
			}

			if (GUI.Button (new Rect (Screen.width / 2 - 40, Screen.height / 2 - 60, 100, 40), "Continuer")) {
				isPaused = false;
				Cursor.visible = false;
				foreach (MouseLook scriptML in GetComponentsInChildren<MouseLook>())
					scriptML.enabled = true;
			}

			if (GUI.Button (new Rect (Screen.width / 2 - 40, Screen.height / 2 - 20, 100, 40), "Recommencer")) {
				perso.transform.position = spawn.position;
				isPaused = false;
				Cursor.visible = false;
				foreach (MouseLook scriptML in GetComponentsInChildren<MouseLook>()) 
					scriptML.enabled = true;
			}


			if (GUI.Button (new Rect (Screen.width / 2 - 40, Screen.height / 2 + 20, 100, 40), "Options")) {
				isPaused = false;
				Cursor.visible = false; 
				foreach (MouseLook scriptML in GetComponentsInChildren<MouseLook>())
					scriptML.enabled = true;
			}

			if (GUI.Button (new Rect (Screen.width / 2 - 40, Screen.height / 2 + 60, 100, 40), "Quitter")) {
				Application.Quit ();
			}

		} else {
			if (Input.GetKeyDown (KeyCode.R)){
				perso.transform.position = spawn.position;
				foreach (MouseLook scriptML in GetComponentsInChildren<MouseLook>()) 
					scriptML.enabled = true;
			}
		}
	}
}
