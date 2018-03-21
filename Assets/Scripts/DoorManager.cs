using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{

    private static float doorAngularSpeed = 10;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            StartCoroutine(openDoor());
    }

    IEnumerator openDoor()
    {
        float step = doorAngularSpeed * Time.deltaTime;
        Quaternion target = Quaternion.Euler(0, 90, 0);
        while (transform.rotation != target)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, target, step);
            yield return new WaitForSeconds(0.01f);
        }
    }
}