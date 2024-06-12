using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGolfMainMenuManager : MonoBehaviour
{
    public static MiniGolfMainMenuManager instance;

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
        
    }

    public void LoadLevel(string LevelName)
    {
        SceneManager.LoadSceneAsync(LevelName);
    }
}
