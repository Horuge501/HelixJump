using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotateSpeed;

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, -rotateSpeed * Time.deltaTime, 0);
        }
    }
}
