using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManagerRotateDash : MonoBehaviour
{
    public static GameManagerRotateDash instance;

    public int score;

    [SerializeField] private GameObject scoreBar;
    [SerializeField] private TMP_Text scoreText;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        UpdateScoreBarRotation();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EndGame()
    {
        SceneManager.LoadScene("RotateDashMenu");
    }

    public void UpdateScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
    public void UpdateScoreBarRotation()
    {
        scoreBar.transform.rotation = Quaternion.Euler(0, 0, Random.Range(0f, 360f));
    }

}
