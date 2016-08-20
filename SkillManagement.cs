using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/*
The SkillManagement script regulates the skills that the player can use when getting enough Cryptium.
*/
public class SkillManagement : MonoBehaviour {

    public Slider playerHealthSlider;           //The player health's slider
    public float amount;                        //The maximum amount of health the player has
    PlayerHealth ph;                            //The PlayerHealth script reference

	/*
    The Start function intializes the player health slider's reference and the maximum amount of health the player
    possesses.
    */
	void Start ()
    {
        playerHealthSlider.GetComponent<Slider>().value = playerHealthSlider.GetComponent<PlayerHealth>().GetCurrentHealth();
        amount = playerHealthSlider.GetComponent<PlayerHealth>().GetMaxHealth();
        ph = playerHealthSlider.GetComponent<PlayerHealth>();
    }
	
	/*
    The Update function provides functionality for the player to use a healing or defense skill using Cryptiums
    rewarded throughout the game. If the player obtains enough cryptium, pressing the Z, X, C, or V buttons
    allow the player to use different skills to aid the player in finishing a challenging level. The amount of health
    the player possesses will never exceed the maximum amount of health set by the variable "amount".
    */
	void Update ()
    {
        if(playerHealthSlider.GetComponent<PlayerHealth>().GetCurrentHealth() >= playerHealthSlider.GetComponent<PlayerHealth>().GetMaxHealth())
        {
            playerHealthSlider.GetComponent<PlayerHealth>().currentHealth = playerHealthSlider.GetComponent<PlayerHealth>().GetMaxHealth();
        }
        if (Input.GetKeyDown(KeyCode.Z) && ScoreManager.cryptium>=2000)
        {
            ScoreManager.cryptium -= 2000;
            ph.ReflectDamage((int)(playerHealthSlider.GetComponent<PlayerHealth>().GetMaxHealth() * 0.05f));
            amount = playerHealthSlider.GetComponent<PlayerHealth>().GetCurrentHealth();
        }
        if (Input.GetKeyDown(KeyCode.X) && ScoreManager.cryptium >= 15000)
        {
            ScoreManager.cryptium -= 15000;
            ph.ReflectDamage((int)(playerHealthSlider.GetComponent<PlayerHealth>().GetMaxHealth() * 0.50f));
            amount = playerHealthSlider.GetComponent<PlayerHealth>().GetCurrentHealth();
        }
        if (Input.GetKeyDown(KeyCode.C) && ScoreManager.cryptium >= 25000)
        {
            ScoreManager.cryptium -= 25000;
            ph.ReflectDamage((int)(playerHealthSlider.GetComponent<PlayerHealth>().GetMaxHealth() * 1.0f));
            amount = playerHealthSlider.GetComponent<PlayerHealth>().GetCurrentHealth();
        }
        if (Input.GetKeyDown(KeyCode.V) && ScoreManager.cryptium >= 5000)
        {
            ScoreManager.cryptium -= 5000;
            ph.ReflectDamage((int)(playerHealthSlider.GetComponent<PlayerHealth>().GetMaxHealth() * 0.2f));
            amount = playerHealthSlider.GetComponent<PlayerHealth>().GetCurrentHealth();
        }
    }
}
