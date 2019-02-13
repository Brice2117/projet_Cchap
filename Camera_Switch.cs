using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Switch : MonoBehaviour
{
    //Camera vue on first person;
    public Camera vueFPS;
    //Camera vue on third person;
    public Camera vueDeDos;
    //public Camera vueDeHaut;


    /**
     * Initializing of the camera used at the beginning of the game;
     */
    private void Start()
    {
        //Third person camera enabled;
        vueDeDos.enabled = true;
        //First person camera disabled;
        vueFPS.enabled = false;
    }

    /**
     * Update is called once per frame;
     * This method enables the player to change the view of the game and switch between the first and third person view;
     */
    void Update()
    {
        /*
         * Waits for the using of the "1" key of the left top of the keyboard to enable the first person view and disable the third one;
         */
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            //FPS
            vueFPS.enabled = true;
            vueDeDos.enabled = false;
            /*vueFPS.depth = 0;
            vueDeDos.depth = -1;*/
            //vueDeHaut.depth = -1;
        }


        /*
         * Waits for the using of the "3" key of the left top of the keyboard to enable the third person view and disable the first one;
         */
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            //TPS
            vueFPS.enabled = false;
            vueDeDos.enabled = true;
            /*vueFPS.depth = -1;
            vueDeDos.depth = 0;*/
            //vueDeHaut.depth = -1;
        }

        /*if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            //Profonde
            vueFPS.depth = -1;
            vueDeDos.depth = -1;
            vueDeHaut.depth = 0;
        }*/
    }
}
