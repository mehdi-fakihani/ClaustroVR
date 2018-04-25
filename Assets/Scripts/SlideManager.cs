using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideManager : MonoBehaviour {

    public Vector3 speed = new Vector3(0,0,-0.1f);

	// Use this for initialization
	void Start () {
        StartCoroutine(slideDoor());
    }
	
	// Update is called once per frame
	void Update () {
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
