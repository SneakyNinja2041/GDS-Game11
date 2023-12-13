using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChallengeSwitch : MonoBehaviour
{
    public GameObject player;

    public bool isChallenge;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isChallenge = true;
        player.transform.position = new Vector3(25.25f, -3.1f, 0);
        //freeze player movement
    }


}
