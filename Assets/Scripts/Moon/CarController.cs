using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour {

    public FauxGravityAttractor attractor;
    private Transform myTransform;

    Rigidbody rgd;
    GravityZone gravityZone;

    // Use this for initialization
    void Start () {
        rgd = GetComponent<Rigidbody>();

        rgd.constraints = RigidbodyConstraints.FreezeRotation;

        myTransform = transform;
        gravityZone = GameObject.Find("MoonGround").GetComponent<GravityZone>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate()
    {
        if (gravityZone)
            gravityZone.Attract(myTransform);
    }
}
