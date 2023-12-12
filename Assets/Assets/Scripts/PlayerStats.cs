using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerStats : MonoBehaviour
{
    public static int money;
    public int startMoney = 0;

    public TextMeshProUGUI moneyText;

    [SerializeField] GameObject expBar;
    EXPBar exp;

    [SerializeField] GameObject dropper;
    Training training;

    void Start()
    {
        money = startMoney;
        exp = expBar.GetComponent<EXPBar>();
        training = dropper.GetComponent<Training>();
    }

    void Update()
    {
        moneyText.text = "Money: $" + money.ToString();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Money"))
        {
            training.currentCoinsCollected++;

            money += 2;
        }

        if (other.CompareTag("Rock"))
        {
            // tell the player that they were hit
            //wait a bit to send them back, to show stats

            training.isDodgeTraining = false;
        }


    }
}
