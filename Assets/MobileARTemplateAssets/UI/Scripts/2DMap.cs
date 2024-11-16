using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MapCameraController : MonoBehaviour
{
    public Transform target; // 3D�е�Ŀ�꣬�������λ��
    public Camera mapCamera; // 2D��ͼ�������
    public LineRenderer lineRenderer; // ��������Ⱦ��
    public Vector3[] pathPoints; // ����·����

    void Start()
    {
        SetupNavigationLine();
    }

    void Update()
    {
        if (target != null)
        {
            // ����2D��ͼ�������λ�ã�ʹ��ʼ��λ��Ŀ�����Ϸ�
            mapCamera.transform.position = new Vector3(target.position.x, mapCamera.transform.position.y, target.position.z);
        }

        // �������������·���㣬�����������Ϸ���Ƕ�̬�仯��
        UpdateNavigationLine();
    }

    void SetupNavigationLine()
    {
        if (lineRenderer != null && pathPoints != null)
        {
            // ����Line Renderer�ĵ�
            lineRenderer.positionCount = pathPoints.Length;
            lineRenderer.SetPositions(pathPoints);
        }
    }

    void UpdateNavigationLine()
    {
        // ������Ը���ʵ�������������·����
        // ���磬���·������Ҫ����ĳЩ��Ϸ�߼�����
    }
}