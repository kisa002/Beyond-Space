using UnityEngine;
using System.Collections;

public class ThrustMainBlock : MonoBehaviour {

	public float thrust = 50;
	public Rigidbody rocket;
	public bool EngineOn;
	//public AudioClip engine;
	//AudioSource audio;




	void Start () 
	{
		rocket = GetComponent<Rigidbody> ();
		EngineOn = false;
		//audio = GetComponent<AudioSource>();
		}
	

	void Update()
	{
		EngineStart ();
		if (EngineOn == true) 
		rocket.AddRelativeForce (0, thrust, 0, ForceMode.Force);


	}
	private void EngineStart()
	{
		
		if (Input.GetKey ("up")) {
			EngineOn = true;
			//audio.PlayOneShot (engine, 0.5F);
		
		}
	}

}
