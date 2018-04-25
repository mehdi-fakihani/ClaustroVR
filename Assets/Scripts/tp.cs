using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class tp : MonoBehaviour {

	[SerializeField] private string doorCode;
	[SerializeField] private Text doorCodeTry;
	//[SerializeField] private GameObject blackScreen;
	private float timer = 0f;
	private bool first = false;


	void Start()
	{
	}
	// Update is called once per frame
	void Update()
	{
		if ("Code : " + doorCode == doorCodeTry.text || doorCode == doorCodeTry.text) 
		{

			timer = timer + Time.deltaTime;
			//blackScreen.SetActive (true);
			if (timer > 5) 
			{
				MoveScene("LevelFinal");
			}
		}
	}

	void MoveScene(string scene)
	{
		SceneManager.LoadScene(scene);
	}
}
