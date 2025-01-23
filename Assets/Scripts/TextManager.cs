using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TextManager : MonoBehaviour
{
    public static TextManager instance;

    public string nowLanguage;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else if(instance != null)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        nowLanguage = PlayerPrefs.GetString("PlayerLanguage", "ENG");       //추후 플레이어가 저장한 언어가 있다면 가져옴. 없으면 "ENG"로 반환
    }

    public void SettingLanguage(string language)
    {
        nowLanguage = language;

        //nowLanguage의 언어가 셋 중 하나도 해당하지 않을 경우 현재 언어를 ENG로 변경
        if (nowLanguage != "ENG" &&  nowLanguage != "KOR" && nowLanguage != "JPN")  
        {
            nowLanguage = "ENG";
        }
    }


}
