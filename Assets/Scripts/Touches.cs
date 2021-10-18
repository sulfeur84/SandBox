using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class Touches : MonoBehaviour
{
    public static List<Touches> TouchesList;

    public float distPerfect;

    private void Awake()
    {
        TouchesList.Add(this);
    }

    // Start is called before the first frame update
   /* void Start()
    {
        float dist = Vector3.Distance(Touches.TouchesList[0].transform.position, Player.transform.position);

        if (dist < distPerfect)
        {
            Perfect();
        }
    }*/

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDestroy()
    {
        TouchesList.Remove(this);
    }
}
