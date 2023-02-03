using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class TimeScript : MonoBehaviour
{
    private int months;
    private int years;
    private int maxDays;
    private int maxMonths = 12;
    private float realTimeSeconds;
    [SerializeField]
    private float monthDuration;
    [SerializeField]
    private TMP_Text time;
    public GameScript gameScript;
    public int totalMonths;

    // Start is called before the first frame update
    void Start()
    {
        months = 1;
        years = 2023;
        time.text = "month: " + months + " year: " + years;
    }

    // Update is called once per frame
    void Update()
    {
        realTimeSeconds += Time.deltaTime;


        if (realTimeSeconds >= monthDuration)
        {
            months++;
            totalMonths++;
            realTimeSeconds = 0;
            time.text = "month: " + months + " year: " + years;
            gameScript.currentMoney += gameScript.increaseMoney;
            gameScript.moneyText.text = "€" + gameScript.currentMoney;

            if (months >= 12)
            {
                years++;
                months = 1;
                time.text = "month: " + months + " year: " + years;
            }
        }
    }
}
