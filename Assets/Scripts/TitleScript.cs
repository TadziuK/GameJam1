using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleScript : MonoBehaviour
{
    public static TitleScript instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        gameObject.GetComponent<Renderer>().enabled = false;
    }
}
