using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PressAnyKey : MonoBehaviour
{
    Text text;
    float alpha = 0f; // 알파값을 조절하기 위한 변수
    float speed = 1f; // 알파값 변화 속도

    void Start()
    {
        text = GetComponent<Text>();
    }

    
    void Update()
    {
        // Mathf.PingPong을 사용해 알파값을 0~1 사이로 변동
        alpha = Mathf.PingPong(Time.time * speed, 1f);

        // 텍스트의 색상 업데이트
        Color color = text.color;
        color.a = alpha;
        text.color = color;
    }
}
