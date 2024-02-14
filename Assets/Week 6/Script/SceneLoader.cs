using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{





    public void LoadNextScene()
    {
        //this line is to keep track of which scene we are on
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        //this line is to make sure that the scene number doesn't go to high
        int nextSceneIndex = (currentSceneIndex + 1) % SceneManager.sceneCountInBuildSettings;

        //this line is to load a scene
        SceneManager.LoadScene(nextSceneIndex);

    }







    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
