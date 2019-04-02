using UnityEngine;
using System.Collections;

public class paause : MonoBehaviour {
	public GameObject Menu;
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
	public void Pause(){
		Time.timeScale = 0;
		Menu.SetActive (true);
		BB.SetActive (false);
		TB.SetActive (false);
		RB.SetActive (false);
		LB.SetActive (false);
	} 
}

