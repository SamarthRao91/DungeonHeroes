using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnClickEvent : MonoBehaviour
{
    public string goTo;

   public void ChangeScene()
    {
        SceneManager.LoadScene(goTo);
    }

}
