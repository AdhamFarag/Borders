using UnityEngine;
using System.Collections;

public class tutorial : MonoBehaviour {
	public GameObject tutorialText;
	public int tut;
	public AudioSource countdown;
	public AudioSource tinn;
	// Use this for initialization
	void Start () {
		Time.timeScale = 0;

	}
	
	// Update is called once per frame
	void Update () {
		tut = PlayerPrefs.GetInt ("tutorial2");//ADHAM if u change this string remember to change it in the recieve backgrundchanges script thanks

		if (tut == 0) {
			tutorialText.SetActive (true);
			Time.timeScale = 0;
			countdown.enabled = false;
			tinn.enabled = false;
		}
		if (tut == 1) {
			countdown.enabled = true;
			tutorialText.SetActive (false);
			tinn.enabled = true;
			Time.timeScale = 1;
		
		}
	}
	public void press(){
		tut = 1;
		PlayerPrefs.SetInt ("tutorial2", 1);
		countdown.enabled = true;

	}
}
