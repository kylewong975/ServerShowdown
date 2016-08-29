using UnityEngine;
using System.Collections;

/*
The ResetValues script resets the score and cryptium values, to prevent excessive cryptium farming in the easier levels.
*/
public class ResetValues : MonoBehaviour {

	/*
    The Start function resets the score and cryptium values acquired in either the ten levels or the Survival Mode.
    */
	void Start () {
        PlayerPrefs.SetInt("scoreval", 0);
        PlayerPrefs.SetInt("cryptiumval", 0);
	}
}
