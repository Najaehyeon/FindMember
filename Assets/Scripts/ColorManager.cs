using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    public static ColorManager instance;

    public GameObject backFirstColor;

    public GameObject backSecondColor;

    public GameObject backThirdColor;

    public GameObject onClickImage;

    public int colorType = 1;


    public void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else if(instance != null)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch(colorType)
        {
            case 1:
            onClickImage.transform.position = backFirstColor.transform.position;
            break;

            case 2:
            onClickImage.transform.position = backSecondColor.transform.position;
            break;

            case 3:
            onClickImage.transform.position = backThirdColor.transform.position;
            break;
        }
        
    }
}
