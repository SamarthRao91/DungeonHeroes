using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public GameObject player;
    public GameObject player1;


    // Start is called before the first frame update
   public void DoJump()
    {
       
        player.GetComponent<Rigidbody2D>().velocity += new Vector2(0, 5f);
        player1.GetComponent<Rigidbody2D>().velocity += new Vector2(0, 5f);
    }
}
