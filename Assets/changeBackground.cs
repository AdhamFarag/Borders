using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class changeBackground : MonoBehaviour {
	public Score score;
	public Camera camera;
	public Color red;
	public Color blue;
	public Color purple;
	public Color yellow;
	public Color green;
	public Color orange;
	public Color pink;
	public Color c1;
	public Color c2;
	public Color c3;
	public int target;
	public int colornum;
	public int background;
	public Text extralifetext;
	public Text best;
	public Color black;
	public Color white;
	public AudioSource tinn;
	void Start () {
		target = 0;
		background = PlayerPrefs.GetInt ("background");

	}
	
	// Update is called once per frame
	void Update () {
		score = GameObject.FindGameObjectWithTag ("Player").GetComponent<Score> ();
		//best = GameObject.Find("BEST").GetComponent<Text> ();
		//extralifetext = GameObject.Find("extra life text").GetComponent<Text> ();
		if (background == 0) {
			best.color = black;
			extralifetext.color = black;
		}
		if (background == 1) {
			best.color = black;
			extralifetext.color = black;
		}
		if (background == 2) {
			best.color = white;
			extralifetext.color = white;
		}
		if (score.scoreNum == target) {
			target += 10;
			tinn.Play ();
			colornum = Random.Range (1, 11);
		}
			
		if (score.scoreNum >= 10) {
			if (colornum == 1) {
				camera.backgroundColor = red;
            }
			if (colornum == 2) {
				camera.backgroundColor = blue;	 
			}
			if (colornum == 3) {
				camera.backgroundColor = purple;
			}
			if (colornum == 4) {
				camera.backgroundColor = yellow;	 
			}
			if (colornum == 5) {
				camera.backgroundColor = green;
			}
			if (colornum == 6) {
				camera.backgroundColor = orange;
			}
			if (colornum == 7) {
				camera.backgroundColor = pink;	 
			}
			if (colornum == 8) {
				camera.backgroundColor = c1;	 
			}
			if (colornum == 9) {
				camera.backgroundColor = c2;
		}
			if (colornum == 10) {
				camera.backgroundColor = c3;
		}
		}
	}

}
