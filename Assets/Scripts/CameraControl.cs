using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {


	public GameObject Player;
	private Transform target;



	void Start () {
	target = Player.GetComponent<Transform>();

	}
	

	void Update () {
		if ((target.position.x > -30) && (target.position.x < 30)){

			transform.position = new Vector3(0,transform.position.y,transform.position.z);

		} else if ((target.position.x > 30) && (target.position.x < 90)){

			transform.position = new Vector3(60,transform.position.y,transform.position.z);

		} else if ((target.position.x > 90) && (target.position.x < 150)){

			transform.position = new Vector3(120,transform.position.y,transform.position.z);

		}else if ((target.position.x > 150) && (target.position.x < 210)){

			transform.position = new Vector3(180,transform.position.y,transform.position.z);

		}else if ((target.position.x > 210) && (target.position.x < 270)){

			transform.position = new Vector3(240,transform.position.y,transform.position.z);

		}else if ((target.position.x > 270) && (target.position.x < 330))
		

			transform.position = new Vector3(300,transform.position.y,transform.position.z);
			
		}
		
		
	}

