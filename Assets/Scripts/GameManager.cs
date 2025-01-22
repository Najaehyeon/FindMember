using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject endPanel;
    public Text timeTxt;
    public Text bestRecordTxt;
    public float timeLimit;

    private float remainTime;

    public Card firstCard;
    public Card secondCard;
    public int cardCount;



    public void Awake()
    {
        Time.timeScale = 1.0f;
        Application.targetFrameRate = 60;
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != null)
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        remainTime = timeLimit;
        timeTxt.text = timeLimit.ToString("N2");


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

                SaveCurrentTime();
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

    void Update()
    {
        remainTime = float.Parse(timeTxt.text);

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

            SaveCurrentTime();
        }
    }
    private void SaveCurrentTime()
    {
        float currentTime = float.Parse(timeTxt.text);
        PlayerPrefs.SetFloat("CurrentTime", currentTime);

        float bestTime = PlayerPrefs.GetFloat("BestTime", float.MaxValue);


        if (currentTime > bestTime)
        {
            PlayerPrefs.SetFloat("BestTime", currentTime);
        }
    }
    void DisplayBestTime()
    {
        float bestTime = PlayerPrefs.GetFloat("BestTime", float.MaxValue);
        if (bestTime == float.MaxValue)
        {
            bestRecordTxt.text = "Best Time: --:--";
        }
        else
        {
            bestRecordTxt.text = "Best Time: " + bestTime.ToString("N2");
        }
    }
}
