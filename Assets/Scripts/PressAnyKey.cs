using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PressAnyKey : MonoBehaviour
{
    Text text;
    float alpha = 0f; // ���İ��� �����ϱ� ���� ����
    float speed = 2f; // ���İ� ��ȭ �ӵ�
    float customTime = 0f; // �������� �ð� ����� ���� ����

    void Start()
    {
        text = GetComponent<Text>();
        Time.timeScale = 1f;

        // �ؽ�Ʈ �ʱ�ȭ
        if (text != null)
        {
            Color color = text.color;
            color.a = 0f; // ���İ� �ʱ�ȭ
            text.color = color;
        }

        // ���İ� ���� Coroutine ����
        StartCoroutine(FadeInAndBlink());
    }

    IEnumerator FadeInAndBlink()
    {
        // 1�� ���
        yield return new WaitForSeconds(1f);

        // ���İ� ��¦�� ����
        while (true)
        {
            customTime += Time.deltaTime * speed;

            // ���İ� ��� (0~1 ������ ����)
            alpha = Mathf.Abs(Mathf.Sin(customTime)); // 0���� �����Ͽ� ��¦�Ÿ����� ����

            // �ؽ�Ʈ�� ���� ������Ʈ
            if (text != null)
            {
                Color color = text.color;
                color.a = alpha;
                text.color = color;
            }

            yield return null; // ���� �����ӱ��� ���
        }
    }
}
