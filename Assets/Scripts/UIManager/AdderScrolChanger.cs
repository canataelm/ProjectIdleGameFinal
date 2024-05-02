using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdderScrolChanger : MonoBehaviour
{
    public static AdderScrolChanger Instance;
    public GameObject treeScrool;
    public GameObject o2MachineScrool;
    public GameObject EcoFactoryScrool;
    public GameObject EcoCityScrool;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void opentreeScrool()
    {
        EcoCityScrool.SetActive(false);
        EcoFactoryScrool.SetActive(false);
        o2MachineScrool.SetActive(false);
        treeScrool.SetActive(true);
    }

    public void openO2MachineScrool()
    {
        EcoCityScrool.SetActive(false);
        EcoFactoryScrool.SetActive(false);
        o2MachineScrool.SetActive(true);
        treeScrool.SetActive(false);
    }

    public void openEcoFactoryScrool()
    {
        EcoCityScrool.SetActive(false);
        EcoFactoryScrool.SetActive(true);
        o2MachineScrool.SetActive(false);
        treeScrool.SetActive(false);
    }
    public void openEcoCityScrool()
    {
        EcoFactoryScrool.SetActive(false);
        o2MachineScrool.SetActive(false);
        treeScrool.SetActive(false);
        EcoCityScrool.SetActive(true);
    }
}
