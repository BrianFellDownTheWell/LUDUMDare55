using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform cameraTarget;
    public float speed = 0.25f;
    public Vector3 offset;

    void Update()
    {
        if(cameraTarget != null)
        {
            Vector3 desiredPos = cameraTarget.position + offset;
            Vector3 smoothPos = Vector2.Lerp(transform.position, desiredPos, speed);
            transform.position = new Vector3(smoothPos.x, smoothPos.y, transform.position.z);
        }
    }
}
