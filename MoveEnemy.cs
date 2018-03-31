using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour {

	//[HideInInspector]
	public GameObject [] wayPoints;
	private int currentWayPoint=0;
	private float lastWayPointSwitchTime;
	public float speed = 2.0f;

	// Use this for initialization
	void Start () {
		lastWayPointSwitchTime = Time.time;
	}
	
	// Update is called once per frame
	void Update ()
	{
		Vector3 startPosition = wayPoints [currentWayPoint].transform.position;
		Vector3 endPosition = wayPoints [currentWayPoint + 1].transform.position;

		float pathLength = Vector3.Distance (startPosition, endPosition);
		float timeForPath = pathLength / speed;
		float timeOnPath = Time.time - lastWayPointSwitchTime;

		gameObject.transform.position = Vector3.Lerp (startPosition, endPosition, timeOnPath / timeForPath);

		if (gameObject.transform.position.Equals (endPosition)) {
			if (currentWayPoint < wayPoints.Length - 2) {
				currentWayPoint++;
				lastWayPointSwitchTime = Time.time;
			}
			else {
				Destroy (gameObject);
			}
		}
	}
}
