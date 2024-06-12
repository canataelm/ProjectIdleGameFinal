using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float startBounceForce;
    [SerializeField] float collisionBounceForce;
    void Start()
    {

    }
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown && GameManagerSaveBall.instance.gameStarted == false)
        {
            Time.timeScale = 1;
            StartBounce();
            GameManagerSaveBall.instance.gameStarted = true;
            GameManagerSaveBall.instance.GameStart();
            ObstacleSpawner.instance.isSpawnable = true;
        }
    }

    void StartBounce()
    {
        Vector2 randomDirection = new Vector2(Random.Range(-1,1),1);

        rb.AddForce(randomDirection * startBounceForce, ForceMode2D.Impulse);
    }

    void CollisionBounce()
    {
        Vector2 randomDirection = new Vector2(Random.Range(-1, 1), 1);

        rb.AddForce(randomDirection * collisionBounceForce, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            CollisionBounce();
            GameManagerSaveBall.instance.ScoreUp();
        }

        if(collision.gameObject.tag == "Danger")
        {
            MaterialManage.instance.AddMaterialToIdle();
            GameManagerSaveBall.instance.Die();
        }
    }
}
