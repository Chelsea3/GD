using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerBehavior : MonoBehaviour {

	public Text nextWaveWarning;
	public Text gameWaves;

	public bool gameOver = false;

	private int wave;

	public int Wave {
		get { 
			return wave; 
		}
		set {
			wave = value;
			if (!gameOver) {
				nextWaveWarning.enabled = true;
				gameWaves.text = "Wave: " + (wave + 1);
			}
			else {
				gameWaves.text = "Game Over!";
			}
		}
	}

	// Use this for initialization
	void Start () {
		Wave = 0;
		nextWaveWarning.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.Find ("enemy(Clone)") != null) {
			nextWaveWarning.enabled = false;
		}
	}
}
