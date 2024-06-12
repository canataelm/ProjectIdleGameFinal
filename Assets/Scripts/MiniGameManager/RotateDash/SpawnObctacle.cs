using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObctacle : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private Transform[] spawnPoints;
    [SerializeField] private bool isSpawnable = true;
    void Start()
    {

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
        Instantiate(prefab, spawnPoints[Random.Range(0, 19)]);
        yield return new WaitForSecondsRealtime(2f);
        isSpawnable = true;
    }
}
