using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryController : MonoBehaviour
{

	public float rotSpeed;

	Transform tr;

	Vector3 rot;

	Rigidbody rgd;

	int storyStage = 1;

	bool isStory = false;

    FauxGravityAttractor attractor;

	// Use this for initialization
	void Start () 
	{
		tr = GetComponent<Transform>();
		rgd = GetComponent<Rigidbody>();

		isStory = true;

        attractor.enabled = false;
	}
	
	void FixedUpdate()
	{
		StoryAnimation(storyStage);
	}

	public void StoryAnimation(int stage)
	{
		if(isStory)
		{
			switch(stage)
			{
				case 1:
					if(transform.rotation.x <= 0.70)
						tr.Rotate(Vector3.right * Time.deltaTime * rotSpeed);
					else
					{
						storyStage++;
						rgd.useGravity = true;
					}
					break;
				
				case 2:
					if(tr.position.y < -1100)
						rgd.AddForce(Vector3.up * 20f);
					else
                    {
                        //rgd.AddForce(Vector3.up * 1f);
                        //rgd.useGravity = false;

                        GameManager.story = 3;
                        attractor.enabled = true;
                    }
					break;
			}
		}
	}
}
