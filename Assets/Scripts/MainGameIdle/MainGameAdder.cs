using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameAdder : MonoBehaviour
{
    private float timer = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 1f)
        {
            GameManager.havedO2 += GameManager.havedO2Machine;
            GameManager.havedO2Machine += GameManager.havedEcoFactory;
            GameManager.havedEcoFactory += GameManager.havedEcoCity;
            timer = 0;
        }
    }
}
