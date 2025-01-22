using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PressAnyKey : MonoBehaviour
{
    Text text;
    float alpha = 0f; // 알파값을 조절하기 위한 변수
    float speed = 3f; // 알파값 변화 속도
    float customTime = 0f; // 클리어 씬에서만 사용되는 독립 시간

    void Start()
    {
        text = GetComponent<Text>();
    }


    void Update()
    {
        // Time.unscaledDeltaTime을 사용하여 독립 시간 계산
        customTime += Time.unscaledDeltaTime * speed;

        // 알파값 계산 (0~1 범위로 변동)
        alpha = (Mathf.Sin(customTime) + 0.8f) / 2f;


        // 텍스트의 색상 업데이트
        Color color = text.color;
        color.a = alpha;
        text.color = color;
    }
}
