using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOptionData : MonoBehaviour
{
    public static PlayerOptionData instance;

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
        nowLanguage = PlayerPrefs.GetString("Language", "ENG");
        Debug.Log("language = " +  nowLanguage);
    }
}
