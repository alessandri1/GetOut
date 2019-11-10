using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BlockManager : MonoBehaviour {
	public GameObject block;
	public GameObject blockNotFall;
	public GameObject manaBar;
	public int blockType;
	
	public float limitBlock =10f;
	public float yourBlocks;
	public float timesPerSecond=1;
	private bool charging=true;	// Use this for initialization

	//MANA SYSTEM

	public float maxMana;
	public float manaPerSecond;
	public float updateMana;
	public string manaText;
	
	

	Vector3 getMousePosition(){
		Vector3 mousePosition = Vector3.one;
		mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition + new Vector3(0,0,10f));
		return(mousePosition);
	}



	void spawner(GameObject objectName){
		GameObject.Instantiate(objectName,getMousePosition(),transform.rotation);
	}

	void change()
	{
		if(Input.GetMouseButtonDown(1))
		{
			Debug.Log("ChangeBlock");
			blockType++;
		}
		if(blockType>2)
		{
			blockType=1;
		}
	}

	void typeChooser(){
		
		if(Input.GetMouseButtonDown(0)){

		switch(blockType){
			case 1:
			if(CanIuseMana(3))
			{
				
				spawner(block);
			}else Debug.Log("se te acabo el mana papuh");

			
			break;
			case 2:
			if(CanIuseMana(2)){
				
			spawner(blockNotFall);}else Debug.Log("se te acabo el mana papuh");
			break;
		}
	}
	}


	void Start () {
		// Mana
		manaPerSecond = 1f;
		updateMana=10f;
		maxMana = 10f;
	}
	bool CanIuseMana(int manaCost){
		if(updateMana>=manaCost)
		{
			updateMana-= manaCost;
			return true;
		} 
		else{
			return false;
		}
		
		}
	
	// Update is called once per frame
	void Update () {
		//Mana
		updateMana += manaPerSecond*Time.deltaTime;
		if(updateMana>maxMana)
		{
			updateMana=10;
		}
		if(updateMana<0)
		{
			updateMana=0;
		}
		manaBar.GetComponent<Slider>().value = (updateMana/10);
//--------------------

		change();
		typeChooser();

		if(charging)
		{
			yourBlocks = timesPerSecond*Time.deltaTime;
			Mathf.Round(yourBlocks);
			
		}

		// if(timer <= 0)
		// {
		// 	timer = cooldown;

		// }
		// else
		// {
		// timer -= Time.deltaTime;
		// }
	}
}
