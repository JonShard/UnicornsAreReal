using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosionScript : MonoBehaviour
{
    public int MuvTileY = 5;   //texture sheet column
    public int MuvTileX = 3;   //texture sheet row

    public int Mfps = 15;        // frames per second
    public float index;

    public Sprite[] sprite = new Sprite[14];

    void Start()
    {
        sprite = Resources.LoadAll<Sprite>("Assets/sprites/explosion-sprite");       //sprite location
    }

    void Update()
    {
        //calculate the index
        index += Time.deltaTime * Mfps;      //sets frames per second

        if (index >= 14) index = 0;      //repeats when all frames have been used

        GetComponent<SpriteRenderer>().sprite = sprite[Mathf.FloorToInt(index)];

        //transform.localScale = new Vector3(1, 1, 0);       //scales the sprite
    }
}