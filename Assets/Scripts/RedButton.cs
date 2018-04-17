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
			}
	
	    }

		private void OnCollisionExit(Collision collision)
		{
			if (collision.gameObject.tag == "Player") 
			{
				playerButtonCollision = false;
			}
		}  

        public bool IsPressed()
        {
            if (playerButtonCollision && input.HairTriggerUp())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
	}
}