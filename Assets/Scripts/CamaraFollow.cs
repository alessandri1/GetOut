using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraFollow : MonoBehaviour {



	public GameObject Player;
	private Transform target;


	// Use this for initialization
	void Start () {
	target = Player.GetComponent<Transform>();

	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = new Vector3(target.position.x,target.position.y,transform.position.z);
		
	}
}
