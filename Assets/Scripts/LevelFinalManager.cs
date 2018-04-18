using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelFinalManager : MonoBehaviour {

    [SerializeField] private GameObject rightWall;
    [SerializeField] private GameObject leftWall;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(leftWall.transform.position);
        if (rightWall.transform.position.x >= 8.5f)
        {
            rightWall.transform.position -= new Vector3(0.3f, 0, 0) * Time.deltaTime;
        }
        leftWall.transform.position += new Vector3(0.3f, 0, 0) * Time.deltaTime;
    }
}
