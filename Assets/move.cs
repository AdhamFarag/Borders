using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
	public RaycastHit2D ahead;
     void Update () {
		Camera.main.ScreenPointToRay (Input.mousePosition);
		Vector3 mouse = Input.mousePosition;


		transform.position = new Vector3 (this.transform.position.x, Camera.main.ScreenToWorldPoint (mouse).y, 0);
	}
}
