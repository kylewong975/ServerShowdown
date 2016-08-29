using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/*
The HighScoreManager script regulates the high score of the Survival Mode game mode.
*/
public class HighScoreManager : MonoBehaviour {

    public static int highScore;            //the high score achieved in Survival Mode
    public Text highScoreText;              //the Text referenced that displays the high score.

	/*
    The Start function sets the high score to the value stored in PlayerPrefs. If there is no such value,
    the high score is set to 0.
    */
	void Start () {
        highScore = PlayerPrefs.GetInt("survivalHighScore");
	}

    /*
    The Update function sets the highs core text to the high score value stored in PlayerPrefs. If there is no
    such value, the text will show "Survival Mode High Score: 0"
    */
    void Update()
    {
        highScoreText.text = "Survival Mode High Score: " + highScore;
    }
}
