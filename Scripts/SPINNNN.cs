using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPINNNN : MonoBehaviour
{
    [SerializeField] float SpinnPerFrame;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, SpinnPerFrame * Time.deltaTime);
    }
}
