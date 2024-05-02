using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class O2TextUpdate : MonoBehaviour
{
    [SerializeField] TMP_Text o2Text;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        o2Text.text = GameManager.havedO2 + "";
    }
}
