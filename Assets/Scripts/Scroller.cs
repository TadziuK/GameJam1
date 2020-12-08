using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroller : MonoBehaviour
{
    public float BPM;
    public bool hasStarted;
    public static Scroller instance;

    // Start is called before the first frame update
    void Start()
    {
        BPM = BPM / 60f;
        hasStarted = false;
        instance = this;

    }

    // Update is called once per frame
    void Update()
    {
        if (hasStarted)
        {
            transform.position += new Vector3(BPM * Time.deltaTime, 0f, 0f);
        }
            

        
          
    }
}
