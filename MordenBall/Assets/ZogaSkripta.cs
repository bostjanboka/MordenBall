using UnityEngine;
using System.Collections;

public class ZogaSkripta : MonoBehaviour {

	// Use this for initialization
	Rigidbody2D rigid;
	SpriteRenderer sprite;
	Vector2 smer;
	public float hitrost=20;
	public float bledenje=15;
	float solid;
	void Start () {
		solid = 100;
		smer = new Vector2 (Random.Range(-10000,10000),Random.Range(-10000,10000));
		smer = smer.normalized;
		smer = smer * hitrost;
		rigid = gameObject.GetComponent<Rigidbody2D> ();
		sprite = gameObject.GetComponent<SpriteRenderer> ();
		rigid.velocity = smer;
	}
	
	// Update is called once per frame
	void Update () {
		rigid.velocity = smer;
		Color c = sprite.color;
		c.a -= (bledenje / 100) * Time.deltaTime;
		sprite.color = c;

		foreach (Touch touch in Input.touches) {
			
			Vector2 mousePosition = Camera.main.ScreenToWorldPoint (touch.position);
			Collider2D hitCollider = Physics2D.OverlapPoint (mousePosition);
			if (hitCollider.transform.tag.Equals ("zoga")) {
				c.a = 1;
				sprite.color = c;
			}
		}




		if (sprite.color.a < 0.01) {
			InputNavigacija.konecIgre=true;
			Destroy(gameObject);
		}
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
