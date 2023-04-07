using UnityEngine;
using System.Collections;


public class Ground : MonoBehaviour
{

    int velocity = 10;

    void Start()
    {


    }

    void FixedUpdate()
    {
        transform.Translate(velocity * -Time.deltaTime, 0, 0);

    }
}