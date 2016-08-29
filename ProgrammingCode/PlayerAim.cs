using UnityEngine;
using System.Collections;
/*
The PlayerAim script lets the user aim the trajectory of the Disk thrown.
*/
public class PlayerAim : MonoBehaviour {

	public Camera cam;          //The player's camera

	/*
	The Update function gets a Vector3 of where the cursor is pointing at and points the GameObject it is
	attached to in that direction.
	*/
	void Update () {
		Vector3 pointAt = cam.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 50.0f));
		transform.LookAt (pointAt);
	}
}
