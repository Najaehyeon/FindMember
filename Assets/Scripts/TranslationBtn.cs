using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslationBtn : MonoBehaviour
{
    public string language;
    public GameObject textObject;
    public GameObject translationObject;
    private Translation translation;

    private void Start()
    {
        translation = translationObject.GetComponent<Translation>();


    }

    public void ClickButton()
    {
        if(textObject.activeSelf == false)
        {
            AudioManager.instance.SoundPlayClick(0f);
            TextManager.instance.SettingLanguage(language);
            translation.SettingActiveFalse();
            textObject.SetActive(true);
        }

    }
}
