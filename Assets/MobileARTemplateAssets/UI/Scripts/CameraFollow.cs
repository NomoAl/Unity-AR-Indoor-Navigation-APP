using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;    // 被导航的对象
    public Vector3 offset = new Vector3(0, 5, -10); // 摄像机相对于目标的偏移量
    public float followSpeed = 10f; // 跟随的速度
    private bool isFirstPerson = false; // 内部状态，用于跟踪当前是否为第一视角


    void LateUpdate()
    {
        if (target != null)
        {
            // 计算摄像机应该在的位置
            Vector3 targetPosition = target.position + offset;

            // 平滑移动摄像机的位置
            transform.position = Vector3.Lerp(transform.position, targetPosition, followSpeed * Time.deltaTime);

            // 摄像机看向目标
            transform.LookAt(target);
        }
    }

    public void ToggleCameraView()
    {
        isFirstPerson = !isFirstPerson; // 切换状态
        if (isFirstPerson)
        {
            offset = Vector3.zero; // 第一视角
        }
        else
        {
            offset = new Vector3(5, 10, 5); // 第三视角
        }
    }
}