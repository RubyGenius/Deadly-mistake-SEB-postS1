using UnityEngine;
using System.Collections;

public class LoadInformation {
	
	public static void LoadAllInfo(){
		GameInfo.playername = PlayerPrefs.GetString("playername");
		GameInfo.nb_level_unlock = PlayerPrefs.GetInt("unlocked_level");
		Debug.Log ("INFO LOADED");
	}
}
