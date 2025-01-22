using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PressAnyKey : MonoBehaviour
{
    Text text;
    float alpha = 0f; // ���İ��� �����ϱ� ���� ����
    float speed = 1f; // ���İ� ��ȭ �ӵ�

    void Start()
    {
        text = GetComponent<Text>();
    }

    
    void Update()
    {
        // Mathf.PingPong�� ����� ���İ��� 0~1 ���̷� ����
        alpha = Mathf.PingPong(Time.time * speed, 1f);

        // �ؽ�Ʈ�� ���� ������Ʈ
        Color color = text.color;
        color.a = alpha;
        text.color = color;
    }
}
