using UnityEngine;
using UnityEngine.AI;

public class PathRenderer : MonoBehaviour
{
    public NavMeshAgent agent;  // 绑定NavMeshAgent
    private LineRenderer lineRenderer;

    void Start()
    {
        // 获取LineRenderer组件
        lineRenderer = GetComponent<LineRenderer>();

        // 设置LineRenderer的属性（如线条宽度和材质）
        lineRenderer.startWidth = 0.1f;
        lineRenderer.endWidth = 0.1f;
        // 设置线条的颜色
        lineRenderer.startColor = Color.green;
        lineRenderer.endColor = Color.red;

        /* 使用自定义材质
        Material lineMaterial = new Material(Shader.Find("Sprites/Default"));
        lineMaterial.color = Color.white;  // 你可以设置材质的颜色或其他属性
        lineRenderer.material = lineMaterial;
        /* 
        // 设置纹理模式
        lineRenderer.textureMode = LineTextureMode.Stretch; // 可选择 Stretch、Tile 或 DistributePerSegment

        // 设置线条拐角形状
        lineRenderer.numCapVertices = 10; // 使线条末端更加圆滑
        lineRenderer.numCornerVertices = 5; // 使拐角更加平滑
        */

        // 设置材质（此处使用默认材质，你可以自定义材质）
        lineRenderer.material = new Material(Shader.Find("Sprites/Default"));
        lineRenderer.positionCount = 0;

    }

    void Update()
    {
        // 获取当前路径
        NavMeshPath path = agent.path;

        // 更新LineRenderer的点数
        lineRenderer.positionCount = path.corners.Length;

        // 将路径的角点设置为LineRenderer的点
        lineRenderer.SetPositions(path.corners);
    }
}