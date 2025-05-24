using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickManager : MonoBehaviour
{

    //�J�E���g�p�̕ϐ���p��
    public int count = 0;

    //�e�L�X�g�^�̕ϐ���p�ӁB�X�R�A�\��
    public Text countText;

    //float�^�̕ϐ���p��
    public float time = 20.0f;

    //�e�L�X�g�^�̕ϐ���p�ӁB�^�C���\��
    public Text timeText;

    //�ϐ��𑝂₷�֐����쐬
    public void PushButton()
    {
        //time��0����̎�
        if (time > 0)
        {
            //count��1�����₷
            count++;

            //�������������e�L�X�g�ŕ\��
            countText.text = "�X�R�A:" + count;
        }
    }


    // Update is called once per frame
    void Update()
    {
        //time��0�ȉ��̎�
        if (time <= 0)
        {
            //�e�L�X�g�ɃJ�E���g�_�E���̕\��������
            timeText.text = "�^�C��:0.00";
        }
        else
        {
            //�J�E���g�_�E��������
            time -= Time.deltaTime;

            //�e�L�X�g�ɃJ�E���g�_�E���̕\��������
            timeText.text = "�^�C��:" + time.ToString("f2");
        }
    }
}