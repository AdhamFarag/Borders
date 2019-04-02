using UnityEngine;
using System.Collections;

public class unlocked : MonoBehaviour {
	public int highscore;

	public GameObject Player1;
	public GameObject Player2;
	public GameObject Player3;
	public GameObject Player4;
	public GameObject Player5;
	public GameObject Player6;
	public GameObject Player7;
	public GameObject Player8;
	public GameObject Player9;
	public GameObject Player10;
	public GameObject Player11;
	public GameObject Player12;
	public GameObject Player13;
	public GameObject Player14;
	public GameObject Player15;
	public GameObject Player16;
	public GameObject Player17;

	// Use this for initialization
	void Start () {
		highscore = PlayerPrefs.GetInt ("Highscore");
	}
	
	// Update is called once per frame
	void Update () {
	    if (highscore >= 5) {
			Player1.SetActive (true);	
		}
		if (highscore >= 10) {
			Player2.SetActive (true);	
		}   if (highscore >= 15) {
			Player3.SetActive (true);	
		}   if (highscore >= 20) {
			Player4.SetActive (true);	
		}   if (highscore >= 25) {
			Player5.SetActive (true);	
		}   if (highscore >= 30) {
			Player6.SetActive (true);	
		}   if (highscore >= 35) {
			Player7.SetActive (true);	
		}   if (highscore >= 40) {
			Player8.SetActive (true);	
		}   if (highscore >= 45) {
			Player9.SetActive (true);	
		}   if (highscore >= 50) {
			Player10.SetActive (true);	
		}   if (highscore >= 55) {
			Player11.SetActive (true);	
		}   if (highscore >= 60) {
			Player12.SetActive (true);	
		}   if (highscore >= 65) {
			Player13.SetActive (true);	
		}   if (highscore >= 70) {
			Player14.SetActive (true);	
		}   if (highscore >= 75) {
			Player15.SetActive (true);	
		}   if (highscore >= 80) {
			Player16.SetActive (true);	
		} if (highscore >= 85) {
			Player17.SetActive (true);	
		} 
	}
}
