using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public AudioSource pew;
    private SpriteRenderer theSR;
    public Sprite defaultImage;
    public Sprite pressedImage;
    public KeyCode key;
    public GameObject lazer;
    // Start is called before the first frame update
    void Start()
    {
        theSR = GetComponent<SpriteRenderer>();
        theSR.sprite = defaultImage;
    }

    // Update is called once per frame
    void Update()

    {
      
        if (Input.GetKeyDown(key))
        {
            theSR.sprite = pressedImage;
            pew.Play();
        }
        if (Input.GetKeyUp(key))
        {
            theSR.sprite = defaultImage;
        }

    }
}
