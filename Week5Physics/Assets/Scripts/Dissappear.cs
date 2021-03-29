using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dissappear : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GetCoinPoint.ScoreValue += 10;
            Destroy(gameObject);
        }
    }
}
