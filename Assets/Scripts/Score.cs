using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int score = 0;
    public TextMeshProUGUI text;
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        score += 1;
        text.text = score.ToString();
    }
}
