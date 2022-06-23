using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerM : MonoBehaviour
{
    public float playerMS;
    public Rigidbody2D rb;

    private Vector2 moveDirection;



    // Update is called once per frame
    void Update()
    {
        ProcessInputs();
    }

    void FixedUpdate()
    {
        Move();
    }

    void ProcessInputs ()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX, moveY).normalized; 

    }

    void Move()
    {
        rb.velocity = new Vector2(moveDirection.x * playerMS, moveDirection.y * playerMS);

    }
}
