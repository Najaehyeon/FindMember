using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PressAnyKey : MonoBehaviour
{
    Text text;
    float alpha = 0f; // ���İ��� �����ϱ� ���� ����
    float speed = 3f; // ���İ� ��ȭ �ӵ�
    float customTime = 0f; // Ŭ���� �������� ���Ǵ� ���� �ð�

    void Start()
    {
        text = GetComponent<Text>();
    }


    void Update()
    {
        // Time.unscaledDeltaTime�� ����Ͽ� ���� �ð� ���
        customTime += Time.unscaledDeltaTime * speed;

        // ���İ� ��� (0~1 ������ ����)
        alpha = (Mathf.Sin(customTime) + 0.8f) / 2f;


        // �ؽ�Ʈ�� ���� ������Ʈ
        Color color = text.color;
        color.a = alpha;
        text.color = color;
    }
}
