using UnityEngine;
using System.Collections;

public class RigidbodyMove : MonoBehaviour {

	Rigidbody rbody;

	// Use this for initialization
	void Start () {
		rbody = GetComponent<Rigidbody>();
	}
	
	// FixedUpdate is called on the same framerate that PHYSICS runs
	void FixedUpdate () {
		// forward / backward movement
		float vertical = Input.GetAxis ("Vertical");
		// add gravity at the end to make it less floaty
		rbody.velocity = transform.forward * vertical * 25f + Physics.gravity;

		// turning left / right does NOT use physics
		float horizontal = Input.GetAxis ("Horizontal");
		transform.Rotate ( 0f, horizontal * Time.deltaTime * 180f, 0f );
	}
}
