using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeControl : MonoBehaviour
{
    public AudioMixer audioMixer; // AudioMixer ����
    public Slider bgmSlider;      // BGM �����̴� ����
    public Slider sfxSlider;      // SFX �����̴� ����

    private void Start()
    {
        // �ʱ� �����̴� �� ���� (�⺻��: 1)
        bgmSlider.value = PlayerPrefs.GetFloat("BGMVolume", 1f);
        sfxSlider.value = PlayerPrefs.GetFloat("SFXVolume", 1f);

        SetBGMVolume(bgmSlider.value);
        SetSFXVolume(sfxSlider.value);

        // �����̴� �̺�Ʈ ������ �߰�
        bgmSlider.onValueChanged.AddListener(SetBGMVolume);
        sfxSlider.onValueChanged.AddListener(SetSFXVolume);
    }

    public void SetBGMVolume(float value)
    {
        // BGM ���� ����
        if (value <= 0.01f)
        {
            audioMixer.SetFloat("BGMVolume", -80f); // ���Ұ�
        }
        else
        {
            audioMixer.SetFloat("BGMVolume", Mathf.Log10(value) * 20);
        }

        // �� ����
        PlayerPrefs.SetFloat("BGMVolume", value);
    }

    public void SetSFXVolume(float value)
    {
        // SFX ���� ����
        if (value <= 0.01f)
        {
            audioMixer.SetFloat("SFXVolume", -80f); // ���Ұ�
        }
        else
        {
            audioMixer.SetFloat("SFXVolume", Mathf.Log10(value) * 20);
        }

        // �� ����
        PlayerPrefs.SetFloat("SFXVolume", value);
    }
}