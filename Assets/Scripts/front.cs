﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class front : MonoBehaviour {
    public GameObject lift;
    public float speed = 20f; 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerStay(Collider other)
    {
        if(lift.transform.position.z < 125.5631)
            lift.transform.position += new Vector3(0,0,Time.deltaTime)*speed;
    }
}
