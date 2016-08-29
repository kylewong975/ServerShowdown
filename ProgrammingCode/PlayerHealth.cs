using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

/*
The PlayerHealth script stores and updates the health for the player.
*/
public class PlayerHealth : MonoBehaviour {

	public Slider playerHealthSlider;		//The GUI Slider showing the player's health.
	public int playerHealth;			    //The value of the player's health stored as an integer.
    public int currentHealth;               //The current health of the player.
    public bool isDead;                     //Determines if the player is dead or not dead.

    /*
    The Start function initializes the player's maximum health, the current health, and sets the health slider to
    correspond to the current health value.
    */
    void Start()
    {
        playerHealth = 1000;
        currentHealth = 1000;
        playerHealthSlider.GetComponent<Slider>().value = playerHealth;
    }
    
	/*
	The Update function calculates the current health of the player.
	*/
	void Update () {
		playerHealthSlider.GetComponent<Slider>().value = currentHealth;
	}

    /*
	The TakeDamage function decreases the player's health parameter amount.
	It calls the Death function if the player no longer has health.
	*/
    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0 && !isDead)
        {
            Death();
        }

    }

    /*
    The ReflectDamage function adds health by an amount to the player.
    */
    public void ReflectDamage(int amount)
    {
        currentHealth += amount;
    }

    /*
	The Death function changes the value of the isDead field.
	*/
    void Death()
    {
        isDead = true;
    }

    /*
    The GetMaxHealth function accesses the amount of health the player has.
    */
    public int GetMaxHealth()
    {
        return playerHealth;
    }

    /*
    The GetCurrentHealth function accesses the amount of health the player currently has.
    */
    public float GetCurrentHealth()
    {
        return currentHealth;
    }
}
