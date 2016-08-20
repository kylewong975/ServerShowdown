using UnityEngine;
using System.Collections;

/*
The DataRetrieve script controls the data object in response to the player acquiring the data.
*/
public class DataRetrieve : MonoBehaviour {

    /*
    The OnTriggerEnter method is called when a collider touches this data object. If the collider other has a 
    Player tag, then the level is complete, stopping the timer and rewarding the player. This script is referenced
    for the 2nd level of the game.
    */
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && GameObject.Find("TimeObject").GetComponent<Timer>().timeRemaining>0)
        {
            GameObject.Find("HUDCanvas").GetComponent<GameOverManager>().PlayGameWon();
            Timer.isCounting = false;
            ObjectiveManager.objectiveProgress++;
        }
    }
}
