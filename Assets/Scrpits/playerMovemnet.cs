using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class playerMovemnet : MonoBehaviour
{
    public Joystick stick;
    public float speed;
    float horzinotalMove;
    float verticalMove;
    void Start()
    {

    }

    void Update()
    {
        //if (stick.Horizontal >= .2f)
        //{
        //    horzinotalMove = speed;
        //}
        //else if (stick.Horizontal <= .2f)
        //{
        //    horzinotalMove = -speed;
        //}
        horzinotalMove = stick.Horizontal;
        verticalMove = stick.Vertical;
        transform.Translate(horzinotalMove * speed *Time.deltaTime, verticalMove * speed * Time.deltaTime, 0);
        Debug.Log(horzinotalMove);
    }
}
