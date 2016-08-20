using UnityEngine;
using System.Collections;

/*
The Boss2Manager script handles the movements and attacks of the second boss.
*/
public class Boss2Manager : MonoBehaviour {

    public GameObject redirectBot;          //The RedirectBot that is summoned by the second boss
    float rotationsPerMinute;               //number of times the boss rotates every minute
    float timeStamp;                        //the recorded time in the scene
    float cooldown;                         //cooldown time
    float xMin, xMax, zMin, zMax, y;        //boundary values for the x, y, z values
    Animator anim;                          //Animation

    /*
    The Start function initializes the cooldown time, the boundary values, the number of rotations per minute, and
    the animation.
    */
    void Start () {
        cooldown = 5f;
        y = 8.61f;
        xMin = -273f;
        xMax = -212f;
        zMin = 14.0f;
        zMax = 125.0f;
        rotationsPerMinute = 10f;
        anim = GameObject.Find("HUDCanvas").GetComponent<Animator>();
    }
	
	/*
    The Update function manages the rotation of the boss, restricting rotation to the first and second quadrants.
    Every five seconds, the boss summons a redirect bot, at a location defined within the boundary values.
    If the boss runs out of health, the player finishes the level and the script records as such.
    */
	void Update () {
        if(transform.eulerAngles.y>180 && transform.eulerAngles.y<360)
        {
            rotationsPerMinute *= -1;
        }
        transform.Rotate(0, (6.0f * rotationsPerMinute * Time.deltaTime), 0);
        if (Time.time >= timeStamp)
        {
            timeStamp = Time.time + cooldown;
            float xVal = Random.Range(xMin, xMax);
            float zVal = Random.Range(zMin, zMax);
            Instantiate(redirectBot, new Vector3(xVal, y, zVal), Quaternion.identity);
        }
        if(GameObject.Find("EnemyHealthUI").GetComponent<BossHealth>().bossCurrentHealth<=0)
        {
            anim.Play("GameWonClip");
            PlayerPrefs.SetInt("level10", 1);
        }
    }
}
