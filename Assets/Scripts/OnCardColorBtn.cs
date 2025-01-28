using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCardColorBtn : MonoBehaviour
{

    public void OnClickColor(int index)
    {
        AudioManager.instance.SoundPlayClick(0f);
        ColorManager.instance.colorType = index;
        PlayerPrefs.SetInt("colorType", index);
    }

}
