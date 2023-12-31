using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buymenu : MonoBehaviour
{
    // GameObjects to Destroy
    public GameObject park;
    public GameObject desert;
    public GameObject fall;
    public GameObject hell;
    public GameObject tophat;
    public GameObject monacle;
    public GameObject angel;
    public GameObject devil;
    public GameObject crown;

    // GameObjects to SetActive
    public GameObject parkButton;
    public GameObject desertButton;
    public GameObject fallButton;
    public GameObject hellButton;
    public GameObject tophatButton;
    public GameObject monacleButton;
    public GameObject angelButton;
    public GameObject devilButton;
    public GameObject crownButton;

    [SerializeField] GameObject expBar;
    EXPBar level;

    void Start()
    {
        level = expBar.GetComponent<EXPBar>();
    }

    public void BuyPark()
    {
        if (level.level >= 5)
        {
            parkButton.SetActive(true);
            Destroy(park.gameObject);
        }
    }

    public void BuyDesert()
    {
        if (level.level >= 15)
        {
            desertButton.SetActive(true);
            Destroy(desert.gameObject);
        }

    }

    public void BuyFall()
    {
        if (level.level >= 25)
        {
            fallButton.SetActive(true);
            Destroy(fall.gameObject);
        }
    }

    public void BuyHell()
    {
        if (level.level >= 35)
        {
            hellButton.SetActive(true);
            Destroy(hell.gameObject);
        }


    }

    public void BuyTophat()
    {
        if (PlayerStats.money >= 10)
        {
            PlayerStats.money -= 10;
            tophatButton.SetActive(true);
            Destroy(tophat.gameObject);
        }
    }

    public void BuyMonacle()
    {
        if (PlayerStats.money >= 25)
        {
            PlayerStats.money -= 25;
            monacleButton.SetActive(true);
            Destroy(monacle.gameObject);
        }
    }

    public void BuyAngel()
    {
        if (PlayerStats.money >= 50)
        {
            PlayerStats.money -= 50;
            angelButton.SetActive(true);
            Destroy(angel.gameObject);
        }
    }

    public void BuyDevil()
    {
        if (PlayerStats.money >= 75)
        {
            PlayerStats.money -= 75;
            devilButton.SetActive(true);
            Destroy(devil.gameObject);
        }
    }

    public void BuyCrown()
    {
        if (PlayerStats.money >= 150)
        {
            PlayerStats.money -= 150;
            crownButton.SetActive(true);
            Destroy(crown.gameObject);
        }
    }

}
