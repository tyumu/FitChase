
using System.Collections.Generic;
using UnityEngine;

public class RaceManager1: MonoBehaviour
{
    public static RaceManager1 Instance;


    private List<string> finishOrder = new List<string>();

    void Awake()
    {
        Instance = this;
    }

    public void RegisterFinish(string carName)
    {
        if (!finishOrder.Contains(carName))
        {
            finishOrder.Add(carName);
            int rank = finishOrder.Count;

            Debug.Log($"{carName} ���S�[���I ����: {rank}��");

            if (carName == "Player")
            {
                Debug.Log($"���Ȃ��� {rank} �ʂł����I");
            }
        }
    }
}

