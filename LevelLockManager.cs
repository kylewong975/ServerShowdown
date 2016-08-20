using UnityEngine;
using System.Collections;

/*
The LevelLockManager script regulates whether the 7th and/or 10th level is completed. This script is a foundation
to accessing the Survival Mode and Network Map areas in the Level Select Menu.
*/
public class LevelLockManager : MonoBehaviour {

    public static int finishedLevel7;           //the value 0 or 1 stored for level 7
    public static int finishedLevel10;          //the value 0 or 1 stored for level 10

	/*
    The Start function acquires the integer value stored in PlayerPrefs for level 7 and level 10.
    */
	void Start () {
        finishedLevel7 = PlayerPrefs.GetInt("level7");
        finishedLevel10 = PlayerPrefs.GetInt("level10");
	}
}
