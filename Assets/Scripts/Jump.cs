using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float targetTime = 1f;
    public float Cadence ;
    private Rigidbody m_Rigidbody;
    private SphereCollider m_Collider;
    private Transform m_Transform;
    private bool CanJump;
    private bool CanCrouch;
    public float m_Thrust = 20f;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        m_Collider = GetComponent<SphereCollider>();
        m_Transform = GetComponent<Transform>();
    }

    void FixedUpdate()
    {
        targetTime -= Time.deltaTime;
        
        if (Input.GetButton("Jump") && CanJump)
        {
            m_Rigidbody.AddForce(transform.up * m_Thrust);
            targetTime = Cadence;
        }
        
        if (targetTime <= 0.0f)
        {
            CanJump = true;
        }
        else CanJump = false;
    }
}
