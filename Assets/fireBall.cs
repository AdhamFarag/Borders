using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; 
public class fireBall : MonoBehaviour {
	public float power;
	public int num;
	public GameObject panelshoot;
	// Use this for initialization
	void Start () {
		num = Random.Range (1, 3);
		if (num == 3) {
			num = 2;
		}
		if (num == 1) {
			transform.Rotate (0, 0, Random.Range (10, 50));
		}
		if (num == 2) {
			transform.Rotate (0, 0, Random.Range (-50, -10));
		}
	}

	void Update () {


	}
	public void wait(){
		GetComponent<Rigidbody2D> ().AddForce (transform.up * power);
		//	GetComponent<Rigidbody2D> ().freezeRotation = true;
	
		panelshoot.SetActive (false);

	}

}
