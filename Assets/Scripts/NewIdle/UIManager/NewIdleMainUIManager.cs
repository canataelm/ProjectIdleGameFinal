using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class NewIdleMainUIManager : MonoBehaviour
{
    public static NewIdleMainUIManager instance;
    public enum menuState
    {
        IdleMenu,
        Minigames,
        Tools,
        Options
    }

    public enum materialState
    {
        Plastic,
        Glass,
        Paper,
        Metal
    }

    [HideInInspector] public menuState menuStateEnum = menuState.IdleMenu;
    [HideInInspector] public materialState materialStateEnum = materialState.Plastic;

    [Header("Menu References")]
    [SerializeField] GameObject idleMenu;
    [SerializeField] GameObject minigamesMenu;
    [SerializeField] GameObject toolsMenu;
    [Space]
    [SerializeField] GameObject plasticIdleUI;
    [SerializeField] GameObject GlassIdleUI;
    [SerializeField] GameObject PaperIdleUI;
    [SerializeField] GameObject MetalIdleUI;
    [Space]
    [SerializeField] Image plasticButtonImage;
    [SerializeField] Image glassButtonImage;
    [SerializeField] Image paperButtonImage;
    [SerializeField] Image metalButtonImage;
    [SerializeField] Color selectedColor;
    [Space]
    [SerializeField] Button plasticButton;
    [SerializeField] Button glassButton;
    [SerializeField] Button paperButton;
    [SerializeField] Button metalButton;


    [Header("Level References")]
    [SerializeField] TMP_Text levelText;
    [SerializeField] TMP_Text levelStaticText;
    [SerializeField] Image levelButtonImage;

    [SerializeField] TMP_Text plasticNextLevelValue;
    [SerializeField] TMP_Text glassNextLevelValue;
    [SerializeField] TMP_Text paperNextLevelValue;
    [SerializeField] TMP_Text metalNextLevelValue;

    [Header("Tool References")]
    [SerializeField] GameObject noneText;
    [Space]
    [SerializeField] GameObject plasticStrawTool;
    [SerializeField] GameObject plasticBottleTool;
    [SerializeField] GameObject plasticBagTool;
    [SerializeField] GameObject plasticToyTool;
    [SerializeField] GameObject plasticFurnitureTool;
    [Space]
    [SerializeField] GameObject glasBottlesTool;
    [SerializeField] GameObject glassJarTool;
    [SerializeField] GameObject glassPlatesTool;
    [SerializeField] GameObject GlassAccesoriesTool;
    [SerializeField] GameObject GlassBulbsTool;


    [Header("Plastic References")]
    [SerializeField] TMP_Text plasticCountText;
    [Space]
    [SerializeField] TMP_Text plasticsStrawCountText;
    [SerializeField] TMP_Text plasticsBottlesCountText;
    [SerializeField] TMP_Text plasticsBagsCountText;
    [SerializeField] TMP_Text plasticsToysCountText;
    [SerializeField] TMP_Text plasticsFurnitureCountText;
    [Space]
    [SerializeField] TMP_Text plasticsStrawCostText;
    [SerializeField] TMP_Text plasticsBottlesCostText;
    [SerializeField] TMP_Text plasticsBagsCostText;
    [SerializeField] TMP_Text plasticsToysCostText;
    [SerializeField] TMP_Text plasticsFurnitureCostText;

    [Header("Glass References")]
    [SerializeField] TMP_Text glassCountText;
    [Space]
    [SerializeField] TMP_Text glassBottlesCountText;
    [SerializeField] TMP_Text glassJarCountText;
    [SerializeField] TMP_Text glassPlatesCountText;
    [SerializeField] TMP_Text glassAccesoriesCountText;
    [SerializeField] TMP_Text glassBulbsCountText;
    [Space]
    [SerializeField] TMP_Text glassBottlesCostText;
    [SerializeField] TMP_Text glassJarCostText;
    [SerializeField] TMP_Text glassPlatesCostText;
    [SerializeField] TMP_Text glassAccesoriesCostText;
    [SerializeField] TMP_Text glassBulbsCostText;

    [Header("Paper References")]
    [SerializeField] TMP_Text paperCountText;
    [Space]
    [SerializeField] TMP_Text paperNotePageCountText;
    [SerializeField] TMP_Text paperPageCountText;
    [SerializeField] TMP_Text paperBrochuresCountText;
    [SerializeField] TMP_Text paperNewsCountText;
    [SerializeField] TMP_Text paperBookCountText;
    [Space]
    [SerializeField] TMP_Text paperNoteCostText;
    [SerializeField] TMP_Text paperPageCostText;
    [SerializeField] TMP_Text paperBrochuresCostText;
    [SerializeField] TMP_Text paperNewsCostText;
    [SerializeField] TMP_Text paperBookCostText;

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
        MenuUIUpdate();
        LevelUIUpdate();
        MaterialUIUpdate();
        ToolsUIUpdate();
        IdleMaterialUnlockedByLevel();
        // Plastic Material UI Manager
        PlasticUI();
        GlassUI();
        PaperUI();

    }

    void PlasticUI()
    {
        plasticCountText.text = "" + GameManagerNewIdle.Instance.plasticCount;

        plasticsStrawCountText.text = "" + GameManagerNewIdle.Instance.plasticStrawsCount;
        plasticsBottlesCountText.text = "" + GameManagerNewIdle.Instance.plasticBottlesCount;
        plasticsBagsCountText.text = "" + GameManagerNewIdle.Instance.plasticBagsCount;
        plasticsToysCountText.text = "" + GameManagerNewIdle.Instance.plasticToysCount;
        plasticsFurnitureCountText.text = "" + GameManagerNewIdle.Instance.plasticFurnitureCount;

        plasticsStrawCostText.text = "Cost: " + GameManagerNewIdle.Instance.plasticStrawsCost;
        plasticsBottlesCostText.text = "Cost: " + GameManagerNewIdle.Instance.plasticBottlesCost;
        plasticsBagsCostText.text = "Cost: " + GameManagerNewIdle.Instance.plasticBagsCost;
        plasticsToysCostText.text = "Cost: " + GameManagerNewIdle.Instance.plasticToysCost;
        plasticsFurnitureCostText.text = "Cost: " + GameManagerNewIdle.Instance.plasticFurnitureCost;
    }

    void GlassUI()
    {
        glassCountText.text = "" + GameManagerNewIdle.Instance.glassCount;

        glassBottlesCountText.text = "" + GameManagerNewIdle.Instance.glassBottlesCount;
        glassJarCountText.text = "" + GameManagerNewIdle.Instance.glassJarsCount;
        glassPlatesCountText.text = "" + GameManagerNewIdle.Instance.glassPlatesCount;
        glassAccesoriesCountText.text = "" + GameManagerNewIdle.Instance.glassAccessoriesCount;
        glassBulbsCountText.text = "" + GameManagerNewIdle.Instance.glassBulbsCount;

        glassBottlesCostText.text = "Cost: " + GameManagerNewIdle.Instance.glassBottlesCost;
        glassJarCostText.text = "Cost: " + GameManagerNewIdle.Instance.glassJarsCost;
        glassPlatesCostText.text = "Cost: " + GameManagerNewIdle.Instance.glassPlatesCost;
        glassAccesoriesCostText.text = "Cost: " + GameManagerNewIdle.Instance.glassAccessoriesCost;
        glassBulbsCostText.text = "Cost: " + GameManagerNewIdle.Instance.glassBulbsCost;
    }

    void PaperUI()
    {
        paperCountText.text = "" + GameManagerNewIdle.Instance.paperCount;

        paperNotePageCountText.text = "" + GameManagerNewIdle.Instance.paperNotePapersCount;
        paperPageCountText.text = "" + GameManagerNewIdle.Instance.paperPagesCount;
        paperBrochuresCountText.text = "" + GameManagerNewIdle.Instance.paperBrochuresCount;
        paperNewsCountText.text = "" + GameManagerNewIdle.Instance.paperNewspapersCount;
        paperBookCountText.text = "" + GameManagerNewIdle.Instance.paperBookCount;

        paperNoteCostText.text = "Cost: " + GameManagerNewIdle.Instance.paperNotePapersCost;
        paperPageCostText.text = "Cost: " + GameManagerNewIdle.Instance.paperPagesCost;
        paperBrochuresCostText.text = "Cost: " + GameManagerNewIdle.Instance.paperBrochuresCost;
        paperNewsCostText.text = "Cost: " + GameManagerNewIdle.Instance.paperANewspapersCost;
        paperBookCostText.text = "Cost: " + GameManagerNewIdle.Instance.paperBookCost;
    }

    void LevelUIUpdate()
    {
        levelText.text = "" + LevelManager.instance.idleLevel;

        plasticNextLevelValue.text = "" + LevelManager.instance.neceseryPlastic;
        glassNextLevelValue.text = "" + LevelManager.instance.neceseryGlass;
        paperNextLevelValue.text = "" + LevelManager.instance.neceseryPaper;
        metalNextLevelValue.text = "" + LevelManager.instance.neceseryMetal;

        if (GameManagerNewIdle.Instance.plasticCount >= LevelManager.instance.neceseryPlastic && GameManagerNewIdle.Instance.glassCount >= LevelManager.instance.neceseryGlass && GameManagerNewIdle.Instance.paperCount >= LevelManager.instance.neceseryPaper && GameManagerNewIdle.Instance.metalCount >= LevelManager.instance.neceseryMetal)
        {
            levelButtonImage.color = Color.green;
            levelStaticText.color = Color.green;
        }
        else
        {
            levelButtonImage.color = Color.white;
            levelStaticText.color = Color.white;
        }
    }

    void MenuUIUpdate()
    {
        if(menuStateEnum == menuState.IdleMenu)
        {
            idleMenu.SetActive(true);
            minigamesMenu.SetActive(false);
            toolsMenu.SetActive(false);
        }
        else if(menuStateEnum == menuState.Minigames)
        {
            idleMenu.SetActive(false);
            minigamesMenu.SetActive(true);
            toolsMenu.SetActive(false);
        }
        else if (menuStateEnum == menuState.Tools)
        {
            idleMenu.SetActive(false);
            minigamesMenu.SetActive(false);
            toolsMenu.SetActive(true);
        }
    }

    void MaterialUIUpdate()
    {
        if(materialStateEnum == materialState.Plastic)
        {
            plasticIdleUI.SetActive(true);
            GlassIdleUI.SetActive(false);
            PaperIdleUI.SetActive(false);
            MetalIdleUI.SetActive(false);

            plasticButtonImage.color = selectedColor;
            glassButtonImage.color = Color.white;
            paperButtonImage.color = Color.white;
            metalButtonImage.color = Color.white;
        }
        else if (materialStateEnum == materialState.Glass)
        {
            plasticIdleUI.SetActive(false);
            GlassIdleUI.SetActive(true);
            PaperIdleUI.SetActive(false);
            MetalIdleUI.SetActive(false);

            plasticButtonImage.color = Color.white;
            glassButtonImage.color = selectedColor;
            paperButtonImage.color = Color.white;
            metalButtonImage.color = Color.white;
        }
        else if (materialStateEnum == materialState.Paper)
        {
            plasticIdleUI.SetActive(false);
            GlassIdleUI.SetActive(false);
            PaperIdleUI.SetActive(true);
            MetalIdleUI.SetActive(false);

            plasticButtonImage.color = Color.white;
            glassButtonImage.color = Color.white;
            paperButtonImage.color = selectedColor;
            metalButtonImage.color = Color.white;
        }
        else if (materialStateEnum == materialState.Metal)
        {
            plasticIdleUI.SetActive(false);
            GlassIdleUI.SetActive(false);
            PaperIdleUI.SetActive(false);
            MetalIdleUI.SetActive(true);

            plasticButtonImage.color = Color.white;
            glassButtonImage.color = Color.white;
            paperButtonImage.color = Color.white;
            metalButtonImage.color = selectedColor;
        }
    }

    void ToolsUIUpdate()
    {
        //Plastic Tools

            if (ToolsManager.instance.isPlasticStrawTool)
            {
                plasticStrawTool.SetActive(true);
                noneText.SetActive(false);
            }
            else
            {
                plasticStrawTool.SetActive(false);
                noneText.SetActive(true);
            }

            if (ToolsManager.instance.isPlasticBottlesTool)
            {
                plasticBottleTool.SetActive(true);
            }
            else
            {
                plasticBottleTool.SetActive(false);
            }

            if (ToolsManager.instance.isPlasticBagsTool)
            {
                plasticBagTool.SetActive(true);
            }
            else
            {
                plasticBagTool.SetActive(false);
            }

            if (ToolsManager.instance.isPlasticToysTool)
            {
                plasticToyTool.SetActive(true);
            }
            else
            {
                plasticToyTool.SetActive(false);
            }

            if (ToolsManager.instance.isPlasticFurnitureTool)
            {
                plasticFurnitureTool.SetActive(true);
            }
            else
            {
                plasticFurnitureTool.SetActive(false);
            }

        //Glass

        if (ToolsManager.instance.isglassBottlesTool)
        {
            glasBottlesTool.SetActive(true);
        }
        else
        {
            glasBottlesTool.SetActive(false);
        }

        if (ToolsManager.instance.isglassJarsTool)
        {
            glassJarTool.SetActive(true);
        }
        else
        {
            glassJarTool.SetActive(false);
        }

        if (ToolsManager.instance.isglassPlatesTool)
        {
            glassPlatesTool.SetActive(true);
        }
        else
        {
            glassPlatesTool.SetActive(false);
        }

        if (ToolsManager.instance.isglassAccessoriesTool)
        {
            GlassAccesoriesTool.SetActive(true);
        }
        else
        {
            GlassAccesoriesTool.SetActive(false);
        }

        if (ToolsManager.instance.isglassBulbsTool)
        {
            GlassBulbsTool.SetActive(true);
        }
        else
        {
            GlassBulbsTool.SetActive(false);
        }


    }

    void IdleMaterialUnlockedByLevel()
    {
        if (LevelManager.instance.idleLevel == 0)
        {

        }
        else if (LevelManager.instance.idleLevel == 1)
        {

        }
        else if (LevelManager.instance.idleLevel == 2)
        {

        }
        else if (LevelManager.instance.idleLevel == 3)
        {
            glassButton.interactable = true;
        }
        else if (LevelManager.instance.idleLevel == 4)
        {
            glassButton.interactable = true;
        }
        else if (LevelManager.instance.idleLevel == 5)
        {
            glassButton.interactable = true;
        }
        else if (LevelManager.instance.idleLevel == 6)
        {
            glassButton.interactable = true;
            paperButton.interactable = true;
        }
        else if (LevelManager.instance.idleLevel == 7)
        {
            glassButton.interactable = true;
            paperButton.interactable = true;
        }
        else if (LevelManager.instance.idleLevel == 8)
        {
            glassButton.interactable = true;
            paperButton.interactable = true;
        }
        else if (LevelManager.instance.idleLevel == 9)
        {
            glassButton.interactable = true;
            paperButton.interactable = true;
            metalButton.interactable = true;
        }
        else if (LevelManager.instance.idleLevel == 10)
        {
            glassButton.interactable = true;
            paperButton.interactable = true;
            metalButton.interactable = true;
        }
    }

    public void MainMenuButtonEvent()
    {
        menuStateEnum = menuState.IdleMenu;
    }

    public void MinigamesMenuButtonEvent()
    {
        menuStateEnum = menuState.Minigames;
    }

    public void ToolsMenuButtonEvent()
    {
        menuStateEnum = menuState.Tools;
    }

    // Material Change Functions
    public void MaterialChangePlastic()
    {
        materialStateEnum = materialState.Plastic;
    }

    public void MaterialChangeGlass()
    {
        materialStateEnum = materialState.Glass;
    }

    public void MaterialChangePaper()
    {
        materialStateEnum = materialState.Paper;
    }

    public void MaterialChangeMetal()
    {
        materialStateEnum = materialState.Metal;
    }
}
