using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslationBtn : MonoBehaviour
{
    public string language;
    public GameObject textObject;
    public GameObject translationObject;
    private Translation translation;


    public void ClickButton()
    {
        translation = translationObject.GetComponent<Translation>();
        if (textObject.activeSelf == false)
        {
            Debug.Log("버튼 클릭");
            AudioManager.instance.SoundPlayClick(0f);
            StartSceneTextManager.instance.SettingLanguage(language);
            translation.CheckToTextObject(language);

            PlayerPrefs.SetString("Language", language);
        }

    }
}
