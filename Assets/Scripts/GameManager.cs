using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instancce;
    public Text timeTxt;
    float time;

    public void Awake()
    {
        Time.timeScale = 1.0f;
        Application.targetFrameRate = 60;
        if(Instancce == null)
        {
            Instancce = this;
        }
        else if(Instancce != null)
        {
            Destroy(this);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        time = float.Parse(timeTxt.text);

        if(time > 0)
        {
            time -= Time.deltaTime;
            timeTxt.text = time.ToString("N2");
        }
        else
        {
            Time.timeScale = 0.0f;
            timeTxt.text = "0.00";
        }


        
    }
}
