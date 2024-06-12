using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManagerBlockDodge : MonoBehaviour
{
    public static GameManagerBlockDodge instance;
    [SerializeField] private GameObject block;
    [SerializeField] private float maxX;
    [SerializeField] Transform spawnPoint;
    [SerializeField] float spawnRate;
    [SerializeField] GameObject[] startObjects;

    private int score;
    [SerializeField] TMP_Text scoreText;

    bool gameStarted = false;

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
        if (Input.GetMouseButtonDown(0) && !gameStarted)
        {
            StartSpawning();
            foreach(GameObject Item in startObjects)
            {
                Item.SetActive(false);
            }
            gameStarted = true;
        }

        scoreText.text = "Score: " + score;
    }

    private void StartSpawning()
    {
        InvokeRepeating("SpawnBlock", 0.5f, spawnRate);
    }

    private void SpawnBlock()
    {
        Vector3 spawnPos = spawnPoint.position;

        spawnPos.x = Random.Range(-maxX, maxX);

        Instantiate(block, spawnPos, Quaternion.identity);
        score++;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("BlockDodge");
    }
}
