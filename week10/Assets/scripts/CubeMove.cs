using UnityEngine;
using System.Collections;

public class CubeMove : MonoBehaviour {

	// public variables in Unity "expose it to the inspector", which will help us TUNE it
	public float moveSpeed = 0.1f;

	// Update is called once per frame
	void Update () {
		// up arrow moves us 0.1f on Z axis
		if ( Input.GetKey( KeyCode.UpArrow ) ) {
			transform.position = transform.position + new Vector3( 0f, 0f, moveSpeed);
		}

		// left arrow moves us -0.1f on X axis
		if ( Input.GetKey( KeyCode.LeftArrow ) ) {
			transform.position = transform.position + new Vector3( -moveSpeed, 0f, 0f);
		}

		// right arrow move us 0.1f on X axis
		if ( Input.GetKey( KeyCode.RightArrow ) ) {
			transform.position = transform.position + new Vector3( moveSpeed, 0f, 0f);
		}

		// down arrow move us -0.1f on Z axis
		if ( Input.GetKey( KeyCode.DownArrow ) ) {
			transform.position = transform.position + new Vector3( 0f, 0f, -moveSpeed);
		}

	}
}
