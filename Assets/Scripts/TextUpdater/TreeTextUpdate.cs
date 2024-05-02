using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TreeTextUpdate : MonoBehaviour
{
    [SerializeField] TMP_Text treeText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        treeText.text = GameManager.havedtree + "";
    }
}
