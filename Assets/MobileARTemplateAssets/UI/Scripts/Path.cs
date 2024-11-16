using UnityEngine;
using UnityEngine.AI;

public class PathRenderer : MonoBehaviour
{
    public NavMeshAgent agent;  // ��NavMeshAgent
    private LineRenderer lineRenderer;

    void Start()
    {
        // ��ȡLineRenderer���
        lineRenderer = GetComponent<LineRenderer>();

        // ����LineRenderer�����ԣ���������ȺͲ��ʣ�
        lineRenderer.startWidth = 0.1f;
        lineRenderer.endWidth = 0.1f;
        // ������������ɫ
        lineRenderer.startColor = Color.green;
        lineRenderer.endColor = Color.red;

        /* ʹ���Զ������
        Material lineMaterial = new Material(Shader.Find("Sprites/Default"));
        lineMaterial.color = Color.white;  // ��������ò��ʵ���ɫ����������
        lineRenderer.material = lineMaterial;
        /* 
        // ��������ģʽ
        lineRenderer.textureMode = LineTextureMode.Stretch; // ��ѡ�� Stretch��Tile �� DistributePerSegment

        // ���������ս���״
        lineRenderer.numCapVertices = 10; // ʹ����ĩ�˸���Բ��
        lineRenderer.numCornerVertices = 5; // ʹ�սǸ���ƽ��
        */

        // ���ò��ʣ��˴�ʹ��Ĭ�ϲ��ʣ�������Զ�����ʣ�
        lineRenderer.material = new Material(Shader.Find("Sprites/Default"));
        lineRenderer.positionCount = 0;

    }

    void Update()
    {
        // ��ȡ��ǰ·��
        NavMeshPath path = agent.path;

        // ����LineRenderer�ĵ���
        lineRenderer.positionCount = path.corners.Length;

        // ��·���Ľǵ�����ΪLineRenderer�ĵ�
        lineRenderer.SetPositions(path.corners);
    }
}