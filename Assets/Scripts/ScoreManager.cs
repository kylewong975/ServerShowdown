using UnityEngine;
using UnityEngine.UI;
using System.Collections;

/*
The ScoreManager script regulates the score for the player.
*/
public class ScoreManager : MonoBehaviour {

    public static int score;        //The score
    public static int cryptium;     //The Cryptium currency
    public Text text;               //The text that displays how much Score the player has.
    public Text text2;              //The text that displays how much Cryptium the player has.

	/*
    The Awake function sets up the score for the first time. The score is set to zero, which is displayed
    in the text.
    */
	void Awake () {
        score = PlayerPrefs.GetInt("scoreval");
        cryptium = PlayerPrefs.GetInt("cryptiumval");
	}
	
	/*
    The Update function sets the score on the text, depending on the amount of score the player has
    accumulated.
    */
	void Update () {
        text.text = "   Score: " + score;
        text2.text = "   Cryptium: " + cryptium;
        Save();
    }

    /*
    The Save function saves the score and cryptium values, allowing these values to be carried across scenes.
    */
    void Save()
    {
        PlayerPrefs.SetInt("scoreval", score);
        PlayerPrefs.SetInt("cryptiumval", cryptium);
    }
}
