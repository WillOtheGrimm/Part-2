using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleBombSpawner : MonoBehaviour
{

    public GameObject bombs;
    float timePassed = 0;
    void Start()
    {
        SpawnBomb();
    }

    void Update()
    {
        timePassed += Time.deltaTime;
        if (timePassed >= 3f)
        {
            SpawnBomb();
            timePassed = 0;
        }
    }

    public void SpawnBomb()
    {
        Instantiate(bombs);
        bombs.transform.position = transform.position;
    }
}
