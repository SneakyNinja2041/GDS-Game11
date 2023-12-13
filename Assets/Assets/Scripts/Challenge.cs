using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Challenge : MonoBehaviour
{
    public GameObject challenge1;
    public GameObject challenge2;
    public GameObject challenge3;
    public GameObject challenge4;
    public GameObject challenge5;

    public GameObject spotlightWin;
    public GameObject spotlightLose;

    public bool SetChallenge1;
    public bool SetChallenge2;
    public bool SetChallenge3;
    public bool SetChallenge4;
    public bool SetChallenge5;

    private int enemyStat;

    public float fanfare = 3.0f;

    [SerializeField] GameObject ExpBar;
    EXPBar levels;

    public GameObject player;

    private void Start()
    {
        SetChallenge1 = true;
        SetChallenge2 = false;
        SetChallenge3 = false;
        SetChallenge4 = false;
        SetChallenge5 = false;

        levels = ExpBar.GetComponent<EXPBar>();
    }


    private void Update()
    {
        if (SetChallenge1 == true)
        {
            enemyStat = 10;
        }
        if (SetChallenge2 == true)
        {
            enemyStat = 20;
        }
        if(SetChallenge3 == true)
        {
            enemyStat = 30;
        }
        if(SetChallenge4 == true)
        {
            enemyStat = 40;
        }
        if(SetChallenge5 == true)
        {
            enemyStat = 50;
        }



    }



    public void Challenge()
    {   
        if(levels.level >= enemyStat)
        {
            StartCoroutine (WaitA(fanfare));
        }
        else
        {
            StartCoroutine (WaitB(fanfare));   
        }
    }


    private IEnumerator WaitA(float delay)
    {
        Debug.Log("Wait For 3 Seconds");
        yield return new WaitForSeconds(fanfare);
        spotlightWin.SetActive(true);
        yield return new WaitForSeconds(fanfare);
        player.transform.position = new Vector3(-1, -3.16f, 0);

        if(SetChallenge1 == true)
        {
            SetChallenge1 = false;
            SetChallenge2 = true;
        }
        if (SetChallenge2 == true)
        {
            SetChallenge2 = false;
            SetChallenge3 = true;
        }
        if (SetChallenge3 == true)
        {
            SetChallenge3 = false;
            SetChallenge4 = true;
        }
        if (SetChallenge4 == true)
        {
            SetChallenge4= false;
            SetChallenge5 = true;
        }
        if (SetChallenge5 == true)
        {
            SetChallenge5= false;

        }

    }

    private IEnumerator WaitB(float delay)
    {
        Debug.Log("Wait For 3 Seconds");
        yield return new WaitForSeconds(fanfare);
        spotlightLose.SetActive(true);
        yield return new WaitForSeconds(fanfare);
        player.transform.position = new Vector3(-1, -3.16f, 0);
    }

}
