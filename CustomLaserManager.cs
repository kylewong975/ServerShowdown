using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/*
The CustomLaserManager script handles the laser customization in the Options Menu.
*/
public class CustomLaserManager : MonoBehaviour {

    public Sprite[] laserImages;        //the collection of laser images
    public static int laserVal;         //the index of the laser collection
    public Image display;               //the Image to be displayed in the Laser Customization Options menu.

	/*
    The Start function initializes the laserVal value to the PlayerPref's value stored.
    */
	void Start () {
        laserVal = PlayerPrefs.GetInt("laservalue");
	}
	
	/*
    The Update function updates the image displayed in the Laser Customization screen to the appropriate image
    when the player selects a certain laser color.
    */
	void Update () {
        laserVal = PlayerPrefs.GetInt("laservalue");
        display.sprite = laserImages[laserVal];
	}

    /*
    The blueButtonPressed function changes the PlayerPrefs value to 0, which is called once the OnClick function is called.
    This integer value is used to access indices of arrays in the laser image and the ammo for the player throughout the game.
    */
    public void blueButtonPressed()
    {
        PlayerPrefs.SetInt("laservalue", 0);
    }

    /*
    The yellowButtonPressed function changes the PlayerPrefs value to 1, which is called once the OnClick function is called.
    This integer value is used to access indices of arrays in the laser image and the ammo for the player throughout the game.
    */
    public void yellowButtonPressed()
    {
        PlayerPrefs.SetInt("laservalue", 1); 
    }

    /*
    The greenButtonPressed function changes the PlayerPrefs value to 2, which is called once the OnClick function is called.
    This integer value is used to access indices of arrays in the laser image and the ammo for the player throughout the game.
    */
    public void greenButtonPressed()
    {
        PlayerPrefs.SetInt("laservalue", 2);
    }

    /*
    The pinkButtonPressed function changes the PlayerPrefs value to 3, which is called once the OnClick function is called.
    This integer value is used to access indices of arrays in the laser image and the ammo for the player throughout the game.
    */
    public void pinkButtonPressed()
    {
        PlayerPrefs.SetInt("laservalue", 3);
    }
}
