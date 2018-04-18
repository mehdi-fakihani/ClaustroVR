using System.Collections;
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

	    private void OnCollisionEnter(Collision collision)
	    {
			if (collision.gameObject.tag == "Player") 
			{
				playerButtonCollision = true;
                helpUI.SetActive(true);
			}
	
	    }

		private void OnCollisionExit(Collision collision)
		{
			if (collision.gameObject.tag == "Player") 
			{
				playerButtonCollision = false;
                helpUI.SetActive(false);
			}
		}  

        public bool IsPressed()
        {
            return playerButtonCollision && input.HairTriggerUp();
        }
	}
}