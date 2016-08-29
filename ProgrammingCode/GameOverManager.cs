using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/*
The GameOverManager script regulates the ending of a level in the game.
It can either be won or lost, and the script is updated in such
cases accordingly.
*/
public class GameOverManager : MonoBehaviour {

    public Slider HPSlider;             //The health bar displayed in the HUDCanvas, which shows the player's health
    Animator anim;                      //Animation

    /*
	Upon instantiatoin the Animator component of the GUI is retrieved.
	The Animator is used later to play GUI animations at the end of the level.
	*/
    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    /*
	The Update function calls the GameOver trigger when the game is lost, which is when the player runs out of health
    in this simpler case. In the special case for level 3, the timer stops once the game is lost since a time of 0
    would result in a game won. To prevent triggering the game won animation during the game over animation,
    the objective is set to a bare minimum so the player has to restart the level to finish the level.
	*/
    void Update()
    {
        if (HPSlider.GetComponent<Slider>().value <= 0)
        {
            anim.Play("GameOverClip");
            ObjectiveManager.objectiveProgress = -999999999;
            if (SceneManager.GetActiveScene().name == "Level3")
            {
                Timer.isCounting = false;
            }
        }
    }

    /*
    PlayGameOver function plays the animation "GameOverClip" manually, useful for versatile situations such as
    running out of time.
    */
    public void PlayGameOver()
    {
        anim.Play("GameOverClip");
    }

    /*
    PlayGameWon function plays the animation "GameWonClip" manually, useful for versatile situations such as
    accomplishing a task early besides the objective.
    */
    public void PlayGameWon()
    {
        anim.Play("GameWonClip");
    }
}
