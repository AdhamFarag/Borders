using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GenerateColliders : MonoBehaviour {
	
	public float widthOfCollider = 2f;
	public float z_axis = 0f;
	private Vector2 screenSize;
	
	void Start ()
	{

		//Create a Dictionary to hold the transforms and their names
		Dictionary<string,Transform> colliders = new Dictionary<string,Transform>();
		//Create GameObjects and add their Transform components to the Dictionary created above
		colliders.Add("Top",new GameObject().transform);
		colliders.Add("Bottom",new GameObject().transform);
		colliders.Add("Right",new GameObject().transform);
		colliders.Add("Left",new GameObject().transform);
		
		//Claculate world space screenSize based on the MainCamera position
		Vector3 cameraPos = Camera.main.transform.position;
		screenSize.x = Vector2.Distance (Camera.main.ScreenToWorldPoint(new Vector2(0,0)),Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0))) * 0.5f;
		screenSize.y = Vector2.Distance (Camera.main.ScreenToWorldPoint(new Vector2(0,0)),Camera.main.ScreenToWorldPoint(new Vector2(0, Screen.height))) * 0.5f;
		
		//loop through the transforms in colliders
		foreach(KeyValuePair<string,Transform> bc in colliders)
		{
			//Add the collider component 
			bc.Value.gameObject.AddComponent<BoxCollider2D>();
			//give the objects a name
			bc.Value.name = bc.Key + "Collider";
			//Make the object with collider child of the object this script is attached to
			bc.Value.parent = transform;
			//Scale the object to the width and height of the screen
			if(bc.Key == "Left" || bc.Key == "Right")
				bc.Value.localScale = new Vector3(widthOfCollider, screenSize.y * 2, widthOfCollider);
			else
				bc.Value.localScale = new Vector3(screenSize.x * 2, widthOfCollider, widthOfCollider);
		}
		
		//Change position of the objects to align perfectly with outer-edge of screen
		colliders["Right"].position = new Vector3(cameraPos.x + screenSize.x + (colliders["Right"].localScale.x * 0.5f), cameraPos.y, z_axis);
		colliders["Left"].position = new Vector3(cameraPos.x - screenSize.x - (colliders["Left"].localScale.x * 0.5f), cameraPos.y, z_axis);
		colliders["Top"].position = new Vector3(cameraPos.x, cameraPos.y + screenSize.y + (colliders["Top"].localScale.y * 0.5f), z_axis);
		colliders["Bottom"].position = new Vector3(cameraPos.x, cameraPos.y - screenSize.y - (colliders["Bottom"].localScale.y * 0.5f), z_axis);
	}
}
