using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearSceneManager : MonoBehaviour
{
    public Text NJH_Text;
    public Text YGM_Text;
    public Text SJW_Text;
    public Text CBC_Text;
    public Text LDH_Text;
    public Text KHA_Text;

    private void Start()
    {
        TextManager.instance.NJH_Text = NJH_Text;
        TextManager.instance.YGM_Text = YGM_Text;
        TextManager.instance.SJW_Text = SJW_Text;
        TextManager.instance.CBC_Text = CBC_Text;
        TextManager.instance.LDH_Text = LDH_Text;
        TextManager.instance.KHA_Text = KHA_Text;
    }
}
