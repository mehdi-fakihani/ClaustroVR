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
	public AudioSource myAudioSource;
   // private Animator doorAnimation;


	void Start()
	{
       // doorAnimation = GetComponent<Animator>();
	}
    // Update is called once per frame
    void Update()
    {
		if ("Code : " + doorCode == doorCodeTry.text || doorCode == doorCodeTry.text) 
		{
			myAudioSource.Play ();
          //  doorAnimation.SetBool("open", true);
			timer = timer + Time.deltaTime;
			blackScreen.SetActive (true);
			StartCoroutine (openDoor());
			if (timer > 5) 
			{
                if (SceneManager.GetActiveScene().name == "TutoSceneVideo")
                {
                    MoveScene("PrisonScene");
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
            transform.rotation = Quaternion.RotateTowards(transform.rotation, target, step);
            yield return new WaitForSeconds(0.01f);
        }

    }
}