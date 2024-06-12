using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class LevelManagerAndUIManager : MonoBehaviour
{
    public static LevelManagerAndUIManager main;

    [Header("References")]
    [SerializeField] private GameObject playerBall;
    [SerializeField] private TextMeshProUGUI strokeUI;
    [Space(10)]
    [SerializeField] private GameObject levelComplateUI;
    [SerializeField] private TextMeshProUGUI levelComplatedStrokeUI;
    [Space(10)]
    [SerializeField] private GameObject gameOverUI;
    [Space]
    [SerializeField] private TextMeshProUGUI[] plasticGatheredText;
    [SerializeField] private TextMeshProUGUI[] glassGatheredText;
    [SerializeField] private TextMeshProUGUI[] paperGatheredText;
    [SerializeField] private TextMeshProUGUI[] metalGatheredText;

    [Header("Attributes")]
    [SerializeField] private int maxStrokes;


    private int strokes;
    [HideInInspector] public bool outOfStrokes;
    [HideInInspector] public bool levelComplacated;

    private void Awake()
    {
        main = this;
    }
    void Start()
    {
        UpdateStrokeUI();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateGatheredMaterialUI();
    }
    private void UpdateStrokeUI()
    {
        strokeUI.text = strokes + "/" + maxStrokes;
    }

    public void IncraeseStroke()
    {
        strokes++;
        UpdateStrokeUI();

        if(strokes >= maxStrokes)
        {
            outOfStrokes = true;
        }
    }

    private void UpdateGatheredMaterialUI()
    {
        foreach(TextMeshProUGUI i in plasticGatheredText)
        {
            i.text = "" + GameManagerNewIdle.Instance.totalGatheredPlastic;
        }

        foreach (TextMeshProUGUI i in glassGatheredText)
        {
            i.text = "" + GameManagerNewIdle.Instance.totalGatheredGlass;
        }

        foreach (TextMeshProUGUI i in paperGatheredText)
        {
            i.text = "" + GameManagerNewIdle.Instance.totalGatheredPaper;
        }

        foreach (TextMeshProUGUI i in metalGatheredText)
        {
            i.text = "" + GameManagerNewIdle.Instance.totalGatheredMetal;
        }
    }

    public void levelComplate()
    {
        levelComplacated = true;

        levelComplatedStrokeUI.text = strokes > 1 ? "You potted in " + strokes + " strokes" : "You got a hole in one!";

        levelComplateUI.SetActive(true);
    }

    public void GameOver()
    {
        playerBall.SetActive(false);
        gameOverUI.SetActive(true);
    }
}
