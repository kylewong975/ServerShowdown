using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

/*
This ButtonScript script holds a collection of functions in which is used to load scenes. The functions are 
called when the buttons are clicked, through the OnClick function.
*/
public class ButtonScript : MonoBehaviour {

    /*
    The MainMenu function opens up the MainMenu scene, which is loaded once the OnClick function is called.
    */
	public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    /*
    The Play function opens up the first level mission scene "Level1Intro," which is loaded once the 
    OnClick function is called.
    */
    public void Play()
    {
        SceneManager.LoadScene("Level1Intro");
    }

    /*
    The Level1 function opens up the first level scene "Level1," which is loaded once the OnClick function is called.
    */
    public void Level1()
    {
        SceneManager.LoadScene("Level1");
    }

    /*
    The Level2Intro function opens up the second level mission scene "Level2Intro," which is loaded once the 
    OnClick function is called.
    */
    public void Level2Intro()
    {
        SceneManager.LoadScene("Level2Intro");
    }

    /*
    The Level2 function opens up the second level scene "Level2," which is loaded once the OnClick function is called.
    */
    public void Level2()
    {
        SceneManager.LoadScene("Level2");
    }

    /*
    The Level3Intro function opens up the third level mission scene "Level3Intro," which is loaded once the 
    OnClick function is called.
    */
    public void Level3Intro()
    {
        SceneManager.LoadScene("Level3Intro");
    }

    /*
    The Level3 function opens up the third level scene "Level3," which is loaded once the OnClick function is called.
    */
    public void Level3()
    {
        SceneManager.LoadScene("Level3");
    }

    /*
    The Level4Intro function opens up the fourth level mission scene "Level4Intro," which is loaded once the 
    OnClick function is called.
    */
    public void Level4Intro()
    {
        SceneManager.LoadScene("Level4Intro");
    }

    /*
    The Level4 function opens up the fourth level scene "Level4" which is loaded once the OnClick function is called.
    */
    public void Level4()
    {
        SceneManager.LoadScene("Level4");
    }

    /*
    The Level5Intro function opens up the fifth level mission scene "Level5Intro," which is loaded once the 
    OnClick function is called.
    */
    public void Level5Intro()
    {
        SceneManager.LoadScene("Level5Intro");
    }

    /*
    The Level5 function opens up the fifth level scene "Level5" which is loaded once the OnClick function is called.
    */
    public void Level5()
    {
        SceneManager.LoadScene("Level5");
    }

    /*
    The Level6Intro function opens up the sixth level mission scene "Level6Intro," which is loaded once the 
    OnClick function is called.
    */
    public void Level6Intro()
    {
        SceneManager.LoadScene("Level6Intro");
    }

    /*
    The Level6 function opens up the sixth level scene "Level6" which is loaded once the OnClick function is called.
    */
    public void Level6()
    {
        SceneManager.LoadScene("Level6");
    }

    /*
    The Level7Intro function opens up the seventh level mission scene "Level7Intro," which is loaded once the 
    OnClick function is called.
    */
    public void Level7Intro()
    {
        SceneManager.LoadScene("Level7Intro");
    }

    /*
    The Level7 function opens up the seventh level scene "Level7" which is loaded once the OnClick function is called.
    */
    public void Level7()
    {
        SceneManager.LoadScene("Level7");
    }

    /*
    The Level8Intro function opens up the eighth level mission scene "Level8Intro," which is loaded once the 
    OnClick function is called.
    */
    public void Level8Intro()
    {
        SceneManager.LoadScene("Level8Intro");
    }

    /*
    The Level8 function opens up the eighth level scene "Level8" which is loaded once the OnClick function is called.
    */
    public void Level8()
    {
        SceneManager.LoadScene("Level8");
    }

    /*
    The Level9Intro function opens up the ninth level mission scene "Level9Intro," which is loaded once the 
    OnClick function is called.
    */
    public void Level9Intro()
    {
        SceneManager.LoadScene("Level9Intro");
    }

    /*
    The Level9 function opens up the ninth level scene "Level9" which is loaded once the OnClick function is called.
    */
    public void Level9()
    {
        SceneManager.LoadScene("Level9");
    }

    /*
    The Level10Intro function opens up the tenth level mission scene "Level10Intro," which is loaded once the 
    OnClick function is called.
    */
    public void Level10Intro()
    {
        SceneManager.LoadScene("Level10Intro");
    }

    /*
    The Level10 function opens up the tenth level scene "Level10" which is loaded once the OnClick function is called.
    */
    public void Level10()
    {
        SceneManager.LoadScene("Level10");
    }

    /*
    The Congrats function opens up the level description scene "Congrats" which is loaded once the OnClick function is called.
    */
    public void Congrats()
    {
        SceneManager.LoadScene("Congrats");
    }

    /*
    The NetworkExploration function opens up the level scene "NetworkExploration" which is loaded once the OnClick function is called.
    */
    public void NetworkExploration()
    {
        SceneManager.LoadScene("NetworkExploration");
    }

    /*
    The SelectLevel function opens up the level selection menu "LevelSelect," which is loaded once the OnClick function 
    is called.
    */
    public void SelectLevel()
    {
        SceneManager.LoadScene("LevelSelect");
    }

    /*
    The NetworkInfo function opens up the first page of the network information section "NetworkInfo1," which is loaded once 
    the OnClick function is called.
    */
    public void NetworkInfo()
    {
        SceneManager.LoadScene("NetworkInfo1");
    }

    /*
    The NetworkInfo2 function opens up the second page of the network information section "NetworkInfo2," which is loaded once 
    the OnClick function is called.
    */
    public void NetworkInfo2()
    {
        SceneManager.LoadScene("NetworkInfo2");
    }

    /*
    The NetworkInfo3 function opens up the third page of the network information section "NetworkInfo2," which is loaded once 
    the OnClick function is called.
    */
    public void NetworkInfo3()
    {
        SceneManager.LoadScene("NetworkInfo3");
    }

    /*
    The NetworkInfo4 function opens up the fourth page of the network information section "NetworkInfo2," which is loaded once 
    the OnClick function is called.
    */
    public void NetworkInfo4()
    {
        SceneManager.LoadScene("NetworkInfo4");
    }

    /*
    The Instructions function opens up the instructions screen "Instructions," which is loaded once the OnClick function 
    is called.
    */
    public void Instructions()
    {
        SceneManager.LoadScene("Instructions");
    }

    /*
    The Options function opens up the options menu "Options," which is loaded once the OnClick function 
    is called.
    */
    public void Options()
    {
        SceneManager.LoadScene("Options");
    }

    /*
    The About function opens up the about screen "About," which is loaded once the OnClick function is called.
    */
    public void About()
    {
        SceneManager.LoadScene("About");
    }

    /*
    The ExitGame function closes the game, once the OnClick function is called.
    */
    public void ExitGame()
    {
        Application.Quit();
    }
}
