using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerBehavior : MonoBehaviour {

	public Text nextWaveWarning;
	public Text gameWaves;

	public bool gameOver = false;
	private SpawnEnemy spawnEnemy;

	private int wave;
	private float timeInterval;

	public float TimeInterval {
		get {
			return timeInterval;
		}
		set {
			timeInterval = value;
		}
	}

	public int Wave {
		get { 
			return wave; 
		}
		set {
			wave = value;
			if (!gameOver) {
				gameWaves.text = "Wave: " + (wave + 1);
			}
			else {
				gameWaves.text = "Game Over!";
			}
		}
	}

	// Use this for initialization
	void Start () {
		spawnEnemy = GameObject.Find ("road").GetComponent<SpawnEnemy> ();
		Wave = 0;
		nextWaveWarning.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if ((spawnEnemy.timeBetweenWaves - TimeInterval <= 2.0) && (spawnEnemy.timeBetweenWaves - TimeInterval >= 1.95) && GameObject.Find ("enemy(Clone)") == null) {
			nextWaveWarning.enabled = true;
		}
		if ((GameObject.Find ("enemy(Clone)") != null) || (spawnEnemy.timeBetweenWaves - TimeInterval >= 2.0)) {
			nextWaveWarning.enabled = false;
		}
	}
}
