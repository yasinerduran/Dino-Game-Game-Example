using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class detect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Transform gameoverUI;

    private void OnCollisionEnter(Collision nesne)
    {
       
        if (nesne.gameObject.tag=="Düşman")
        {
            Debug.Log("Öldük!");
            Time.timeScale = 0f;
            gameoverUI.gameObject.SetActive(true);
            //GetComponent<GameOver>().gameOver = true;
            //StartCoroutine(WaitAndLoad());

        }

    }

    IEnumerator WaitAndLoad()
    {
        // 2 saniye bekler
        yield return new WaitForSeconds(2);
        SceneManager.LoadSceneAsync("MainMenu");
    }
    

}
