using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalkeeperController : MonoBehaviour
{

    Rigidbody2D rigidbody;
    public GameObject goalKeeper;
    Vector2 direction;
    public float maxDistance = 3;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = goalKeeper.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

            direction = (Controller.CurrentSelection.transform.position - transform.position).normalized;

        if (Vector3.Distance(Controller.CurrentSelection.transform.position, transform.position) < maxDistance * 2)
        {
            goalKeeper.transform.position = transform.position + (Vector3)(Vector3.Distance(Controller.CurrentSelection.transform.position, transform.position) /2 * direction);
        }
        else
        {
            goalKeeper.transform.position = transform.position + (Vector3)(maxDistance * direction);
        }

    }
}
