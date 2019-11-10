using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour {

public GameObject door;

	// Use this for initialization
	void Start () {
		
	}
	public void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.tag == "Player"){
		door.GetComponent<Animator>().SetBool("Key",true);
		gameObject.GetComponent<SpriteRenderer>().enabled = false;
		gameObject.GetComponent<BoxCollider2D>().enabled = false;}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
