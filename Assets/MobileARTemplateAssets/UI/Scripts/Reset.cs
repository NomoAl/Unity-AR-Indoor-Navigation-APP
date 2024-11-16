using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetManager : MonoBehaviour
{
    public void ResetAllActions()
    {
        // 重置游戏状态或其他必要的操作
        Debug.Log("All actions have been reset.");

        // 示例：重置游戏数据、得分、位置等
        // GameManager.Instance.ResetGame();
        // ScoreManager.Instance.ResetScore();
        // Player.Instance.ResetPosition();
    }
}