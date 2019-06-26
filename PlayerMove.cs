using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody rb;

    void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            rb.velocity = new Vector3(0, 0, 20);
            //rb.AddForce(0, 0, 100 * Time.deltaTime);
        }

        if (Input.GetKey("s"))
        {
            rb.velocity = new Vector3(0, 0, -20);
            //rb.AddForce(0, 0, -50 * Time.deltaTime);
        }

        if (Input.GetKey("a"))
        {

            rb.velocity = new Vector3(-10, 0, 0);
            //rb.AddForce(-50 * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("d"))
        {

            rb.velocity = new Vector3(10, 0, 0);
            //rb.AddForce(50 * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("space"))
        {

            rb.velocity = new Vector3(0, 0, 0);
            //rb.AddForce(50 * Time.deltaTime, 0, 0);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<SceneMovement>().EndGame();
        }
    }
}
