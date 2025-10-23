using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed;

    // Update is called once per frame
    void Update()
    {
        // get inputs
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        // log for debugging
        Debug.Log($"Horizontal input: {horizontal}, Vertical input: {vertical}");
        // move object
        Vector3 movementDirection = new Vector3(horizontal, 0, vertical);
        movementDirection.Normalize();
        transform.position += movementDirection * speed * Time.deltaTime;

    }
}