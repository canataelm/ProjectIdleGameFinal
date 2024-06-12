using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewIdleUpgradeButton : MonoBehaviour
{
    [Header("Plastic")]
    [SerializeField] bool isPlasticplasticStraws;
    [SerializeField] bool isPlasticBottles;
    [SerializeField] bool isPlasticBags;
    [SerializeField] bool isPlasticToys;
    [SerializeField] bool isPlasticFurniture;
    [Header("Glass")]
    [SerializeField] bool isGlassBottles;
    [SerializeField] bool isGlassJars;
    [SerializeField] bool isGlassPlates;
    [SerializeField] bool isGlassAccesories;
    [SerializeField] bool isGlassBulbs;
    [Header("Paper")]
    [SerializeField] bool isPaperNotes;
    [SerializeField] bool isPaperPages;
    [SerializeField] bool isPaperBrochures;
    [SerializeField] bool isPaperNewspapers;
    [SerializeField] bool isPaperBooks;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpgradeMaterialEarn()
    {
        //Plastic

        if (isPlasticplasticStraws)
        {
            if (GameManagerNewIdle.Instance.plasticCount >= GameManagerNewIdle.Instance.plasticStrawsCost)
            {
                GameManagerNewIdle.Instance.plasticStrawsCount = GameManagerNewIdle.Instance.plasticStrawsCount + 1;

                GameManagerNewIdle.Instance.plasticCount = GameManagerNewIdle.Instance.plasticCount - GameManagerNewIdle.Instance.plasticStrawsCost;
            }
        }
        else if (isPlasticBottles)
        {
            if (GameManagerNewIdle.Instance.plasticCount >= GameManagerNewIdle.Instance.plasticBottlesCost)
            {
                GameManagerNewIdle.Instance.plasticBottlesCount = GameManagerNewIdle.Instance.plasticBottlesCount + 1;

                GameManagerNewIdle.Instance.plasticCount = GameManagerNewIdle.Instance.plasticCount - GameManagerNewIdle.Instance.plasticBottlesCost;
            }
        }
        else if (isPlasticBags)
        {
            if (GameManagerNewIdle.Instance.plasticCount >= GameManagerNewIdle.Instance.plasticBagsCost)
            {
                GameManagerNewIdle.Instance.plasticBagsCount = GameManagerNewIdle.Instance.plasticBagsCount + 1;

                GameManagerNewIdle.Instance.plasticCount = GameManagerNewIdle.Instance.plasticCount - GameManagerNewIdle.Instance.plasticBagsCost;
            }
        }
        else if (isPlasticToys)
        {
            if (GameManagerNewIdle.Instance.plasticCount >= GameManagerNewIdle.Instance.plasticToysCost)
            {
                GameManagerNewIdle.Instance.plasticToysCount = GameManagerNewIdle.Instance.plasticToysCount + 1;

                GameManagerNewIdle.Instance.plasticCount = GameManagerNewIdle.Instance.plasticCount - GameManagerNewIdle.Instance.plasticToysCost;
            }
        }
        else if (isPlasticFurniture)
        {
            if (GameManagerNewIdle.Instance.plasticCount >= GameManagerNewIdle.Instance.plasticFurnitureCost)
            {
                GameManagerNewIdle.Instance.plasticFurnitureCount = GameManagerNewIdle.Instance.plasticFurnitureCount + 1;

                GameManagerNewIdle.Instance.plasticCount = GameManagerNewIdle.Instance.plasticCount - GameManagerNewIdle.Instance.plasticFurnitureCost;
            }
        }

        //Glass

        if (isGlassBottles)
        {
            if (GameManagerNewIdle.Instance.glassCount >= GameManagerNewIdle.Instance.glassBottlesCost)
            {
                GameManagerNewIdle.Instance.glassBottlesCount = GameManagerNewIdle.Instance.glassBottlesCount + 1;

                GameManagerNewIdle.Instance.glassCount = GameManagerNewIdle.Instance.glassCount - GameManagerNewIdle.Instance.glassBottlesCost;
            }
        }
        else if (isGlassJars)
        {
            if (GameManagerNewIdle.Instance.glassCount >= GameManagerNewIdle.Instance.glassJarsCost)
            {
                GameManagerNewIdle.Instance.glassJarsCount = GameManagerNewIdle.Instance.glassJarsCount + 1;

                GameManagerNewIdle.Instance.glassCount = GameManagerNewIdle.Instance.glassCount - GameManagerNewIdle.Instance.glassJarsCost;
            }
        }
        else if (isGlassPlates)
        {
            if (GameManagerNewIdle.Instance.glassCount >= GameManagerNewIdle.Instance.glassPlatesCost)
            {
                GameManagerNewIdle.Instance.glassPlatesCount = GameManagerNewIdle.Instance.glassPlatesCount + 1;

                GameManagerNewIdle.Instance.glassCount = GameManagerNewIdle.Instance.glassCount - GameManagerNewIdle.Instance.glassPlatesCost;
            }
        }
        else if (isGlassAccesories)
        {
            if (GameManagerNewIdle.Instance.glassCount >= GameManagerNewIdle.Instance.glassAccessoriesCost)
            {
                GameManagerNewIdle.Instance.glassAccessoriesCount = GameManagerNewIdle.Instance.glassAccessoriesCount + 1;

                GameManagerNewIdle.Instance.glassCount = GameManagerNewIdle.Instance.glassCount - GameManagerNewIdle.Instance.glassAccessoriesCost;
            }
        }
        else if (isGlassBulbs)
        {
            if (GameManagerNewIdle.Instance.glassCount >= GameManagerNewIdle.Instance.glassBulbsCost)
            {
                GameManagerNewIdle.Instance.glassBulbsCount = GameManagerNewIdle.Instance.glassBulbsCount + 1;

                GameManagerNewIdle.Instance.glassCount = GameManagerNewIdle.Instance.glassCount - GameManagerNewIdle.Instance.glassBulbsCost;
            }
        }

        //Paper

        if (isPaperNotes)
        {
            if (GameManagerNewIdle.Instance.paperCount >= GameManagerNewIdle.Instance.paperNotePapersCost)
            {
                GameManagerNewIdle.Instance.paperNotePapersCount = GameManagerNewIdle.Instance.paperNotePapersCount + 1;

                GameManagerNewIdle.Instance.paperCount = GameManagerNewIdle.Instance.paperCount - GameManagerNewIdle.Instance.paperNotePapersCost;
            }
        }
        else if (isPaperPages)
        {
            if (GameManagerNewIdle.Instance.paperCount >= GameManagerNewIdle.Instance.paperPagesCost)
            {
                GameManagerNewIdle.Instance.paperPagesCount = GameManagerNewIdle.Instance.paperPagesCount + 1;

                GameManagerNewIdle.Instance.paperCount = GameManagerNewIdle.Instance.paperCount - GameManagerNewIdle.Instance.paperPagesCost;
            }
        }
        else if (isPaperBrochures)
        {
            if (GameManagerNewIdle.Instance.paperCount >= GameManagerNewIdle.Instance.paperBrochuresCost)
            {
                GameManagerNewIdle.Instance.paperBrochuresCount = GameManagerNewIdle.Instance.paperBrochuresCount + 1;

                GameManagerNewIdle.Instance.paperCount = GameManagerNewIdle.Instance.paperCount - GameManagerNewIdle.Instance.paperBrochuresCost;
            }
        }
        else if (isPaperNewspapers)
        {
            if (GameManagerNewIdle.Instance.paperCount >= GameManagerNewIdle.Instance.paperANewspapersCost)
            {
                GameManagerNewIdle.Instance.paperNewspapersCount = GameManagerNewIdle.Instance.paperNewspapersCount + 1;

                GameManagerNewIdle.Instance.paperCount = GameManagerNewIdle.Instance.paperCount - GameManagerNewIdle.Instance.paperANewspapersCost;
            }
        }
        else if (isPaperBooks)
        {
            if (GameManagerNewIdle.Instance.paperCount >= GameManagerNewIdle.Instance.paperBookCost)
            {
                GameManagerNewIdle.Instance.paperBookCount = GameManagerNewIdle.Instance.paperBookCount + 1;

                GameManagerNewIdle.Instance.paperCount = GameManagerNewIdle.Instance.paperCount - GameManagerNewIdle.Instance.paperBookCost;
            }
        }
    }
}
