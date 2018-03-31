using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour {

	public GameObject[] wayPoints;
	public GameObject testEnemyPrefab;
	// Use this for initialization
	void Start () {
		Instantiate (testEnemyPrefab).GetComponent<MoveEnemy> ().wayPoints = wayPoints;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
