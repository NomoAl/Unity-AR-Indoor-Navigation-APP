using UnityEngine;
using UnityEngine.UI;

public class ToggleControl : MonoBehaviour
{
    public Toggle toggle;             // 绑定Toggle组件
    public GameObject[] uiElements;   // 需要隐藏/显示的UI元素

    void Start()
    {
        // 初始化UI元素的状态
        SetUIElementsVisibility(toggle.isOn);

        // 监听Toggle的状态变化
        toggle.onValueChanged.AddListener(delegate {
            SetUIElementsVisibility(toggle.isOn);
        });
    }

    // 设置UI元素的显示状态
    void SetUIElementsVisibility(bool isVisible)
    {
        foreach (GameObject element in uiElements)
        {
            element.SetActive(!isVisible); // Toggle被选中时隐藏UI元素
        }
    }
}