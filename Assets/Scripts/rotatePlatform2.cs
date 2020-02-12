using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatePlatform2 : MonoBehaviour {
    Vector3 point;
    public float speed = 40f;
    // Use this for initialization
    void Start () {
        point = new Vector3(0, 0, 45.34f);
    }
	
	// Update is called once per frame
	void Update () {
        transform.RotateAround(point, Vector3.right, speed * Time.deltaTime);
        transform.Rotate(Vector3.left, speed * Time.deltaTime);
    }
}
