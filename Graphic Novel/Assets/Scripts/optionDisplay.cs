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
	
	// Update is called once per frame
	void Update ()
    {
	if(Input.GetKeyDown(KeyCode.W))
        {
            
            botRight.GetComponent<GUIText>().text = "Fuck you Ling";
            botLeft.GetComponent<GUIText>().text = "FyL";
            topRight.GetComponent<GUIText>().text = "Bananas";
            topLeft.GetComponent<GUIText>().text = "Apples";

        }
    
        	
	}
}
