using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetManager : MonoBehaviour
{
    public void ResetAllActions()
    {
        // ������Ϸ״̬��������Ҫ�Ĳ���
        Debug.Log("All actions have been reset.");

        // ʾ����������Ϸ���ݡ��÷֡�λ�õ�
        // GameManager.Instance.ResetGame();
        // ScoreManager.Instance.ResetScore();
        // Player.Instance.ResetPosition();
    }
}