using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBlock : MonoBehaviour {

	public float lifetime;
	// Use this for initialization
	void Start () {
		lifetime = lifetime*Time.deltaTime;
		Destroy (gameObject, lifetime);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
