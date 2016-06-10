using UnityEngine;
using System.Collections;


/*
 * The Map Editor script
*/



// TO-DO and LOGIC:
// 1. Once Map Editor has been launched, the player will be introduced to the GUI
// 2. The entire GUI will be attached to the camera
// 3. The preview box will act as the camera
// 4. Input number of players for a size-respective plane
// 5. Once plane has been created, player will be free to customize
// 6. The player will only be able to select one mode at a time
// 7. Regardless of modes, the camera will switch to a top-down view
// 8. Once the player deselects a mode, the camera will return to a isometric view for preview purposes


public class MapEditor : MonoBehaviour {

	public int numberOfPlayers;


	GameObject plane;

	// Initialization
	void Awake() {
		// Default value for number of players is 2
		numberOfPlayers = 2;
		// Create a default inactive plane gameobject
		plane = GameObject.CreatePrimitive(PrimitiveType.Plane);
		plane.SetActive (false);
	}
		

	// Method is consistently called on a regular timeline
	void FixedUpdate() {
	
	// The x- and z- values will change accordingly to the number of players
		createPlane ();
	}




	// Even number of players only:
	// If there are 2 players, create a 24 x 24 plane (2.4 x 2.4)
	// If there are 4 players, create a 32 x 32 plane (3.2 x 3.2)
	// If there are 6 players, create a 48 x 48 plane (4.8 x 4.8)
	// If there are 8 players, create a 64 x 64 plane (6.4 x 6.4)
	// If there are 10 players, create 96 x 96 plane (9.6 x 9.6)
	
	// In Unity, the default size of the mesh of the plane is 10 x 10
	// In order to scale properly, the values are divided by 10
	private void createPlane() {
		if (numberOfPlayers == 2) {
			plane.SetActive (true);
			plane.transform.localScale = new Vector3 (2.4f, 1.0f, 2.4f);
		}

		if (numberOfPlayers == 4) {
			plane.SetActive (true);
			plane.transform.localScale = new Vector3 (3.2f, 1.0f, 3.2f);
		}

		if (numberOfPlayers == 6) {
			plane.SetActive (true);
			plane.transform.localScale = new Vector3 (4.8f, 1.0f, 4.8f);
		}

		if (numberOfPlayers == 8) {
			plane.SetActive (true);
			plane.transform.localScale = new Vector3 (6.4f, 1.0f, 6.4f);
		}

		if (numberOfPlayers == 10) {
			plane.SetActive (true);
			plane.transform.localScale = new Vector3 (9.6f, 1.0f, 9.6f);
		}
	}



}
