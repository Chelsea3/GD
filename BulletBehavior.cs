using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour {
	public float speed=10;
	public int damage;
	public GameObject target;
	public Vector3 startPosition;
	public Vector3 targetPosition;

	public float distance;
	public float startTime;

	private GameManagerBehavior gameManager;

	// Use this for initialization
	void Start () {
		startTime = Time.time;
		distance = Vector3.Distance (startPosition, targetPosition);
		GameObject gm = GameObject.Find ("GameManager");
		gameManager = gm.GetComponent<GameManagerBehavior> ();
	}
	
	// Update is called once per frame
	void Update () {
		float timeInterval = Time.time - startTime;
		gameObject.transform.position = Vector3.Lerp (startPosition, targetPosition, timeInterval * speed / distance);

		if (gameObject.transform.position.Equals (targetPosition)) {
			if (target != null) {
				Transform barTransform = target.transform.FindChild ("BarTop");
				BarTop bar = barTransform.gameObject.GetComponent<BarTop> ();
				bar.currentHealth -= Mathf.Max (damage, 0);

				if (bar.currentHealth <= 0) {
					Destroy (target);
					//gameManager.Gold += 50;
				}
			}
			Destroy (gameObject);
		}
	}
}
