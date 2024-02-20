using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleBombs : MonoBehaviour
{

    public float speed = 1;
  
    void Update()
    {
        transform.Translate(speed * Time.deltaTime , 0 , 0);
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}
