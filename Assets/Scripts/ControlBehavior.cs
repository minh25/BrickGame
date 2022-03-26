using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlBehavior : MonoBehaviour
{
    public float moveSpeed = 10.0f;

    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(horizontalInput, verticalInput, 0) * moveSpeed * Time.deltaTime);
    }
}
