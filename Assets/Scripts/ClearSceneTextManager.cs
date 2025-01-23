using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearSceneTextManager : MonoBehaviour
{
    public static ClearSceneTextManager instance;


    public Text NJH_Text;
    public Text YGM_Text;
    public Text SJW_Text;
    public Text CBC_Text;
    public Text LDH_Text;
    public Text KHA_Text;

    public Font fontENG;
    public Font fontKOR;
    public Font fontJPN;

    private string nowLanguage;

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
    }

    private void Start()
    {
        SettingText();
    }

    public void SettingText()
    {
        nowLanguage = PlayerOptionData.instance.nowLanguage;
        SettingLanguage(nowLanguage);
    }

    private void SettingFont(Font font)
    {
        NJH_Text.font = font;
        YGM_Text.font = font;
        SJW_Text.font = font;
        CBC_Text.font = font;
        LDH_Text.font = font;
        KHA_Text.font = font;
    }

    public void SettingLanguage(string language)
    {
        nowLanguage = language;
        //nowLanguage의 언어가 셋 중 하나도 해당하지 않을 경우 현재 언어를 ENG로 변경
        if (nowLanguage != "ENG" && nowLanguage != "KOR" && nowLanguage != "JPN")
        {
            nowLanguage = "ENG";
        }


        if (nowLanguage == "ENG")
        {
            SettingFont(fontENG);
            NJH_Text.text = "I want to create a game for 100 billion people.";
            YGM_Text.text = "I want to create a game that will last a long time in peoples memory";
            SJW_Text.text = "I want to create a game that will be nominated for GOTY";
            CBC_Text.text = "want to create a game that brings happiness to the players";
            LDH_Text.text = "I want to create a game that we can enjoy now, remebering the memories";
            KHA_Text.text = "I want to create a game that we forget the harsh reality";
        }
        else if (nowLanguage == "KOR")
        {
            SettingFont(fontKOR);
            NJH_Text.text = "1억명이 쓰는 게임을 만들자";
            YGM_Text.text = "사람들 기억에 오래 남을 수 있는 게임을 만들자";
            SJW_Text.text = "GOTY 후보에 올라갈 만한 게임을 만들자";
            CBC_Text.text = "유저들의 행복감을 채워주는 게임을 만들자";
            LDH_Text.text = "추억 속의 낭만을 챙기며, 지금을 즐길 게임을 만들자";
            KHA_Text.text = "힘든 현실을 잠시나마 잊을 수 있는 게임을 만들자";
        }
        else if (nowLanguage == "JPN")
        {
            SettingFont(fontJPN);
            NJH_Text.text = "一億人が楽しめるゲームを作ろう";
            YGM_Text.text = "みんなの思い出に残るゲームを作ろう";
            SJW_Text.text = "GOTYにノミネートされるゲームを作ろう";
            CBC_Text.text = "ユーザーを幸せにするゲームを作ろう";
            LDH_Text.text = "思い出を守りながら今を楽しめるゲームを作ろう";
            KHA_Text.text = "辛い堅実を忘れられるゲームを作ろう";
        }
        else
        {
            Console.WriteLine("언어 확인 오류");
        }
    }
}
