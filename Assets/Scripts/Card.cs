using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Card : MonoBehaviour
{
    public int index;
    public SpriteRenderer frontimage;
    public GameObject front;
    public GameObject back;

    public GameObject backBtn;

    private AudioSource flipSound;

    public Animator anim;

    private void Start()
    {
        flipSound = GetComponent<AudioSource>();
        flipSound.clip = AudioManager.instance.cardFlipClip;
    }

    void Update()
    {
        if(transform.eulerAngles.y >= -90f && transform.eulerAngles.y <= 90f)   //카드가 뒷면
        {
            front.SetActive(false);
            back.SetActive(true);
        }
        else
        {
            front.SetActive(true);
            back.SetActive(false);
        }
    }
    public void DestroyCard()
    {
        Invoke("DestroyCardInvoke", GameManager.Instance.cardCloseDelayTime);
    }
    void DestroyCardInvoke()
    {
        Destroy(gameObject);
    }
    public void OpenCard()
    {
        anim.SetBool("isOpen", true);
        backBtn.SetActive(false);
        flipSound.Play();
        GameManager.Instance.selectCount++;

        if (GameManager.Instance.firstCard == null)
        {
            GameManager.Instance.firstCard = this;
        }
        else 
        { 
            GameManager.Instance.secondCard = this;
            GameManager.Instance.isMatched();
        }
    }

    public void CloseCard()
    {
        Invoke("CloseCardInvoke", GameManager.Instance.cardCloseDelayTime);
    }
    void CloseCardInvoke()
    {
        anim.SetBool("isOpen", false);
        backBtn.SetActive(true);
    }

    public void Setting(int number)
    {
        index = number;
        frontimage.sprite = Resources.Load<Sprite>($"card{index}");

    }

   

}
