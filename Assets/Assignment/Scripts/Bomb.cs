using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Bomb : MonoBehaviour
{
    Vector3 mouseDirection;
    Vector2 direction;
    public float speed = 0.04f;
    Animator animator;
    float deathTimer;
    float fadeTimer;
    public string correctGoalTag = "Red Goal";
    public string otherGoalTag = "Black Goal";
    Collider2D collider2D;
    public AnimationCurve fade;
    bool isInGoal = false;
    public GameObject hp;

    // Start is called before the first frame update
    void Start()
    {
        collider2D = GetComponent<Collider2D>();
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

        if (isInGoal == true)
        {
            fadeTimer += 0.1f * Time.deltaTime;
            float interpolation = fade.Evaluate(fadeTimer);
            if (transform.localScale.z < 0.1f)
            {
                Destroy(gameObject);
            }
            transform.localScale = Vector3.Lerp(Vector3.one, Vector3.zero, interpolation);
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
        collider2D.enabled = false;
    }




    private void OnMouseDrag()
    {
        transform.position = MousePosition() + mouseDirection;
    }

    private void OnMouseUp()
    {
        collider2D.enabled = true;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Barrier"))
        {
            direction *= -1;
        }

        if (collision.CompareTag(correctGoalTag))
        {
            isInGoal = true;
        }

        if (collision.CompareTag(otherGoalTag))
        {
            BombExplode();
        }

    }



    //This section is for the bomb death timer / animation

    private void BombExplode()
    {
        animator.SetTrigger("Explode");
        Destroy(gameObject, 0.55f);
        hp.SendMessage("Damage", 1, SendMessageOptions.DontRequireReceiver);

    }





}



