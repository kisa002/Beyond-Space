using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryController : MonoBehaviour
{

	public float rotSpeed;

	Transform tr;

	Vector3 rot;

	// Use this for initialization
	void Start () 
	{
		tr = this.gameObject.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(transform.rotation.x <= 0.70)
			StoryAnimation1();

		//Debug.Log(transform.rotation.x);
	}

	public void StoryAnimation1()
	{
		tr.Rotate(Vector3.right * Time.deltaTime * rotSpeed);
	}
}
