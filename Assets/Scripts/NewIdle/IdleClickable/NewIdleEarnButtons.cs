using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewIdleEarnButtons : MonoBehaviour
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
    [SerializeField] bool isGlassAcsesories;
    [SerializeField] bool isGlassBulb;
    [Header("Paper")]
    [SerializeField] bool isPaperNotes;
    [SerializeField] bool isPaperPages;
    [SerializeField] bool isPaperBrochures;
    [SerializeField] bool isPaperNewspapers;
    [SerializeField] bool isPaperBooks;

    [SerializeField] TMP_Text plasticsEarnText;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Plastic

        if (isPlasticplasticStraws)
        {
            plasticsEarnText.text =  "+" + GameManagerNewIdle.Instance.plasticStrawsCount * 1;
        }
        else if (isPlasticBottles)
        {
            plasticsEarnText.text = "+" + GameManagerNewIdle.Instance.plasticBottlesCount * 5;
        }
        else if (isPlasticBags)
        {
            plasticsEarnText.text = "+" + GameManagerNewIdle.Instance.plasticBagsCount * 25;
        }
        else if (isPlasticToys)
        {
            plasticsEarnText.text = "+" + GameManagerNewIdle.Instance.plasticToysCount * 125;
        }
        else if (isPlasticFurniture)
        {
            plasticsEarnText.text = "+" + GameManagerNewIdle.Instance.plasticFurnitureCount * 625;
        }

        //Glass

        if (isGlassBottles)
        {
            plasticsEarnText.text = "+" + GameManagerNewIdle.Instance.glassBottlesCount * 1;
        }
        else if (isGlassJars)
        {
            plasticsEarnText.text = "+" + GameManagerNewIdle.Instance.glassJarsCount * 5;
        }
        else if (isGlassPlates)
        {
            plasticsEarnText.text = "+" + GameManagerNewIdle.Instance.glassPlatesCost * 25;
        }
        else if (isGlassAcsesories)
        {
            plasticsEarnText.text = "+" + GameManagerNewIdle.Instance.glassAccessoriesCount * 125;
        }
        else if (isGlassBulb)
        {
            plasticsEarnText.text = "+" + GameManagerNewIdle.Instance.glassBulbsCount * 625;
        }

        //Paper

        if (isPaperNotes)
        {
            plasticsEarnText.text = "+" + GameManagerNewIdle.Instance.paperNotePapersCount * 1;
        }
        else if (isPaperPages)
        {
            plasticsEarnText.text = "+" + GameManagerNewIdle.Instance.paperPagesCount * 5;
        }
        else if (isPaperBrochures)
        {
            plasticsEarnText.text = "+" + GameManagerNewIdle.Instance.paperBrochuresCount * 25;
        }
        else if (isPaperNewspapers)
        {
            plasticsEarnText.text = "+" + GameManagerNewIdle.Instance.paperNewspapersCount * 125;
        }
        else if (isPaperBooks)
        {
            plasticsEarnText.text = "+" + GameManagerNewIdle.Instance.paperBookCount * 625;
        }
    }

    public void EarnMaterials()
    {
        //Plastic

        if (isPlasticplasticStraws)
        {
            GameManagerNewIdle.Instance.plasticCount = GameManagerNewIdle.Instance.plasticCount + (GameManagerNewIdle.Instance.plasticStrawsCount * 1);
        }
        else if (isPlasticBottles)
        {
            GameManagerNewIdle.Instance.plasticCount = GameManagerNewIdle.Instance.plasticCount + (GameManagerNewIdle.Instance.plasticBottlesCount * 5);
        }
        else if (isPlasticBags)
        {
            GameManagerNewIdle.Instance.plasticCount = GameManagerNewIdle.Instance.plasticCount + (GameManagerNewIdle.Instance.plasticBagsCount * 25);
        }
        else if (isPlasticToys)
        {
            GameManagerNewIdle.Instance.plasticCount = GameManagerNewIdle.Instance.plasticCount + (GameManagerNewIdle.Instance.plasticToysCount * 125);
        }
        else if (isPlasticFurniture)
        {
            GameManagerNewIdle.Instance.plasticCount = GameManagerNewIdle.Instance.plasticCount + (GameManagerNewIdle.Instance.plasticFurnitureCount * 625);
        }

        //Glass

        if (isGlassBottles)
        {
            GameManagerNewIdle.Instance.glassCount = GameManagerNewIdle.Instance.glassCount + (GameManagerNewIdle.Instance.glassBottlesCount * 1);
        }
        else if (isGlassJars)
        {
            GameManagerNewIdle.Instance.glassCount = GameManagerNewIdle.Instance.glassCount + (GameManagerNewIdle.Instance.glassJarsCount * 5);
        }
        else if (isGlassPlates)
        {
            GameManagerNewIdle.Instance.glassCount = GameManagerNewIdle.Instance.glassCount + (GameManagerNewIdle.Instance.glassPlatesCount * 25);
        }
        else if (isGlassAcsesories)
        {
            GameManagerNewIdle.Instance.glassCount = GameManagerNewIdle.Instance.glassCount + (GameManagerNewIdle.Instance.glassAccessoriesCount * 125);
        }
        else if (isGlassBulb)
        {
            GameManagerNewIdle.Instance.glassCount = GameManagerNewIdle.Instance.glassCount + (GameManagerNewIdle.Instance.glassBulbsCount * 625);
        }

        //Paper

        if (isPaperNotes)
        {
            GameManagerNewIdle.Instance.paperCount = GameManagerNewIdle.Instance.paperCount + (GameManagerNewIdle.Instance.paperNotePapersCount * 1);
        }
        else if (isPaperPages)
        {
            GameManagerNewIdle.Instance.paperCount = GameManagerNewIdle.Instance.paperCount + (GameManagerNewIdle.Instance.paperPagesCount * 5);
        }
        else if (isPaperBrochures)
        {
            GameManagerNewIdle.Instance.paperCount = GameManagerNewIdle.Instance.paperCount + (GameManagerNewIdle.Instance.paperBrochuresCount * 25);
        }
        else if (isPaperNewspapers)
        {
            GameManagerNewIdle.Instance.paperCount = GameManagerNewIdle.Instance.paperCount + (GameManagerNewIdle.Instance.paperNewspapersCount * 125);
        }
        else if (isPaperBooks)
        {
            GameManagerNewIdle.Instance.paperCount = GameManagerNewIdle.Instance.paperCount + (GameManagerNewIdle.Instance.paperBookCount * 625);
        }
    }
}
