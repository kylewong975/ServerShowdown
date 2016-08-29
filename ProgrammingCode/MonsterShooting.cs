using UnityEngine;
using System.Collections;

/*
The MonsterShooting script regulates the instantiation and behavior of the monster's laser ammos.
*/
public class MonsterShooting : MonoBehaviour {

    public float timeBetweenAttacks;            //The interval between successive monster attacks by laser.
    float timing;                               //the time recorded in the scene
    public Rigidbody enemyLaser;                //the laser ammo object's rigidbody

	/*
    The Start function sets up the time recorded to 0.
    */
	void Start () {
        timing = 0f;
	}

    /*
    The Update function instantiates the enemy laser ammo every interval timeBetweenAttacks, as defined in the 
    class variable.
    */
    void Update()
    {
        if (Time.time > timing)
        {
            timing = Time.time + timeBetweenAttacks;
            var temp = transform.rotation;
            temp *= Quaternion.Euler(0, 90, 0);
            Rigidbody enemyAmmo = Instantiate(enemyLaser, transform.position, temp)
                as Rigidbody;
            enemyAmmo.velocity = transform.TransformDirection(new Vector3(0, 0, 50f));
        }
    }
}
