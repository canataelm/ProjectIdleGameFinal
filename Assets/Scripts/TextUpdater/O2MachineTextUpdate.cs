using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class O2MachineTextUpdate : MonoBehaviour
{
    [SerializeField] TMP_Text o2MachineText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        o2MachineText.text = GameManager.havedO2Machine + "";
    }
}
