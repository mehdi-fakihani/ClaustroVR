using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour {

    public float speed = 6f;            // The speed that the player will move at.

    Vector3 movement;                   // The vector to store the direction of the player's movement.

    void Awake()
    {

    }

    void FixedUpdate()
    {
        // Store the input axes.
        float h = Input.GetAxisRaw("CameraHorizontal");
        float v = Input.GetAxisRaw("CameraVertical");

        // Move the player around the scene.
        Move(h, v);
    }

    void Move(float h, float v)
    {
        // Set the movement vector based on the axis input.
        movement.Set(v, h, 0f);

        // Normalise the movement vector and make it proportional to the speed per second.
        movement = movement.normalized * speed * Time.deltaTime;

        this.transform.Rotate(movement);
        // Move the player to it's current position plus the movement.
        //playerRigidbody.MovePosition(transform.position + movement);
    }
}
