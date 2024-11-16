using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DropdownSearch : MonoBehaviour
{
    public TMP_InputField searchInputField;  // Input Field - TextMeshPro
    public TMP_Dropdown dropdown;            // Dropdown - TextMeshPro

    private List<string> originalOptions;    // ���� Dropdown ��ԭʼѡ��

    void Start()
    {
        // ���� Dropdown �ĳ�ʼѡ��
        originalOptions = new List<string>();
        foreach (TMP_Dropdown.OptionData option in dropdown.options)
        {
            originalOptions.Add(option.text);
        }

        // ���� Input Field ���ݱ仯
        searchInputField.onValueChanged.AddListener(OnSearchInputChanged);
    }

    // �� Input Field ���ݱ仯ʱ����
    void OnSearchInputChanged(string searchText)
    {
        // ���˷�������������ѡ��
        List<string> filteredOptions = originalOptions.FindAll(option => option.ToLower().Contains(searchText.ToLower()));

        // ���� Dropdown ѡ��
        dropdown.ClearOptions();
        dropdown.AddOptions(filteredOptions.ConvertAll(option => new TMP_Dropdown.OptionData(option)));

        // ���� Dropdown ������ˢ����ʾ
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
        // �������� Dropdown �����Ժͼ�����
    }
}