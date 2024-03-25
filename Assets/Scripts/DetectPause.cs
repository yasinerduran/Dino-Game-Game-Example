using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DetectPause : MonoBehaviour
{
    public bool menu = false;
    private void Update()
    {
        if (Input.GetButton("Cancel"))
        {
            if (menu!=true && !GetComponent<GameOver>().gameOver)
            {
                Time.timeScale = 0;
                SceneManager.LoadSceneAsync("MainMenu", LoadSceneMode.Additive);
                menu = true;
            }
        }

        if (Time.timeScale != 0)
        {
            menu = false;
        }
    }
}
