using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManagerSaveBall : MonoBehaviour
{
    public static GameManagerSaveBall instance;
    private int score;
    [SerializeField] private TMP_Text scoreBoard;
    public bool gameStarted = false;
    public GameObject gameStartUI;
    public GameObject dieUI;

    [SerializeField] private TextMeshProUGUI[] plasticGatheredText;
    [SerializeField] private TextMeshProUGUI[] glassGatheredText;
    [SerializeField] private TextMeshProUGUI[] paperGatheredText;
    [SerializeField] private TextMeshProUGUI[] metalGatheredText;

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
        UpdateGatheredMaterialUI();
    }

    public void GameStart()
    {
        gameStartUI.SetActive(false);
        scoreBoard.gameObject.SetActive(true);
    }
    public void Die()
    {
        dieUI.SetActive(true);
        Time.timeScale = 0;
    }
    public void Restart()
    {
        SceneManager.LoadScene("BallSaver");
    }

    public void ScoreUp()
    {
        score++;
        scoreBoard.text = "O2 : " + score;
    }

    private void UpdateGatheredMaterialUI()
    {
        foreach (TextMeshProUGUI i in plasticGatheredText)
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

    public void AddGainedMaterial()
    {
        GameManagerNewIdle.Instance.plasticCount = GameManagerNewIdle.Instance.plasticCount + GameManagerNewIdle.Instance.totalGatheredPlastic;
        GameManagerNewIdle.Instance.glassCount = GameManagerNewIdle.Instance.glassCount + GameManagerNewIdle.Instance.totalGatheredGlass;
        GameManagerNewIdle.Instance.paperCount = GameManagerNewIdle.Instance.paperCount + GameManagerNewIdle.Instance.totalGatheredPaper;
        GameManagerNewIdle.Instance.metalCount = GameManagerNewIdle.Instance.metalCount + GameManagerNewIdle.Instance.totalGatheredMetal;
    }
}
