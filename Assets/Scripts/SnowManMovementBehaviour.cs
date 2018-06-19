using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowManMovementBehaviour : MonoBehaviour {

    public float speed;
    private Rigidbody rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update ()
    {
        var jump = Input.GetAxis("Vertical");
        var movement = new Vector3(0, jump, 0);
        rb.AddForce(movement * speed);
	}
}
