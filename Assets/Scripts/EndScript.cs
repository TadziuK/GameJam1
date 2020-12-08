using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndScript : MonoBehaviour
{
    public static EndScript instance;
    public Text hText;
    public Text mText;
    public Text sText;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;


    }

    // Update is called once per frame
    void Update()
    {
        

    }

    public void EndGame()
    {
        GameManager.instance.endBool = true;
        Scroller.instance.hasStarted = false;
        gameObject.GetComponent<Renderer>().enabled = true;
        hText.gameObject.SetActive(false);
        sText.gameObject.SetActive(false);
        mText.gameObject.SetActive(false);
        // Time.timeScale = 0;

    }
    public void StartGame()
    {
        gameObject.GetComponent<Renderer>().enabled = false;
        
    }
}
