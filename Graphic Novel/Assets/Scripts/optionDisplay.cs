using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class optionDisplay : MonoBehaviour
{

    GameObject botRight;
    GameObject botLeft;
    GameObject topRight;
    GameObject topLeft;
    GameObject question;
    GameObject action;


    // Use this for initialization
    void Start()
    {
        topLeft = GameObject.Find("topLeft");
        topRight = GameObject.Find("topRight");
        botLeft = GameObject.Find("botLeft");
        botRight = GameObject.Find("botRight");
        question = GameObject.Find("question");
        action = GameObject.Find("action");



    }
    void topRightWinner()
    {
        topRight.GetComponent<GUIText>().enabled = false;
        question.GetComponent<GUIText>().enabled = false;
        action.GetComponent<GUIText>().enabled = false;
    }
    void topLeftWinner()
    {
        topLeft.GetComponent<GUIText>().enabled = false;
        question.GetComponent<GUIText>().enabled = false;
        action.GetComponent<GUIText>().enabled = false;
    }
    void botRightWinner()
    {
        botRight.GetComponent<GUIText>().enabled = false;
        question.GetComponent<GUIText>().enabled = false;
        action.GetComponent<GUIText>().enabled = false;
    }
    void botLeftWinner()
    {
        botLeft.GetComponent<GUIText>().enabled = false;
        question.GetComponent<GUIText>().enabled = false;
        action.GetComponent<GUIText>().enabled = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha5))
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
            question.GetComponent<GUIText>().enabled = true;
            action.GetComponent<GUIText>().enabled = true;
        }

      
    }

    void activateQuestionScreen(string questionText, string topLeftText, string topRightText = "", string botLeftText = "", string botrightText = "")
    {
        question.GetComponent<GUIText>().text = questionText;
        botRight.GetComponent<GUIText>().text = botrightText;
        botLeft.GetComponent<GUIText>().text = botLeftText;
        topRight.GetComponent<GUIText>().text = topRightText;
        topLeft.GetComponent<GUIText>().text = topLeftText;

    }
}
