using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotateSpeed;

    public static bool rotationCheck = true;

    private void Start()
    {
        
    }
    void Update()
    {
        //moveX = Input.GetAxis("Mouse X");
        //if (Input.GetMouseButton(0))
        //{ 
        // }

        if (rotationCheck==true) {
            transform.Rotate(0f, rotateSpeed * Time.deltaTime, 0f);
            
        }
        if (rotationCheck == false)
        {
            transform.Rotate(0f, rotateSpeed * Time.deltaTime*-1f, 0f);
        }





    }
    void circleRotation()
    {
        transform.Rotate(0f, rotateSpeed*Time.deltaTime , 0f);
    }
}
