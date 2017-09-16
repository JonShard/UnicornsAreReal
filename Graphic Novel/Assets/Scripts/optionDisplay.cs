using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class optionDisplay : MonoBehaviour
{
    //Declarations
    GameObject botRight;
    GameObject botLeft;
    GameObject topRight;
    GameObject topLeft;
    GameObject question;
    GameObject action;
    GameObject optionBackground;

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


    }

    void topRightWinner() //Invoke functions that run based on what option wins the vote
    {
        topRight.GetComponent<GUIText>().enabled = false;
        question.GetComponent<GUIText>().enabled = false;
        action.GetComponent<GUIText>().enabled = false;
        optionBackground.GetComponent<SpriteRenderer>().enabled = false;
    }
    void topLeftWinner()
    {
        topLeft.GetComponent<GUIText>().enabled = false;
        question.GetComponent<GUIText>().enabled = false;
        action.GetComponent<GUIText>().enabled = false;
        optionBackground.GetComponent<SpriteRenderer>().enabled = false;

    }
    void botRightWinner()
    {
        botRight.GetComponent<GUIText>().enabled = false;
        question.GetComponent<GUIText>().enabled = false;
        action.GetComponent<GUIText>().enabled = false;
        optionBackground.GetComponent<SpriteRenderer>().enabled = false;

    }
    void botLeftWinner()
    {
        botLeft.GetComponent<GUIText>().enabled = false;
        question.GetComponent<GUIText>().enabled = false;
        action.GetComponent<GUIText>().enabled = false;
        optionBackground.GetComponent<SpriteRenderer>().enabled = false;

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha5))    //GetKeyDown functions that runs one of the above invoke functions and turns the three other sprite renderers off 
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

    void activateQuestionScreen(string questionText, string topLeftText, string topRightText = "", string botLeftText = "", string botrightText = "") //function that recieves five strings and displays them all on screen along with the background
    {
        question.GetComponent<GUIText>().text = questionText;
        botRight.GetComponent<GUIText>().text = botrightText;
        botLeft.GetComponent<GUIText>().text = botLeftText;
        topRight.GetComponent<GUIText>().text = topRightText;
        topLeft.GetComponent<GUIText>().text = topLeftText;
        botRight.GetComponent<GUIText>().enabled = true;
        botLeft.GetComponent<GUIText>().enabled = true;
        topLeft.GetComponent<GUIText>().enabled = true;
        topRight.GetComponent<GUIText>().enabled = true;
        question.GetComponent<GUIText>().enabled = true;
        action.GetComponent<GUIText>().enabled = true;
        optionBackground.GetComponent<SpriteRenderer>().enabled = true;
    }
}
