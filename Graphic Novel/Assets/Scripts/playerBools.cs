using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBools : MonoBehaviour
{
    public enum inventoryCheck{axe,sword,antidote,emptyVial,waterBucket,emptyBucket}; //enum that keeps track of "where things is in the inventory"
    //public variables to check actions that can/will be performed
    public static int goldAmount;
    public static int weaponEquipped;
    public static bool[] inventory = new bool[20];
    public static bool isPoisoned;
    public static bool onFire;
    public static bool armourEquipped;
 
	// Use this for initialization
	void Start ()
    {       	
	}
	// Update is called once per frame
	void Update ()
    {	
	}
}
