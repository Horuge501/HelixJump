using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public float posOfset;
    private Vector3 velocity;
    public float smoothDamp;

    private void FixedUpdate()
    {
        Vector3 targetPos = player.position + offset;

        if (player.position.y < transform.position.y + posOfset)
        {
            transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, smoothDamp);
        }
    }
}
