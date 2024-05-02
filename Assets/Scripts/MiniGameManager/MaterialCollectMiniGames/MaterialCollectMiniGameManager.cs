using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialCollectMiniGameManager : MonoBehaviour
{
    [SerializeField] private float goOnSpeed = 1f;
    [SerializeField] private GameObject[] goOnObjects;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        foreach(GameObject objects in goOnObjects)
        {
            objects.transform.Translate(Vector2.down * goOnSpeed * Time.deltaTime);
        }
    }
}
