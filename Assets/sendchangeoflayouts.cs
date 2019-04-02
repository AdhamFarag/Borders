using UnityEngine;
using System.Collections;

public class sendchangeoflayouts : MonoBehaviour {
	public int background;
	public Color white;
	public Color black;
	public Camera camera;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		background = PlayerPrefs.GetInt ("background");
		if (background == 0) {
			camera.backgroundColor = white;

		}
		if (background == 1) {
			camera.backgroundColor = white;
	
		}

		if (background == 2) {
			camera.backgroundColor = black;
		
		}
	
	}
	public void blackball(){
		background = 1;
		PlayerPrefs.SetInt ("background",background);
		camera.backgroundColor = white;
	}
	public void neonball(){
		background = 2;
		PlayerPrefs.SetInt ("background",background);
		camera.backgroundColor = black;
	}
}
