using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/*
The MonsterHP script regulates the health of the enemy. Health and maxHealth values can be inputted, since there
will be different values of health points (HP) for enemies in different levels.
*/
public class MonsterHP : MonoBehaviour {

    public int health;             //The current health of the enemy
    public int maxHealth;          //The maximum health of the enemy
    public Image healthBar;        //The healthbar of the enemy that is located on top of its head.
    public int scoreAmt;           //Score gained after the player kills the enemy
    public int cryptiumAmt;        //Cryptium gained after the player kills the enemy

    /*
    The Start function intializes the monster's health bar's color to green, denoting full or near-full health.
    */
    void Start()
    {
        healthBar.color = Color.green;
    }

    /*
    The Update function updates the amount of health the monster/enemy has, which is shown in the fill size of the health
    bar. If the amount of health reaches certain thresholds, the enemy's health bar changes to a color yellow or red.
    */
    void Update()
    {
        healthBar.fillAmount = (float)health / (float)maxHealth;
        if (healthBar.fillAmount >= 0.7f)
        {
            healthBar.color = Color.green;
        }
        else if (healthBar.fillAmount >= 0.3f && healthBar.fillAmount <= 0.7f)
        {
            healthBar.color = Color.yellow;
        }
        else
        {
            healthBar.color = Color.red;
        }
    }

    /*
    The TakeHit function has a parameter damage, which passes on the amount of damage to be inflicted on the enemy.
    Thus, the health of the enemy will decrease. The health bar will update accordingly, setting the fill size to
    its appropriate value.
    */
    public void TakeHit(int damage)
    {
        health -= damage;
    }

    /*
    The GetHealth function returns the current health of the enemy.
    */
    public int GetHealth()
    {
        return health;
    }
}
