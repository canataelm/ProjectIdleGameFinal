using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class O2MachineAdder : MonoBehaviour
{
    [SerializeField] int howMuchO2Machine;
    [SerializeField] int howMuchTreeCost = 25;
    [SerializeField] Button button;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(GameManager.havedtree >= howMuchTreeCost)
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
        GameManager.havedtree -= howMuchTreeCost;
        GameManager.havedO2Machine += howMuchO2Machine;
    }
}
