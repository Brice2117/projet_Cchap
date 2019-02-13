using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Perso_Info_Printing : MonoBehaviour
{
    //Targeted Text Printer on the game screen;
    public GameObject lifeText;
    //Targeted Death Menu of the game;
    public GameObject failMenu;
    //Number of lives of the character;
    public int nbOfLives;


    /**
     * Start is called before the first frame update;
     * Initialization of the variables of the game at its beginning;
     */
    void Start()
    {
        //The "Death" Menu is set inactive from the start of the game;
        failMenu.gameObject.SetActive(false);
        //The time runs normally;
        Time.timeScale = 1f;
        //The text printing the number of lives is set with the correct values;
        lifeText.GetComponent<TextMeshProUGUI>().text = "x"+nbOfLives.ToString();
    }


    /**
     * This function detects the entry of the player in a collider zone to decrease the number of lives and print the "Death" Menu;
     */
    public void OnTriggerEnter(Collider other)
    {
        /*
         * Checks if the player enters a collider zone tagged "Vide" and if it remains some lives to him;
         * If the player enters in the collider zone tagged "Vide" and its number of lives is higher than 0, its number of lives decreases;
         */
        if(other.gameObject.tag=="Vide" && nbOfLives>0)
        {
            nbOfLives--;
            //The Lives text is updated;
            lifeText.GetComponent<TextMeshProUGUI>().text = "x"+nbOfLives.ToString();
        }
        /*
         * If the player enters in the collider zone tagged "Vide" and its number of lives is 0, the "Death" Menu is printed;
         */
        else
        {
            //The "Death" Menu is enabled;
            failMenu.gameObject.SetActive(true);
            //The time stops;
            Time.timeScale = 0f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
