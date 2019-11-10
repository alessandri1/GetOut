using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {
public string tittle;
	// Use this for initialization

	public void OnTriggerEnter2D(Collider2D other){
		if(tittle=="GameoverMoses")
		gameObject.GetComponent<AudioSource>().Play();
		Invoke("change",2);
		
	}
	void change(){
	SceneManager.LoadScene(tittle);

	}
	// Update is called once per frame
	
}
