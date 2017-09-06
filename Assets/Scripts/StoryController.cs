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

    ThrustMainBlock tmb;

    Camera mainCamera;

	// Use this for initialization
	void Start () 
	{
		tr = GetComponent<Transform>();
		rgd = GetComponent<Rigidbody>();

		isStory = true;

        tmb = GameObject.Find("rocket7").GetComponent<ThrustMainBlock>();

        mainCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
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
					if(transform.rotation.x <= 0.7) //0.70 or 0
						tr.Rotate(Vector3.right * Time.deltaTime * rotSpeed);
					else
					{
						storyStage++;
                        //tmb.EngineOn = true;
                        //tmb.thrust = 0;

                        //StartCoroutine(Booster());

                        //rgd.useGravity = true;
                    }
					break;

                case 2:
                    if (tr.position.y < -1100)
                        rgd.AddForce(Vector3.up * 20f);
                    else
                    {
                        rgd.AddForce(Vector3.up * 1f);
                        rgd.useGravity = false;

                        GameManager.story = 3;
                    }
                    break;
            }
        }
	}

    IEnumerator Booster()
    {
        Debug.Log(tmb.thrust);

        if (tmb.thrust <= 3000)
        {
            tmb.thrust += 50;

            yield return new WaitForSeconds(0.1f);

            StartCoroutine(Booster());
        }
    }
    
}
