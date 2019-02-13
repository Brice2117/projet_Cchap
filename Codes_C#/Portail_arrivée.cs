using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Portail_arrivée : MonoBehaviour
{
    //Targeted Finish Menu to print at the end of the game;
    public GameObject FinishMenu;
    //Targeted Text to print the time score of the gamer;
    public GameObject timeScore;
    //Timer where to take the value of the time of the player at the end of the game;
    public Text chrono;
    //Counter to know the number of time the player go through the "Finish Portal";
    public int compteur = 0;


    /**
     * Method to dectect the entry of the player in the collider zone of the portal and launch the "Finish" Menu only once;
     */
    public void OnTriggerEnter(Collider other)
    {
        /**
         * Checks if the object that is entered in the zone of the portal is tagged as "Player" or not and if the counter is under 1;
         */
        if(other.gameObject.tag=="Player" && compteur<1)
        {
            //If the conditions are true, the "Finish" menu is enabled;
            FinishMenu.gameObject.SetActive(true);
            //The time speed of the game is reduced;
            Time.timeScale = 0.3f;
            //The time score text is updated with the time the player passed through the "Finish" portal;
            timeScore.GetComponent<TextMeshProUGUI>().text= chrono.text+" s";
            //The timer is disabled;
            chrono.gameObject.SetActive(false);
            //The counter is increased of one;
            compteur++;
            
        }
    }

    /**
     * Start is called before the first frame update;
     * Initialization of the variables of the game;
     */
    void Start()
    {
        //The "Finish" Menu is desabled from the beginning of the game;
        FinishMenu.gameObject.SetActive(false);
        //The time runs normally;
        Time.timeScale = 1f;
        //The timer is enabled;
        chrono.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
