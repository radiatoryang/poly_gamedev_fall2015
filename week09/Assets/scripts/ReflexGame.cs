using UnityEngine;
using System.Collections;

using UnityEngine.UI; // VERY IMPORTANT, YOU NEED THIS TO TALK TO UI COMPONENTS

public class ReflexGame : MonoBehaviour {
	
	float timeHeldDown = 0.0f;

	// "public" keyword when declaring a class member var = exposes to Unity Editor inspector
	public Text myTextComponent;
	
	// Update is called once per frame
	void Update () {
		if ( Input.GetKey (KeyCode.Space) ) {
			// Time.deltaTime is the duration of the frame in seconds
			timeHeldDown += Time.deltaTime;
			myTextComponent.text = "TIME HELD DOWN: " + timeHeldDown.ToString();
			Debug.Log ( timeHeldDown.ToString() );
		}
	}
}
