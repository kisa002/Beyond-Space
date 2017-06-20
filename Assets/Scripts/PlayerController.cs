using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

	public float hSpeed = 1.0f;

	float h, v;

	GameObject mainCamera;
	Transform tr;
	CameraController cameraController;

    public FauxGravityAttractor attractor;
    private Transform myTransform;

    Rigidbody rgd;

    void Start ()
	{
		tr = GetComponent<Transform>();

		mainCamera = GameObject.Find("Main Camera");

		cameraController = mainCamera.GetComponent<CameraController>();
        //cameraController.enabled = false;

        rgd = GetComponent<Rigidbody>();

        rgd.constraints = RigidbodyConstraints.FreezeRotation;

        myTransform = transform;
        attractor = GameObject.Find("MoonGround").GetComponent<FauxGravityAttractor>();
    }

    void FixedUpdate()
    {
        if (attractor)
        {
            if(GameManager.story == 3)
                attractor.Attract(myTransform);
        }
    }

    void Update ()
	{
		Move();
	}

	void Move()
	{
		h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        Vector3 moveDir = (Vector3.forward * v) + (Vector3.right * h);

        tr.Translate(moveDir.normalized * Time.deltaTime * hSpeed  , Space.Self);
	}

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "MoonGround")
            SceneManager.LoadScene("Moon");
    }
}
