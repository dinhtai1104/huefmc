using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewHeightCamera : MonoBehaviour
{
    public float maxHeight, minHeight;
    public float speed;
    public Transform cameraViewTrans;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            //Up
            if (cameraViewTrans.position.y >= maxHeight) return;
            cameraViewTrans.position += Vector3.up * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.F))
        {
            //Down
            if (cameraViewTrans.position.y <= minHeight) return;
            cameraViewTrans.position -= Vector3.up * Time.deltaTime * speed;
        }
    }
}
