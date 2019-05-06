using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Transform Lava;
    Vector3 StartPos;
    Vector3 LavaStartPos;
    bool AllowStart = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(StartPos.y <= Lava.position.y + 1f)
        {
            AllowStart = false;
        }

        if(Input.GetKeyDown(KeyCode.R) && AllowStart)
        {
            transform.position = StartPos;
            Lava.transform.position = LavaStartPos;
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        // Debug.Log(collision.gameObject.name);
        if (collision.gameObject.tag == "Checkpoint")
        {
            StartPos = transform.position;
            LavaStartPos = new Vector3(0,Lava.position.y,0);
            AllowStart = true;
        }

        if (collision.gameObject.tag == "Death")
        {
            Application.LoadLevel("Death");
        }

        if (collision.gameObject.tag == "Finish")
        {
            SceneManager.LoadScene("Finish");
        }

    }

}
