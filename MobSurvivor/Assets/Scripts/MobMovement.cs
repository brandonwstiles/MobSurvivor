using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobMovement : MonoBehaviour
{
    public Transform player;
    public float moveSpeed = 0.2f;
    private Rigidbody2D rb;
    private Vector2 direction;
    public bool isCollision;


    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        direction = player.position - transform.position;
        //float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        //rb.rotation = angle;
        direction.Normalize();
    }

    private void FixedUpdate() 
        //FixedUpdate is called every Frame per Framerate
    {
        if(!isCollision)
            moveCharacter(direction);
    }

    void moveCharacter(Vector2 direction)
    {
        Physics2D.SyncTransforms();
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
        //rb.MovePosition(Vector2 position);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isCollision = true;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        isCollision = false;
    }
}
