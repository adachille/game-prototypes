using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float turnSpeed = 200f;
    [SerializeField] float acceleration = 10f;
    [SerializeField] float breakDeceleration = 200f;
    [SerializeField] float idleDeceleration = 50f;

    [SerializeField] float maxSpeed = 20f;
    float curSpeed = 0f;

    void Start()
    {
        
    }

    void Update()
    {
        applyTurning();
        applyMovement();
    }
    
    void applyTurning()
    {
        float steerAmount = -Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        transform.Rotate(0, 0, steerAmount);
    }

    void applyMovement()
    {
        float direction = Math.Sign(Input.GetAxis("Vertical"));
        float deltaSpeed;

        if (direction == 0) { 
            deltaSpeed = -Math.Sign(curSpeed) * idleDeceleration * Time.deltaTime;
        }
        else if (Math.Sign(direction) != Math.Sign(curSpeed))
        {
            deltaSpeed = direction * breakDeceleration * Time.deltaTime;
        }
        else
        {
            deltaSpeed = direction * acceleration * Time.deltaTime;
        }
        curSpeed = Math.Clamp(curSpeed + deltaSpeed, -maxSpeed, maxSpeed);
        float moveAmount = curSpeed * Time.deltaTime;
        transform.Translate(0, moveAmount, 0);
    }
}
