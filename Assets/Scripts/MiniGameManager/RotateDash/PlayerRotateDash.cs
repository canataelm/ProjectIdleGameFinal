using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotateDash : MonoBehaviour
{
    [SerializeField] private Vector3 center;
    [SerializeField] private float startSpeed,startRadius;

    private float speed;
    void Start()
    {
        
    }
    private void Awake()
    {
        speed = startSpeed;
        startRadius = Vector3.Distance(transform.position, center);
    }

    private void FixedUpdate()
    {
        Vector3 down = transform.position - center;
        Vector3 forward = Vector3.Cross(down, Vector3.forward).normalized;
        Vector3 temp = transform.position;
        temp += speed * Time.fixedDeltaTime * forward;
        float currentRadius = Vector3.Distance(temp, center);
        if (currentRadius > startRadius)
        {
            float extraRadius = currentRadius - startRadius;
            Vector3 offset = (temp - center).normalized;
            temp -= extraRadius * offset;
        }
        transform.position = temp;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            speed *= -1f;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Score"))
        {
            GameManagerRotateDash.instance.UpdateScore();
            GameManagerRotateDash.instance.UpdateScoreBarRotation();
            return;
        }
        if (collision.CompareTag("Danger"))
        {
            Destroy(gameObject);
            GameManagerRotateDash.instance.EndGame();
        }
    }
}
