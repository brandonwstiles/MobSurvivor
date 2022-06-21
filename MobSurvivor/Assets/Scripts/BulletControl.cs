using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControl : MonoBehaviour
{
    public float speed = 1f;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(transform.right * speed * Time.deltaTime);
        //rb.velocity = new Vector2(transform.rotation.z , transform.rotation.z * speed * Time.deltaTime);
        //transform.forward = new Vector3(speed * Time.deltaTime, speed * Time.deltaTime);
    }
}
