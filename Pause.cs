﻿using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour
{

    [SerializeField]
    //　ポーズした時に表示するUI
    private GameObject pauseUI;
    //　ポーズUIのインスタンス
    private GameObject instancePauseUI;
    void start() { 
    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("p"))
        {
            if (instancePauseUI == null)
            {
                instancePauseUI = GameObject.Instantiate(pauseUI) as GameObject;
                Time.timeScale = 0f;
            }
            else
            {
                Destroy(instancePauseUI);
                Time.timeScale = 1f;
            }
        }
    }
}
