using UnityEngine;
using System.Collections;

public class InputNavigacija : MonoBehaviour {

	// Use this for initialization

	public GameObject zoga;
	public Canvas canvas;


	public static bool konecIgre;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (konecIgre) {
			konecIgre=false;
			canvas.enabled=true;
		}
	}


	public void PlayGumb(){
		Instantiate (zoga);
		canvas.enabled = false;

	}
}
