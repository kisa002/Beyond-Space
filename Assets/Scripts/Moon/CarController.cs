using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour {

    public float speed = 1.0f;

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
		Move();
	}

    void FixedUpdate()
    {
        if (gravityZone)
            gravityZone.Attract(myTransform);
    }

    void Move()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        transform.Translate(Vector2.left * h * speed * Time.deltaTime);
        transform.Translate(Vector3.back * v * speed * Time.deltaTime);
    }
}
