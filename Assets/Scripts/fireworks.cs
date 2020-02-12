using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireworks : MonoBehaviour {

    public ParticleSystem ps;

    // Use this for initialization
    void Start () {
        ps.GetComponent<ParticleSystem>().enableEmission = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("on spot000");
        ps.GetComponent<ParticleSystem>().enableEmission = true;
       
    }
}
