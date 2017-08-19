using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonGameManager : MonoBehaviour {

    GameObject alien;

    //int battery = 0;

	// Use this for initialization
	void Start () {
        alien = GameObject.Find("Alien");
        alien.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
