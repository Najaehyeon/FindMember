using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instancce;
    public GameObject endPanel;
    public Text timeTxt;
    float time;

    public Card firstCard;
    public Card secondCard;
    public int cardCount;

    public void Awake()
    {
        Time.timeScale = 1.0f;
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

    public void isMatched()
    {
        if (firstCard.index == secondCard.index) 
        {
            checkMatched();
            cardCount -= 2;
            if (cardCount == 0) 
            {
                SceneManager.LoadScene("ClearScene");
                Time.timeScale = 0.0f;
            }
        }
        else 
        {
            checkMatched();
        }
    }
    public void checkMatched() 
        {
            if (firstCard.index == secondCard.index) 
            {
                firstCard.DestroyCard();
                secondCard.DestroyCard();
            }
            else 
            { 
                firstCard.CloseCard();
                secondCard.CloseCard();
            }
            firstCard = null;
            secondCard = null;
        }
    // Update is called once per frame
    void Update()
    {
        
        time = float.Parse(timeTxt.text);

        if (time > 0)
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
