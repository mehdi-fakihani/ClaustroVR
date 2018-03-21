using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextManager : MonoBehaviour {



    [SerializeField] private GameObject textButton;
    [SerializeField] private GameObject textKey;
    [SerializeField] private GameObject GLText;
    private float time = 0;
    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update ()
    {
        time = time + Time.deltaTime;
        if (time > 10)
        {
            textKey.SetActive(false);
            textButton.SetActive(true);
        }
        if (time > 20)
        {
            textButton.SetActive(false);
            GLText.SetActive(true);
        }
        if(time > 30)
        {
            GLText.SetActive(false);
        }
	}


}
