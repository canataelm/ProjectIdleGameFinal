using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerNewIdle : MonoBehaviour
{
    private float timer;
    [SerializeField] private bool iscontinuedSaveActivated;

    public static GameManagerNewIdle Instance;
    [HideInInspector] public int plasticCount;
    [HideInInspector] public int glassCount;
    [HideInInspector] public int paperCount;
    [HideInInspector] public int metalCount;

    //Plastic Recycle

    [HideInInspector] public int plasticStrawsCount;
    [HideInInspector] public int plasticBottlesCount;
    [HideInInspector] public int plasticBagsCount;
    [HideInInspector] public int plasticToysCount;
    [HideInInspector] public int plasticFurnitureCount;

    [HideInInspector] public int plasticStrawsCost;
    [HideInInspector] public int plasticBottlesCost;
    [HideInInspector] public int plasticBagsCost;
    [HideInInspector] public int plasticToysCost;
    [HideInInspector] public int plasticFurnitureCost;

    //Glass Recycle

    [HideInInspector] public int glassBottlesCount;
    [HideInInspector] public int glassJarsCount;
    [HideInInspector] public int glassPlatesCount;
    [HideInInspector] public int glassAccessoriesCount;
    [HideInInspector] public int glassBulbsCount;

    [HideInInspector] public int glassBottlesCost;
    [HideInInspector] public int glassJarsCost;
    [HideInInspector] public int glassPlatesCost;
    [HideInInspector] public int glassAccessoriesCost;
    [HideInInspector] public int glassBulbsCost;

    //Paper Recycle

    [HideInInspector] public int paperNotePapersCount;
    [HideInInspector] public int paperPagesCount;
    [HideInInspector] public int paperBrochuresCount;
    [HideInInspector] public int paperNewspapersCount;
    [HideInInspector] public int paperBookCount;

    [HideInInspector] public int paperNotePapersCost;
    [HideInInspector] public int paperPagesCost;
    [HideInInspector] public int paperBrochuresCost;
    [HideInInspector] public int paperANewspapersCost;
    [HideInInspector] public int paperBookCost;

    [HideInInspector] public int totalGatheredPlastic;
    [HideInInspector] public int totalGatheredGlass;
    [HideInInspector] public int totalGatheredPaper;
    [HideInInspector] public int totalGatheredMetal;


    void Start()
    {
        Instance = this;
        LoadGame();
        SaveGame();

    }

    // Update is called once per frame
    void Update()
    {
        //Plastic Costs
        plasticStrawsCost = 100;
        plasticBottlesCost = 400;
        plasticBagsCost = 1800;
        plasticToysCost = 8500;
        plasticFurnitureCost = 40000;

        // Glass Costs
        glassBottlesCost = 150;
        glassJarsCost = 800;
        glassPlatesCost = 3600;
        glassAccessoriesCost = 17000;
        glassBulbsCost = 80000;

        // Paper Costs
        paperNotePapersCost = 300;
        paperPagesCost = 1600;
        paperBrochuresCost = 7200;
        paperANewspapersCost = 34000;
        paperBookCost = 160000;

       if (iscontinuedSaveActivated)
        {
            timer = Time.deltaTime + timer;
            if (timer < 1)
            {

            }
            else
            {
                SaveGame();
                timer = 0;
            }
        }
    }

    public void Restarter()
    {
        //Main Materials
        plasticCount = 0;
        glassCount = 0;
        paperCount = 0;
        metalCount = 0;

        //Plastic Items
        plasticStrawsCount = 1;
        plasticBottlesCount = 0;
        plasticBagsCount = 0;
        plasticToysCount = 0;
        plasticFurnitureCount = 0;

        //Glass Items
        glassBottlesCount = 1;
        glassJarsCount = 0;
        glassPlatesCount = 0;
        glassAccessoriesCount = 0;
        glassBulbsCount = 0;

        //Paper Items
        paperNotePapersCount = 1;
        paperPagesCount = 0;
        paperBrochuresCount = 0;
        paperNewspapersCount = 0;
        paperBookCount = 0;
    }

    public void LoadGame()
    {
        //Main Materials
        GameManagerNewIdle.Instance.plasticCount = PlayerPrefs.GetInt("plasticCount", 0);
        GameManagerNewIdle.Instance.glassCount = PlayerPrefs.GetInt("glassCount", 0);
        GameManagerNewIdle.Instance.paperCount = PlayerPrefs.GetInt("paperCount", 0);
        GameManagerNewIdle.Instance.metalCount = PlayerPrefs.GetInt("metalCount", 0);

        //Level
        LevelManager.instance.idleLevel = PlayerPrefs.GetInt("idleLevel", 0);

        ////Plastic Recycle
        GameManagerNewIdle.Instance.plasticStrawsCount = PlayerPrefs.GetInt("platicStrawsCount", 1);
        GameManagerNewIdle.Instance.plasticBottlesCount = PlayerPrefs.GetInt("plasticBottlesCount", 0);
        GameManagerNewIdle.Instance.plasticBagsCount = PlayerPrefs.GetInt("plasticBagCounts", 0);
        GameManagerNewIdle.Instance.plasticToysCount = PlayerPrefs.GetInt("plasticToysCount", 0);
        GameManagerNewIdle.Instance.plasticFurnitureCount = PlayerPrefs.GetInt("plasticFurnitureCount", 0);

        //Glass Recycle
        GameManagerNewIdle.Instance.glassBottlesCount = PlayerPrefs.GetInt("glassBottlesCount", 1);
        GameManagerNewIdle.Instance.glassJarsCount = PlayerPrefs.GetInt("glassJarsCount", 0);
        GameManagerNewIdle.Instance.glassPlatesCount = PlayerPrefs.GetInt("glassPlatesCount", 0);
        GameManagerNewIdle.Instance.glassAccessoriesCount = PlayerPrefs.GetInt("glassAccessoriesCount", 0);
        GameManagerNewIdle.Instance.glassBulbsCount = PlayerPrefs.GetInt("glassBulbsCount", 0);

        //Paper Recycle
        GameManagerNewIdle.Instance.paperNotePapersCount = PlayerPrefs.GetInt("paperNotePapersCount", 1);
        GameManagerNewIdle.Instance.paperPagesCount = PlayerPrefs.GetInt("paperPagesCount", 0);
        GameManagerNewIdle.Instance.paperBrochuresCount = PlayerPrefs.GetInt("paperBrochuresCount", 0);
        GameManagerNewIdle.Instance.paperNewspapersCount = PlayerPrefs.GetInt("paperNewspapersCount", 0);
        GameManagerNewIdle.Instance.paperBookCount = PlayerPrefs.GetInt("paperBookCount", 0);

        Debug.Log("Load Game");
    }

    public void SaveGame()
    {
        //Main Materials
        PlayerPrefs.SetInt("plasticCount", GameManagerNewIdle.Instance.plasticCount);
        PlayerPrefs.SetInt("glassCount", GameManagerNewIdle.Instance.glassCount);
        PlayerPrefs.SetInt("paperCount", GameManagerNewIdle.Instance.paperCount);
        PlayerPrefs.SetInt("metalCount", GameManagerNewIdle.Instance.metalCount);

        //Level
        PlayerPrefs.SetInt("idleLevel", LevelManager.instance.idleLevel);

        ////Plastic Recycle
        PlayerPrefs.SetInt("platicStrawsCount", GameManagerNewIdle.Instance.plasticStrawsCount);
        PlayerPrefs.SetInt("plasticBottlesCount", GameManagerNewIdle.Instance.plasticBottlesCount);
        PlayerPrefs.SetInt("plasticBagCounts", GameManagerNewIdle.Instance.plasticBagsCount);
        PlayerPrefs.SetInt("plasticToysCount", GameManagerNewIdle.Instance.plasticToysCount);
        PlayerPrefs.SetInt("plasticFurnitureCount", GameManagerNewIdle.Instance.plasticFurnitureCount);

        //Glass Recycle
        PlayerPrefs.SetInt("glassBottlesCount", GameManagerNewIdle.Instance.glassBottlesCount);
        PlayerPrefs.SetInt("glassJarsCount", GameManagerNewIdle.Instance.glassJarsCount);
        PlayerPrefs.SetInt("glassPlatesCount", GameManagerNewIdle.Instance.glassPlatesCount);
        PlayerPrefs.SetInt("glassAccessoriesCount", GameManagerNewIdle.Instance.glassAccessoriesCount);
        PlayerPrefs.SetInt("glassBulbsCount", GameManagerNewIdle.Instance.glassBulbsCount);

        //Paper Recycle
        PlayerPrefs.SetInt("paperNotePapersCount", GameManagerNewIdle.Instance.paperNotePapersCount);
        PlayerPrefs.SetInt("paperPagesCount", GameManagerNewIdle.Instance.paperPagesCount);
        PlayerPrefs.SetInt("paperBrochuresCount", GameManagerNewIdle.Instance.paperBrochuresCount);
        PlayerPrefs.SetInt("paperNewspapersCount", GameManagerNewIdle.Instance.paperNewspapersCount);
        PlayerPrefs.SetInt("paperBookCount", GameManagerNewIdle.Instance.paperBookCount);

        Debug.Log("Save Game");

    }
}
