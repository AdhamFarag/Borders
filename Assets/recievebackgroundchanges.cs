using UnityEngine;
using System.Collections;

public class recievebackgroundchanges : MonoBehaviour {
	public int background;
	public Camera camera;
	public Color black;
	public Color white;
	public GameObject blackballcharacter;
	public GameObject neonballcharacter;
	public swapcharacters SWAPCHAR;
	public int tut;
	public AudioSource countdown;
	// Use this for initialization
	void Start () {
		tut = PlayerPrefs.GetInt ("tutorial2");
		background = PlayerPrefs.GetInt ("background");
		if (tut == 1) {
			countdown.enabled = true;

		}
		if (background == 0) {
			camera.backgroundColor = white;
			blackballcharacter.SetActive (true);
			SWAPCHAR.enabled = false;
		}
		if (background == 1) {
			camera.backgroundColor = white;
			blackballcharacter.SetActive (true);
			SWAPCHAR.enabled = false;
		}

		if (background == 2) {
			camera.backgroundColor = black;
			neonballcharacter.SetActive (true);
			SWAPCHAR.enabled = true;
		}
	}
	
	// Update is called once per frame
	void Update () {

	}
}
