using UnityEngine;
using System.Collections;

public class InputNavigacija : MonoBehaviour {

	// Use this for initialization

	public GameObject zoga;
	public Canvas canvas;



	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	public void PlayGumb(){
		Instantiate (zoga);
		canvas.enabled = false;

	}
}
