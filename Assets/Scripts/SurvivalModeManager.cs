using UnityEngine;
using System.Collections;

/*
The SurvivalModeManager script regulates the gameplay in the Survival Mode scene.
*/
public class SurvivalModeManager : MonoBehaviour {

    float cooldown;             //the frequency of robot instantiation
    float timestamp;            //the recorded time in the scene

    /*
    The Start function sets the cooldown time and the recorded time in the scene.
    */
    void Start()
    {
        cooldown = 2.5f;
        timestamp = 0.0f;
    }
	
	/*
    The Update function instantiates robots at a frequency defined in the class variable.
    */
	void Update () {
        if (Time.time >= timestamp && TimeUp.startIncrementing)
        {
            timestamp = Time.time + cooldown;
            GameObject.Find("SpawnScript").GetComponent<SpawnControl>().InstantiateRobots();
        }
    }
}
