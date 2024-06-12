using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -650f)
        {
            Destroy(gameObject);
        }
    }
}
