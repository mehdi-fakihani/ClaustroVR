using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelFinalManager : MonoBehaviour {

    [SerializeField] private GameObject rightWall;
    [SerializeField] private GameObject leftWall;
    [SerializeField] private GameObject frontWall;
    [SerializeField] private GameObject backWall;
    private AudioSource audio;

	// Use this for initialization
	void Start () {
        audio = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        if (rightWall.transform.position.x >= 7.5f)
        {
            if(!audio.isPlaying) audio.Play();
            rightWall.transform.position -= new Vector3(0.3f, 0, 0) * Time.deltaTime;
            leftWall.transform.position += new Vector3(0.3f, 0, 0) * Time.deltaTime;
        }
        else if (rightWall.transform.position.x <= 7.5f && frontWall.transform.position.z >= 24f)
        {
            if (!audio.isPlaying) audio.Play();
            frontWall.transform.position -= new Vector3(0, 0, 0.3f) * Time.deltaTime;
            backWall.transform.position += new Vector3(0, 0, 0.3f) * Time.deltaTime;
        }
        else
        {
            audio.Stop();
            Game.win = true;
            SceneManager.LoadScene("WhiteRoomScene");
        }
    }
}
