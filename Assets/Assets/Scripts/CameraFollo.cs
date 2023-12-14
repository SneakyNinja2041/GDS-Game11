using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollo : MonoBehaviour
{
    public Transform target1;
    
    public Transform target3;  

    public float smoothing = 5f;
    public Vector3 offset = new Vector3(0f, 0f, 0f);

    [SerializeField] GameObject dropper;
    Training training;

    [SerializeField] GameObject fight;
    ChallengeSwitch challenge;

    void Start()
    {
        training = dropper.GetComponent<Training>();
        challenge = fight.GetComponent<ChallengeSwitch>();
    }


    private void FixedUpdate()
    {
           
        if (training.isDodgeTraining == true)
        {
            transform.position = new Vector3(-31.5f, 0, -1f);
        }
        if (challenge.isChallenge == true)
        {
            Vector3 targetPosition = target3.position + offset;
            transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing * Time.fixedDeltaTime);
        }
        else
        {
            Vector3 targetPosition = target1.position + offset;
            transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing * Time.fixedDeltaTime);

        }

    }



}
