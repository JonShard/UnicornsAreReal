using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class optionDisplay : MonoBehaviour
{

    public GameObject botRight;
    public GameObject botLeft;
    public GameObject topRight;
    public GameObject topLeft;



	// Use this for initialization
	void Start ()
    {
		


	}
    void topRightWinner()
    {
         topRight.GetComponent<GUIText>().enabled = false;
    }
    void topLeftWinner()
    {
        topLeft.GetComponent<GUIText>().enabled = false;
    }
    void botRightWinner()
    {
        botRight.GetComponent<GUIText>().enabled = false;
    }
    void botLeftWinner()
    {
        botLeft.GetComponent<GUIText>().enabled = false;
    }
    // Update is called once per frame
    void Update ()
    {
	if(Input.GetKeyDown(KeyCode.Alpha5))
        {
            
            Invoke("topLeftWinner", 3);
            botRight.GetComponent<GUIText>().enabled = false;
            botLeft.GetComponent<GUIText>().enabled = false;
            topRight.GetComponent<GUIText>().enabled = false;
        }
    if (Input.GetKeyDown(KeyCode.Alpha6))
        {

            Invoke("topRightWinner", 3);
            botRight.GetComponent<GUIText>().enabled = false;
            botLeft.GetComponent<GUIText>().enabled = false;
            topLeft.GetComponent<GUIText>().enabled = false;
        }
    if (Input.GetKeyDown(KeyCode.Alpha7))
        {

            Invoke("botRightWinner", 3);
            topLeft.GetComponent<GUIText>().enabled = false;
            botLeft.GetComponent<GUIText>().enabled = false;
            topRight.GetComponent<GUIText>().enabled = false;
        }
    if (Input.GetKeyDown(KeyCode.Alpha8))
        {

            Invoke("botLeftWinner", 3);
            botRight.GetComponent<GUIText>().enabled = false;
            topLeft.GetComponent<GUIText>().enabled = false;
            topRight.GetComponent<GUIText>().enabled = false;
        }
    if (Input.GetKeyDown(KeyCode.Space))
        {
            botRight.GetComponent<GUIText>().enabled = true;
            botLeft.GetComponent<GUIText>().enabled = true;
            topLeft.GetComponent<GUIText>().enabled = true;
            topRight.GetComponent<GUIText>().enabled = true;

        }
    }
    /*
            botRight.GetComponent<GUIText>().text = "Fuck you Ling";
            botLeft.GetComponent<GUIText>().text = "FyL";
            topRight.GetComponent<GUIText>().text = "Bananas";
            topLeft.GetComponent<GUIText>().text = "Apples";
           */

}
