using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using TMPro;
using System.IO;
using Unity.VisualScripting;

public class DropdownNavController : MonoBehaviour
{
    public TMP_Dropdown dropdown;  // ʹ��TMP_Dropdown����
    public Transform target;
    public GameObject agent;
    public NavMeshPath path;
    void Start()
    {
        // ����Dropdown��ֵ�仯�¼�
        dropdown.onValueChanged.AddListener(delegate {
            DropdownValueChanged(dropdown);
        });
    }

    void DropdownValueChanged(TMP_Dropdown change)
    {
        Vector3 newPosition = Vector3.zero;
        switch (change.value)
        {
            case 0:
                newPosition = new Vector3(15, 0, -17);
                break;
            case 1:
                newPosition = new Vector3(32, 0, -12);
                break;
            case 2:
                newPosition = new Vector3(18, 0, -24);
                break;
            case 3:
                newPosition = new Vector3(14, 0, 10);
                break;
            case 205:
                newPosition = new Vector3(15, 0, 10);
                break;

                // ��Ӹ����case���������ѡ��
        }

        if (target != null)
        {
            path = new NavMeshPath();
            target.position = newPosition;
            if (agent != null)
            {
                NavMesh.CalculatePath(agent.transform.position, target.transform.position, NavMesh.AllAreas, path);
            }
        }
    }
}