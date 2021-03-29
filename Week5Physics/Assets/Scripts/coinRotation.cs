using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinRotation : MonoBehaviour
{
    public float Speed = 5f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * Speed);

        //var Vector3randompoint = new Vector3(Random.Range(-100, 100), Random.Range(-20, 20));

        //gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, Vector3randompoint, Time.deltaTime * Speed);
    }
}
