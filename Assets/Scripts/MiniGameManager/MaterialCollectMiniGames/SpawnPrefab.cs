using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPrefab : MonoBehaviour
{
    private Vector3 nextSpawnPoint;
    [SerializeField] private GameObject mapPrefab;
    void Start()
    {
        nextSpawnPoint = gameObject.transform.position;
        nextSpawnPoint.y += -57;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            Instantiate(mapPrefab, nextSpawnPoint, Quaternion.identity);
        }
    }
}
