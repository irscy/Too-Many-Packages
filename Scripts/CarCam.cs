using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCam : MonoBehaviour
{
    [SerializeField] GameObject carFollow;

    //camera do the follow car funny

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = carFollow.transform.position + new Vector3 (0, 0, -10);
    }
}
