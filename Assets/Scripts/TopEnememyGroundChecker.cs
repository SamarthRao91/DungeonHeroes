using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopEnememyGroundChecker : MonoBehaviour
{
    public bool topChecker = false;
    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("ground"))
        {
            topChecker = true;
            
        }
        else
        {
            topChecker = false;
        }



    }
}
