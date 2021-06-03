using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomEnemyGroundChecker : MonoBehaviour
{
    public bool bottomChecker = false;
    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("ground"))
        {
            bottomChecker = true;

        }
        else
        {
            bottomChecker = false;
        }



    }
}
