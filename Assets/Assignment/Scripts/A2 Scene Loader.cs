using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class A2SceneLoader : MonoBehaviour
{
   
    public void GameLoader() 
    {
        SceneManager.LoadScene("Main Game");
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Title Screen");
    }
}
