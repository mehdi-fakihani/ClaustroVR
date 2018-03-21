using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RedButton : MonoBehaviour
{
    private bool playerButton = false;

    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerButton = true;
            ChangeScene("WhiteRoomScene");
        }
    }

    public bool GetPlayerButton()
    {
        return playerButton;
    }

    
}