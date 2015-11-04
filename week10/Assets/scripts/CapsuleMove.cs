using UnityEngine;
using System.Collections;

public class CapsuleMove : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		if ( Input.GetKey ( KeyCode.W ) ) {
			transform.position += transform.forward * 0.25f;
		}

		float mouseX = Input.GetAxis ("Mouse X");
		transform.Rotate ( 0f, mouseX * 45f, 0f );
	}

}
