using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ReducePollution : MonoBehaviour
{
    public int cost;
    public float pollutionEffect;
    public int currentLvl = 0;
    public int maxLvl = 3;
    public PollutionScript pollutionScript;
    public TMP_Text lvlText;
    public GameScript gameScript;

    private void Start()
    {
        gameScript = FindObjectOfType<GameScript>();
        pollutionScript = FindObjectOfType<PollutionScript>();
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
            FindObjectOfType<GameScript>().IncreaseMaxedPollution();
            lvlText.text = "Lvl.MAX";
        }

        gameScript.currentMoney -= cost;
        pollutionScript.pollutionAddTime += pollutionEffect;
        gameScript.moneyText.text = "€" + gameScript.currentMoney;
    }
}
