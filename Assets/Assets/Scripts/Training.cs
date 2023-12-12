using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Training : MonoBehaviour
{
    public GameObject goodItem;
    public GameObject badItem;
    private GameObject itemToSpawn;

    public GameObject ui;

    public float spawnDelay;
    private float currentSpawnDelay;

    public int coinsCollected;
    public int currentCoinsCollected;

    public bool isDodgeTraining;

    private int randomTemp;

    public AudioClip goodAudio;
    public AudioClip badAudio;

    public AudioSource audioSource;


    void Start()
    {
        currentSpawnDelay = spawnDelay;
        currentCoinsCollected = coinsCollected;
        isDodgeTraining = false;
    }

    private void GetItem()
    {
        randomTemp = Random.Range(1, 10);

        if (randomTemp <= 5)
        {
            itemToSpawn = badItem;
            audioSource.clip = badAudio;
        }
        else
        {
            itemToSpawn = goodItem;
            audioSource.clip = goodAudio;
        }

    }

    void Update()
    {


         if (isDodgeTraining == true)
         {
            ui.SetActive(false);

            currentSpawnDelay -= Time.deltaTime;
            if (currentSpawnDelay < 0)
            {
                GetItem();
                currentSpawnDelay = spawnDelay;
                var randomPosition = Random.Range(-40f, -20f);
                Instantiate(itemToSpawn, new Vector3(randomPosition, 13, 0), Quaternion.identity);
                audioSource.Play();
            }

            //i want the items to drop more frequently as time goes on


         }


         if (isDodgeTraining == false)
         {
            currentSpawnDelay = 10;
            currentCoinsCollected = 0;
            ui.SetActive(true);
         }
    }
}
