using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float targetTime = 1f;
    public float Cadence ;
    Rigidbody m_Rigidbody;
    private bool CanJump;
    public float m_Thrust = 20f;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        
        if (Input.GetButton("Jump") && CanJump)
        {
            m_Rigidbody.AddForce(transform.up * m_Thrust);
            targetTime = Cadence;
        }
        targetTime -= Time.deltaTime;

        if (targetTime <= 0.0f)
        {
            CanJump = true;
        }
        else CanJump = false;
    }
}
