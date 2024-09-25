using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float turnSpeed = 200f;
    [SerializeField] float acceleration = 30f;
    [SerializeField] float deceleration = 90f;
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
            deltaSpeed = -Math.Sign(curSpeed) * deceleration * Time.deltaTime;
        }
        else if (Math.Sign(direction) != Math.Sign(curSpeed))
        {
            deltaSpeed = direction * deceleration * Time.deltaTime;
        }
        else
        {
            deltaSpeed = direction * deceleration * Time.deltaTime;
        }
        curSpeed = Math.Clamp(curSpeed + deltaSpeed, -maxSpeed, maxSpeed);
        float moveAmount = curSpeed * Time.deltaTime;
        transform.Translate(0, moveAmount, 0);
    }
}
