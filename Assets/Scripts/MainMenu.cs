using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.SceneManagement;
using Update = UnityEngine.PlayerLoop.Update;

public class MainMenu : MonoBehaviour
{

    public GameObject contuine_button;
    private bool is_play = false;
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(sceneName:"SampleScene");
        Time.timeScale = 1;
        is_play = true;
    }

    public void Contiune()
    {
        SceneManager.UnloadSceneAsync("MainMenu");
        Time.timeScale = 1;
    }

    private void Update()
    {
        if (SceneManager.sceneCount != 1)
        {
            contuine_button.SetActive(true);
        }
    }
}
