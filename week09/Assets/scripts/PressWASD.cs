using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PressWASD : MonoBehaviour {

	// private variables are accessible ONLY in this class
	private Text myTextComponent;

	// Use this for initialization
	void Start () {
		// tell Unity to look for a "Text" component next to this script
		myTextComponent = GetComponent<Text>();
		myTextComponent.text = "Hey this works!";
	}
	
	// Update is called once per frame
	void Update () {
		// this will fire when the player RELEASES the W key
		if (Input.GetKeyUp (KeyCode.W)) {
			myTextComponent.text = "You pressed W! Good job, champ!";
		}

		// this will happen when player holds down A, S, and D
		if ( Input.GetKey (KeyCode.A) && Input.GetKey (KeyCode.S) && Input.GetKey(KeyCode.D)) {
			// "+=" adds on top of the existing value
			myTextComponent.text += "\n\nWow your power is astounding!"; // "\n" is a line break
		}
	}
}
