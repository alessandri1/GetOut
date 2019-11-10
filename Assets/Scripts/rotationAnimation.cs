using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationAnimation : MonoBehaviour {

	// Use this for initialization
		public int speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	 void Update () {
 	 transform.Rotate(Vector3.up, speed * Time.deltaTime);
	 }
}
