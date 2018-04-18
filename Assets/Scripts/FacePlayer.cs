using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacePlayer : MonoBehaviour {

    GameObject player;

	// Use this for initialization
	void Awake () {
        player = GameObject.FindGameObjectWithTag("Player");
    }
	
	// Update is called once per frame
	void LateUpdate () {
        transform.rotation = Quaternion.LookRotation(-(player.transform.position - transform.position));
	}
}
