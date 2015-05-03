using UnityEngine;
using System.Collections;

public class CreateNewPlayer : MonoBehaviour {
	
	private BasePlayer newPlayer;
	private string enter="";
	public UnityEngine.UI.InputField input;

	public void creatPlayer()
	{
		newPlayer = new BasePlayer ();
		enter = input.text.ToString();
		newPlayer.Name = enter;
		newPlayer.nb_level_unlock = 1;

		StoreNewPLayerInfo();
		SaveInformation.SaveAllInformation();

		Application.LoadLevel(1);
	}

	private void StoreNewPLayerInfo(){
		GameInfo.nb_level_unlock = newPlayer.nb_level_unlock;
		GameInfo.playername = newPlayer.Name;
	}
}