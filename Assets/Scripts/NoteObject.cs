using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{
    public bool redCanBePressed;
    public bool blueCanBePressed;
    public bool ShipCanBeHit;
    public GameObject asteroid;
    private SpriteRenderer sr;
    private Rigidbody2D rb;



    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddTorque(4f);
        if (Input.GetKeyDown("z") && (asteroid.tag=="Asteroid"))
        {
            if (redCanBePressed)
            {
                GameManager.instance.NoteHit();
                gameObject.SetActive(false);
            }
        }
        if (Input.GetKeyDown("x") && (asteroid.tag == "BlueAsteroid"))
        {
            if (blueCanBePressed)
            {
                GameManager.instance.NoteHit();
                gameObject.SetActive(false);
            }
        }
        if (Input.GetKeyDown("x") && (asteroid.tag == "Asteroid"))
        {
            if (blueCanBePressed)
            {
                sr.material.color = Color.green;
                GameManager.instance.NoteMissed();    
            }
        }
        if (Input.GetKeyDown("z") && (asteroid.tag == "BlueAsteroid"))
        {
            if (redCanBePressed)
            {
                sr.material.color = Color.green;
                GameManager.instance.NoteMissed();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "BlueLazer")
        {
            blueCanBePressed = true;
        }
        if (collision.tag == "Lazer")
        {
            redCanBePressed = true;
        }
        if (collision.tag == "ship")
        {
            GameManager.instance.AsteroidHit();
            gameObject.SetActive(false);
        }
        if ((collision.tag == "ship") && (asteroid.tag == "win"))
        {
            GameManager.instance.youWin = true;
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Lazer") 
        {
            redCanBePressed = false;
            
        }
        if (collision.tag == "BlueLazer") 
        {
            blueCanBePressed = false;
           
        }
    }
}
