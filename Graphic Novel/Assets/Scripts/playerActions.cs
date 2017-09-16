using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playerActions : MonoBehaviour
{

    public Vector2 desiredPosition = new Vector2(0, 0);             //The global position the player will move to. 
    public float movementSpeed = 20.0f;                             //How fast the player moves to the disired location.


    public Rigidbody2D playerRigidbody;

    // Use this for initialization
    void Start ()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
        
        
	}


    void moveToPosition(Vector2 v)
    {
        
        playerRigidbody.velocity = transform.position - 

    }



}
