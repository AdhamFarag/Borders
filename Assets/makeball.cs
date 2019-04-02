using UnityEngine;
using System.Collections;

public class makeball : MonoBehaviour {
	public GameObject player;
	public GameObject RB;
	public GameObject LB;
	public GameObject TB;
	public GameObject BB;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public IEnumerator wait(){
		yield return new WaitForSeconds (2.0f);
		Instantiate (player, TB.transform.position, player.transform.rotation);
	}
}
