using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float hSpeed = 1.0f;

	float h, v;

	GameObject mainCamera;
	Transform tr;
	CameraController cameraController;

	void Start ()
	{
		tr = GetComponent<Transform>();

		mainCamera = GameObject.Find("Main Camera");

		cameraController = mainCamera.GetComponent<CameraController>();
		cameraController.enabled = false;
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
}
