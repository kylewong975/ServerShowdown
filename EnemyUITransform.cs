using UnityEngine;
using System.Collections;

/*
This EnemyUITransform script enables the canvas (enemy's health bar) to face the player at a given time.
*/
public class EnemyUITransform : MonoBehaviour {

    private Camera cam;         //The player's camera

    /*
	The Start function sets the variable cam to be the player's camera.
	*/
    void Start () {
        cam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
	}
	
	/*
    The Update function updates the enemy canvas (which consists of the enemy's health bar) to the rotation
    of the player, so that the canvas faces the player.
    */
	void Update () {
        transform.LookAt(transform.position + cam.transform.rotation * Vector3.forward, cam.transform.rotation * Vector3.up);
	}
}
