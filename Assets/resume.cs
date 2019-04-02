using UnityEngine;
using System.Collections;

public class resume : MonoBehaviour {
	public GameObject menu;
	public GameObject LB;
	public GameObject TB;
	public GameObject RB;
	public GameObject BB;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void resumee(){
		Time.timeScale =1;
		menu.SetActive (false);
		BB.SetActive (true);
		TB.SetActive (true);
		RB.SetActive (true);
		LB.SetActive (true);
	} 
}
