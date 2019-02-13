using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**
 * Class enabling the respawn of the character on some checkpoints;
 */
public class Zone_Death : MonoBehaviour
{
    //Checkpoint targeted;
    public Transform zone_start;


    /**
     * Method enabling the recovery of the falling player;
     * @ parameter other : Collider field of the player;
     */
    private void OnTriggerEnter(Collider other)
    {
        /*
         * Test if the player's collider enter in the field of recovery;
         */
        if(other.gameObject.tag=="Player" )//&& compteurVies-1>0)
        {
            //The player is transported to the position of the checkpoint;
            other.transform.position = zone_start.transform.position;
        }
    }
}
