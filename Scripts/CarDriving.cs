using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarDriving : MonoBehaviour
{
    //Accelerate Power
    [SerializeField] float accelerate;

    //Reverse Power
    [SerializeField] float reverse;

    //Steer Left Power
    [SerializeField] float steerLeft;

    //Steer Right Power
    [SerializeField] float steerRight;

    [SerializeField] float boostMove;

    [SerializeField] float boostRotation;

    [SerializeField] float slowDownTime;

    [SerializeField] float slowRotationTime;

    // Start is called before the first frame update
    void Start()
    {
        //Car will point down when game starts
        transform.rotation = Quaternion.Euler(0, 0, 0);
        transform.position = new Vector3 (-0.5f, 11, -1);
        slowDownTime = 20;
        slowRotationTime = 125;
    }

    //if car collides with something else
    void OnCollisionEnter2D(Collision2D other) 
    {
        accelerate = -slowDownTime;
        reverse = slowDownTime;
        steerLeft = slowRotationTime;
        steerRight = -slowRotationTime;
    }

    //if car touches speed bost
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "speedBoost")
        {
            accelerate = -boostMove;
            reverse = boostMove;
            steerLeft = boostRotation;
            steerRight = -boostRotation;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //W key to accelerate car
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, accelerate * Time.deltaTime, 0);
        }

        //S key to reverse car
         if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, reverse * Time.deltaTime, 0);
        }

         //Left arrow to turn left
         if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, 0, steerLeft * Time.deltaTime);
        }

        //turn right
         if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 0, steerRight * Time.deltaTime);
        }
    }
}