using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollo : MonoBehaviour
{
    public Transform target1;
    public Transform target2;

    public float smoothing = 5f;
    public Vector3 offset = new Vector3(0f, 0f, 0f);

    [SerializeField] GameObject dropper;
    Training training;

    void Start()
    {
        training = dropper.GetComponent<Training>();

    }


    private void FixedUpdate()
    {
           
        if (training.isDodgeTraining == true)
        {
            Vector3 targetPosition = target2.position + offset;
            transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing * Time.fixedDeltaTime);
        }
        else
        {
            Vector3 targetPosition = target1.position + offset;
            transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing * Time.fixedDeltaTime);

        }

    }



}
