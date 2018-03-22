using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorManager : MonoBehaviour
{
    [SerializeField] private float doorSpeed = 100f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            StartCoroutine(openDoor());
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
        ScreenFader screenFader = GameObject.FindObjectOfType<ScreenFader>();
        screenFader.EndScene();
    }
}