using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCharacterController : MonoBehaviour
{

    public float Speed;
    public float jumpStrength = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
        if (Input.GetKeyDown(KeyCode.Space))
            Jump();
    }

    void Jump()
    {
        if (CanJump())
        {
            // Jump on ridigbody
            GetComponent<Rigidbody>().AddForce(jumpStrength * transform.up, ForceMode.Impulse);
        }
    }

    bool CanJump()
    {
        // Create Ray
        Ray ray = new Ray(transform.position, transform.up * -1);

        // Create Hit Info
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, transform.localScale.y + 0.1f))
        {
            return true;
        }

        // Nothing so return false
        return false;
    }

    void PlayerMovement()
    {
        float Haxis = Input.GetAxis("Horizontal");
        float Vaxis = Input.GetAxis("Vertical");
        Vector3 playerMovement = new Vector3(Haxis, 0f, Vaxis) * Speed * Time.deltaTime;
        transform.Translate(playerMovement, Space.Self);

    }
}
