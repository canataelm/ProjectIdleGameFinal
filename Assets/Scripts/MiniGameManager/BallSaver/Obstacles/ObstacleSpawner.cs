using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public static ObstacleSpawner instance;
    [SerializeField] private GameObject prefab;
    [SerializeField] private GameObject spawnFX;
    [SerializeField] private Transform[] spawnPoints;
    [HideInInspector] public bool isSpawnable = false;
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (isSpawnable)
        {
            StartCoroutine(Spawner());
        }
    }
    IEnumerator Spawner()
    {
        isSpawnable = false;
        int spawnPointNumber = Random.Range(0, spawnPoints.Length - 1);
        Instantiate(prefab, spawnPoints[spawnPointNumber]);
        Instantiate(spawnFX, spawnPoints[spawnPointNumber]);
        yield return new WaitForSecondsRealtime(2f);
        isSpawnable = true;
    }
}
