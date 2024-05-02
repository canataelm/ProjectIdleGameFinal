using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] private int howMuchEnemy;
    [SerializeField] private GameObject enemyObject;
    [SerializeField] private List<GameObject> gameObjectsList; // Karýþtýrýlacak GameObject listesi
    private float timer = 0;
    void Start()
    {
        Shuffle(gameObjectsList);
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if(timer >= 5)
        {
            for (int i = 0; i < howMuchEnemy; i++)
            {
                GameObject obj = gameObjectsList[i];
                Instantiate(enemyObject, obj.transform);
            }
            timer = 0;
            Shuffle(gameObjectsList);
        }
    }

    void Shuffle<T>(List<T> list)
    {
        System.Random rng = new System.Random();
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }
}
