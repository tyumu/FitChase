using UnityEngine;

public class ConstantUpwardMovement4 : MonoBehaviour
{
    public float moveSpeed = 10f; // 上に進む速度（ユニット/秒）
    public float delayTime = 5f; // 移動開始までの待機時間（秒）

    private float timer = 0f;
    private bool canMove = false;

    void Update()
    {
        if (!canMove)
        {
            timer += Time.deltaTime;
            if (timer >= delayTime)
            {
                canMove = true;
                Debug.Log("移動開始！");
            }
        }

        if (canMove)
        {
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        }
    }
}


