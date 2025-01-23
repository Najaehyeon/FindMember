using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCardColorBtn : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickOne()
    {
        ColorManager.instance.colorType = 1;
    }
    public void OnClickTwo()
    {
        ColorManager.instance.colorType = 2;
    }

    public void OnClickThree()
    {
        ColorManager.instance.colorType = 3;
    }

    public void OnClickFour()
    {
        ColorManager.instance.colorType = 3;
    }

    public void OnClickFive()
    {
        ColorManager.instance.colorType = 3;
    }

}
