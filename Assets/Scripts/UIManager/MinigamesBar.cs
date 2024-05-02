using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigamesBar : MonoBehaviour
{
    [SerializeField] GameObject minigamesBar;
    [SerializeField] private Animator animation;
    private bool open = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BarGoing()
    {
        if(!open)
        {
            animation.SetBool("Open", true);
            open = true;
        }
        else if(open)
        {
            animation.SetBool("Open", false);
            open = false;
        }
        
    }
}
