using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translate : MonoBehaviour
{
    public float Speed;
    public void Update()
    {

        transform.Translate(Vector3.right * Time.deltaTime * Speed, Space.World);
    }
}