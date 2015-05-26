using UnityEngine;
using System.Collections;

public class ZogaSkripta : MonoBehaviour {

	// Use this for initialization
	Rigidbody2D rigid;
	Vector2 smer;
	public float hitrost=20;
	void Start () {
		smer = new Vector2 (Random.Range(-10000,10000),Random.Range(-10000,10000));
		smer = smer.normalized;
		smer = smer * hitrost;
		rigid = gameObject.GetComponent<Rigidbody2D> ();
		rigid.velocity = smer;
	}
	
	// Update is called once per frame
	void Update () {
		rigid.velocity = smer;
	}


	void OnTriggerEnter2D(Collider2D other) {
		if (other.name.Equals ("BottomCollider")) {
			smer.y = Mathf.Abs(smer.y);

		} else if (other.name.Equals ("TopCollider")) {
			smer.y = -smer.y;

		} else if (other.name.Equals ("RightCollider")) {
			smer.x = -smer.x;

		} else if (other.name.Equals ("LeftCollider")) {
			smer.x = Mathf.Abs(smer.x);

		}
	}
}
