using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolsManager : MonoBehaviour
{
    public static ToolsManager instance;

    [Header("Tools")]
    //Plastic
    [HideInInspector] public bool isPlasticStrawTool;
    [HideInInspector] public bool isPlasticBottlesTool;
    [HideInInspector] public bool isPlasticBagsTool;
    [HideInInspector] public bool isPlasticToysTool;
    [HideInInspector] public bool isPlasticFurnitureTool;
    //Glass
    [HideInInspector] public bool isglassBottlesTool;
    [HideInInspector] public bool isglassJarsTool;
    [HideInInspector] public bool isglassPlatesTool;
    [HideInInspector] public bool isglassAccessoriesTool;
    [HideInInspector] public bool isglassBulbsTool;

    public void Awake()
    {
        instance = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        IdleGameToolsEnabled();
    }

    void IdleGameToolsEnabled()
    {
        if (LevelManager.instance.idleLevel == 0)
        {

        }
        else if (LevelManager.instance.idleLevel == 1)
        {
            isPlasticStrawTool = true;
        }
        else if (LevelManager.instance.idleLevel == 2)
        {
            isPlasticStrawTool = true;
            isPlasticBottlesTool = true;
        }
        else if (LevelManager.instance.idleLevel == 3)
        {
            isPlasticStrawTool = true;
            isPlasticBottlesTool = true;
            isPlasticBagsTool = true;
        }
        else if (LevelManager.instance.idleLevel == 4)
        {
            isPlasticStrawTool = true;
            isPlasticBottlesTool = true;
            isPlasticBagsTool = true;
            isPlasticToysTool = true;
        }
        else if (LevelManager.instance.idleLevel == 5)
        {
            isPlasticStrawTool = true;
            isPlasticBottlesTool = true;
            isPlasticBagsTool = true;
            isPlasticToysTool = true;
            isPlasticFurnitureTool = true;
        }
        else if (LevelManager.instance.idleLevel == 6)
        {
            isPlasticStrawTool = true;
            isPlasticBottlesTool = true;
            isPlasticBagsTool = true;
            isPlasticToysTool = true;
            isPlasticFurnitureTool = true;
            isglassBottlesTool = true;
        }
        else if (LevelManager.instance.idleLevel == 7)
        {
            isPlasticStrawTool = true;
            isPlasticBottlesTool = true;
            isPlasticBagsTool = true;
            isPlasticToysTool = true;
            isPlasticFurnitureTool = true;
            isglassBottlesTool = true;
            isglassJarsTool = true;
        }
        else if (LevelManager.instance.idleLevel == 8)
        {
            isPlasticStrawTool = true;
            isPlasticBottlesTool = true;
            isPlasticBagsTool = true;
            isPlasticToysTool = true;
            isPlasticFurnitureTool = true;
            isglassBottlesTool = true;
            isglassJarsTool = true;
            isglassPlatesTool = true;
        }
        else if (LevelManager.instance.idleLevel == 9)
        {
            isPlasticStrawTool = true;
            isPlasticBottlesTool = true;
            isPlasticBagsTool = true;
            isPlasticToysTool = true;
            isPlasticFurnitureTool = true;
            isglassBottlesTool = true;
            isglassJarsTool = true;
            isglassPlatesTool = true;
            isglassAccessoriesTool = true;
        }
        else if (LevelManager.instance.idleLevel == 10)
        {
            isPlasticStrawTool = true;
            isPlasticBottlesTool = true;
            isPlasticBagsTool = true;
            isPlasticToysTool = true;
            isPlasticFurnitureTool = true;
            isglassBottlesTool = true;
            isglassJarsTool = true;
            isglassPlatesTool = true;
            isglassAccessoriesTool = true;
            isglassBulbsTool = true;
        }
    }
}
