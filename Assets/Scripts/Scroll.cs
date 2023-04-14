using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{

    void Update()
    {
        transform.Translate(transform.forward * GameManager.Instance.GetScrollSpeed() * Time.deltaTime);
    }
}