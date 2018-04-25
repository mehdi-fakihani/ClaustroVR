using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderManager : MonoBehaviour {

	private bool isClimbing = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col) 
	{
		if (col.CompareTag("Player"))
		{
			isClimbing = true;
		}
			
	}

	void OnTriggerExit(Collider col) 
	{
		if (col.CompareTag("Player"))
		{
			isClimbing = false;
		}

	}

	public bool PlayerIsClimbing()
	{
		return isClimbing;
	}


}
