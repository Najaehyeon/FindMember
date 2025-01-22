using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instancce;
    public GameObject endPanel;
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
        DontDestroyOnLoad(this.gameObject);             //scene이 이동하는 과정에 해당 오브젝트가 파괴되지 않도록 관리.
    }


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
            endPanel.SetActive(true);
            Time.timeScale = 0.0f;
            timeTxt.text = "0.00";
  
        }


        
    }
}
