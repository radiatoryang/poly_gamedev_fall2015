using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	// to clone something, you first need an original thing to clone
	public GameObject thingToClone; // assign in Inspector

	// Use this for initialization
	void Start () {
		// if NIGHTMARE MODE IS ENABLED, turn the cube red
		if ( MenuScreen.useNightmareMode == true ) {
			thingToClone.GetComponent<Renderer>().material.color = new Color(1f, 0f, 0f);
		}
	}
	
	// Update is called once per frame
	void Update () {
		// our main mechanic: MAKE CUBES!!!
		if ( Input.GetKeyDown (KeyCode.Space) ) {
			Instantiate ( thingToClone, new Vector3( Random.Range (-5f, 5f), 0f, Random.Range (-5f, 5f) ), Quaternion.Euler(0f, 45f, 0f) );
		}

		// simple restart
		if ( Input.GetKeyDown (KeyCode.R) ) {
			Application.LoadLevel ( 0 ); // load scene number 0 (go to File > Build Settings in Unity)
		}
	}
}
