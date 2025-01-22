using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public AudioClip matchFailedClip;
    public AudioClip matchSuccessClip;
    public AudioClip cardFlipClip;
    public AudioClip clickButtonClip;
    public AudioClip bgmClip;

    private AudioSource bgmSource;
   
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        } 
        else if (instance != null)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(this.gameObject);     //scene이 이동하는 과정에 해당 오브젝트가 파괴되지 않도록 관리.
    }

    private void Start()
    {
        bgmSource = GetComponent<AudioSource>();
        bgmSource.clip = bgmClip;
        bgmSource.Play();           //해당 오브젝트가 활성화 되자마자 BGM 재생 시작.
    }
}
