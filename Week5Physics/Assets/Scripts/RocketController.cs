using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour
{
    public float Power = 5f;
    public float SpeedDirection = 5f;
    public Rigidbody rigidbody;

    private void Start()
    {
        rigidbody = GetComponent <Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime * SpeedDirection;
        //float vertical = Input.GetAxis("Vertical") * Time.deltaTime * Speed;

        //transform.Translate(horizontal, 0, 0);
        //Vector3 movement = new Vector3(horizontal, 0, vertical);
        //rigidbody.MovePosition(transform.position + movement);

        transform.Rotate(new Vector3(horizontal * SpeedDirection, 0, 0));

        if (Input.GetButtonDown("Jump"))
            rigidbody.AddRelativeForce(new Vector3(0, Power, 0));
    }
}
