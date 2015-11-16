using UnityEngine;
using System.Collections;

public class MenuScreen : MonoBehaviour {

	// "PUBLIC STATIC" makes data persist across scene changes + globally accessable by any script
	public static bool useNightmareMode = false;

	// Use this for initialization
	void Start () {
		// manually reset nightmare mode
		useNightmareMode = false;
	}
	
	// Update is called once per frame
	void Update () {
		// options mode toggle
		if ( Input.GetKeyDown (KeyCode.N) ) {
			useNightmareMode = !useNightmareMode; // toggle the bool
		}

		// press space to start game
		if ( Input.GetKeyDown (KeyCode.Space) ) {
			Application.LoadLevel( "instantiateDemo" ); // load the game
		}
	}
}
