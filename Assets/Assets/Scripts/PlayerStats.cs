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
            money++;
            training.currentCoinsCollected++;
            exp.ExpUp();
        }

        if (other.CompareTag("Rock"))
        {
            training.trainingUI.SetActive(true);
            Time.timeScale = 0f;
        }


    }
}
