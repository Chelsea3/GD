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

	// 1
	void OnMouseUp() 
	{
		// 2
		if (canPlaceMonster()) 
		{
			// 3
			tower = (GameObject)Instantiate(towerPrefab, transform.position, Quaternion.identity);
			print ("cannnnn");
			// 4
			//AudioSource audioSource = gameObject.GetComponent<AudioSource>();
			//audioSource.PlayOneShot(audioSource.clip); 

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
