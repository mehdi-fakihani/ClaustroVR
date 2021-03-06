﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Valve.VR.InteractionSystem
{
	public class RedButton : MonoBehaviour
	{
		public InputTest input;
		private bool playerButtonCollision = false;
        GameObject helpUI;

        void Awake()
        {
            helpUI = transform.Find("HelpUI").gameObject;
        }

        void Update ()
		{
			if (playerButtonCollision && input.HairTriggerUp())
			{
				ChangeScene("WhiteRoomScene");
			}
		}

	    public void ChangeScene(string sceneName)
	    {
	        SceneManager.LoadScene(sceneName);
	    }

	    void OnTriggerEnter(Collider collision)
	    {
			if (collision.gameObject.tag == "Player") 
			{
				Debug.Log ("ok");
				playerButtonCollision = true;
                helpUI.SetActive(true);
			}
	
	    }

		void OnTriggerExit(Collider collision)
		{
			if (collision.gameObject.tag == "Player") 
			{
				playerButtonCollision = false;
                helpUI.SetActive(false);
			}
		}

		public bool GetCollisionButton()
		{
			return playerButtonCollision;
		}
	}
}