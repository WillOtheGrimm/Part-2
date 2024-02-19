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
    public float speed = 0.05f;
    Animator animator;
    float deathTimer;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        direction.x = Random.Range(-100, 100);
        direction.y = Random.Range(0, 100);

    }

    // Update is called once per frame
    void Update()
    {
        deathTimer += Time.deltaTime;


        if (deathTimer >= 8f)
        {
            BombExplode();
            deathTimer = 0;
        }

    }


    private void FixedUpdate()
    {
        transform.Translate(direction.normalized * speed);
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


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("THis is collision");
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        direction *= -1;

    }



    //This section is for the bomb death timer / animation

    private void BombExplode()
    {
        animator.SetTrigger("Explode");
        Destroy(gameObject, 0.55f);

    }





}



