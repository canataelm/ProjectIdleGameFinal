using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class TreeAdder : MonoBehaviour
{
    [SerializeField] int howMuchTree;
    [SerializeField] float howMuchO2 = 25;
    [SerializeField] Button button;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(GameManager.havedO2 >= howMuchO2)
        {
            button.interactable = true;
        }
        else
        {
            button.interactable = false;
        }
    }

    public void TreeAdded()
    {
        GameManager.havedO2 -= howMuchO2;
        GameManager.havedtree += howMuchTree;
    }
}
