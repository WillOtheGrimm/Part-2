using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawner : MonoBehaviour
{

    public GameObject[] bombPrefabs = new GameObject[2];
    private GameObject bomb;
    float timePassed = 0;
    public GameObject hp;

    void Update()
    {
        timePassed += Time.deltaTime;
        if (timePassed >= 2f)
        {
            bomb = Instantiate(bombPrefabs[Random.Range(0, 2)]);
            bomb.GetComponent<Bomb>().hp = hp;

            bomb.transform.position = transform.position;
            timePassed = 0;
        }
    }
}
