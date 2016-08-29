using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/*
The BossHealth script stores values of the boss health and displays it in the Boss Health UI slider.
*/
public class BossHealth : MonoBehaviour {

    public Slider bossHealthSlider;         //the slider for the boss's health
    public int bossHealth;                  //the initial value of the boss's health
    public int bossCurrentHealth;           //the current value of the boss's health

	/*
    The Start function initializes the boss's health and gets the reference to the boss's health slider.
    */
	void Start ()
    {
        bossCurrentHealth = bossHealth;
        bossHealthSlider.GetComponent<Slider>().value = bossHealth;
	}
	
	/*
    The Update function updates the boss's current health and displays it in the boss's health slider.
    */
	void Update ()
    {
        bossHealthSlider.GetComponent<Slider>().value = bossCurrentHealth;
    }

    /*
    The receiveDamage function decreases the boss's health by an amount passed as an argument in other scripts.
    */
    public void receiveDamage(int amount)
    {
        bossCurrentHealth -= amount;
    }
}
