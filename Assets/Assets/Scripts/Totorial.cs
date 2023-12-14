using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Totorial : MonoBehaviour
{
    [SerializeField] GameObject train;
    Training trains;

    private void Start()
    {
        trains = train.GetComponent<Training>();
    }

    private void Update()
    {
        if (trains.isDodgeTraining == true)
        {
            StartCoroutine(WaitC(1));
        }


    }

    private IEnumerator WaitC(float delay)
    {
        yield return new WaitForSeconds(9);
        Destroy(gameObject);
    }


}
