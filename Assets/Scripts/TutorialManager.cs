using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class TutorialManager : MonoBehaviour {

	[SerializeField] private GameObject tutoMove;
	[SerializeField] private GameObject tutoButton;
	[SerializeField] private GameObject tutoEnd;
    [SerializeField] private InputTest player;
    [SerializeField] private RedButton buton;

	private bool move = false;
	private bool button = false;

	
	// Update is called once per frame
	void Update () {
        if (player.isMoving())
        {
            move = true;
        }
        /*if (buton.IsPressed())
        {
            button = true;
        }*/
		if (move && !button) {
			tutoMove.SetActive (false);
			tutoButton.SetActive (true);
		} else if (move && button) {
			tutoButton.SetActive (false);
			tutoEnd.SetActive (true);
		}
	}
}
