using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


/**
 * Class of the Main Menu scripts of the game;
 */
public class MainMenu_Script : MonoBehaviour
{
    /**
     * This method enables the player to begin a new game form the Main Menu;
     */
    public void newGame()
    {
        //Call the next scene with the following build index of the scenes settings;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        /*
         * Also possible to call with the name of the scene :
         * SceneManager.LoadScene("Level01");
         * 
         * Also possible to call the scene with the buildindex :
         * SceneManager.LoadScene(1);
         */

    }


    /**
     * This method enables the player to completely quit the game from the Main Menu;
     */
    public void quitGame()
    {
        //"Quit" function doesn't work natively in unity IDE, so a log is printed on the shell to advertise us;
        Debug.Log("QUIT!");
        //The application is shut down;
        Application.Quit();
    }

}
