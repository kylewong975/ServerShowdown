using UnityEngine;
using System.Collections;

/*
The Boss1Manager script handles all the different movements and attacks the first boss possesses.
*/
public class Boss1Manager : MonoBehaviour {

    public float rotationsPerMinute;            //the number of times the boss rotates per minute
    public float teleportInterval;                //how often the boss teleports to a random location
    float timeCount;                            //the time recorded in a given scene
    float xMin, xMax, zMin, zMax, y;            //boundary values for the x, y, z values

	/*
    The Start function initializes the class variables, including the time record and the boundary values.
    */
	void Start () {
        timeCount = 0f;
        y = 8.61f;
        xMin = -273f;
        xMax = -212f;
        zMin = 14.0f;
        zMax = 125.0f;
	}
	
	/*
    The Update function rotates the boss at a rate defined in the class variable "rotationsPerMinute." Also, the boss
    teleports to a random location within the boundary values, at an interval defined in the inspector.
    */
	void Update () {
        transform.Rotate(0, (6.0f * rotationsPerMinute * Time.deltaTime), 0);
        if(Time.time > timeCount)
        {
            timeCount = Time.time + teleportInterval;
            float xVal = Random.Range(xMin, xMax);
            float zVal = Random.Range(zMin, zMax);
            transform.position = new Vector3(xVal, y, zVal);
        }
	}
}
