using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Bomb : MonoBehaviour
{
    Vector3 mouseDirection;


    Vector2 currentPosition;
    Vector2 direction;
    


    // Start is called before the first frame update
    void Start()
    {
       //direction.x =  Random.Range(0, 100);
       //direction.y = Random.Range(0, 100);

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void FixedUpdate()
    {
       //transform.Translate(direction);
    }








    //This section is to allow dragging bombs  \/

    //This method is to return current mouse position
    private Vector3 MousePosition()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    
    private void OnMouseDown()
    {
        mouseDirection = gameObject.transform.position - MousePosition();
    }




    private void OnMouseDrag()
    {
        transform.position = MousePosition() + mouseDirection;
    }

}



