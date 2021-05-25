using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    public float restposition = 0f;
    public float pressedposition ;
    public float hitstrength = 10000f;
    public float flipperdamper = 150f;
    HingeJoint hinge;

    void Start()
    {
        hinge = GetComponent<HingeJoint>();
        hinge.useSpring = true;
    }
    void Update()
    {
        JointSpring spring = new JointSpring();
        spring.spring = hitstrength;
        spring.damper = flipperdamper;

        if (Input.GetKey(KeyCode.X))
        {
            spring.targetPosition = pressedposition;
        }
        else
        {
            spring.targetPosition = restposition;
        }
        hinge.spring = spring;
        hinge.useLimits = true;
    }


}