using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SpawnControl : MonoBehaviour {

    public bool newEnemy;           //Determines if a new enemy should spawn so there will not be a surplus or a deficiency 
                                    //of the amount of enemies in a given level.
    public int carryingCapacity;    //Maximum number of enemies there should be for a level.
    public int currentAmt;          //Current number of enemies there is in a level
    public Rigidbody redirectBot;   //The RigidBody of the redirect robot.
    public Rigidbody redirectBot2;  //For survival mode, the RigidBody of another type of redirect robot
    public Rigidbody redirectBot3;  //For non-survival mode scenes, the same RigidBody as the first
    public Rigidbody redirectBot4;  //Another type of redirect robot for survival mode, for random number generator.
    float y, x1, x2, z1, z2, z3, z4, z5, z6, z7, z8;  //Set y value, range of x values from x1 to x2, and range of possible
                                                      //z values from z1 to z2, z3 to z4...for the random spawn locations.
    float[] zValues;                                  //one of 4 possible z values
    Rigidbody[] robots;                               //the array of redirect bots' rigidbodies

	/*
    The Start function initializes the carrying capacity, the current amount of monsters, and the boundary values in
    x, y, and z coordinates. This function also initializes the array of redirect robots' rigidbodies.
    */
	void Start () {
        newEnemy = false;
        currentAmt = carryingCapacity;
        y = 2.30f;
        x1 = -75.7f;
        x2 = 35.6f;
        z1 = -158f;
        z2 = -138f;
        z3 = -113f;
        z4 = -73f;
        z5 = 33f;
        z6 = 54f;
        z7 = 96f;
        z8 = 130f; // There exists 4 possible z ranges, but 1 x range and 1 y value, so choose random
                   // one of the 4 possible z ranges' random z value.
        zValues = new float[4];
        robots = new Rigidbody[4];
        robots[0] = redirectBot;
        robots[1] = redirectBot2;
        robots[2] = redirectBot3;
        robots[3] = redirectBot4;
    }
	
	/*
    The Update function instantiates robots if a new enemy is needed to fill the current amount to reach the
    carrying capacity defined in the inspector.
    */
	void Update () {
	    if(newEnemy && currentAmt < carryingCapacity)
        {
            InstantiateRobots();
        }
	}

    /*
    The InstantiateRobots function instantiates robots at a random x, y, z value within the boundary x, y, z values
    */
    public void InstantiateRobots()
    {
        float xVal = Random.Range(x1, x2);
        zValues[0] = Random.Range(z1, z2);
        zValues[1] = Random.Range(z3, z4);
        zValues[2] = Random.Range(z5, z6);
        zValues[3] = Random.Range(z7, z8);
        if (SceneManager.GetActiveScene().name == "Level3" || SceneManager.GetActiveScene().name == "SurvivalMode")
        {
            Instantiate(robots[(int)(Random.Range(0, 3.9f))], new Vector3(xVal, y, zValues[(int)(Random.Range(2, 3.9f))]), Quaternion.identity);
        }
        else
        {
            Instantiate(robots[(int)(Random.Range(0, 3.9f))], new Vector3(xVal, y, zValues[(int)(Random.Range(0, 3.9f))]), Quaternion.identity);
        }
        newEnemy = false;
        currentAmt++;
    }
}
