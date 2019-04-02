using UnityEngine;
using System.Collections;

public class positionBorder : MonoBehaviour {
	public Transform RightCollider;
	public GameObject RightBorder;
	public Transform LeftCollider;
	public GameObject LeftBorder;
	public Transform TopCollider;
	public GameObject TopBorder;
	public Transform BottomCollider;
	public GameObject BottomBorder;


	// Use this for initialization
	void Start () {
		RightCollider = GameObject.Find ("RightCollider").GetComponent<Transform>();
		RightBorder.transform.position = new Vector2 (RightCollider.transform.position.x - 1.1f, RightBorder.transform.position.y);
		LeftCollider = GameObject.Find ("LeftCollider").GetComponent<Transform>();
		LeftBorder.transform.position = new Vector2 (LeftCollider.transform.position.x + 1.1f, LeftBorder.transform.position.y);
		TopCollider = GameObject.Find ("TopCollider").GetComponent<Transform>();
		TopBorder.transform.position = new Vector2 (TopBorder.transform.position.x, TopCollider.transform.position.y - 1.1f);
		BottomCollider = GameObject.Find ("BottomCollider").GetComponent<Transform>();
		BottomBorder.transform.position = new Vector2 (BottomBorder.transform.position.x, BottomCollider.transform.position.y + 1.1f);

	}
	
	// Update is called once per frame
	void Update () {


	}
}
