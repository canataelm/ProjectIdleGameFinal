using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadVariable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LoadGame();
        SaveGame();
        LoadGame();
    }

    // Update is called once per frame
    void Update()
    {
        
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
    }

    public void SaveGame()
    {
        //Main Materials
        PlayerPrefs.SetInt("plasticCount", GameManagerNewIdle.Instance.plasticCount);
        PlayerPrefs.SetInt("glassCount", GameManagerNewIdle.Instance.glassCount);
        PlayerPrefs.SetInt("paperCount", GameManagerNewIdle.Instance.paperCount);
        PlayerPrefs.SetInt("metalCount", GameManagerNewIdle.Instance.metalCount);

        //Level
        LevelManager.instance.idleLevel = PlayerPrefs.GetInt("idleLevel", 0);

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

    }
}
