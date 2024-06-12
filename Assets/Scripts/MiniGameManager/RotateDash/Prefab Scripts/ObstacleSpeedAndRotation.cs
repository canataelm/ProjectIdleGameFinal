using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpeedAndRotation : MonoBehaviour
{
    [SerializeField] float speed = 1;
    [SerializeField] float maxLeftPosition;
    [SerializeField] float maxRightPosition;
    private Rigidbody2D rb;

    private bool isRight;
    private bool isLeft;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();

        if (transform.position.x == maxLeftPosition)
        {
            isLeft = true;
        }
        else if(transform.position.x == maxRightPosition)
        {
            isRight = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isLeft)
        {
            rb.AddForce(Vector2.right * speed);
        }
        else if(isRight)
        {
            rb.AddForce(Vector2.left * speed);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Destroy")
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "DestroyWall")
        {
            Destroy(gameObject);
        }
    }
}
