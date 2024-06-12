using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GatherableMaterial : MonoBehaviour
{
    [Header("Which Material")]
    [SerializeField] private bool isPlasticMaterial;
    [SerializeField] private bool isGlassMaterial;
    [SerializeField] private bool isPaperMaterial;
    [SerializeField] private bool isMetalMaterial;
    [Space]
    [Header("Image")]
    [SerializeField] private Sprite plasticImage;
    [SerializeField] private Sprite glassImage;
    [SerializeField] private Sprite paperImage;
    [SerializeField] private Sprite metalImage;


    private int plasticValue;
    private int glassValue;
    private int paperValue;
    private int metalValue;

    void Start()
    {
        ValueDefination();
        ImageChange();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            if (isPlasticMaterial)
            {
                MaterialManage.instance.earnedPlastic = MaterialManage.instance.earnedPlastic + plasticValue;
                GameManagerNewIdle.Instance.totalGatheredPlastic = GameManagerNewIdle.Instance.totalGatheredPlastic + plasticValue;
                Destroy(gameObject);
            }
            if (isGlassMaterial)
            {
                MaterialManage.instance.earnedGlass = MaterialManage.instance.earnedGlass + glassValue;
                GameManagerNewIdle.Instance.totalGatheredGlass = GameManagerNewIdle.Instance.totalGatheredGlass + glassValue;
                Destroy(gameObject);
            }
            if (isPaperMaterial)
            {
                MaterialManage.instance.earnedPaper = MaterialManage.instance.earnedPaper + paperValue;
                GameManagerNewIdle.Instance.totalGatheredPaper = GameManagerNewIdle.Instance.totalGatheredPaper + paperValue;
                Destroy(gameObject);
            }
            if (isMetalMaterial)
            {
                MaterialManage.instance.earnedMetal = MaterialManage.instance.earnedMetal + metalValue;
                GameManagerNewIdle.Instance.totalGatheredMetal = GameManagerNewIdle.Instance.totalGatheredMetal + metalValue;
                Destroy(gameObject);
            }
        }
    }

    void ImageChange()
    {
        if (isPlasticMaterial)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = plasticImage;
        }
        if (isGlassMaterial)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = glassImage;
        }
        if (isPaperMaterial)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = paperImage;
        }
        if (isMetalMaterial)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = metalImage;
        }

    }

    void ValueDefination()
    {
        if (LevelManager.instance.idleLevel == 0)
        {
            plasticValue = 100;
            glassValue = 100;
            paperValue = 100;
            metalValue = 100;
        }
        else if (LevelManager.instance.idleLevel == 1)
        {
            plasticValue = 200;
            glassValue = 200;
            paperValue = 200;
            metalValue = 200;
        }
        else if (LevelManager.instance.idleLevel == 2)
        {
            plasticValue = 400;
            glassValue = 400;
            paperValue = 400;
            metalValue = 400;
        }
        else if(LevelManager.instance.idleLevel == 3)
        {
            plasticValue = 800;
            glassValue = 800;
            paperValue = 800;
            metalValue = 800;
        }
        else if(LevelManager.instance.idleLevel == 4)
        {
            plasticValue = 1600;
            glassValue = 1600;
            paperValue = 1600;
            metalValue = 1600;
        }
        else if(LevelManager.instance.idleLevel == 5)
        {
            plasticValue = 3200;
            glassValue = 3200;
            paperValue = 3200;
            metalValue = 3200;
        }
        else if(LevelManager.instance.idleLevel == 6)
        {
            plasticValue = 6400;
            glassValue = 6400;
            paperValue = 6400;
            metalValue = 6400;
        }
        else if(LevelManager.instance.idleLevel == 7)
        {
            plasticValue = 12800;
            glassValue = 12800;
            paperValue = 12800;
            metalValue = 12800;
        }
        else if(LevelManager.instance.idleLevel == 8)
        {
            plasticValue = 25600;
            glassValue = 25600;
            paperValue = 25600;
            metalValue = 25600;
        }
        else if (LevelManager.instance.idleLevel == 9)
        {
            plasticValue = 51200;
            glassValue = 51200;
            paperValue = 51200;
            metalValue = 51200;
        }
        else if (LevelManager.instance.idleLevel == 10)
        {
            plasticValue = 124000;
            glassValue = 124000;
            paperValue = 124000;
            metalValue = 124000;
        }
    }
}
