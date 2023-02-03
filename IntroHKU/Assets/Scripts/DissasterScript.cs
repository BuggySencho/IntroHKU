using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DissasterScript : MonoBehaviour
{
    public float dissasterRate;
    public string[] dissasters;
    public string[] countries;
    public float timer;
    public int checkRate = 6;
    public GameScript gameScript;
    public TMP_Text dissasterText;
    public float pollutionIncrease;

    // Start is called before the first frame update
    void Start()
    {
        gameScript = FindObjectOfType<GameScript>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= checkRate)
        {
            timer = 0;

            if (Random.Range(0, 100) < dissasterRate)
            {
                int randomDissaster = Random.Range(0, dissasters.Length);
                int randomCountry = Random.Range(0, countries.Length);
                gameScript.currentMoney -= gameScript.dissasterDecreaseIncome;
                gameScript.moneyText.text = "€" + gameScript.currentMoney;
                dissasterText.text = countries[randomCountry] + " has been hit by a " + dissasters[randomDissaster];
                dissasterText.gameObject.SetActive(false);
                dissasterText.gameObject.SetActive(true);
            }
        }
    }
}
