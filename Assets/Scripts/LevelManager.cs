using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
	private Level activeLevel;

	private void Awake()
	{
		int levelIndex = PlayerPrefs.GetInt("Level", 1);
	
		activeLevel = Resources.Load("Levels/Level" + levelIndex) as Level;

		if (activeLevel == null)
		{
			levelIndex = 1;
			Debug.LogWarning("Level" + levelIndex + " is not found. First level loaded!");
			PlayerPrefs.SetInt("Level", levelIndex);
			activeLevel = Resources.Load("Levels/Level" + levelIndex) as Level;
		}

		CreateScene();
	}

	private void CreateScene()
	{
		foreach (Transform child in transform)
		{
			Destroy(child.gameObject);
		}

		GameObject level = Instantiate(activeLevel.levelPrefab, transform);
	}
}
