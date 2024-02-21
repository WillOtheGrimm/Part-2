using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootballPlayer : MonoBehaviour
{
    bool isSelected = false;
    Vector2 mouseLocation;
    public SpriteRenderer spriteRenderer;
    Rigidbody2D rigibody; 


    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rigibody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //mouseLocation = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Selected();
    }
    public void Selected()
    {
        if (isSelected == true) 
        {
            spriteRenderer.color = Color.green; 
        }
        else if (isSelected == false)
        {
            spriteRenderer.color= Color.red;
        }
       
    }


    private void OnMouseDown()
    {
        isSelected = true;
    }
         

    /*private void OnMouseUp()
    {
        isSelected = false;

    }*/

}
