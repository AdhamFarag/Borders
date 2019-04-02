using UnityEngine;
using System.Collections;

public class swapcharacters : MonoBehaviour {
	public int charnum;
	public GameObject player;
	public Sprite red;
	public Sprite blue;
	public Sprite green;
	public Sprite redB;
	public Sprite blueB;
	public Sprite greenB;
	public GameObject BB;
	public GameObject LB;
	public GameObject RB;
	public GameObject TB;
	public int background;
	// Use this for initialization
	void Start () {
		background = PlayerPrefs.GetInt ("background");
		if (background == 2) {
			charnum = Random.Range (1, 4);

			if (charnum == 1) {
				player.GetComponent<SpriteRenderer> ().sprite = red;
				BB.GetComponent<SpriteRenderer> ().sprite = redB;
				LB.GetComponent<SpriteRenderer> ().sprite = redB;
				RB.GetComponent<SpriteRenderer> ().sprite = redB;
				TB.GetComponent<SpriteRenderer> ().sprite = redB;
			}
			if (charnum == 2) {
				player.GetComponent<SpriteRenderer> ().sprite = blue;
				BB.GetComponent<SpriteRenderer> ().sprite = blueB;
				LB.GetComponent<SpriteRenderer> ().sprite = blueB;
				RB.GetComponent<SpriteRenderer> ().sprite = blueB;
				TB.GetComponent<SpriteRenderer> ().sprite = blueB;
		
			}
			if (charnum == 3) {
				player.GetComponent<SpriteRenderer> ().sprite = green;
				BB.GetComponent<SpriteRenderer> ().sprite = greenB;
				LB.GetComponent<SpriteRenderer> ().sprite = greenB;
				RB.GetComponent<SpriteRenderer> ().sprite = greenB;
				TB.GetComponent<SpriteRenderer> ().sprite = greenB;
			}

	
		}
		if (background == 1) {
		
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
