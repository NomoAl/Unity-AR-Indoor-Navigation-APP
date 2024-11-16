using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MapCameraController : MonoBehaviour
{
    public Transform target; // 3D中的目标，例如玩家位置
    public Camera mapCamera; // 2D地图的摄像机
    public LineRenderer lineRenderer; // 导航线渲染器
    public Vector3[] pathPoints; // 导航路径点

    void Start()
    {
        SetupNavigationLine();
    }

    void Update()
    {
        if (target != null)
        {
            // 更新2D地图摄像机的位置，使其始终位于目标正上方
            mapCamera.transform.position = new Vector3(target.position.x, mapCamera.transform.position.y, target.position.z);
        }

        // 可以在这里更新路径点，如果它们在游戏中是动态变化的
        UpdateNavigationLine();
    }

    void SetupNavigationLine()
    {
        if (lineRenderer != null && pathPoints != null)
        {
            // 设置Line Renderer的点
            lineRenderer.positionCount = pathPoints.Length;
            lineRenderer.SetPositions(pathPoints);
        }
    }

    void UpdateNavigationLine()
    {
        // 这里可以根据实际情况重新设置路径点
        // 例如，如果路径点需要根据某些游戏逻辑更新
    }
}