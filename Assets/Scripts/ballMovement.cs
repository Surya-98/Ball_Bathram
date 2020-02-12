using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMovement : MonoBehaviour {

    private Vector3 movement;
    public float movespeed;
    void Update()
    {
        movement = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));

        GetComponent<Rigidbody>().AddForce(movement * movespeed);
        if (transform.position.y < -20f)
            Application.LoadLevel("BallGame");

    }

}
