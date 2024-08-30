using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public GameObject player;
    //camera postion at an angel
    private Vector3 offset = new Vector3(-7, 5, -10);


    // Update is called once per frame
    void LateUpdate()
    {



        //camera follows player left/right and up/down and forward/backwards 
        transform.position = player.transform.position + offset;
       

    } 
}
