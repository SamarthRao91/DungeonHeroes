using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PuzzleScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject thingToHide;
    float timeLeft = 0.5f;
    public bool timerActivated;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timerActivated)
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft < 0)
            {
                thingToHide.SetActive(true);
            }
        }
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("enemy"))
        {
            Debug.Log("WE colided with the puzzle piece");
            thingToHide.SetActive(false);
            timerActivated = true;
        }
        

        
    }
}
