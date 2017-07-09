using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonGameManager : MonoBehaviour {

    GameObject alien;

	// Use this for initialization
	void Start () {
        alien = GameObject.Find("Alien");
        alien.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
