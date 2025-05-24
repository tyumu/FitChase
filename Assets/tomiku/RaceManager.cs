using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RaceManager : MonoBehaviour
{
    public static RaceManager Instance;

    public TextMeshProUGUI rankText;
    public GameObject resultPanel;

    private List<string> finishOrder = new List<string>();
    private float raceTime = 0f;
    private bool raceStarted = true;

    void Awake()
    {
        Instance = this;
    }

    void Update()
    {
        if (raceStarted)
        {
            raceTime += Time.deltaTime;
        }
    }

    public void RegisterFinish(string carName)
    {
        if (!finishOrder.Contains(carName))
        {
            finishOrder.Add(carName);
            int rank = finishOrder.Count;

            if (carName == "Player")
            {
                raceStarted = false;
                rankText.text = $"Ç†Ç»ÇΩÇÕ {rank} à Ç≈ÇµÇΩÅI\nÉ^ÉCÉÄ: {raceTime:F2} ïb";
                resultPanel.SetActive(true);
            }
        }
    }
}

