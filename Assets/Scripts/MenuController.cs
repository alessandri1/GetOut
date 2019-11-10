using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("s")) SceneManager.LoadScene("Lvl1");
		if(Input.GetButtonDown("i")) SceneManager.LoadScene("Instructions");
		if(Input.GetButtonDown("c")) SceneManager.LoadScene("Credits");
		if(Input.GetButtonDown("e"))  Application.Quit();
	}
	
}
