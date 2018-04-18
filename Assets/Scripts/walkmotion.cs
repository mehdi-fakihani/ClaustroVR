using UnityEngine;
using System.Collections;
//using UnityStandardAssets.ImageEffects;

public class walkmotion : MonoBehaviour {

	Camera headsetCamera;
	//BlurOptimized cameraBlur;
	Transform cameraRig;

	Vector3 lastHeadRot;

	bool freezeYCameraRotation = false;

	// Use this for initialization
	void Start() {
		headsetCamera = GameObject.FindObjectOfType<SteamVR_Camera>().GetComponent<Transform>().GetComponent<Camera>();
		//cameraBlur = GameObject.FindObjectOfType<SteamVR_Camera>().GetComponent<Transform>().GetComponent<BlurOptimized>();

		cameraRig = GameObject.FindObjectOfType<SteamVR_ControllerManager>().GetComponent<Transform>();

		/*if (cameraBlur == null)
		{
			Debug.LogError("Cannot find BlurOptimized script on SteamVR_Camera object");
			return;
		}*/

		if (headsetCamera == null)
		{
			Debug.LogError("Cannot find SteamVR_Camera");
			return;
		}

		var trackedController = GetComponent<SteamVR_TrackedController>();
		if (trackedController == null)
		{
			trackedController = gameObject.AddComponent<SteamVR_TrackedController>();
		}

		trackedController.PadClicked += new ClickedEventHandler(BlurAndFreezeCamera);
		trackedController.PadUnclicked += new ClickedEventHandler(UnblurAndDefreezeCamera);



		//cameraBlur.enabled = false;
	}

	void BlurAndFreezeCamera(object sender, ClickedEventArgs e)
	{
		Valve.VR.OpenVR.Chaperone.ForceBoundsVisible(true);

		/*cameraBlur.enabled = true;
		cameraBlur.downsample = 2;
		cameraBlur.blurSize = 3.5f;
		cameraBlur.blurIterations = 3;*/

		lastHeadRot = headsetCamera.transform.eulerAngles;

		freezeYCameraRotation = true;
		SteamVR_Fade.Start(new Color(0f,0f,0f,0.92f),0.5f);
	}

	void LateUpdate()
	{
		if(freezeYCameraRotation)
		{
			cameraRig.transform.RotateAround(headsetCamera.transform.position,Vector3.up,-(headsetCamera.transform.eulerAngles.y - lastHeadRot.y));
			lastHeadRot = headsetCamera.transform.eulerAngles;
		}


	}

	void UnblurAndDefreezeCamera(object sender, ClickedEventArgs e)
	{
		//cameraBlur.enabled = false;
		SteamVR_Fade.Start(new Color(0f, 0f, 0f, 0f), 0.5f);

		freezeYCameraRotation = false;
		Valve.VR.OpenVR.Chaperone.ForceBoundsVisible(false);
	}
}
