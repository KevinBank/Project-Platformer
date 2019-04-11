using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    private float currentMouseH;
    private float currentMouseV;

    private float previousMouseH;
    private float previousMouseV;

    private Vector3 mousePos;
    //public Vector3 cameraAngle;

    private bool inGame = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //cameraAngle = 

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            inGame = !inGame;
            Debug.Log(inGame);
        }

        mousePos = Input.mousePosition;
        mousePos = mousePos / 10;
        Debug.Log(mousePos);
        //transform.Rotate(Vector3.left * mousePos.y / 50);
        //transform.Rotate(Vector3.up * mousePos.x / 50);

        //transform.localRotation.SetEulerRotation(currentMouseH - previousMouseH,currentMouseV - previousMouseV,0);
        transform.localRotation = Quaternion.Euler(new Vector3(-mousePos.y, mousePos.x, 0));
    }


}
