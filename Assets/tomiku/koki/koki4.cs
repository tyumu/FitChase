using UnityEngine;

public class ConstantUpwardMovement4 : MonoBehaviour
{
    public float moveSpeed = 10f; // ��ɐi�ޑ��x�i���j�b�g/�b�j
    public float delayTime = 5f; // �ړ��J�n�܂ł̑ҋ@���ԁi�b�j

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
                Debug.Log("�ړ��J�n�I");
            }
        }

        if (canMove)
        {
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        }
    }
}


