using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public int index;
    public SpriteRenderer frontimage;
    public GameObject front;
    public GameObject back;

    public Animator anim;

    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    
    public void OpenCard()
    {
        anim.SetBool("isOpen", true);
        front.SetActive(true);
        back.SetActive(false);
        
    }

    public void Setting(int number)
    {
        index = number;
        frontimage.sprite = Resources.Load<Sprite>($"card{index}");

    }
}
