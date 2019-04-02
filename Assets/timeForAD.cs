using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;

public class timeForAD : MonoBehaviour {
	public GameObject heartButton;
	public GameObject heartbuttonntext;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Advertisement.IsReady ("rewardedVideo")) {
			heartButton.SetActive (true);
			heartbuttonntext.SetActive (true);
		}
		if (!Advertisement.IsReady ("rewardedVideo")) {
			heartButton.SetActive (false);
			heartbuttonntext.SetActive (false);
		}
	}
}
