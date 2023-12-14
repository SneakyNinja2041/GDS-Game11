using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinFall : MonoBehaviour
{

    [SerializeField] GameObject switchTrain;
    Training train;
    private void Start()
    {
        train = switchTrain.GetComponent<Training>();
    }

    private void Update()
    {
        if (train.isDodgeTraining == true)
        {
            Destroy(gameObject);
        }

    }


}
