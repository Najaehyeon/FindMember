using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class GameoverPanel : MonoBehaviour
{
    public GameObject gameoverPanel;
    public GameObject pressAnyKeyText;

    public Text currentTimeText;
    public Text bestTimeText;

    private float currentTime;

    // Start is called before the first frame update

    void Start()
    {
        if (gameoverPanel != null)
        {
            gameoverPanel.SetActive(false);
        }
    }

    void Update()
    {
        if (Input.anyKeyDown && gameoverPanel != null && !gameoverPanel.activeSelf)
        {
            gameoverPanel.SetActive(true);
            pressAnyKeyText.SetActive(false);

            
            currentTime = PlayerPrefs.GetFloat("CurrentTime", 0f); 
            float bestTime = PlayerPrefs.GetFloat("BestTime", float.MaxValue); 

            
            currentTimeText.text = $"{currentTime:N2}"; 

            if (bestTime == float.MaxValue)
            {
                bestTimeText.text = ""; 
            }
            else
            {
                bestTimeText.text = $"{bestTime:N2}"; 
            }
        }
    }
}