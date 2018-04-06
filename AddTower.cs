using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddTower : MonoBehaviour {

	public GameObject towerPrefab;
	private GameObject tower;

	private bool canPlaceMonster() { 
		print ("innnnn");
		return tower == null;
	}

	void OnMouseUp() 
	{
		if (canPlaceMonster()) 
		{
			tower = (GameObject)Instantiate(towerPrefab, transform.position, Quaternion.identity);
			print ("cannnnn");
			
			// todo: Deduct gold
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
