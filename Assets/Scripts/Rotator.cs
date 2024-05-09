using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotateSpeed;

    private CylinderController controls;
    private float rotateInput;

    private void Awake()
    {
        controls = new CylinderController();
        controls.Enable();
        controls.PlayerControls.Rotate.performed += ctx => rotateInput = ctx.ReadValue<float>();
        controls.PlayerControls.Rotate.canceled += ctx => rotateInput = 0f;
    }

    private void Update()
    {
        transform.Rotate(0, rotateInput * rotateSpeed * Time.deltaTime, 0);
    }
}
