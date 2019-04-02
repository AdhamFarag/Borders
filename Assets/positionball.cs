using UnityEngine;
using System.Collections;

public class positionball : MonoBehaviour {
	public GameObject ball;
	public Transform BottomCollider;
	// Use this for initialization
	void Start () {
		StartCoroutine (wait ());

	}
	
	// Update is called once per frame
	void Update () {
		ball = GameObject.FindGameObjectWithTag ("Player");
		BottomCollider = GameObject.Find ("BottomCollider").GetComponent<Transform>();
		ball.transform.position = new Vector2 (BottomCollider.transform.position.x, BottomCollider.transform.position.y + 2f);
	}
	public IEnumerator wait(){
		yield return new WaitForSeconds (0.5f);
		this.enabled = false;
	}
}
