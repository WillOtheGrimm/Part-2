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
    public Color selectedColour;
    public Color unselectedColour;
    public float speed = 100;


    // Start is called before the first frame update
    void Start()
    {
        rigibody = GetComponent<Rigidbody2D>(); 
        spriteRenderer = GetComponent<SpriteRenderer>();
        Selected(false);
    }

    // Update is called once per frame
   
    public void Selected(bool isSelected)
    {
        if (isSelected ) 
        {
            spriteRenderer.color = selectedColour;
        }
        else 
        {
        spriteRenderer.color=unselectedColour;
        }
       
    }


    private void OnMouseDown()
    {
        Controller.SetCurrentSelection(this);
        isSelected = true;
    }
         

    public void Move(Vector2 direction)
    {
    rigibody.AddForce(direction *speed, ForceMode2D.Impulse);
    }

}
