using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoIntroManager : MonoBehaviour {

	[SerializeField] private GameObject videoPlayer;
    [SerializeField] private GameObject light;
    [SerializeField] private float pauseTime = 5;
    private VideoPlayer test;
	private float timeTest = 0;
	//public GameObject audioSour;

	// Use this for initialization
	void Start () {
		test = videoPlayer.GetComponent<VideoPlayer>();
	}
	
	// Update is called once per frame
	void Update () {
        if (!test.isPlaying)
        {
			timeTest += Time.deltaTime;
			if (timeTest > pauseTime) {
				this.gameObject.SetActive(false);
				light.SetActive(true);
				//audioSour.SetActive (true);
			}
        }
        else
        {
            light.SetActive(false);
        }
    }
}
