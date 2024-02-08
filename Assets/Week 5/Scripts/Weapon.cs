using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    public float weaponSpeed = 0.3f;
    Rigidbody2D rigidbody;
    float timePassed = 0f;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

        timePassed += Time.deltaTime;
        if (timePassed >= 4f)
        {
            Destroy(gameObject);
            timePassed = 0f;
        }


    }
    private void FixedUpdate()
    {
        Vector2 direction = new Vector2(weaponSpeed * Time.deltaTime, 0);
        rigidbody.MovePosition(rigidbody.position + direction * Time . deltaTime);

        transform.Translate(-weaponSpeed,0 ,0);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.SendMessage("TakeDamage", 1, SendMessageOptions.DontRequireReceiver);
        Destroy(gameObject);
    }
}
