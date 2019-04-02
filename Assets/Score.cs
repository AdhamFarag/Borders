using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Score : MonoBehaviour {
	public int scoreNum;
	public Text ScoreText;
	public int HighScoreNum;
	public Text HighScoreText;
	public int cash;
	public AudioSource bounce;
	// Use this for initialization
	void Start () {

	HighScoreNum = PlayerPrefs.GetInt ("Highscore",0);

	}
	
	// Update is called once per frame
	void Update () {


		HighScoreText.text = "BEST:" +HighScoreNum;
		ScoreText.text = "" + scoreNum;	

	if (scoreNum > HighScoreNum) {
			PlayerPrefs.SetInt ("Highscore", scoreNum);
			HighScoreNum = scoreNum;
		
		}
	}
	public void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag == "border") {
			scoreNum += 1;
			bounce.Play ();
		
		}
	}


 
	}


