using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColorManager : MonoBehaviour
{
    public static ColorManager instance;

    public GameObject backonetColor;

    public GameObject backtwoColor;

    public GameObject backThreeColor;

    public GameObject backFourColor;

    public GameObject backFiveColor;

    public GameObject onClickImage;

    public int colorType = 1;


    public void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
            SceneManager.sceneLoaded += OnSceneLoaded;
        }
        else if(instance != null)
        {
            Destroy(gameObject);
        }


        
    }
    // Start is called before the first frame update
    void Start()
    {
         FindUIObjects();

    }

    // Update is called once per frame
    void Update()
    {

        switch(colorType)
        {
            case 1:
            onClickImage.transform.position = backonetColor.transform.position;
            break;

            case 2:
            onClickImage.transform.position = backtwoColor.transform.position;
            break;

            case 3:
            onClickImage.transform.position = backThreeColor.transform.position;
            break;

            case 4:
            onClickImage.transform.position = backFourColor.transform.position;
            break;

            case 5:
            onClickImage.transform.position = backFiveColor.transform.position;
            break;
        }
        
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // 씬 로드 후 오브젝트 참조 갱신
        FindUIObjects();
    }


    private void FindUIObjects()
    {
        // Canvas에서 특정 오브젝트를 찾음
        GameObject canvas = GameObject.Find("Canvas");

        if(canvas != null)
        {
            Transform settingPanel = canvas.transform.Find("Setting Panel");
            Transform cardColorSettingText = settingPanel.Find("Card Color Setting Text");

            backonetColor = cardColorSettingText.transform.Find("Back1")?.gameObject;
            backtwoColor = cardColorSettingText.transform.Find("Back2")?.gameObject;
            backThreeColor = cardColorSettingText.transform.Find("Back3")?.gameObject;
            backFourColor = cardColorSettingText.transform.Find("Back4")?.gameObject;
            backFiveColor = cardColorSettingText.transform.Find("Back5")?.gameObject;
            onClickImage = cardColorSettingText.transform.Find("SelectCard")?.gameObject;
        }

        Debug.Log($"backonetColor: {backonetColor}, backtwoColor: {backtwoColor}");
        
    }

    private void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
