using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DoorManager : MonoBehaviour
{
    [SerializeField] private float doorSpeed = 100f;
	[SerializeField] private string doorCode;
	[SerializeField] private Text doorCodeTry;
	[SerializeField] private GameObject blackScreen;
	private float timer = 0f;
	private AudioSource audio;
    private Animator doorAnimation;
	private bool first = false;


	void Start()
	{
        doorAnimation = GetComponent<Animator>();
		audio = GetComponent<AudioSource>();
	}
    // Update is called once per frame
    void Update()
    {
		if ("Code : " + doorCode == doorCodeTry.text || doorCode == doorCodeTry.text) 
		{
			if (first == false && doorAnimation != null)
			{
				audio.Play();
	            doorAnimation.SetBool("open", true);
				first = true;
			}
			else if (first == false && doorAnimation == null)
			{
				audio.Play();
				StartCoroutine (openDoor());
				first = true;
			}
			timer = timer + Time.deltaTime;
			blackScreen.SetActive (true);
			//StartCoroutine (openDoor());
			if (timer > 5) 
			{
                if (SceneManager.GetActiveScene().name == "TutoSceneVideo")
                {
                    MoveScene("PrisonScene");
                }
				else if (SceneManager.GetActiveScene().name == "PrisonScene")
					{
						MoveScene("CellarScene");
					}
			}
		}
    }

    void MoveScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    IEnumerator openDoor()
    {
        float step = doorSpeed * Time.deltaTime;
        Quaternion target = Quaternion.Euler(0, 90, 0);
        while (transform.rotation != target)
        {
			//Debug.Log (transform.rotation);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, target, step);
            yield return new WaitForSeconds(0.01f);
        }
    }
}