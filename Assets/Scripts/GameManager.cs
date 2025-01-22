using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject endPanel;
    public Text timeTxt;
    public float timeLimit;

    private float remainTime;

    public GameObject cardObjects;

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
        ActiveButtonObjects(false);
        if (firstCard.index == secondCard.index)
        {
            firstCard.DestroyCard();
            secondCard.DestroyCard();
            AudioManager.instance.SoundPlayMatchSuccess(0.5f);
        }
        else
        {
            firstCard.CloseCard();
            secondCard.CloseCard();
            AudioManager.instance.SoundPlayMatchFailed(0.5f);
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


    public void ActiveButtonObjects(bool active)            //Button 태그를 가진 오브젝트를 활성화 및 비활성화화
    {
        List<GameObject> buttonObject = GetButtonGameObjects(cardObjects, "Button");

        if (buttonObject.Count > 0)
        {
            for (int i = 0; i < buttonObject.Count; i++)
            { 
                buttonObject[i].SetActive(active);
            }
        }
    }

    private List<GameObject> GetButtonGameObjects(GameObject parentObject, string tag)
    {
        List<GameObject> result = new List<GameObject>();

        foreach (Transform child in parentObject.transform)
        {
            if(child.gameObject.CompareTag(tag))
            {
                result.Add(child.gameObject);
            }

            result.AddRange(GetButtonGameObjects(child.gameObject, tag));
        }

        return result;
    }
}
