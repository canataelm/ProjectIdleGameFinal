using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerDead : MonoBehaviour
{
    private PlayerController playerController;
    void Start()
    {
        playerController = gameObject.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayerDie()
    {
        playerController.enabled = false;
    }
}
