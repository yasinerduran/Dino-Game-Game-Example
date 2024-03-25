using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class Destroy : MonoBehaviour
{
    public TextMeshProUGUI scoreUI;
    private int skor = 0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GameObject().tag == "Agaç")
        {
            Destroy(other.GameObject());
        }
        if (other.GameObject().tag == "Düşman")
        {
            Destroy(other.GameObject());
            skor += 1;
            scoreUI.text = skor.ToString();

        }
        
    }
}
