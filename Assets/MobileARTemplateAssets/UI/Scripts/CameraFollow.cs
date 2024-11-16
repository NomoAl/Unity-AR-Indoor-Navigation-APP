using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;    // �������Ķ���
    public Vector3 offset = new Vector3(0, 5, -10); // ����������Ŀ���ƫ����
    public float followSpeed = 10f; // ������ٶ�
    private bool isFirstPerson = false; // �ڲ�״̬�����ڸ��ٵ�ǰ�Ƿ�Ϊ��һ�ӽ�


    void LateUpdate()
    {
        if (target != null)
        {
            // ���������Ӧ���ڵ�λ��
            Vector3 targetPosition = target.position + offset;

            // ƽ���ƶ��������λ��
            transform.position = Vector3.Lerp(transform.position, targetPosition, followSpeed * Time.deltaTime);

            // ���������Ŀ��
            transform.LookAt(target);
        }
    }

    public void ToggleCameraView()
    {
        isFirstPerson = !isFirstPerson; // �л�״̬
        if (isFirstPerson)
        {
            offset = Vector3.zero; // ��һ�ӽ�
        }
        else
        {
            offset = new Vector3(5, 10, 5); // �����ӽ�
        }
    }
}