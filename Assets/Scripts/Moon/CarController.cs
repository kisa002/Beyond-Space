using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour {

    public float speed = 1.0f;

    public GameObject alien;

    GameObject bigDoor;

    Rigidbody rgd;

    public int battery = 0;

    // Use this for initialization
    void Start () {
        rgd = GetComponent<Rigidbody>();
        bigDoor = GameObject.Find("BigDoor");

        //alien = GameObject.Find("Alien");
        //alien.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		Move();
        Key();
        BigDoor();
	}

    void Move()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        //float transX = Input.GetAxis("Mouse X");
        //float transY = Input.GetAxis("Mouse Y");

        //transform.Translate(Vector2.left * h * speed * Time.deltaTime);

        transform.Rotate(Vector3.up * Time.deltaTime * h * 50f);
        transform.Translate(Vector3.forward * v * speed * Time.deltaTime);
    }

    void Key()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            transform.rotation = new Quaternion(0, 0, 0, 0);
    }

    void BigDoor()
    {
        if(battery >= 5)
        {
            if (bigDoor.transform.position.y > -23.0f)
                bigDoor.transform.Translate(Vector3.down * 0.05f);
            else
                Destroy(bigDoor);
        }
    }
    
    public void OnTriggerEnter(Collider other)
    {
        switch (other.name)
        {
            case "MachineRange":
                alien.SetActive(true);
                break;
        }
    }

    public void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Battery")
        {
            battery += 1;
            Destroy(other.gameObject);
        }
    }
}
