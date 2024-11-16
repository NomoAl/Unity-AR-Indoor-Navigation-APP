using UnityEngine;
using UnityEngine.UI;

public class ToggleControl : MonoBehaviour
{
    public Toggle toggle;             // ��Toggle���
    public GameObject[] uiElements;   // ��Ҫ����/��ʾ��UIԪ��

    void Start()
    {
        // ��ʼ��UIԪ�ص�״̬
        SetUIElementsVisibility(toggle.isOn);

        // ����Toggle��״̬�仯
        toggle.onValueChanged.AddListener(delegate {
            SetUIElementsVisibility(toggle.isOn);
        });
    }

    // ����UIԪ�ص���ʾ״̬
    void SetUIElementsVisibility(bool isVisible)
    {
        foreach (GameObject element in uiElements)
        {
            element.SetActive(!isVisible); // Toggle��ѡ��ʱ����UIԪ��
        }
    }
}