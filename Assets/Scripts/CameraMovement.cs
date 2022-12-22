using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    void Update()
    {
        float speed = 30;

        if (Input.GetKey(KeyCode.D))
            transform.Rotate(0, speed * Time.deltaTime, 0);
        if (Input.GetKey(KeyCode.A))
            transform.Rotate(0, (-1) * speed * Time.deltaTime, 0);
    }
}
