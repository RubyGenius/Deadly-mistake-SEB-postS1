using UnityEngine;
using System.Collections;

public class changemenu : MonoBehaviour {
    public GameObject prec;
    public GameObject suiv;

	public void change(){
        this.prec.SetActive(false);
        this.suiv.SetActive(true);
	}
}