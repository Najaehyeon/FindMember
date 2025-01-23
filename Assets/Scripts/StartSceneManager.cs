using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartSceneManager : MonoBehaviour
{
    public Text startBtnTxt;
    public Text optionBtnTxt;
    public Text topTitleTxt;
    public Text middleTitleTxt;
    public Text bottomTitleTxt;
    public Text settingTitleTxt;
    public Text settingAudioTxt;
    public Text settingEffectTxt;
    public Text settingCardColorTxt;
    public Text settingLanguageTxt;

    private void Start()
    {
        TextManager.instance.startBtnTxt = startBtnTxt;
        TextManager.instance.optionBtnTxt = optionBtnTxt;
        TextManager.instance.topTitleTxt = topTitleTxt;
        TextManager.instance.middleTitleTxt = middleTitleTxt;
        TextManager.instance.bottomTitleTxt = bottomTitleTxt;
        TextManager.instance.settingTitleTxt = settingTitleTxt;
        TextManager.instance.settingAudioTxt = settingAudioTxt;
        TextManager.instance.settingEffectTxt = settingEffectTxt;
        TextManager.instance.settingCardColorTxt = settingCardColorTxt;
        TextManager.instance.settingLanguageTxt = settingLanguageTxt;
    }
}
