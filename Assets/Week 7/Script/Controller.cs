using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Controller : MonoBehaviour
{
    public Slider chargeSlider;
    float charge;
    public float maxCharge;
    Vector2 direction;
    public static int score = 0;
    public static FootballPlayer CurrentSelection { get; private set; }



    public static void SetCurrentSelection(FootballPlayer player)
    {
        if (CurrentSelection != null)
        {
            CurrentSelection.Selected(false);
        }
        CurrentSelection = player;
        CurrentSelection.Selected(true);
    }



    private void FixedUpdate()
    {
        if (direction != Vector2.zero)
        {
            CurrentSelection.Move(direction);
            direction = Vector2.zero;
        }
    }




    private void Update()
    {
        ScoreDisplay.scoreShowcase.text = "Score: " + score;


        if (CurrentSelection == null) return;

        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            charge = 0;
            direction = Vector2.zero;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            charge += Time.deltaTime;
            charge = Mathf.Clamp(charge, 0, maxCharge);
            chargeSlider.value = charge;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            direction = ((Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - (Vector2)CurrentSelection.transform.position).normalized * charge;
        }




    }


}
