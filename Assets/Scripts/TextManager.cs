using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    public static TextManager instance;

    public string nowLanguage;

    public Text optionPanelCancleText;
    public Text startBtnTxt;
    public Text optionBtnTxt;
    //public Text gameOutBtnTxt;

    public Font fontENG;
    public Font fontKOR;
    public Font fontJPN;

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
        Debug.Log("실행");
        //nowLanguage의 언어가 셋 중 하나도 해당하지 않을 경우 현재 언어를 ENG로 변경
        if (nowLanguage != "ENG" &&  nowLanguage != "KOR" && nowLanguage != "JPN")  
        {
            nowLanguage = "ENG";
        }
        Debug.Log("현재 언어: " +  nowLanguage);
        if(nowLanguage == "ENG")
        {
            Debug.Log("영어 감지");
            SettingFont(fontENG);
            optionPanelCancleText.text = "Apply and Exit";
            startBtnTxt.text = "Start";
            //gameOutBtnTxt.text = "Exit";
            optionBtnTxt.text = "Option";
        }
        else if (nowLanguage == "KOR")
        {
            SettingFont(fontKOR);
            optionPanelCancleText.text = "적용 및 나가기";
            startBtnTxt.text = "시작하기";
            //gameOutBtnTxt.text = "게임종료";
            optionBtnTxt.text = "옵션";
        }
        else if (nowLanguage == "JPN")
        {
            SettingFont(fontJPN);
            optionPanelCancleText.text = "適用して戻る";
            startBtnTxt.text = "スタート";
            //gameOutBtnTxt.text = "終了";
            optionBtnTxt.text = "設定";

        }
        else
        {
            Console.WriteLine("언어 확인 오류");
        }
    }

    private void SettingFont(Font font)
    {
        optionPanelCancleText.font = font;
        startBtnTxt.font = font;
        optionBtnTxt.font = font;
        //gameOutBtnTxt.font = font;
    }


}
