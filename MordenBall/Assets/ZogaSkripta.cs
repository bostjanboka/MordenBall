using UnityEngine;
using System.Collections;

public class ZogaSkripta : MonoBehaviour {

	// Use this for initialization
	Rigidbody2D rigid;
	void Start () {
		rigid = gameObject.GetComponent<Rigidbody2D> ();
		rigid.velocity = new Vector2 (10,-10);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
