using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStartScript : MonoBehaviour {

	void Start() 
	{
	}

	void OnGUI()
	{
		if(GUI.Button(new Rect(Screen.width / 2 - 60, 450, 100, 40), "NEW GAME"))
		{
			SceneManager.LoadSceneAsync(0, LoadSceneMode.Single);
		}
	}
}