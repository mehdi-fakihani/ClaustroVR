using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextModifier : MonoBehaviour {

	void Start () {
        Text text = GetComponent<Text>();
        text.text = (Game.win) ? "Merci d'avoir participé à ce test et d'être allé au bout !" : "Vous n'êtes pas allé au bout du test.\nMerci !";
	}
}
