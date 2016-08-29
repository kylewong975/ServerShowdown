using UnityEngine;
using System.Collections;
/*
The MyAudio script allows the AudioSource component which plays the audio to be
universal throughout all scenes.
*/
public class MyAudio : MonoBehaviour {

	private static MyAudio instance = null;     //the audio instance
	
    /*
    The accessor method to get the audio instance.
    */
	public static MyAudio Instance {
		get { return instance; }
	}

	/*
	The Awake function destroys the GameObject upon instantiation, thus making
	the MyAudio instance universal.
	*/	
	void Awake() {
		if (instance != null && instance != this) {
			Destroy(this.gameObject);
			return;
		} else {
			instance = this;
		}
		DontDestroyOnLoad(this.gameObject);
	}
}
