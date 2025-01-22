using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public AudioClip matchFailed;
    public AudioClip matchSuccess;
    public AudioClip cardFlip;
    public AudioClip clickButton;
    public AudioClip bgm;
   
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        } else if (instance != null)
        {
            Destroy(this);
        }
    }


}
