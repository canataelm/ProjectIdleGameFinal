using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    private GameObject player;
    private PlayerDead playerDead;

    void Start()
    {
        gameObject.transform.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Time.timeScale = 0;
        }
    }

}
