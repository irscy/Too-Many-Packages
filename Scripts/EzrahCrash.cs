using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EzrahCrash : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Car")
        {
            Application.Quit();
            Debug.Log("should quit");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
