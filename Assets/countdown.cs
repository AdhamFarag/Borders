using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class countdown : MonoBehaviour {
	public float times = 3;
	public Text countdowntext;
	public Score score;
	public countdown COUNTDOWNSCRIPT;
	public fireBall firebal;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	score = GameObject.FindGameObjectWithTag ("Player").GetComponent<Score> ();
		firebal = GameObject.FindGameObjectWithTag ("Player").GetComponent<fireBall> ();
		score.enabled = false;
		times -= Time.deltaTime;
		countdowntext.text = "" + Mathf.Round (times);
	         if(times <= 0){
			times = 0;
			firebal.wait ();
			score.enabled = true;
			COUNTDOWNSCRIPT.enabled = false;
		}
	}

}
