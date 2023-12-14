using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChallengeSwitch : MonoBehaviour
{
    public GameObject player;

    public bool isChallenge;

    public GameObject menuUI;

    [SerializeField] GameObject challenges;
    Challenge chal;

    private void Start()
    {
        chal = challenges.GetComponent<Challenge>();    
    }

    private void Update()
    {
        if (isChallenge == true)
        {
            menuUI.SetActive(false);
        }
        else
        {
            menuUI.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isChallenge = true;
        player.transform.position = new Vector3(26f, -1.5f, 0);
        chal.Challenge1();
        
    }


}
