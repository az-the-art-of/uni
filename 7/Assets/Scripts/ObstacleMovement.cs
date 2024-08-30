using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // obstcale speed
    public float speed = 2.0f;

    // Update is called once per frame
    void Update()
    {


        // loops obstacle back and forth
        if (transform.position.z < -4)
        { transform.position = new Vector3(transform.position.x, transform.position.y, 4); }

        if (transform.position.z > 4)
        { transform.position = new Vector3(transform.position.x, transform.position.y, -4); }




        // moves obstacle 
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

    }
}
