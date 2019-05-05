using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Transform Lava;
    Vector3 Startpos = new Vector3();
    bool AllowStart = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(Startpos.y <= Lava.position.y + 1f)
        {
            AllowStart = false;
        }

        if(Input.GetKeyDown(KeyCode.R) && AllowStart)
        {
            transform.position = Startpos;
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        // Debug.Log(collision.gameObject.name);
        if (collision.gameObject.tag == "Checkpoint")
        {
            Startpos = transform.position;
            AllowStart = true;
        }

    }

}
