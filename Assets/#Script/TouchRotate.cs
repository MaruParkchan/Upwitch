using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchRotate : MonoBehaviour
{
    ////  float rotationSpeed = 10.0f;
    //  float lerpSpeed = 10.0f;

    //  private Vector3 speed = new Vector3();
    //  private Vector3 avgSpeed = new Vector3();
    //  private bool dragging = false;

    //  //private void OnMouseDown()
    //  //{
    //  //    dragging = true;
    //  //}

    //  //private void Update()
    //  //{
    //  //    if (Input.GetMouseButtonDown(0) && dragging)
    //  //    {
    //  //        speed = new Vector3(-Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"), 0);
    //  //        avgSpeed = Vector3.Lerp(avgSpeed, speed, Time.deltaTime * 2);
    //  //    }
    //  //    else
    //  //    {
    //  //        if (dragging)
    //  //        {
    //  //            speed = avgSpeed;
    //  //            dragging = false;
    //  //        }


    //  //        float i = Time.deltaTime * lerpSpeed;
    //  //        speed = Vector3.Lerp(speed, Vector3.zero, i);
    //  //    }

    //  //    transform.Rotate(Camera.main.transform.up * speed.x * rotationSpeed, Space.World);
    //  //    transform.Rotate(Camera.main.transform.right * speed.y * rotationSpeed, Space.World);

    //  //}

    //  float rotationSpeed = 2.0f;

    //  void OnMouseDrag()
    //  {
    //      float XaxisRotation = Input.GetAxis("Mouse X") * rotationSpeed;
    //      float YaxisRotation = Input.GetAxis("Mouse Y") * rotationSpeed;
    //      // select the axis by which you want to rotate the GameObject
    //      transform.Rotate(Vector3.down, XaxisRotation);
    //      transform.Rotate(Vector3.right, YaxisRotation);
    //  }


    public Vector3 pos;
    private void Update()
    {
        transform.Rotate(pos);
    }
}
