using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void OnTriggerEnter(Collider other) {
        Destroy(gameObject);
        //if (!gameObject.CompareTag("Bad")) { gameManager.GameOver();  }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
