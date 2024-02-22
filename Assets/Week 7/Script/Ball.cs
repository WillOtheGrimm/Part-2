using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{



    Rigidbody2D rigidbody;
    public GameObject kickOffSpot;


    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();

    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) 
        {
            Scored();
        }
    }

    
    public void Scored()
    {
        Controller.score++;
        transform.position = kickOffSpot.transform.position;
        rigidbody.velocity = Vector2.zero;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Scored();
    }
}
