using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int speed = 5;

    private float moveX;
    private float moveY;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        moveX = Input.GetAxisRaw("Horizontal") * speed;
        moveY = Input.GetAxisRaw("Vertical") * speed;
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(moveX, 0, moveY);
    }
}
