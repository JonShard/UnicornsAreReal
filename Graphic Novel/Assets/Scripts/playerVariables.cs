using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerVariables : MonoBehaviour
{
    public enum inventoryCheck{axe,sword, antidote, emptyVial, waterBucket, emptyBucket, rock}; //enum that keeps track of "where things is in the inventory"
    //public variables to check actions that can/will be performed
    public int goldAmount;
    public int weaponEquipped;
    public bool[] inventory = new bool[20];
    public bool isPoisoned;
    public bool onFire;
    public bool armourEquipped;

}
