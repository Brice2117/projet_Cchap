using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam_Perso_Follower : MonoBehaviour
{
    //Target of the camera and setting space on unity;
    [SerializeField] Transform target;
    //Variable and setting space of the smooth on unity;
    [Range(0.01f, 1.0f)] [SerializeField] float smooth;
    //Offset of the camera compared with the character position;
    Vector3 offsetCam;


    /**
     * Start is called before the first frame update
     */
    void Start()
    {
        //Initializing of the offset of the camera;
        offsetCam = transform.position - target.position;
    }


    /**
     * Update is called once per frame;
     */
    void Update()
    {
        //Defining of the position pf the camera;
        Vector3 camPos = target.position + offsetCam;
        /*
         * Defining of the speed of following of the camera;
         */
        //Vector3 smoothPosition = Vector3.Lerp(transform.position, camPos, smooth);
        //transform.position = smoothPosition;

        //The camera follow perfectly the character;
        transform.position = camPos;

        //transform.LookAt(target);
    }
}
