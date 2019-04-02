using UnityEngine;
using System.Collections;

public class preventrepeat1 : MonoBehaviour {
	public int bounce;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (bounce == 5) {
			Debug.Log ("ifnrnfiu");
		}
	}
	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag == "Player") {
			bounce += 1;
		}

	}
}
