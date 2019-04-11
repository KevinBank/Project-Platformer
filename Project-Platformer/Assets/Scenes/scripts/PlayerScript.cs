using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    public float fUp = 10f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            transform.position -= transform.forward * speed * Time.deltaTime;
            //rb.AddRelativeForce(rb.velocity.x, rb.velocity.y, speed);
        }
        if (Input.GetKey("s"))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
            //rb.AddRelativeForce(rb.velocity.x, rb.velocity.y, -speed);
        }
        if (Input.GetKey("a"))
        {
            transform.position += transform.right * speed * Time.deltaTime;
            //rb.AddRelativeForce(-speed, rb.velocity.y, rb.velocity.z);
        }
        if (Input.GetKey("d"))
        {
            transform.position -= transform.right * speed * Time.deltaTime;
            //rb.AddRelativeForce(speed, rb.velocity.y, rb.velocity.z);
        }

        if (Input.GetKey("space") && onGround)
        {
            rb.velocity = new Vector3(rb.velocity.x, fUp, rb.velocity.z);
        }
    }

    private bool onGround = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground") onGround = true;

        Debug.Log("on ground" + onGround);
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Ground") onGround = false;
    }

}
