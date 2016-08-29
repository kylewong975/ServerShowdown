using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/*
The ObjectiveManager script regulates the objective of the level.
*/
public class ObjectiveManager : MonoBehaviour {

    public static int objectiveProgress;    //The number that corresponds to the current kills or requirements met for the level.
    public int objectiveGoal;               //The number needed to be reached in order to move on to the next level.
    public int reward;                      //Amount of reward in Cryptiums when the player finishes a level.
    public Text objText;                    //The text to be displayed, through the HUDCanvas.
    PlayerHealth ph;                        //The PlayerHealth script reference
    GameObject slider;                      //The player's health
    Animator anim;                          //Animation

    /*
	Upon instantiation the Animator component of the GUI is retrieved.
	The Animator is used later to play GUI animations upon the end of the level.
	*/
    void Awake()
    {
        anim = GetComponent<Animator>();
        objectiveProgress = 0;
        slider = GameObject.Find("PlayerHealthUI");
        ph = slider.GetComponent<PlayerHealth>();
    }

    /*
    The update function updates the objective progress and displays it in the objective text. If the
    objective is met, the animation Game Won will be triggered, where the player can move on to the
    next level. When the level is complete, the player's health is set to an extremely high amount to prevent
    potential bugs that trigger the game over animation.
    */
    void Update()
    {
        objText.text = "" + objectiveProgress + " / " + objectiveGoal;
        if (objectiveProgress >= objectiveGoal)
        {
            anim.Play("GameWonClip");
            if (SceneManager.GetActiveScene().name == "Level4" || SceneManager.GetActiveScene().name == "Level6" || SceneManager.GetActiveScene().name == "Level7" || SceneManager.GetActiveScene().name == "Level9")
            {
                Timer.isCounting = false;
            }
            if(SceneManager.GetActiveScene().name == "Level5")
            {
                MonsterAmmoAttack.isAmmoImmune = true;
                Timer.isCounting = false;
            }
            if (SceneManager.GetActiveScene().name == "Level7")
            {
                PlayerPrefs.SetInt("level7", 1);
            }
                objectiveProgress = 0;
            ph.playerHealth = 20000000;
            ph.ReflectDamage(20000000);
            ScoreManager.cryptium += reward;
        }
	}
}
