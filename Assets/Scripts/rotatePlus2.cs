using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatePlus2 : MonoBehaviour {

    public float speed = 0.5f;   
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(0, -90, 0) * speed * Time.deltaTime);
    }
}
