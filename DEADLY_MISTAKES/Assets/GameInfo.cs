using UnityEngine;
using System.Collections;

public class GameInfo : MonoBehaviour {

	void Awake(){
		DontDestroyOnLoad(gameObject);
	}
	public static string playername;
	public static int nb_level_unlock;
}
