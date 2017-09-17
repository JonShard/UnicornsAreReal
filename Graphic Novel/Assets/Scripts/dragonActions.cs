using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragonActions : MonoBehaviour
{
    public int dragonAction = 0;    //  0 = idle, 1 = attack, 2 = death, 3 = flight/ movement
    public float movementSpeed = 5.0f;                              //How fast the player moves to the disired location.

    private Animator animator;
    public Rigidbody2D dragonRigidbody;
    public Vector2 desiredPosition = new Vector2(0, 0);             //The global position the player will move to. 
    
    void Start()
    {
        dragonRigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    
    void FixedUpdateUpdate()
    {
        //move dragon to the desired position with movement speed.
        Vector2 vectorToDesiredPoint = desiredPosition - new Vector2(transform.position.x, transform.position.y);
        int dragonAnimation = 0;

        dragonRigidbody.velocity = vectorToDesiredPoint;
        dragonRigidbody.velocity = dragonRigidbody.velocity.normalized * movementSpeed;

        switch (dragonAction)
        {
            case 0: dragonAnimation = 0;    //  idle
                break;

            case 1:
                dragonAnimation = 1;    //  attack
                break;

            case 2:
                dragonAnimation = 2;    //  death
                break;

            case 3:
                dragonAnimation = 3;    //  flight/ movement
                break;

            default: dragonAnimation = 0;
                break;
        }
        animator.SetInteger("dragonAction", dragonAnimation);
    }
    public void moveDragonToPosition(Vector2 v)
    {
        desiredPosition = v;                                        //Sets the desired position to be a point on global cordinates. 
    }
}
