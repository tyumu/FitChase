using UnityEngine;

public class SpeedControl1 : MonoBehaviour
{
    public float speedIncrement = 1f;
    public float moveSpeed = 0f;
    public float maxInputTime = 5f;

    private float inputTimer = 0f;
    private bool isMoving = false;

    void Update()
    {
        if (!isMoving)
        {
            inputTimer += Time.deltaTime;

            if (inputTimer < maxInputTime)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    moveSpeed += speedIncrement;
                    Debug.Log("���݂̑���: " + moveSpeed);
                }
            }
            else
            {
                isMoving = true;
                Debug.Log("�ړ��J�n�I");
            }
        }
        else
        {
            // ������Ɉړ�
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        }
    }
}
