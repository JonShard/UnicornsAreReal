using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class optionDisplay : MonoBehaviour
{
    //Declarations
    GameObject botRight;
    GameObject botLeft;
    GameObject topRight;
    GameObject topLeft;
    GameObject question;
    GameObject action;
    GameObject optionBackground;


    public int timeout = 5;

    // Use this for initialization
    void Start()
    {

        //defenitions
        topLeft = GameObject.Find("topLeft");
        topRight = GameObject.Find("topRight");
        botLeft = GameObject.Find("botLeft");
        botRight = GameObject.Find("botRight");
        question = GameObject.Find("question");
        action = GameObject.Find("action");
        optionBackground = GameObject.Find("optionBackground");


        deactivateQuestionScreen();
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        int choice = 0;

        if (Input.GetKeyDown(KeyCode.Alpha5) && topLeft.GetComponent<GUIText>().text != "")    //GetKeyDown functions that runs one of the invoke functions and turns the three other sprite renderers off 
        {

            Invoke("deactivateQuestionScreen", timeout);
            botRight.GetComponent<GUIText>().enabled = false;
            botLeft.GetComponent<GUIText>().enabled = false;
            topRight.GetComponent<GUIText>().enabled = false;
            choice = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha6) && topRight.GetComponent<GUIText>().text != "")
        {

            Invoke("deactivateQuestionScreen", timeout);
            botRight.GetComponent<GUIText>().enabled = false;
            botLeft.GetComponent<GUIText>().enabled = false;
            topLeft.GetComponent<GUIText>().enabled = false;
            choice = 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha7) && botRight.GetComponent<GUIText>().text != "")
        {

            Invoke("deactivateQuestionScreen", timeout);
            topLeft.GetComponent<GUIText>().enabled = false;
            botLeft.GetComponent<GUIText>().enabled = false;
            topRight.GetComponent<GUIText>().enabled = false;
            choice = 3;
        }
        if (Input.GetKeyDown(KeyCode.Alpha8) && botLeft.GetComponent<GUIText>().text != "")
        {

            Invoke("deactivateQuestionScreen", timeout);
            botRight.GetComponent<GUIText>().enabled = false;
            topLeft.GetComponent<GUIText>().enabled = false;
            topRight.GetComponent<GUIText>().enabled = false;
            choice = 4;
        }
        if (choice != 0)
        {
            question.GetComponent<GUIText>().enabled = false;
            action.GetComponent<GUIText>().text = OptionsClass.performActions(choice);
        }



        if (Input.GetKeyDown(KeyCode.Space))            //test func that makes all GUI texts appear on screen
        {
            botRight.GetComponent<GUIText>().enabled = true;
            botLeft.GetComponent<GUIText>().enabled = true;
            topLeft.GetComponent<GUIText>().enabled = true;
            topRight.GetComponent<GUIText>().enabled = true;
            question.GetComponent<GUIText>().enabled = true;
            action.GetComponent<GUIText>().enabled = true;
            optionBackground.GetComponent<SpriteRenderer>().enabled = true;

        }



    }

    public void activateQuestionScreen(string questionText, string topLeftText, string topRightText = "", string botLeftText = "", string botrightText = "") //function that recieves five strings and displays them all on screen along with the background
    {

        botRight.GetComponent<GUIText>().enabled = true;
        botLeft.GetComponent<GUIText>().enabled = true;
        topLeft.GetComponent<GUIText>().enabled = true;
        topRight.GetComponent<GUIText>().enabled = true;
        question.GetComponent<GUIText>().enabled = true;
        action.GetComponent<GUIText>().enabled = true;
        optionBackground.GetComponent<SpriteRenderer>().enabled = true;

        question.GetComponent<GUIText>().text = questionText;
        botRight.GetComponent<GUIText>().text = botrightText;
        botLeft.GetComponent<GUIText>().text = botLeftText;
        topRight.GetComponent<GUIText>().text = topRightText;
        topLeft.GetComponent<GUIText>().text = topLeftText;


    }

    public void deactivateQuestionScreen()
    {
        action.GetComponent<GUIText>().text = "What do you do?";
        question.GetComponent<GUIText>().enabled = false;
        action.GetComponent<GUIText>().enabled = false;
        botRight.GetComponent<GUIText>().enabled = false;
        botLeft.GetComponent<GUIText>().enabled = false;
        topLeft.GetComponent<GUIText>().enabled = false;
        topRight.GetComponent<GUIText>().enabled = false;
        optionBackground.GetComponent<SpriteRenderer>().enabled = false;

    }
}
