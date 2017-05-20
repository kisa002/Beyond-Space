using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public float rotSpeed = 1.0f;

	private Transform tr;

	void Start () {
		tr = GetComponent<Transform>();
	}
	
	void Update () {
		Controller();
	}
	private void Controller()
	{
		tr.Rotate(Vector3.up * Time.deltaTime * rotSpeed * Input.GetAxis("Mouse X"));
		tr.Rotate(Vector3.left * Time.deltaTime * rotSpeed * Input.GetAxis("Mouse Y"));
	}
}
