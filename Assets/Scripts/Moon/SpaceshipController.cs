using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipController : MonoBehaviour {

    Rigidbody rgd;

    public int storyStage = 1;

    public float speed = 5f;

    GameObject car;

    Camera carCamera;
    Camera spaceshipCamera;

	// Use this for initialization
	void Start () {
        rgd = GetComponent<Rigidbody>();

        rgd.useGravity = false;

        car = GameObject.Find("Car");

        carCamera = GameObject.Find("CarCamera").GetComponent<Camera>();
        spaceshipCamera = GameObject.Find("SpaceshipCamera").GetComponent<Camera>();

        car.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        Story(storyStage);
	}

    void Story(int stage)
    {
        switch(stage)
        {
            case 1:
                //rgd.AddForce(Vector3.down * speed);
                if (transform.position.y >= 3f)
                    transform.Translate(Vector3.down * speed * Time.deltaTime);
                else
                {
                    storyStage = 2;
                    StartCoroutine(NextStage());
                }
                break;

            case 3:
                spaceshipCamera.enabled = false;
                car.SetActive(true);
                storyStage++;
                break;
        }
    }

    IEnumerator NextStage()
    {
        yield return new WaitForSeconds(2.0f);
        storyStage++;
    }
}
