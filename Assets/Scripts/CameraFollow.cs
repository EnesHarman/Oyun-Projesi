using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform playerTransform;
    public Vector3 offsetCamera = Vector3.zero;

    void Start()
    {
        offsetCamera = transform.position - playerTransform.position;
    }

    void Update()
    {
        Vector3 newPosition = playerTransform.position + offsetCamera;

        transform.position = newPosition;
    }
}
