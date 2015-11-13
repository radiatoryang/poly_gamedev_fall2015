using UnityEngine;
using System.Collections;

public class VectorMove : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		// "Horizontal" is Left/Right, A/D
		float horizontal = Input.GetAxis ("Horizontal");
		// rotate the player
		const float turnRate = 45f;
		transform.Rotate (0f, horizontal * turnRate * Time.deltaTime, 0f );

		// "Vertical" is Up/Down, W/S
		float vertical = Input.GetAxis ("Vertical");
		// move the player
		const float moveSpeed = 5f;
		transform.position += transform.forward * vertical * Time.deltaTime * moveSpeed;

	}
}
