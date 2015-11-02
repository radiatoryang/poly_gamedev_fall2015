using UnityEngine;
using System.Collections;

public class SphereMove : MonoBehaviour {

	public float moveSpeed = 0.1f;
	public float turnSpeed = 5f;

	// Update is called once per frame
	void Update () {
		if ( Input.GetKey (KeyCode.W) ) {
			// transform.forward is the "forward" direction of the object
			transform.position += transform.forward * moveSpeed;
			// transform.position += Vector3.forward; // Vector3.forward is ALWAY "south"
		}

		if ( Input.GetKey (KeyCode.A) ) {
			transform.Rotate ( 0f, -turnSpeed, 0f );
		}

		// if I hold down D, rotate 15 degrees to my right
		if ( Input.GetKey (KeyCode.D) ) {
			transform.Rotate ( 0f, turnSpeed, 0f );
		}
	}
}
