using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SlideManager : MonoBehaviour {

    public Vector3 speed = new Vector3(0,0,-0.1f);
	[SerializeField] private string doorCode;
	[SerializeField] private Text doorCodeTry;
	//[SerializeField] private GameObject blackScreen;
	private bool first = false;
	private float timer =0f;

	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () 
	{
		if ("Code : " + doorCode == doorCodeTry.text || doorCode == doorCodeTry.text) 
		{
			if (first == false)
			{
				StartCoroutine (slideDoor());
				first = true;
			}
		}
    }

    IEnumerator slideDoor()
    {
        while(transform.position.z > -2.0f)
        {
            transform.position += speed;
            yield return new WaitForSeconds(0.1f);
        }
    }
		
}
