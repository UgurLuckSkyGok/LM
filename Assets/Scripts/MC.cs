using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MC : MonoBehaviour
{
	[SerializeField] private Text levelText;

	private void Start()
	{
		levelText.text = "Level :" + PlayerPrefs.GetInt("Level", 1);
	}
	public void NextLevel()
	{
		int levelndex = PlayerPrefs.GetInt("Level", 1);
		levelndex++;
		PlayerPrefs.SetInt("Level", levelndex);
		SceneManager.LoadScene("Main");
	}
}
