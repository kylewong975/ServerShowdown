using UnityEngine;
using UnityEngine.UI;
using System.Collections;

/*
The AudioOnOff script allows the audio to be turned on and off during the scene.
If finds the GameObject with the AudioSource component and toggles its state
accordingly, taking into account its current state.
*/
public class AudioOnOff : MonoBehaviour {

	public GameObject music;		//GameObject for which the AudioSource component
							        //is attached to
	public Text onOffText;	//Text which shows whether the Audio is on or off
	
	/*
	On initialization the GameObject with the AudioSource component is found and
	stored in the <music> field.

	The Text for the button which toggles the music is also set, taking into account
	the current state of the AudioSource component.
	*/
	void Start () {
		//music = GameObject.FindGameObjectWithTag ("Music");
		if (MyAudio.Instance.GetComponent<AudioSource> ().isPlaying)
		{
			onOffText.text = "Off";
		}
		else
		{
			onOffText.text = "On";
		}
	}
	
	/*
	The OnOff function is called when a UI Button which toggles the audio is clicked,
	using the OnClick() function in the Inspector.

	It turns on or off the music played from the AudioSource component, depending on
	whether or not it is already on or off.
	*/
	public void OnOff()
	{
		if (MyAudio.Instance.GetComponent<AudioSource> ().isPlaying)
		{
			
			MyAudio.Instance.GetComponent<AudioSource> ().Pause ();
			onOffText.text = "On";
		}
		else
		{
			MyAudio.Instance.GetComponent<AudioSource> ().Play();
			onOffText.text = "Off";
		}
	}
}
