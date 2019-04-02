using UnityEngine;
using System.Collections;

public class MoveLEFTRIGHT : MonoBehaviour {

	void Update () {
		Camera.main.ScreenPointToRay (Input.mousePosition);
		Vector3 mouse = Input.mousePosition;
		mouse = mouse;

		transform.position = new Vector3 (Camera.main.ScreenToWorldPoint (mouse).x, this.transform.position.y, 0);
	}
}
