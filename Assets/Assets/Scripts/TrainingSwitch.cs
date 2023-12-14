using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainingSwitch : MonoBehaviour
{
    public GameObject dropper;
    Training training;

    public GameObject player;

    public AudioSource audioSource;
    public AudioClip clip;

    

    void Start()
    {
        training = dropper.GetComponent<Training>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            training.isDodgeTraining = true;
            player.transform.position = new Vector3(-26.7f, -3.1f, 0);
            audioSource.Stop();
            audioSource.clip = clip;
            audioSource.Play();
        }


    }


}
