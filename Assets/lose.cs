using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; 
using UnityEngine.Advertisements;

public class lose : MonoBehaviour {
	public GameObject lose_menu;
	public int gamesplayed;
	public GameObject LB;
	public GameObject TB;
	public GameObject RB;
	public GameObject BB;
public GameObject adbutton;
	public GameObject panelshoot;
	// Use this for initialization
	void Start(){
		gamesplayed = PlayerPrefs.GetInt ("ADnum");
	
	}
	
	// Update is called once per frame
	void Update () {

		if (gamesplayed >= 8) {
			ShowAd ();
			gamesplayed = 0;
			PlayerPrefs.SetInt ("ADnum",gamesplayed);
		}
	
	}
	public void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.name == "TopCollider" || other.gameObject.name == "BottomCollider" || other.gameObject.name == "RightCollider" || other.gameObject.name == "LeftCollider" ) {
			Time.timeScale = 0;

			lose_menu.SetActive (true);
			BB.SetActive (false);
			TB.SetActive (false);
			RB.SetActive (false);
			LB.SetActive (false);
			gamesplayed += 1;
			PlayerPrefs.SetInt ("ADnum", gamesplayed);
			adbutton.SetActive (true);
			panelshoot.SetActive (false);
		}


	}
	public void Restart(){

		SceneManager.LoadScene (0);
		Time.timeScale = 1;

	}
	public void ShowAd()
	{
		if (Advertisement.IsReady("video"))
		{
			Advertisement.Show("video");
			Debug.Log ("video AD shown");
		}
	}

}
