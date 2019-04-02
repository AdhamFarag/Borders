using UnityEngine;
using System.Collections;

public class clearplayerprefs : MonoBehaviour {

	// Use this for initialization
	void Start () {
		PlayerPrefs.DeleteAll ();
	}
	
	// Update is called once per frame
	void Update () {
	
	
	}
	public void Clear(){
		PlayerPrefs.DeleteAll ();
	}
}
