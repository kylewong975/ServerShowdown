using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/*
The TimeUp script counts up the time recorded in the scene, which is used for the Survival Mode gameplay.
*/
public class TimeUp : MonoBehaviour {

    public static bool startIncrementing;           //determines if the timer should start counting up
    public float timeSurvived;                      //the time recorded in the scene
    public Text timeText;                           //the Text displaying the time
    public Text gameOverText;                       //the Text displaying the time survived and score earned in the game over animation
    PlayerHealth ph;                                //the PlayerHealth script reference
    public Slider playerHealthSlider;               //the player health's slider
    Animator anim;                                  //the Animation

    /*
    The Start function increments the time and sets the time survived to 0, marking the beginning of the level. This function
    also initializes the animation reference.
    */
    void Start () {
        startIncrementing = true;
        timeSurvived = 0.0f;
        anim = GameObject.Find("HUDCanvas").GetComponent<Animator>();
    }
	
	/*
    The Update function updates how long the player has survived. If the player runs out of health, the game
    over animation is displayed, showing how long the player has survived and how much score the player has
    accumulated in a given Survival Mode round.
    */
	void Update () {
	    if(startIncrementing && playerHealthSlider.GetComponent<Slider>().value>0)
        {
            timeSurvived += Time.deltaTime;
            timeText.text = "Time Survived: " + (int)timeSurvived;
        }
        else
        {
            startIncrementing = false;
            anim.Play("GameOverClip");
            gameOverText.text = "Good job! You have survived " + (int)timeSurvived + " seconds. Your score is " + ScoreManager.score;
            if(ScoreManager.score>PlayerPrefs.GetInt("survivalHighScore"))
            {
                PlayerPrefs.SetInt("survivalHighScore", ScoreManager.score);
            }
        }
	}
}
