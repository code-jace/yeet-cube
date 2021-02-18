using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YeetScript : MonoBehaviour
{
    public Rigidbody rb;
    public float yeetFactor = 500f;
    // Update is called once per frame
    void Update()
    {
        // check if moving, if not can yeet
        if(rb.velocity.magnitude < 0.1f) {
            if(Input.GetMouseButtonDown(1)){
                // yeet
                rb.AddForce(Camera.main.transform.forward*yeetFactor);
            }
        }

    }

}
