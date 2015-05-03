using UnityEngine;
using System.Collections;

public class SaveInformation {

	public static void SaveAllInformation(){
		PlayerPrefs.SetInt("unlocked_level", GameInfo.nb_level_unlock);
		PlayerPrefs.SetString("playername",GameInfo.playername);
		Debug.Log("INFO SAVED");
	}
}
