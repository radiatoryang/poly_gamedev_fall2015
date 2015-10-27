using UnityEngine;
using System.Collections;

public class TapGame : MonoBehaviour {

	// the player's current score; goes from 0 to 100
	int score = 0;
	
	// Update is called once per frame
	void Update () {
		if ( Input.GetKeyDown (KeyCode.Space) ) {
			score += 1; // add 1 point to score
			Debug.Log ( "CURRENT SCORE: " + score.ToString() );
		}

	}
}
