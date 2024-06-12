using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPlayer : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private LineRenderer lr;
    [SerializeField] private GameObject goalFX;
    [SerializeField] private Transform cameraTransform;

    [Header("Attributes")]
    [SerializeField] private float maxPower = 10f;
    [SerializeField] private float power = 2f;
    [SerializeField] private float maxGoalSpeed = 4f;

    private bool isDragging;
    private bool inHole;

    void Start()
    {
        cameraTransform.position = new Vector3(transform.position.x, transform.position.y, -15);
    }

    // Update is called once per frame
    void Update()
    {
        PlayerInput();
        CameraFollow();

        if(LevelManagerAndUIManager.main.outOfStrokes && rb.velocity.magnitude <= 0.2f && !LevelManagerAndUIManager.main.levelComplacated)
        {
            LevelManagerAndUIManager.main.GameOver();
        }

    }

    private bool isReady()
    {
        return rb.velocity.magnitude <= 0.2f;
    }


    private void PlayerInput()
    {
        if (!isReady())
        {
            return;
        }
        Vector3 screenPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 15);
        Vector2 inputPosition = Camera.main.ScreenToWorldPoint(screenPosition);
        float distance = Vector2.Distance(transform.position, inputPosition);
        Debug.Log(inputPosition);

        if (Input.GetMouseButtonDown(0) && distance <= 0.5f)
        {
            DragStart();
        }

        if (Input.GetMouseButton(0) && isDragging)
        {
            DragChange(inputPosition);
        }

        if (Input.GetMouseButtonUp(0) && isDragging)
        {
            DragRealese(inputPosition);
        }
    }

    private void DragStart()
    {
        isDragging = true;
        lr.positionCount = 2;
    }

    private void DragChange(Vector2 pos)
    {
        Vector2 dir = (Vector2)transform.position - pos;
        lr.SetPosition(0, transform.position);
        lr.SetPosition(1, (Vector2)transform.position + Vector2.ClampMagnitude((dir * power / 2) , maxPower / 2));
    }

    private void DragRealese(Vector2 pos)
    {
        float distance = Vector2.Distance((Vector2)transform.position, pos);
        isDragging = false;
        lr.positionCount = 0;

        if (distance < 1f)
        {
            return;
        }

        LevelManagerAndUIManager.main.IncraeseStroke();

        Vector2 dir = (Vector2)transform.position - pos;

        rb.velocity = Vector2.ClampMagnitude(dir * power, maxPower);

    }

    private void CheckWinState()
    {
        if (inHole)
        {
            return;
        }

        if(rb.velocity.magnitude <= maxGoalSpeed)
        {
            inHole = true;
            rb.velocity = Vector2.zero;
            gameObject.SetActive(false);

            GameObject fx = Instantiate(goalFX, transform.position, Quaternion.identity);
            Destroy(fx, 2f);

            MaterialManage.instance.AddMaterialToIdle();
            GameManagerNewIdle.Instance.SaveGame();
            LevelManagerAndUIManager.main.levelComplate();
        }
    }

    private void CameraFollow()
    {
        cameraTransform.position = Vector3.Lerp(cameraTransform.position, new Vector3(transform.position.x, transform.position.y, -15f), 0.005f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Hole")
        {
            CheckWinState();
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Hole")
        {
            CheckWinState();
        }
    }
}
