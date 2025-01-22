using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject endPanel;
    public Text timeTxt;
    public float timeLimit;

    private float remainTime;

    public void Awake()
    {
        Time.timeScale = 1.0f;
        Application.targetFrameRate = 60;
        if(Instance == null)
        {
            Instance = this;
        }
        else if(Instance != null)
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        remainTime = timeLimit;
        timeTxt.text = timeLimit.ToString("N2");
    }

    void Update()
    {
        if (remainTime > 0)
        {
            remainTime -= Time.deltaTime;
            timeTxt.text = remainTime.ToString("N2");
        }
        else
        {
            endPanel.SetActive(true);
            Time.timeScale = 0.0f;
            timeTxt.text = "0.00";
        }
    }
}
