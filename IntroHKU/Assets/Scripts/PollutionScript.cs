using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PollutionScript : MonoBehaviour
{
    public int pollution;
    public float pollutionAddTime = 3;
    public float timer;
    public Image pollutionBar;
    public DissasterScript dissasterScript;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= pollutionAddTime)
        {
            pollution++;
            dissasterScript.dissasterRate += dissasterScript.pollutionIncrease;
            pollutionBar.fillAmount = (float)pollution / 100;
            timer = 0;
        }
    }
}
