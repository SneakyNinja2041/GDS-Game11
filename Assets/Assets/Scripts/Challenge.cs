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

    public GameObject introText1;
    public GameObject introText2;
    public GameObject introText3;
    public GameObject introText4;
    public GameObject introText5;

    public GameObject winnerText;

    public GameObject winText;

    public GameObject loseText1;
    public GameObject loseText2;       
    public GameObject loseText3;
    public GameObject loseText4;
    public GameObject loseText5;

    public GameObject spotlightWin;
    public GameObject spotlightLose;

    public bool SetChallenge1;
    public bool SetChallenge2;
    public bool SetChallenge3;
    public bool SetChallenge4;
    public bool SetChallenge5;

    public AudioSource audioSource;
    public AudioClip bgMusic;
    public AudioClip challengeMusic;

    private int enemyStat;

    public float fanfare = 3.0f;

    [SerializeField] GameObject ExpBar;
    EXPBar levels;

    public GameObject player;

    [SerializeField] GameObject fight;
    ChallengeSwitch chal;

    private void Start()
    {
        SetChallenge1 = true;
        SetChallenge2 = false;
        SetChallenge3 = false;
        SetChallenge4 = false;
        SetChallenge5 = false;

        levels = ExpBar.GetComponent<EXPBar>();

        chal = fight.GetComponent<ChallengeSwitch>();
    }


    private void Update()
    {
        if (SetChallenge1 == true)
        {
            enemyStat = 10;
            challenge1.SetActive(true);
        }
        else
        {
            challenge1.SetActive(false);
        }
        if (SetChallenge2 == true)
        {
            enemyStat = 20;
            challenge2.SetActive(true);
        }
        else
        {
            challenge2.SetActive(false);
        }
        if(SetChallenge3 == true)
        {
            enemyStat = 30;
            challenge3.SetActive(true);
        }
        else
        {
            challenge3.SetActive(false);
        }
        if(SetChallenge4 == true)
        {
            enemyStat = 40;
            challenge4.SetActive(true);
        }
        else
        {
            challenge4.SetActive(false);
        }
        if(SetChallenge5 == true)
        {
            enemyStat = 50;
            challenge5.SetActive(true);
        }
        else
        {
            challenge5.SetActive(false);
        }



    }



    public void Challenge1()
    {
        audioSource.Stop();
        audioSource.clip = challengeMusic;
        audioSource.Play();

        if (levels.level >= enemyStat)
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
        yield return new WaitForSeconds(3);

 


        if (SetChallenge5 == true)
        {
            introText5.SetActive(true);
            yield return new WaitForSeconds(6);
            introText5.SetActive(false);
            winnerText.SetActive(true);
            yield return new WaitForSeconds(3);
            winnerText.SetActive(false);
            spotlightWin.SetActive(true);
            winText.SetActive(true);
            yield return new WaitForSeconds(4);
            chal.isChallenge = false;
            player.transform.position = new Vector3(-1, -3.16f, 0);
            SetChallenge5 = false;
            spotlightWin.SetActive(false);
        }

        if (SetChallenge4 == true)
        {
            introText4.SetActive(true);
            yield return new WaitForSeconds(6);
            introText4.SetActive(false);
            winnerText.SetActive(true);
            yield return new WaitForSeconds(3);
            winnerText.SetActive(false);
            spotlightWin.SetActive(true);
            winText.SetActive(true);
            yield return new WaitForSeconds(4);
            chal.isChallenge = false;
            player.transform.position = new Vector3(-1, -3.16f, 0);
            SetChallenge4 = false;
            SetChallenge5 = true;
            spotlightWin.SetActive(false);
            winText.SetActive(false);
        }
        if (SetChallenge3 == true)
        {

            introText3.SetActive(true);
            yield return new WaitForSeconds(6);
            introText3.SetActive(false);
            winnerText.SetActive(true);
            yield return new WaitForSeconds(3);
            winnerText.SetActive(false);
            spotlightWin.SetActive(true);
            winText.SetActive(true);
            yield return new WaitForSeconds(4);
            chal.isChallenge = false;
            player.transform.position = new Vector3(-1, -3.16f, 0);
            SetChallenge3 = false;
            SetChallenge4 = true;
            spotlightWin.SetActive(false);
            winText.SetActive(false);
        }
        if (SetChallenge2 == true)
        {

            introText2.SetActive(true);
            yield return new WaitForSeconds(6);
            introText2.SetActive(false);
            winnerText.SetActive(true);
            yield return new WaitForSeconds(3);
            winnerText.SetActive(false);
            spotlightWin.SetActive(true);
            winText.SetActive(true);
            yield return new WaitForSeconds(4);
            chal.isChallenge = false;
            player.transform.position = new Vector3(-1, -3.16f, 0);
            SetChallenge2 = false;
            SetChallenge3 = true;
            spotlightWin.SetActive(false);
            winText.SetActive(false);
        }
        if (SetChallenge1 == true)
        {
            introText1.SetActive(true);
            yield return new WaitForSeconds(6);
            introText1.SetActive(false);
            winnerText.SetActive(true);
            yield return new WaitForSeconds(3);
            winnerText.SetActive(false);
            spotlightWin.SetActive(true);
            winText.SetActive(true);
            yield return new WaitForSeconds(4);
            chal.isChallenge = false;
            player.transform.position = new Vector3(-1, -3.16f, 0);
            spotlightWin.SetActive(false);
            winText.SetActive(false);
            SetChallenge1 = false;
            SetChallenge2 = true;

        }
        audioSource.Stop();
        audioSource.clip = bgMusic;
        audioSource.Play();
    }

    private IEnumerator WaitB(float delay)
    {
        Debug.Log("Wait For 3 Seconds");
        yield return new WaitForSeconds(3);

        if (SetChallenge1 == true)
        {
            introText1.SetActive(true);
            yield return new WaitForSeconds(6);
            introText1.SetActive(false);
            winnerText.SetActive(true);
            yield return new WaitForSeconds(3);
            winnerText.SetActive(false);
            spotlightLose.SetActive(true);
            loseText1.SetActive(true);
            yield return new WaitForSeconds(4);
            chal.isChallenge = false;
            loseText1.SetActive(false);
        }
        if (SetChallenge2 == true)
        {

            introText2.SetActive(true);
            yield return new WaitForSeconds(6);
            introText2.SetActive(false);
            winnerText.SetActive(true);
            yield return new WaitForSeconds(3);
            winnerText.SetActive(false);
            spotlightLose.SetActive(true);
            loseText2.SetActive(true);
            yield return new WaitForSeconds(4);
            chal.isChallenge = false;
            loseText2.SetActive(false);
        }
        if (SetChallenge3 == true)
        {

            introText3.SetActive(true);
            yield return new WaitForSeconds(6);
            introText3.SetActive(false);
            winnerText.SetActive(true);
            yield return new WaitForSeconds(3);
            winnerText.SetActive(false);
            spotlightLose.SetActive(true);
            loseText3.SetActive(true);
            yield return new WaitForSeconds(4);
            chal.isChallenge = false;
            loseText3.SetActive(false);
        }
        if (SetChallenge4 == true)
        {
            introText4.SetActive(true);
            yield return new WaitForSeconds(6);
            introText4.SetActive(false);
            winnerText.SetActive(true);
            yield return new WaitForSeconds(3);
            winnerText.SetActive(false);
            spotlightLose.SetActive(true);
            loseText4.SetActive(true);
            yield return new WaitForSeconds(4);
            chal.isChallenge = false;
            loseText4.SetActive(false);
        }
        if (SetChallenge5 == true)
        {
            introText5.SetActive(true);
            yield return new WaitForSeconds(6);
            introText5.SetActive(false);
            winnerText.SetActive(true);
            yield return new WaitForSeconds(3);
            winnerText.SetActive(false);
            spotlightLose.SetActive(true);
            loseText5.SetActive(true);
            yield return new WaitForSeconds(4);
            chal.isChallenge = false;
            loseText5.SetActive(false);

        }
        player.transform.position = new Vector3(-1, -3.16f, 0);
        spotlightLose.SetActive(false);
        audioSource.Stop();
        audioSource.clip = bgMusic;
        audioSource.Play();
    }

}
