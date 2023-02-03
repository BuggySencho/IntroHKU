using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class IncomeUpgrade : MonoBehaviour
{
    public int cost;
    public int incomeEffect;
    public int decreaseEffect;
    public int currentLvl = 0;
    public int maxLvl = 3;
    public GameScript gameScript;
    public TMP_Text lvlText;

    private void Start()
    {
        gameScript = FindObjectOfType<GameScript>();
    }

    public void Upgrade()
    {
        if (gameScript.currentMoney < cost)
        {
            return;
        }
        currentLvl++;
        lvlText.text = "Lvl." + currentLvl;

        if (currentLvl == maxLvl)
        {
            gameObject.GetComponent<Button>().interactable = false;
            lvlText.text = "Lvl.MAX";
        }

        gameScript.currentMoney -= cost;
        gameScript.moneyText.text = "€" + gameScript.currentMoney;
        gameScript.increaseMoney += incomeEffect;
        gameScript.dissasterDecreaseIncome -= decreaseEffect;
    }
}
