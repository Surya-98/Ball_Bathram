using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class right : MonoBehaviour {

    public GameObject lift;
    public float speed = 20f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay(Collider other)
    {
        if (lift.transform.position.x < 40.76022)
            lift.transform.position += new Vector3(Time.deltaTime, 0, 0) * speed;
    }
}
