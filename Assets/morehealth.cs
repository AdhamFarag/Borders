using UnityEngine;
using System.Collections;

public class morehealth : MonoBehaviour {
	public int second1;
	public GameObject heart;
	public GameObject LC;
	public GameObject TC;
	public GameObject RC;
	public GameObject BC;

	// Use this for initialization
	void Start () {
		heart = GameObject.Find ("heart");
		second1 = PlayerPrefs.GetInt ("secondchance");
		TC = GameObject.Find ("TopCollider");
		BC = GameObject.Find("BottomCollider");
		RC = GameObject.Find ("RightCollider");
		LC = GameObject.Find("LeftCollider");
	}
	
	// Update is called once per frame
	void Update () {

		if (second1 == 1) {
			StartCoroutine (wait ());
			heart.SetActive (true);
		
		}
		if (second1 == 0) {
		
			BC.gameObject.name = "BottomCollider";
			TC.gameObject.name= "TopCollider";
			RC.gameObject.name= "RightCollider";
			LC.gameObject.name= "LeftCollider";
			heart.SetActive (false);
		}
	}
	public IEnumerator wait(){
		yield return new WaitForSeconds (0.5f);

		BC.gameObject.name = "health1";
		TC.gameObject.name= "health1";
		RC.gameObject.name= "health1";
		LC.gameObject.name= "health1";
	}
	public void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.name == "health1") {
			second1 = 0;
			PlayerPrefs.SetInt ("secondchance", second1);
		}
	}

}
