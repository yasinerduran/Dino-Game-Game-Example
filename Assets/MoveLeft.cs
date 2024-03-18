using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private Rigidbody rb;

    public float speed = 3;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 newpos = new Vector3(transform.position.x-1,transform.position.y,transform.position.z);
        rb.MovePosition(Vector3.Lerp(rb.position,newpos,speed*Time.deltaTime));
    }
}
