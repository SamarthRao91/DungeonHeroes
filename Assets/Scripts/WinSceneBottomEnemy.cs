﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinSceneBottomEnemy : MonoBehaviour
{
    public bool amCollided = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("hero"))
        {
            amCollided = true;
            Debug.Log("true");
        }
        else
        {
            amCollided = false;
            Debug.Log(false);
        }
    }
}
