using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finalObstacle : MonoBehaviour {
    public GameObject floor1;
    public GameObject floor2;
    public GameObject finalFloor;
    public bool switchon = false;
    private MeshRenderer meshrend;
    public ParticleSystem particleSystem;
    //public switch_activator switch_Activator;
    private float speed = 20f;
    public int i = 0;


	// Use this for initialization
	void Start () {
        floor1.transform.position = new Vector3(floor1.transform.position.x + 10f, floor1.transform.position.y, floor1.transform.position.z);
        floor2.transform.position = new Vector3(floor2.transform.position.x - 10f, floor2.transform.position.y, floor2.transform.position.z);
        meshrend = gameObject.GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update () {
        //switch_Activator = GetComponent<switch_activator>();
        if (switchon && i==0)
        {
            floor1.transform.position = new Vector3(floor1.transform.position.x - 10f, floor1.transform.position.y, floor1.transform.position.z);
            floor2.transform.position = new Vector3(floor2.transform.position.x + 10f, floor2.transform.position.y, floor2.transform.position.z);
            switchon = false;
            i = 1;
        }
        
        if(i==1)
        {
            floor1.transform.RotateAround(finalFloor.transform.position, Vector3.up, speed * Time.deltaTime);
            floor2.transform.RotateAround(finalFloor.transform.position, Vector3.down, speed * Time.deltaTime);
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("on");
        switchon = true;
        meshrend.enabled = false;
        Destroy(particleSystem);
    }
}
