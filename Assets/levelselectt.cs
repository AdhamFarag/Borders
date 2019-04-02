using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; 

public class levelselectt : MonoBehaviour {
	public int levelNum;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	
	}
	public void levelselect(){
		SceneManager.LoadScene (levelNum);
		Time.timeScale = 1;
	
	}

}
