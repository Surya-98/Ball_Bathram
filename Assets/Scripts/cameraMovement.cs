using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour {

    public float x;
    public float y;
    public float z;

    public Transform target;

    void Update()
    {
        transform.position = new Vector3(target.position.x, target.position.y, target.position.z) + new Vector3(x, y, z);
    }

}
