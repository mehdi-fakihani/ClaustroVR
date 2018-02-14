using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerManager : MonoBehaviour {

    private SteamVR_TrackedController device;

    void Start()
    {

        device = GetComponent<SteamVR_TrackedController>();

        device.TriggerClicked += Trigger;

    }

    void Trigger(object sender, ClickedEventArgs e)

    {

        Debug.Log("Trigger has been pressed");

    }
}
