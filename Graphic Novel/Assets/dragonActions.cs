using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragonActions : MonoBehaviour
{

    private Animator animator;
    public Rigidbody2D dragonRigidbody;
    public int dragonAction = 0;    //  0 = idle, 1 = attack, 2 = death, 3 = flight

    // Use this for initialization
    void Start()
    {
        dragonRigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        int dragonAnimation = 0;

        switch (dragonAction)
        {
            case 0: dragonAnimation = 0;
                break;

            case 1:
                dragonAnimation = 1;
                break;

            case 2:
                dragonAnimation = 2;
                break;

            case 3:
                dragonAnimation = 3;
                break;

            case 4:
                dragonAnimation = 4;
                break;

            default: dragonAnimation = 0;
                break;
        }
        animator.SetInteger("dragonAction", dragonAnimation);
    }
}
