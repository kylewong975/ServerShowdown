using UnityEngine;
using System.Collections;

/*
The PortCounter script counts the amount of the port objects obtained in the ninth level.
*/
public class PortCounter : MonoBehaviour {

    /*
    The OnTriggerEnter function detects the object that is colliding with the port object. If the object has a Player
    tag and there is still time remaining in the level, the port object is acquired, giving score, cryptium, and progress 
    in the level.
    */
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && GameObject.Find("TimeObject").GetComponent<Timer>().timeRemaining > 0)
        {
            Destroy(this.gameObject);
            ScoreManager.score += 800;
            ScoreManager.cryptium += 200;
            ObjectiveManager.objectiveProgress++;
        }
    }
}
