using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleporter : MonoBehaviour {

	public GameObject Player;
	public GameObject [] Door = new GameObject[5];

	public string sceneName;

	public void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.tag == "Player")
		{
			changeScene();
		}
	}

	void changeScene()
	{
		
	}

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
