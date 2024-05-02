using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SpawnCollectible : MonoBehaviour
{
    [SerializeField] private int howMuchCollectible;
    [SerializeField] private GameObject collectibleObject;
    [SerializeField] private List<GameObject> gameObjectsList; // Karýþtýrýlacak GameObject listesi
    void Start()
    {
        Shuffle(gameObjectsList);
        for (int i = 0; i < howMuchCollectible; i++)
        {
            GameObject obj = gameObjectsList[i];
            Instantiate(collectibleObject, obj.transform);
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
