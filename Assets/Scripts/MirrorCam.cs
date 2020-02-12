using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorCam : MonoBehaviour {

    public Transform MirrorCamera;
    public Transform PlayerCamera;

	// Update is called once per frame
	void Update ()
    {
        CalculateRotation();	
	}

    public void CalculateRotation()
    {
        Vector3 dir = (PlayerCamera.position - transform.position).normalized;
        Quaternion rot = Quaternion.LookRotation(dir);

        rot.eulerAngles = transform.eulerAngles - rot.eulerAngles;

        MirrorCamera.localRotation = rot;

    }
}
