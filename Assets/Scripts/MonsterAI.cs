using UnityEngine;
using System.Collections;

/*
The MonsterAI script regulates the movement and animations of the monster/enemy.
*/
public class MonsterAI : MonoBehaviour {

    public Transform target;            //Enemy's target
    public float moveSpeed = 3f;         //Enemy's speed
    public float rotationSpeed = 3f;     //Enemy's rotation speed
    public float range = 50f;           //The minimum distance before the enemy follows the target
    public float range2 = 50f;          //The maximum (approximate) distance before the enemy follows the target
    public float stop = 0f;             //The value which indicates a stop
    public Transform myTransform;       //The transform of the enemy itself

    void Awake()
    {
        myTransform = transform; //sets up the transformation
    }

	/*
    The start function sets up what the target should be. In this case, it would be the player.
    */
	void Start () {
        target = GameObject.FindWithTag("Player").transform;
	}
	
	/*
    The update function calculates the distance between the enemy and the target. If the target is within
    a certain thershold (denoted by range), the enemy will orient itself and follow the target.
    The animation "Run" will play while the enemy follows the target.

    Otherwise, the enemy will remain in an "Idle" position, orienting itself to see the player depending
    on the player's location.
    */
	void Update () {
        float distance = Vector3.Distance(myTransform.position, target.position);
        if(distance>=range)
        {
            myTransform.rotation = Quaternion.Slerp(myTransform.rotation, Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed * Time.deltaTime);
            GetComponent<Animation>().Play("Idle");
        }
        else if(distance<=range && distance>stop)
        {
            myTransform.rotation = Quaternion.Slerp(myTransform.rotation, Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed * Time.deltaTime);
            myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;
            GetComponent<Animation>().Play("Run");
        }
        else if(distance<=stop)
        {
            myTransform.rotation = Quaternion.Slerp(myTransform.rotation, Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed * Time.deltaTime);
            GetComponent<Animation>().Play("Idle");
        }
	}
}
