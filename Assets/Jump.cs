using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private Rigidbody rb;
    public TextMeshProUGUI strongUI;

    private float strong = 5f;
    public float force;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        
        strongUI.text = Mathf.RoundToInt(strong).ToString();
    }

    private void FixedUpdate()
    {
        
        if (Input.GetButton("Jump"))
        {
            if (strong > 0.1f)
            {
                rb.AddForce(transform.up*force);
                strong -= 3f*Time.deltaTime;
            }
        }
        else
        {
            if (strong<5)
            {
                strong += 1f*Time.deltaTime;
            }
        }
    }
}
