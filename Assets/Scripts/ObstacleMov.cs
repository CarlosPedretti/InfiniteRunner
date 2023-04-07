using UnityEngine;
using System.Collections;


public class ObstacleMov : MonoBehaviour
{

     int velocity = 10;

    void Start()
    {


    }


    void FixedUpdate()
    {
        transform.Translate(0, 0, velocity * -Time.deltaTime);

    }
}