using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienManager : MonoBehaviour {

    public GameObject player;

<<<<<<< HEAD
    float speed = 0.2f;
=======
    public float speed = 0.1f;
>>>>>>> 3aeb63f94ad97947dd8ae539bea934cec2687948

	// Use this for initialization
	void Start () {
        //player = GameObject.Find("Car");
	}
	
	// Update is called once per frame
	void Update () {
        PlayerTracking();
	}

    void PlayerTracking()
    {
        var alienPos = transform.position;
        var playerPos = player.transform.position;

        float x, y, z;

		//-145 / 18 / 38

        if (alienPos.x - playerPos.x <= 0f)
            x = speed;
        else
            x = -speed;

//        if (alienPos.y - playerPos.y <= 0f)
//            y = speed;
//        else
//            y = -speed;

        if (alienPos.z - playerPos.z <= 0f)
            z = speed;
        else
            z = -speed;

        transform.position = new Vector3(alienPos.x + x, alienPos.y, alienPos.z + z);

        //Debug.LogError("Player : " + playerPos + "\nAlien : " + alienPos);

		transform.LookAt (player.transform);
    }
}