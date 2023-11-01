using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Comet_Movement : MonoBehaviour
{
    public Vector3 targetPosition;
    public float smoothTime = 0.5f;
    public float speed = 10;
    Vector3 velocity;
    void Update()
    {
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime, speed);
    }
}
