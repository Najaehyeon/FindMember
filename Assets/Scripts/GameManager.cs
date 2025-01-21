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
        Application.targetFrameRate = 60;
        if(Instancce == null)
        {
            Instancce = this;
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
        time -= Time.deltaTime;
        timeTxt.text = time.ToString("N2");
        
    }
}
