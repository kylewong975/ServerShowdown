using UnityEngine;
using System.Collections;

/*
The AmmoAttack script allows the laser ammo to deal damage if it collides with an enemy.
*/
public class AmmoAttack : MonoBehaviour {

    public int damage;      //The damage dealt to the enemy
    float cooldownTime;     //Cooldown time to increase the value of the objective, for the packets since they can be
                            //defeated in 1 shot, but the OnTriggerEnter fires multiple times during the collision.
    float timestamp;        //Recorded time
    
    /*
    The Start function sets up the values for the cooldown time and the recorded time in the level.
    */
    void Start()
    {
        cooldownTime = 1.1f;
        timestamp = 0;
    }

    /*
    The OnTriggerEnter method checks a collision col. If collision col has an "Enemy" tag, the laser
    ammo will deal damage to said enemy. If the enemy possesses no more health, the enemy is
    removed from the scene, granting values of score and cryptium to the player, as defined in the MonsterHP Script.

    If the collision col has a "Packet" tag, the laser ammo will destroy the packet, granting the player 15 points,
    5 cryptium, and 1 value gained in the objective. To prevent triggering the method multiple times, since the packets, 
    are killed in one shot, a cooldwon is placed.

    If the collision col has a "Boss" tag, the laser ammo will deal damage to said boss. The only difference between the
    boss and the enemy is the values: the boss gives more cryptium and score and has a fixed value, while the enemy
    gives cryptium and score set by the player in the MonsterHP script.

    If the collision col is untagged, the laser ammo will be destroyed to remove clutter.
    */
	void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            other.gameObject.GetComponent<MonsterHP>().TakeHit(damage);
            Destroy(this.gameObject);
            if(other.gameObject.GetComponent<MonsterHP>().GetHealth() <= 0)
            {
                Destroy(other.gameObject);
                int points = other.GetComponent<MonsterHP>().scoreAmt;
                int cpoints = other.GetComponent<MonsterHP>().cryptiumAmt;
                ScoreManager.score += points;
                ScoreManager.cryptium += cpoints;
                ObjectiveManager.objectiveProgress += 1;
                GameObject.Find("SpawnScript").GetComponent<SpawnControl>().currentAmt -= 1;
                GameObject.Find("SpawnScript").GetComponent<SpawnControl>().newEnemy = true;
            }
        }
        if(other.gameObject.tag == "Packet")
        {
            Destroy(this.gameObject);
            Destroy(other.gameObject);
            ScoreManager.score += 15;
            ScoreManager.cryptium += 5;
            if(timestamp <= Time.time)
            {
                ObjectiveManager.objectiveProgress += 1;
                timestamp = Time.time + cooldownTime;
            }
        }
        if (other.gameObject.tag == "Boss")
        {
            Destroy(this.gameObject);
            GameObject.Find("EnemyHealthUI").GetComponent<BossHealth>().receiveDamage(damage);
            if (GameObject.Find("EnemyHealthUI").GetComponent<BossHealth>().bossCurrentHealth <= 0)
            {
                ScoreManager.score += 50000;
                ScoreManager.cryptium += 32000;
                ObjectiveManager.objectiveProgress += 1;
            }
        }
        if (other.gameObject.tag == "Untagged")
        {
            Destroy(this.gameObject);
        }
    }
}
