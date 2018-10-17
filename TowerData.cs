using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;

[System.Serializable]  
public class TowerLevel
{
	public int cost; 
	public GameObject visualization;
	public GameObject bullet;
	public float fireRate;
}

public class TowerData : MonoBehaviour {

	public List<TowerLevel> levels;
	private TowerLevel currentLevel;

	public TowerLevel CurrentLevel 
	{
		get { return currentLevel; }

		set 
		{
			currentLevel = value;
			int currentLevelIndex = levels.IndexOf(currentLevel);

			GameObject levelVisualization = levels[currentLevelIndex].visualization;
			for (int i = 0; i < levels.Count; i++)
			{
				if (levelVisualization != null)
				{
					if (i == currentLevelIndex)
					{
						levels[i].visualization.SetActive(true);
					}
					else 
					{
						levels[i].visualization.SetActive(false);
					}
				}
			}
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
