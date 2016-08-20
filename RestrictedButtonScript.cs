using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

/*
The RestrictedButtonScript script holds functions in which is used to load scenes that need some requirements
to load. The functions are called when the buttons are clicked, through the OnClick function and that the player 
meets certain requirements, 
*/
public class RestrictedButtonScript : MonoBehaviour {

    /*
    The openSurvivalMode function opens up the SurvivalMode scene, which is loaded once the OnClick function is called
    and the player has finished Level 7.
    */
    public void openSurvivalMode()
    {
        if (LevelLockManager.finishedLevel7 == 1)
        {
            SceneManager.LoadScene("SurvivalMode");
        }
    }

    /*
    The openNetworkMap function opens up the NetworkExploration scene, which is loaded once the OnClick function is called
    and the player has finished Level 10.
    */
    public void openNetworkMap()
    {
        if(LevelLockManager.finishedLevel10 == 1)
        {
            SceneManager.LoadScene("NetworkExploration");
        }
    }
}
