using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/*
The Timer script regulates the time in the scene.
*/
public class Timer : MonoBehaviour {

    public float timeRemaining;           //amount of time allotted for the level
    public Text timeText;                 //Text to display the time left for the level
    public static bool isCounting;        //Determines if the timer should count. If the game ends, the timer stops counting.

    /*
    The Start function intializes the isCounting varible to true, allowing the timer to count down.
    */
    void Start()
    {
        isCounting = true;
    }

	/*
    The Update function updates the time left for a certain level and determines if it is game over or game won
    depending on the specific level.
    */
	void Update () {
        if(isCounting)
        {
            timeRemaining -= Time.deltaTime;
            if (timeRemaining > 0)
            {
                timeText.text = "Time Left: " + (int)timeRemaining;
            }
            else
            {
                if(SceneManager.GetActiveScene().name == "Level2" || SceneManager.GetActiveScene().name == "Level4" || SceneManager.GetActiveScene().name == "Level9")
                {
                    GameObject.Find("HUDCanvas").GetComponent<GameOverManager>().PlayGameOver();
                    isCounting = false;
                }
                else if(SceneManager.GetActiveScene().name == "Level3")
                {
                    GameObject.Find("HUDCanvas").GetComponent<GameOverManager>().PlayGameWon();
                    MonsterAttack.isVulnerable = true;
                    isCounting = false;
                }
                
            }
        }
	}
}
