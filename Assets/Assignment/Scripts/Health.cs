using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    int health;
    public Slider healthSlider;

    // Start is called before the first frame update
    void Start()
    {
        health = 3;
    }

    public void Damage (float damageTaken)
    {
        Debug.Log("Hurt");
        health--;
        healthSlider.value = health;

        if (health <= 0) 
        {
            SceneManager.LoadScene("Game Over");
        }

    }

}
