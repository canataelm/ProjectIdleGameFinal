using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public static float havedO2;
    public static int havedtree;
    public static int havedO2Machine;
    public static int havedEcoFactory;
    public static int havedEcoCity;
    void Start()
    {
        havedO2 = 0;
        havedtree = 0;
        havedO2Machine = 0;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
