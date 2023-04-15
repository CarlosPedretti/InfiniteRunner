using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{

    [SerializeField] private GameManager coins;
    [SerializeField] private int valueCoins;


    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {

            coins.AdditionCoins(valueCoins);
            Destroy(gameObject);
        }
    }

    void Update()
    {
        
    }
}
