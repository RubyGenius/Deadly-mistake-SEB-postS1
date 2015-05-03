using UnityEngine;
using System.Collections;

public class locklevels : MonoBehaviour {

	public int nb_total_de_level;
	public bool cheat;
	public UnityEngine.UI.Button level1;
	public UnityEngine.UI.Button level2;
	public UnityEngine.UI.Button level3;


	public void unlock_level()
	{
		if(cheat)
			GameInfo.nb_level_unlock = nb_total_de_level;
		for (int i = 1; i <= GameInfo.nb_level_unlock; i++) {
			if(level2.name.Contains(i.ToString()))
			{
				level2.interactable = true;
				Debug.Log("LV2-> true");
			}
			if(level3.name.Contains(i.ToString()))
			{
				level3.interactable = true;
				Debug.Log("LV3-> true");
			}
		}
		for (int i = GameInfo.nb_level_unlock+1; i <= nb_total_de_level; i++) {
			if(level2.name.Contains(i.ToString()))
			{
				level2.interactable = false;
				Debug.Log("LV2-> false");
			}
			if(level3.name.Contains(i.ToString()))
			{
				level3.interactable = false;
				Debug.Log("LV3-> false");
			}
		}
		Debug.Log("UNLOCK");
	}
}