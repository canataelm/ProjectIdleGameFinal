using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EcoFactoryTextUpdate : MonoBehaviour
{
    [SerializeField] TMP_Text ecoFactoryText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        ecoFactoryText.text = GameManager.havedEcoFactory + "";
    }
}
