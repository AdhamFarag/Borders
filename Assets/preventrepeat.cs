using UnityEngine;
using System.Collections;

public class preventrepeat : MonoBehaviour {
	public int bounceupdown;
	public int bounceleftright;
	public Rigidbody2D rgid;
	// Use this for initialization
	void Start () {
		rgid = GameObject.FindGameObjectWithTag ("Player").GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (bounceupdown >= 10) {
			rgid.AddForce (transform.up * 1);
			}
		if (bounceleftright >= 10) {
			rgid.AddForce (transform.up *1);
			}
		if (bounceupdown >= 15) {
			bounceupdown = 0;
        }
		if (bounceleftright >= 15) {
			bounceleftright = 0;
		}
	}
	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.name == ("top")|| other.gameObject.name == ("bottom")) {
			bounceupdown += 1;
			bounceleftright = 0;
		}
	}
	void OnCollisionExit2D(Collision2D other1){
		if (other1.gameObject.name == ("right")|| other1.gameObject.name == ("left")) {
			bounceleftright  += 1;
			bounceupdown = 0;
		}

	}
}
