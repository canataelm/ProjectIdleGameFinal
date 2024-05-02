using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class EcoFactoryAdder : MonoBehaviour
{
    [SerializeField] int howMuchEcoFactory;
    [SerializeField] int howMuchO2MachineCost = 25;
    [SerializeField] Button button;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(GameManager.havedO2Machine >= howMuchO2MachineCost)
        {
            button.interactable = true;
        }
        else
        {
            button.interactable = false;
        }
    }

    public void EcoFactoryAdded()
    {
        GameManager.havedO2Machine -= howMuchO2MachineCost;
        GameManager.havedEcoFactory += howMuchEcoFactory;
    }
}
