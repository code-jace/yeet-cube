using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YeetScript : MonoBehaviour
{
    public Rigidbody rb;
    public float yeetFactor = 500f;
    bool canYeet = false;
    // Update is called once per frame
    void Update()
    {
        // check if moving, if not can yeet
        canYeet = rb.velocity.magnitude < 0.1f;            

    }

    public void FireYeet() {
        if(canYeet){
            rb.AddForce(Camera.main.transform.forward*yeetFactor);
        }
        
    }

}
