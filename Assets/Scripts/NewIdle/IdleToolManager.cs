using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IdleToolManager : MonoBehaviour
{
    private float timer = 0;

    [Header("Color")]
    [SerializeField] Color autoColor;

    [Header("UI References")]
    //Plastic Buttons
    [SerializeField] Image plasticStrawUpgradeImage;
    [SerializeField] Image plasticBottleUpgradeImage;
    [SerializeField] Image plasticBagsUpgradeImage;
    [SerializeField] Image plasticToysUpgradeImage;
    [SerializeField] Image plasticFurnitureUpgradeImage;
    //Glass Buttons
    [SerializeField] Image glassBottlesUpgradeImage;
    [SerializeField] Image glassJarsUpgradeImage;
    [SerializeField] Image glassPlatesUpgradeImage;
    [SerializeField] Image glassAccessoriesUpgradeImage;
    [SerializeField] Image glassBulbsUpgradeImage;
    void Start()
    {
        Invoke("EarnMaterials", 0.02f);
    }

    // Update is called once per frame
    void Update()
    {
        timer = Time.deltaTime + timer;

        if(timer < 1)
        {

        }
        else
        {
            EarnMaterials();
            timer = 0;
        }

    }

    public void EarnMaterials()
    {
        //Plastic

        if (ToolsManager.instance.isPlasticStrawTool)
        {
            plasticStrawUpgradeImage.color = autoColor;
            GameManagerNewIdle.Instance.plasticCount = GameManagerNewIdle.Instance.plasticCount + (GameManagerNewIdle.Instance.plasticStrawsCount * 1);
        }
        if (ToolsManager.instance.isPlasticBottlesTool)
        {
            plasticBottleUpgradeImage.color = autoColor;
            GameManagerNewIdle.Instance.plasticCount = GameManagerNewIdle.Instance.plasticCount + (GameManagerNewIdle.Instance.plasticBottlesCount * 5);
        }
        if (ToolsManager.instance.isPlasticBagsTool)
        {
            plasticBagsUpgradeImage.color = autoColor;
            GameManagerNewIdle.Instance.plasticCount = GameManagerNewIdle.Instance.plasticCount + (GameManagerNewIdle.Instance.plasticBagsCount * 25);
        }
        if (ToolsManager.instance.isPlasticToysTool)
        {
            plasticToysUpgradeImage.color = autoColor;
            GameManagerNewIdle.Instance.plasticCount = GameManagerNewIdle.Instance.plasticCount + (GameManagerNewIdle.Instance.plasticToysCount * 125);
        }
        if (ToolsManager.instance.isPlasticFurnitureTool)
        {
            plasticFurnitureUpgradeImage.color = autoColor;
            GameManagerNewIdle.Instance.plasticCount = GameManagerNewIdle.Instance.plasticCount + (GameManagerNewIdle.Instance.plasticFurnitureCount * 625);
        }

        //Glass

        if (ToolsManager.instance.isglassBottlesTool)
        {
            glassBottlesUpgradeImage.color = autoColor;
            GameManagerNewIdle.Instance.glassCount = GameManagerNewIdle.Instance.glassCount + (GameManagerNewIdle.Instance.glassBottlesCount * 1);
        }
        if (ToolsManager.instance.isglassJarsTool)
        {
            glassJarsUpgradeImage.color = autoColor;
            GameManagerNewIdle.Instance.glassCount = GameManagerNewIdle.Instance.glassCount + (GameManagerNewIdle.Instance.glassJarsCount * 5);
        }
        if (ToolsManager.instance.isglassPlatesTool)
        {
            glassPlatesUpgradeImage.color = autoColor;
            GameManagerNewIdle.Instance.glassCount = GameManagerNewIdle.Instance.glassCount + (GameManagerNewIdle.Instance.glassPlatesCount * 25);
        }
        if (ToolsManager.instance.isglassAccessoriesTool)
        {
            glassAccessoriesUpgradeImage.color = autoColor;
            GameManagerNewIdle.Instance.glassCount = GameManagerNewIdle.Instance.glassCount + (GameManagerNewIdle.Instance.glassAccessoriesCount * 125);
        }
        if (ToolsManager.instance.isglassBulbsTool)
        {
            glassBulbsUpgradeImage.color = autoColor;
            GameManagerNewIdle.Instance.glassCount = GameManagerNewIdle.Instance.glassCount + (GameManagerNewIdle.Instance.glassBulbsCount * 625);
        }


    }
}
