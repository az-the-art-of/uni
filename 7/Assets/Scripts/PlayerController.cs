using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    private float speed = 4.0f;
    private float horizontalInput;
    private float forwardInput;
    private float jumpInput;

    // Update is called once per frame
    void Update()
    {

        // keep player in playarea  bounds
        if (transform.position.z < -2)
        { transform.position = new Vector3(transform.position.x, transform.position.y, -2); }

        if (transform.position.z > 2)
        { transform.position = new Vector3(transform.position.x, transform.position.y, 2); }

        if (transform.position.x < -40)
        { transform.position = new Vector3(-40, transform.position.y, transform.position.z); }

        if (transform.position.x > 2)
        { transform.position = new Vector3(2, transform.position.y, transform.position.z); }

       


        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        jumpInput = Input.GetAxis("Jump");


        // Player up/down movement 
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        // player left/right movement 
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);

        // Player jump movement
        transform.Translate(Vector3.up * Time.deltaTime * speed * jumpInput);


    }
}
