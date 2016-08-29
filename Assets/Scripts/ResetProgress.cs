using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/*
The ResetProgress script resets all progress (levels completed and Survival Mode high score) in the game.
*/
public class ResetProgress : MonoBehaviour {

    public int counter;             //the number of times the reset button is pressed
    public Text resetText;          //the Text displayed in the reset button

    /*
    The Start function initializes the counter to 0, which means that the reset button is never pressed.
    */
    void Start()
    {
        counter = 0;
    }

    /*
    The ResetAllProgress function resets all progress in the game, including levels completed and the Survival
    Mode high score. To prevent accidental clicking, the player needs to press the button two times, where the
    first click asks for a confirmation to reset progress. Once the player presses the button two times,
    all progress in the game is reset.
    */
    public void ResetAllProgress()
    {
        counter++;
        if(counter==1)
        {
            resetText.text = "Press again to confirm";
        }
        if(counter==2)
        {
            PlayerPrefs.SetInt("survivalHighScore", 0);
            PlayerPrefs.SetInt("level7", 0);
            PlayerPrefs.SetInt("level10", 0);
            resetText.text = "All progress has been reset.";
            counter = 0;
        }
    }

}
