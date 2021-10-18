using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim : MonoBehaviour
{
    public Animator pute;
    void Update()
    {
        if (pute.GetCurrentAnimatorStateInfo(0).IsName("idle"))
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                pute.Play("Saut");
            }

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                pute.Play("Dash");
            }

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                pute.Play("Crouc");
            }
        }
    }
}
