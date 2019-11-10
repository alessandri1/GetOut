using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleporter2 : MonoBehaviour {

	public GameObject Prota;
	[SerializeField]
	public GameObject[] Door = new GameObject[6];
	public GameObject key;
	private int doorNumber=1;
	
	public void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.tag == "Player")
		{
			doorNumber++;
			changeRoom();
			GetComponent<Animator>().SetBool("Key",false);
			key.GetComponent<SpriteRenderer>().enabled = true;
			key.GetComponent<BoxCollider2D>().enabled = true;
		}
	}



	void changeRoom()
	{
		Prota.transform.position = new Vector2 (Door[doorNumber].transform.position.x,
												Door[doorNumber].transform.position.y);
		
	}

}
