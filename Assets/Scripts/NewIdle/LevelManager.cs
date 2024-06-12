using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;

    [HideInInspector] public int idleLevel;

    [HideInInspector] public int neceseryPlastic;
    [HideInInspector] public int neceseryGlass;
    [HideInInspector] public int neceseryPaper;
    [HideInInspector] public int neceseryMetal;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        IdleGameUpgradeLevelCalculator();
    }

    public void IdleGameUpgradeLevel()
    {
        if (GameManagerNewIdle.Instance.plasticCount >= neceseryPlastic && GameManagerNewIdle.Instance.glassCount >= neceseryGlass && GameManagerNewIdle.Instance.paperCount >= neceseryPaper && GameManagerNewIdle.Instance.metalCount >= neceseryMetal)
        {
            idleLevel++;
            GameManagerNewIdle.Instance.Restarter();
        }
    }

    private void IdleGameUpgradeLevelCalculator()
    {
        if(idleLevel == 0)
        {
            neceseryPlastic = 100000;
            neceseryGlass = 0;
            neceseryPaper = 0;
            neceseryMetal = 0;
        }
        else if (idleLevel == 1)
        {
            neceseryPlastic = 200000;
            neceseryGlass = 0;
            neceseryPaper = 0;
            neceseryMetal = 0;
        }
        else if (idleLevel == 2)
        {
            neceseryPlastic = 400000;
            neceseryGlass = 0;
            neceseryPaper = 0;
            neceseryMetal = 0;
        }
        else if (idleLevel == 3)
        {
            neceseryPlastic = 800000;
            neceseryGlass = 0;
            neceseryPaper = 0;
            neceseryMetal = 0;
        }
        else if (idleLevel == 4)
        {
            neceseryPlastic = 1600000;
            neceseryGlass = 0;
            neceseryPaper = 0;
            neceseryMetal = 0;
        }
        else if (idleLevel == 5)
        {
            neceseryPlastic = 3200000;
            neceseryGlass = 0;
            neceseryPaper = 0;
            neceseryMetal = 0;
        }
        else if (idleLevel == 6)
        {
            neceseryPlastic = 6400000;
            neceseryGlass = 0;
            neceseryPaper = 0;
            neceseryMetal = 0;
        }
        else if (idleLevel == 7)
        {
            neceseryPlastic = 12800000;
            neceseryGlass = 0;
            neceseryPaper = 0;
            neceseryMetal = 0;
        }
        else if (idleLevel == 8)
        {
            neceseryPlastic = 25600000;
            neceseryGlass = 0;
            neceseryPaper = 0;
            neceseryMetal = 0;
        }
        else if (idleLevel == 9)
        {
            neceseryPlastic = 51200000;
            neceseryGlass = 0;
            neceseryPaper = 0;
            neceseryMetal = 0;
        }
        else if (idleLevel == 10)
        {
            neceseryPlastic = 102400000;
            neceseryGlass = 0;
            neceseryPaper = 0;
            neceseryMetal = 0;
        }
    }
}
