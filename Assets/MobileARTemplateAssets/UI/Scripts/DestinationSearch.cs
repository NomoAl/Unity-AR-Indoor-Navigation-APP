using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DropdownSearch : MonoBehaviour
{
    public TMP_InputField searchInputField;  // Input Field - TextMeshPro
    public TMP_Dropdown dropdown;            // Dropdown - TextMeshPro

    private List<string> originalOptions;    // 保存 Dropdown 的原始选项

    void Start()
    {
        // 保存 Dropdown 的初始选项
        originalOptions = new List<string>();
        foreach (TMP_Dropdown.OptionData option in dropdown.options)
        {
            originalOptions.Add(option.text);
        }

        // 监听 Input Field 内容变化
        searchInputField.onValueChanged.AddListener(OnSearchInputChanged);
    }

    // 当 Input Field 内容变化时调用
    void OnSearchInputChanged(string searchText)
    {
        // 过滤符合搜索条件的选项
        List<string> filteredOptions = originalOptions.FindAll(option => option.ToLower().Contains(searchText.ToLower()));

        // 更新 Dropdown 选项
        dropdown.ClearOptions();
        dropdown.AddOptions(filteredOptions.ConvertAll(option => new TMP_Dropdown.OptionData(option)));

        // 重置 Dropdown 索引和刷新显示
        if (filteredOptions.Count > 0)
        {
            dropdown.value = 0;
        }
        dropdown.RefreshShownValue();
    }
    void RebuildDropdown()
    {
        var dropdownComponent = dropdown.gameObject.GetComponent<TMP_Dropdown>();
        Destroy(dropdownComponent);
        dropdown.gameObject.AddComponent<TMP_Dropdown>();
        // 重新设置 Dropdown 的属性和监听器
    }
}