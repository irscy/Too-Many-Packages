using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class debug : MonoBehaviour
{

    public void OnZAxis()
    {
        transform.position = new Vector3 (60, 4.5f, 5);
    }

    // Start is called before the first frame update
    void Start()
    {
        OnZAxis();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
