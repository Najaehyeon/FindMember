using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameoverPanel : MonoBehaviour
{
    public GameObject gameoverPanel;

    // Start is called before the first frame update

    void Start()
    {
        if (gameoverPanel != null)
        {
            gameoverPanel.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown && gameoverPanel != null && !gameoverPanel.activeSelf)
        {
            gameoverPanel.SetActive(true);
        }
    }
}
