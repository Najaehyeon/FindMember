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
        Invoke("DestroyCardInvoke", 1.0f);
    }
    void DestroyCardInvoke() 
    {
        Destroy(gameObject);
    }
    public void OpenCard()
    {
        anim.SetBool("isOpen", true);
<<<<<<< HEAD
        flipSound.Play();
=======
        front.SetActive(true);
        back.SetActive(false);

        if (GameManager.Instancce.firstCard == null)
        {
            GameManager.Instancce.firstCard = this;
        }
        else 
        { 
            GameManager.Instancce.secondCard = this;
            GameManager.Instancce.isMatched();
        }
>>>>>>> KangHyunAh_Dev
    }

    public void CloseCard()
    {
        Invoke("CloseCardInvoke", 1.0f);
    }
    void CloseCardInvoke() 
    {
        anim.SetBool("isOpen", false);
        front.SetActive(false);
        back.SetActive(true);
    }

    public void Setting(int number)
    {
        index = number;
        frontimage.sprite = Resources.Load<Sprite>($"card{index}");

    }

   

}
