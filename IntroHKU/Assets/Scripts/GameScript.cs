using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameScript : MonoBehaviour
{
    [SerializeField]
    private UpgradeScript[] upgrade;
    public int totalMaxedPollutionUpgrades;
    public int maxPollutionUpgrades = 6;
    public int currentMoney = 100;
    public int increaseMoney = 10;
    public TMP_Text moneyText;
    public int dissasterDecreaseIncome = 200;
    public TMP_Text score;
    public GameObject scoreUI;
    public GameObject gameUI;

    public void IncreaseMaxedPollution()
    {
        totalMaxedPollutionUpgrades++;

        if (totalMaxedPollutionUpgrades >= maxPollutionUpgrades)
        {
            scoreUI.SetActive(true);
            score.text = "You won in " + FindObjectOfType<TimeScript>().totalMonths + " months";
            Time.timeScale = 0;
            gameUI.SetActive(false);
        }
    }


}
