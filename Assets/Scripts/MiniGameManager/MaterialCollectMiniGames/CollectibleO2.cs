using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleO2 : MonoBehaviour
{
    private GameObject player;
    private int o2Multiply = 1;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        o2Multiply = (int)(player.transform.position.y / -100);
        Debug.Log(25 * Mathf.Pow(2, o2Multiply));
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            if (o2Multiply == 0)
            {
                GameManager.havedO2 += 25;
                Destroy(gameObject);
            }
            else
            {
                GameManager.havedO2 += 25 * o2Multiply;
                Destroy(gameObject);
            }
        }
    }
}
