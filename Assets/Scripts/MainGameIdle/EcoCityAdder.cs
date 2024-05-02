using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class EcoCityAdder : MonoBehaviour
{
    [SerializeField] int howMuchEcoCity;
    [SerializeField] int howMuchEcoFactoryCost = 25;
    [SerializeField] Button button;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(GameManager.havedEcoFactory >= howMuchEcoFactoryCost)
        {
            button.interactable = true;
        }
        else
        {
            button.interactable = false;
        }
    }

    public void EcoCityAdded()
    {
        GameManager.havedEcoFactory -= howMuchEcoFactoryCost;
        GameManager.havedEcoCity += howMuchEcoCity;
    }
}
