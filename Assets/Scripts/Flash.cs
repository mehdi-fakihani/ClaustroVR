using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flash : MonoBehaviour {

    public Light light;
    public float blinkingTime = 0.5f;
    public float offTime = 0.5f;
    private float timeOn;
    private float timeOff;
    private bool on = false;
    private bool off = false;

    void Start()
    {
        timeOn = 0.0f;
        timeOff = 0.0f;
        light = GetComponent<Light>();
    }

    void Update()
    {
        Blink();
    }

    public void Blink()
    {
        if (timeOn < blinkingTime)
        {
            light.intensity = 1;
            timeOn += Time.deltaTime;
            Debug.Log(timeOn);
        }

        else
        {
            on = true;
            if (timeOff < offTime)
            {
                light.intensity = 0;
                timeOff += Time.deltaTime;
            }
            else
            {
                off = true;
            }
        }

        if (on == true && off == true)
        {
            timeOn = 0.0f;
            timeOff = 0.0f;
            on = false;
            off = false;
        }
    }

 
}
