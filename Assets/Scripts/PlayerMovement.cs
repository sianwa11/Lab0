using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardMovement = 5000;
    public float sidewaysMovement = 120;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey("w"))
        {
            rb.AddForce(0, 0, forwardMovement * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysMovement * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysMovement * Time.deltaTime, 0, 0);
        }

    }
}
