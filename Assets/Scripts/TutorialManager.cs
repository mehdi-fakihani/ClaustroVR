using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour {

	[SerializeField] private GameObject tutoMove;
	[SerializeField] private GameObject tutoButton;
	[SerializeField] private GameObject tutoEnd;

	private bool move = false;
	private bool button = false;

	
	// Update is called once per frame
	void Update () {
		if (move && !button) {
			tutoMove.SetActive (false);
			tutoButton.SetActive (true);
		} else if (move && button) {
			tutoButton.SetActive (false);
			tutoEnd.SetActive (true);
		}
	}
}
