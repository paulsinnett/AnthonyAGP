using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementDash : MonoBehaviour
{
    AnimationAndMovementController moveScript;


    public float DashSpeed;
    public float dashTime;

    // Start is called before the first frame update
    void Start()
    {
        moveScript = GetComponent<AnimationAndMovementController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            StartCoroutine(Dash());
        }
    }

    IEnumerator Dash()
    {
        
        float startTime = Time.time;

        while (Time.time < startTime + dashTime)
        {
            moveScript.Dash(DashSpeed);

            yield return null;
        }

        moveScript.Dash(0);
    }
}