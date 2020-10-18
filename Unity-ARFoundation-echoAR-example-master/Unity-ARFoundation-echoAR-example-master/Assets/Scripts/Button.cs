using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    public GameObject FutureCamPanel, DailyLogPanel, EcoHabitsPanel, MissionsPanel;

    void Start()
    {
        DailyLogPanel.SetActive(false);
    }

    public void OpenDailyLog()
    {
        DailyLogPanel.SetActive(true);
        FutureCamPanel.SetActive(false);
    }
}