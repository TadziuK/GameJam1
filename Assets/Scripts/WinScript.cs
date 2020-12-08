using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinScript : MonoBehaviour
{
    public static WinScript instance;
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
        hText.gameObject.SetActive(false);
        sText.gameObject.SetActive(false);
        mText.gameObject.SetActive(false);
        gameObject.GetComponent<Renderer>().enabled = true;
    }
    public void StartGame()
    {
        gameObject.GetComponent<Renderer>().enabled = false;

    }

}
