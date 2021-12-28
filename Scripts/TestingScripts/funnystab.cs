using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class funnystab : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "sadrocc")
        {
            Debug.Log("AAAAA YOURE KILLING ME MAN STOP AHH DAMN IT IM DYING");
        }
    }
}
