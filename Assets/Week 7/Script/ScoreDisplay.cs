using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class ScoreDisplay : MonoBehaviour
{
    public static TextMeshProUGUI scoreShowcase;

    void Start()
    {
        scoreShowcase = gameObject.GetComponent<TextMeshProUGUI>();
            
    }



  
}
