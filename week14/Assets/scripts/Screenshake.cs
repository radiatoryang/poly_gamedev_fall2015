using UnityEngine;
using System.Collections;

// put this on the camera
public class Screenshake : MonoBehaviour {

	Vector3 startPos;
	public float shakeStrength = 0f;
	
	void Start () {
		startPos = transform.position; // remember where we started before shaking
	}

	void Update () {
		// generate shaking direction
		Vector3 shakeDirection = transform.right * Mathf.Sin(Time.time * 50f)
							   + transform.up * Mathf.Sin (Time.time * 43f);

		// apply shake direction
		transform.position = startPos + shakeDirection * shakeStrength;

		// control the shaking via key press
		if ( Input.GetKeyDown (KeyCode.Space) ) {
			shakeStrength = 0.4f;
		}

		// "decay" the shakeStrength, across 2 seconds, but clamp result between 0 and 1
		shakeStrength = Mathf.Clamp (shakeStrength - Time.deltaTime / 2f, 0f, 1f);
	}
}
