using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pause_Menu_Perso : MonoBehaviour
{
    //Boolean variable to idicate the state of the game, paused or not;
    public static bool gameIsPaused = false;
    //Targeted menu to print when "Pause" is requested;
    public GameObject pauseMenuUI;


    /**
     * Update is called once per frame;
     * It waits for the use of the "Escape" key to print the "Pause" menu or go out of it;
     */
    void Update()
    {
        /*
         * The game wait for the use of the "Escape" key;
         */
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            /*
             * It tests if the game is already on "Pause";
             */
            if(gameIsPaused==true)
            {
                // If it is the case, it get back to the game;
                Resume();
            }
            else
            {
                // If it is not the case, it prints the "Pause" menu;
                Pause();
            }
        }
    }


    /**
     * Resume method enables to get back to the game at the moment of the pause;
     */
    public void Resume()
    {
        //It changes the state of visibility and usability of the "Pause" Menu during the game to make it unusable;
        pauseMenuUI.SetActive(false);
        //It gives back a normal speed to the game time;
        Time.timeScale = 1f;
        //It changes the state value of the game;
        gameIsPaused = false;
    }


    /**
     * This method enables to set the "Pause" Menu active;
     */
    void Pause()
    {
        //It changes the state of visibility and usability of the "Pause" Menu during the game to make it usable;
        pauseMenuUI.SetActive(true);
        //It stops the time speed;
        Time.timeScale = 0f;
        //It changes the state value of the game;
        gameIsPaused = true;
    }


    /**
     * This method enables to come back to the Main Menu;
     */
    public void LoadMenu()
    {
        //It calls a scene manager to come back to the scene called "Mai_Menu";
        SceneManager.LoadScene("Main_Menu");
        //The time runs normally;
        Time.timeScale = 1f;
    }


    /**
     * This method enables to quit the game from the "Pause" menu;
     */
    public void QuiTGame()
    {
        //"Quit" function doesn't work natively in unity IDE, so a log is printed on the shell to advertise us;
        Debug.Log("Quit");
        //The application is shut down;
        Application.Quit();
    }


    /**
     * The "Replay" function enables the player to come back to the start of the game;
     */
    public void Replay()
    {
        //It calls back the same scene to reload it from the start;
        SceneManager.LoadScene("Level_1");
        //The time runs normally;
        Time.timeScale = 1f;
    }
}
