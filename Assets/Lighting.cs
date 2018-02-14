using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lighting : MonoBehaviour
{

    public Light light;
    private float forcelight;
    private Flash flash;
    // Use this for initialization
    void Start()
    {
        forcelight = 0;
        light = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (forcelight < 1.5)
        {
            light.intensity = forcelight;
            forcelight += Time.deltaTime;
        }
        else
        {
            //flash.Blink();
        }
    }
}
