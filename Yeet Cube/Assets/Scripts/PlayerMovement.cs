using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float moveForce = 1000;

    // Start is called before the first frame update
    void Start()
    {

    }

// Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey("w")){
            rb.AddForce(0, 0, moveForce*Time.deltaTime);
        }
        if(Input.GetKey("s")){
            rb.AddForce(0, 0, -1*moveForce*Time.deltaTime);
        }
        if(Input.GetKey("a")){
            rb.AddForce(-moveForce*Time.deltaTime, 0, 0);
        }
        if(Input.GetKey("d")){
            rb.AddForce(moveForce*Time.deltaTime, 0, 0);
        }
    }
}
