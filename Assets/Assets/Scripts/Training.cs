using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Training : MonoBehaviour
{
    public GameObject goodItem;
    public GameObject badItem;
    private GameObject itemToSpawn;

    public GameObject player;
    PlayerStats playerStats;

    public TextMeshProUGUI collectedText;

    public GameObject trainingUI;
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
        playerStats = player.GetComponent<PlayerStats>();
        
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
        collectedText.text = "Coins Earned: " + currentCoinsCollected.ToString();
        if (currentCoinsCollected > 5)
        {
            spawnDelay = 3f;
        }

        if (currentCoinsCollected >= 5)
        {
            spawnDelay = 2.5f;
        }
        if (currentCoinsCollected >= 10)
        {
            spawnDelay = 2;
        }
        if (currentCoinsCollected >= 15)
        {
            spawnDelay = 1.5f;
        }
        if (currentCoinsCollected >= 20)
        {
            spawnDelay = 1;
        }
        if (currentCoinsCollected >= 25)
        {
            spawnDelay = 0.5f;
        }
        if (currentCoinsCollected >= 30)
        {
            spawnDelay = 0.1f;
        }
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
         }


         if (isDodgeTraining == false)
         {
            currentSpawnDelay = 5;
            currentCoinsCollected = 0;
            ui.SetActive(true);
            trainingUI.SetActive(false);
         }
    }

    public void TrainingButton()
    {
        Time.timeScale = 1f;
        isDodgeTraining = false;
        player.transform.position = new Vector3(0.6f, -3.1f, 0);
        currentCoinsCollected = 0;
    }

}
