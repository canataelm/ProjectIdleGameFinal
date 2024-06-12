using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicker : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Clicked()
    {
        GameManager.havedO2 += 1 + GameManager.havedtree;
        Debug.Log(GameManager.havedO2);
    }


}
