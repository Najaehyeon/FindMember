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

    public void OnClickFirst()
    {
        ColorManager.instance.colorType = 1;
    }
    public void OnClickSecond()
    {
        ColorManager.instance.colorType = 2;
    }

    public void OnClickThird()
    {
        ColorManager.instance.colorType = 3;
    }

}
