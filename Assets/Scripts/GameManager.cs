using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject endPanel;
    public Text timeTxt;
    public Text bestScoreTxt;
    public Text tryCountTxt;
    public float timeLimit;

    private float remainTime;

    public Card firstCard;
    public Card secondCard;
    public int cardCount;
    public int selectCount;
    int tryCount;

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

                SaveCurrentCount();
                selectCount = 0;
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
        tryCount = selectCount / 2;
        tryCountTxt.text = tryCount.ToString();

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
            if (PlayerPrefs.GetInt("BestScore") == 0)
            {
                bestScoreTxt.text = "기록이 없습니다.";
            }
            else
            {
                bestScoreTxt.text = PlayerPrefs.GetInt("BestScore").ToString("N2");
            }
        }
    }
    private void SaveCurrentCount()
    {
        if (PlayerPrefs.GetInt("BestScore") == 0)
        {
            PlayerPrefs.SetInt("BestScore", tryCount);
            bestScoreTxt.text = PlayerPrefs.GetInt("BestScore").ToString("N2");
        }
        else
        {
            if (tryCount < PlayerPrefs.GetInt("BestScore"))
            {
                PlayerPrefs.SetInt("BestScore", tryCount);
            }
        }
        PlayerPrefs.SetInt("CurrentScore", tryCount);
    }
}
