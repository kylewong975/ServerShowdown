using UnityEngine;
using System.Collections;

/*
The PlayerShooting script regulates the shooting of the Disk by the player.
*/
public class PlayerShooting : MonoBehaviour {

    Rigidbody[] laser;          //the array of lasers, to be compatible with the laser customization
	public Rigidbody laser1;	//the laser prefab that is shot (blue)
    public Rigidbody laser2;    //the laser prefab that is shot (yellow)
    public Rigidbody laser3;    //the laser prefab that is shot (green)
    public Rigidbody laser4;    //the laser prefab that is shot (pink)

    /*
    The Start function intializes the laser array and sets up the array with laser objects.
    */
    void Start()
    {
        laser = new Rigidbody[4];
        laser[0] = laser1;
        laser[1] = laser2;
        laser[2] = laser3;
        laser[3] = laser4;
    }

	/*
	The Update function shoots a laser prefab when the Fire1 input is button downed and the game
	is not paused.
	*/
	void Update () {
		if (Input.GetButtonDown ("Fire1") && Time.timeScale == 1.0) 
		{
            var temp = transform.rotation;
            temp *= Quaternion.Euler(0, 90, 0);
            Rigidbody instantiatedLaser = Instantiate(laser[PlayerPrefs.GetInt("laservalue")], transform.position, temp)
				as Rigidbody;
			instantiatedLaser.velocity = transform.TransformDirection(new Vector3(0,0,100f));
		}
	}
}
