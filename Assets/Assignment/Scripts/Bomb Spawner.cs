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
    public int flippedSpawns = 1;
    


    // Start is called before the first frame update
    void Start()
    {
        
        bomb = Instantiate(bombPrefabs[Random.Range(0, 2)]);
        bomb.GetComponent<Bomb>();
            
        bomb.transform.position = transform.position;




    }

    // Update is called once per frame
    void Update()
    {
        timePassed += Time.deltaTime;
        if (timePassed >= 2f)
        {
            bomb = Instantiate(bombPrefabs[Random.Range(0, 2)]);
            bomb.transform.position = transform.position;
            timePassed = 0;
        }




    }
}
