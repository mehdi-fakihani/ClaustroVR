using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;
using UnityEngine.SceneManagement;

namespace Valve.VR.InteractionSystem
{
	public class InputTest : MonoBehaviour {

		[SerializeField] private Transform rig;
		private SteamVR_TrackedObject trackedObj;
		private SteamVR_Controller.Device controller { get { return SteamVR_Controller.Input ((int)trackedObj.index); } } // the controller property of the hand
		private Player player = null;
		private  Valve.VR.EVRButtonId touchpad = Valve.VR.EVRButtonId.k_EButton_SteamVR_Touchpad;
		private Vector2 axis = Vector2.zero;
		[SerializeField] private RedButton button;
		


		void Start ()
		{
			player = InteractionSystem.Player.instance;
			trackedObj = GetComponent<SteamVR_TrackedObject> ();
		}

		void Update ()
		{
			var device = SteamVR_Controller.Input ((int)trackedObj.index);
			if (controller.GetTouch(touchpad)) 
			{
				axis = device.GetAxis (Valve.VR.EVRButtonId.k_EButton_Axis0);
				if (rig != null) 
				{
					rig.position += (transform.right * axis.x + transform.forward * axis.y) * Time.deltaTime;
					rig.position = new Vector3 (rig.position.x, 1f, rig.position.z);
				}
			}
			if (button.GetCollisionButton() && controller.GetHairTrigger())
			{
				ChangeScene("WhiteRoomScene");
			}
		}

        public bool isMoving()
        {
            if ( controller.GetTouch(touchpad))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
		
			public bool HairTriggerUp()
			{
				if (controller.GetHairTrigger ()) 
				{
					return true;
				}

				else
				{
					return false;
				}
			}
		public void ChangeScene(string sceneName)
		{
			SceneManager.LoadScene(sceneName);
		}

	}
}
		
	
