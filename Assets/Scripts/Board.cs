using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public GameObject cardPref;

    void Start()
    {
        for (int i = 0; i < 4;  i++)
        {
            for (int j = 0; j < 6;  j++)
            {
                Vector3 pos = new Vector3(i * 1.2f - 1.8f, j * 1.4f - 4, 1);
                Instantiate(cardPref, pos, Quaternion.identity);
            }
        }
        
    }
}
