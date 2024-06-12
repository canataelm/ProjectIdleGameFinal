using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StateManagerMiniGolf : MonoBehaviour
{
    public void LoadLevel(string LevelName)
    {
        SceneManager.LoadSceneAsync(LevelName, LoadSceneMode.Single);
    }

    public void ReloadLevel()
    {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
