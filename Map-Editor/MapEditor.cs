using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MapEditor : MonoBehaviour {

	public int numberOfPlayers;

	public Camera cam;

	// Mode Selection toggles
	public Toggle placeTilesMode;
	public Toggle placeRegionTilesMode;
	public Toggle placeObjectsMode;

	// Dropdowns for Region & Object
	public Dropdown regionSelect;
	public Dropdown objectSelect;

	// Camera functions
	private float maxZoom = 30.0f;
	private float minZoom = 100.0f;
	private float zoomSpeed = 5.5f;

	// Methods are called in a consistent manner on a regular timeline
	void FixedUpdate () {

		modeSelection ();

	}


	public void modeSelection() {

		if (placeTilesMode.isOn) {

			placeRegionTilesMode.interactable = false;
			placeObjectsMode.interactable = false;

		} else if (placeRegionTilesMode.isOn) {

			placeTilesMode.interactable = false;
			placeObjectsMode.interactable = false;

		} else if (placeObjectsMode.isOn) {

			placeTilesMode.interactable = false;
			placeRegionTilesMode.interactable = false;

		} else {

			placeTilesMode.interactable = true;
			placeRegionTilesMode.interactable = true;
			placeObjectsMode.interactable = true;

		}

	}


	// method used by button's onclick
	public void changeIsometric() {
			cam.transform.position = new Vector3 (-6.7f, -4.5f, -7.0f);
			cam.transform.localEulerAngles = new Vector3 (30, 45, 0);
	}

	public void changeTopDown() {
		cam.transform.position = new Vector3 (0, 0, 0);
		cam.transform.localEulerAngles = new Vector3 (90, 0, 0);
	}

	// method used by button's onclick
	public void zoomIn() {

		if (cam.fieldOfView >= maxZoom) {

			cam.fieldOfView -= zoomSpeed;

		}

	}

	// method used by button's onclick
	public void zoomOut() {

		if (cam.fieldOfView <= minZoom) {

			cam.fieldOfView += zoomSpeed;

		}

	}

	// method used by button's onclick
	public void rotateRight() {
		
		cam.transform.Rotate (Vector3.up,  5.0f, Space.World);

	}

	// method used by button's onclick
	public void rotateLeft() {

		cam.transform.Rotate (Vector3.down, 5.0f, Space.World);

	}

}
