using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleRotateDash : MonoBehaviour
{
    [SerializeField] Transform startPoint; // Baþlangýç noktasý
    [SerializeField] Transform endPoint;   // Bitiþ noktasý
    private float speed = 100f;     // Cismin hýzý

    private Vector3 targetPosition;
    private bool movingToEnd = true;

    void Start()
    {
        targetPosition = endPoint.position;
    }

    void Update()
    {
        // Hedefe doðru hareket et
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        // Eðer hedefe ulaþýldýysa, yeni hedefi ayarla (diðer nokta) ve hareket yönünü deðiþtir
        if (transform.position == targetPosition)
        {
            if (movingToEnd)
            {
                targetPosition = startPoint.position;
                RandomSpeed();
            }
            else
            {
                targetPosition = endPoint.position;
                RandomSpeed();
            }
            movingToEnd = !movingToEnd;
        }
    }

    void RandomSpeed()
    {
        speed = Random.Range(100f, 300f);
    }
}
