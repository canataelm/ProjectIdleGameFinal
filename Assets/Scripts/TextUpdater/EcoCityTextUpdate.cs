using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EcoCityTextUpdate : MonoBehaviour
{
    [SerializeField] TMP_Text ecoCityText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        ecoCityText.text = GameManager.havedEcoCity + "";
    }
}
