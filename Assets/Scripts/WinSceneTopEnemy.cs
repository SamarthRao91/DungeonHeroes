using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinSceneTopEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    public string goTo;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {

       
        if (collision.gameObject.CompareTag("hero") && FindObjectOfType<WinSceneBottomEnemy>().amCollided == true)
        {
            Debug.Log("tHE LEVEL was cCompleteD");
            
            SceneManager.LoadScene(goTo);
        }
    }

}
