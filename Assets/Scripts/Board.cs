using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public GameObject cardPref;

    void Start()
    {
        int[] arr = new int[24];

        for(int i = 0; i < 24; i++)
        {
            arr[i] = i%12;

        }

        for(int i = 0; i < 24 ; i++)
        {
            GameObject go = Instantiate(cardPref, this.transform);

            float x = i%4*1.2f -1.8f;
            float y = i/4*1.4f -4.0f;

            go.transform.position = new Vector2(x,y);

            go.GetComponent<Card>().Setting(arr[i]);
            
        }
        
    }
}
