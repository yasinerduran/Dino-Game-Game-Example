using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class animation_control : MonoBehaviour
{
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator.SetBool("Run", true);
    }

    

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Zemin")
        {
            animator.SetBool("Run", true);
            animator.SetBool("Fly", false);
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Zemin")
        {
            animator.SetBool("Run", false);
            animator.SetBool("Fly", true);
        }
    }
}
