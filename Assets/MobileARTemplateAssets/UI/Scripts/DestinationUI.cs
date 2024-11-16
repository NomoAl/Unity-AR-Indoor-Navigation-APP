using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ToggleUI : MonoBehaviour
{
    public GameObject[] uiElements; // 用于存放要控制的UI元素

    // 切换UI元素的显示和隐藏
    public void ToggleVisibility()
    {
        foreach (var element in uiElements)
        {
            element.SetActive(!element.activeSelf); // 如果元素是激活的，则隐藏它；如果是隐藏的，则显示它
        }
    }
}