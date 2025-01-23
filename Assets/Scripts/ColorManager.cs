using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    public static ColorManager instance;

    public GameObject backonetColor;

    public GameObject backtwoColor;

    public GameObject backThreeColor;

    public GameObject backFourColor;

    public GameObject backFiveColor;

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
            onClickImage.transform.position = backonetColor.transform.position;
            break;

            case 2:
            onClickImage.transform.position = backtwoColor.transform.position;
            break;

            case 3:
            onClickImage.transform.position = backThreeColor.transform.position;
            break;

            case 4:
            onClickImage.transform.position = backFourColor.transform.position;
            break;

            case 5:
            onClickImage.transform.position = backFiveColor.transform.position;
            break;
        }
        
    }
}
