using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : MonoBehaviour
{

    Rigidbody2D rb;
    Vector2 destination;
    Vector2 movement;
    public float speed = 3;
    Animator animator;
    bool clickingOnself = false;
    public float health;
    public float maxHealth = 5;
    bool isDead = false;
    public HealthBar healthBar;




    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody2D>(); 
       animator = GetComponent<Animator>();
        health = maxHealth;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
     movement = destination - (Vector2)transform.position;

        if (isDead) return;

        if (movement.magnitude < 0.1)
        {
            movement = Vector2.zero;
        }
        rb.MovePosition(rb.position + movement.normalized * speed * Time.deltaTime);



    }




    void Update()
    {
        if (isDead) return;
        if (Input.GetMouseButtonDown(0) && !clickingOnself)
        {
            destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

        animator.SetFloat("Movement", movement.magnitude);


        if (Input.GetMouseButtonDown (1))
        {
            animator.SetTrigger("Attack");
        }


    }

    private void OnMouseDown()
    {
        if (isDead) return;
        clickingOnself |= true;
        animator.SetTrigger("TakeDamage");
        SendMessage("TakeDamage", 1);


    }

    private void OnMouseUp()
    {
        clickingOnself &= false;
    }



    public void TakeDamage(float damage)
    {
        health -= damage;
        health = Mathf.Clamp(health, 0 , maxHealth);



        if(health <= 0)
        {
            animator.SetTrigger("Death");
            isDead = true;
        }
        else
        {
            animator.SetTrigger("TakeDamage");
            isDead = false;
        }



    }




}

