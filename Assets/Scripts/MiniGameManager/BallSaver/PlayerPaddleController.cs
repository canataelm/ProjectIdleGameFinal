using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddleController : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] private float moveSpeed;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        TouchMove();
    }

    void TouchMove()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 touchPos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
            touchPos.x = touchPos.x - 0.5f;
            Debug.Log(touchPos);
            if(touchPos.x < 0)
            {
                rb.velocity = Vector2.left * moveSpeed;
            }
            else
            {
                rb.velocity = Vector2.right * moveSpeed;
            }
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }
}
