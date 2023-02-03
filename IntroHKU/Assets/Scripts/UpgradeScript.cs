using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeScript : MonoBehaviour
{
    [SerializeField]
    public enum upgradeType
    { 
        INCOME,
        CONSUMER_ACTION,
        PRODUCER_ACTION
    }
    [SerializeField]
    public upgradeType type;
    [SerializeField]
    private Button upgradeButton;
    [SerializeField]
    private Button[] otherUpgradeButtons;

    public void Interact()
    {
        upgradeButton.gameObject.SetActive(true);

        for (int i = 0; i < otherUpgradeButtons.Length; i++)
        {
            otherUpgradeButtons[i].gameObject.SetActive(false);
        }
    }

    public void Upgrade()
    { 
        
    }
}
