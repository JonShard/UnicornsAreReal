﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playerActions : MonoBehaviour
{

    public Vector2 desiredPosition = new Vector2(0, 0);             //The global position the player will move to. 
    public float movementSpeed = 20.0f;                             //How fast the player moves to the disired location.
    private int movingInDirection = 0;                              //0 = still,  1 = right,  2 = left,  3 = up,  4 = down

    public Rigidbody2D playerRigidbody;

    // Use this for initialization
    void Start ()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        //Constantly move player to the desired position with movement speed.
        Vector2 vectorToDesiredPoint = desiredPosition - new Vector2(transform.position.x, transform.position.y);
        if (vectorToDesiredPoint.magnitude > 0.1f)
        {
            playerRigidbody.velocity = vectorToDesiredPoint;
            playerRigidbody.velocity = playerRigidbody.velocity.normalized * movementSpeed;



            int angle = (int) Helpfunctions.getAngle(vectorToDesiredPoint, new Vector2(0,0)) + 90;
            if (angle > 180-45 && angle < 180+45)   movingInDirection = 1;      //right
            if (angle > 0-45   && angle < 0+45)     movingInDirection = 2;      //left
            if (angle > 270-45 && angle < 270+45)  movingInDirection = 3;      //up
            if (angle > 90-45  && angle < 90+45)   movingInDirection = 4;      //down



        }
        else
        {
            movingInDirection = 0;                                  //Standing still now. 
            playerRigidbody.velocity = Vector2.zero;
        }
    }


    void moveToPosition(Vector2 v)
    {
        desiredPosition = v;                                        //Sets the desired position to be a point on global cordinates. 
    }



}
