using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialManage : MonoBehaviour
{

    public static MaterialManage instance;

    [HideInInspector] public int earnedPlastic;
    [HideInInspector] public int earnedGlass;
    [HideInInspector] public int earnedPaper;
    [HideInInspector] public int earnedMetal;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddMaterialToIdle()
    {
        GameManagerNewIdle.Instance.plasticCount = GameManagerNewIdle.Instance.plasticCount + earnedPlastic;
        GameManagerNewIdle.Instance.glassCount = GameManagerNewIdle.Instance.glassCount + earnedGlass;
        GameManagerNewIdle.Instance.paperCount = GameManagerNewIdle.Instance.paperCount + earnedPaper;
        GameManagerNewIdle.Instance.metalCount = GameManagerNewIdle.Instance.metalCount + earnedMetal;
        GameManagerNewIdle.Instance.SaveGame();
    }
}
