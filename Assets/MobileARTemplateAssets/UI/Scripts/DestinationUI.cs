using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ToggleUI : MonoBehaviour
{
    public GameObject[] uiElements; // ���ڴ��Ҫ���Ƶ�UIԪ��

    // �л�UIԪ�ص���ʾ������
    public void ToggleVisibility()
    {
        foreach (var element in uiElements)
        {
            element.SetActive(!element.activeSelf); // ���Ԫ���Ǽ���ģ�������������������صģ�����ʾ��
        }
    }
}