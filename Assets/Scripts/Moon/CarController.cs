using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour {

    public float speed = 1.0f;

    Rigidbody rgd;

    // Use this for initialization
    void Start () {
        rgd = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
		Move();
        Key();
	}

    void Move()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        //transform.Translate(Vector2.left * h * speed * Time.deltaTime);

        transform.Rotate(Vector3.up * Time.deltaTime * h * 50f);
        transform.Translate(Vector3.back * v * speed * Time.deltaTime);
    }

    void Key()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            transform.rotation = new Quaternion(0, 0, 0, 0);
    }
}
