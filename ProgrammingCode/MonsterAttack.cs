using UnityEngine;
using System.Collections;

/*
The MonsterAttack script regulates the various attack moves of the monsters.
*/
public class MonsterAttack : MonoBehaviour {

    PlayerHealth ph;                    //The PlayerHealth script reference
    public int damage = 10;             //the amount of damage received by the player
    public int points;                  //the amount of points the player receives when the monster is killed
    public int cryptium;                //the amount of cryptium the player receives when the monster is killed
    public static bool isVulnerable;    //determines if the player is vulnerable to the monster or not
    GameObject slider;                  //the player's health slider
    int damageInterval;                 //how often the player should be damaged if the player touches the monster
    float timeStamp;                    //the recorded time in the scene

    /*
    The Start function initializes the player's health slider reference and sets up the damage interval and recorded
    time value in the scene. The player is also initially not vulnerable to the monster's attacks.
    */
    void Start()
    {
        slider = GameObject.Find("PlayerHealthUI");
        ph = slider.GetComponent<PlayerHealth>();
        isVulnerable = false;
        damageInterval = 1;
        timeStamp = 0;
    }

    /*
    The OnCollisionStay function detects whether the player (with the Player tag) is colliding with the monster.
    If so, the player continuously loses health at an interval damageInterval defined in the class variable.
    */
	public void OnCollisionStay(Collision col)
    {
        if (!isVulnerable)
        {
            if(col.collider.tag == "Player" && timeStamp <= Time.time)
            {
                ph.TakeDamage(damage);
                timeStamp = Time.time + damageInterval;
            }
        }
    }
}
