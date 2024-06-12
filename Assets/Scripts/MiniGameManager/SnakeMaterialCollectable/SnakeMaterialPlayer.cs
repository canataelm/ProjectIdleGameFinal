using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SnakeMaterialPlayer : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float rotateAmaount;
    [SerializeField] private TMP_Text scoreBoard;
    private float rot;
    int score;

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
        scoreBoard.text = "O2: " + score;

        if (Input.GetMouseButton(0))
        {
            Vector3 mousePos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
            mousePos.x = mousePos.x - 0.5f;

            Debug.Log(mousePos);
            if(mousePos.x < 0)
            {
                rot = rotateAmaount;
            }
            else
            {
                rot = -rotateAmaount;
            }

            transform.Rotate(0, 0, rot);
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = transform.up * moveSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Material")
        {
            Destroy(collision.gameObject);
            score++;

            if(score >= 4)
            {
                print("Level Complate");
            }
        }
        else if(collision.gameObject.tag == "Danger")
        {
            SceneManager.LoadScene("SnakeMaterialCollectable");
        }
    }
}
