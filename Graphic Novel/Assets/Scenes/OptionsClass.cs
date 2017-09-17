using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class OptionsClass
{
    public static int situation = 1;

    private static bool rockPickedUp = false;

    static Vector2 spawnPosition = new Vector2(0,0);
    static Vector2 situationPosition1 = new Vector2(0, 10);
    static Vector2 exitPosition = new Vector2(0, 20);

    static GameObject optionsMenuObject = GameObject.FindGameObjectWithTag("options");
    static GameObject player = GameObject.Find("player");

    static optionDisplay perOgPaal = optionsMenuObject.GetComponent<optionDisplay>();
    static playerActions actions = player.GetComponent<playerActions>();
    static playerVariables inventory = player.GetComponent<playerVariables>();



    public static int getChoices()
    {
        int selectedChoice = 0;


        switch(situation)
        {
            case 1:
                perOgPaal.activateQuestionScreen("You find yourself outside and extremely bored.", "Head out");
                break;


            case 2:         //Rock on ground
                perOgPaal.activateQuestionScreen("You notice a rock on the ground.", "Pick it up!", "Leave it to suffer.", "Throw it into the air!", "Talk to the rock");
                break;




        }


        return selectedChoice;
    }



    public static string performActions(int action)
    {

        switch (situation)
        {

            case 1:
                actions.movePlayerToPosition(situationPosition1);
                situation++;
                return "It's a nice day out.";
                break;


            case 2:
                switch (action)
                {
                    case 1:     //Pick up rock.

                        //Disable rock instance.
                        inventory.inventory[6] = true;                  // rock in inventory is true.
                        return "It's lighter than it seems.";
                        break;

                    case 2:     //Leave rock.

                        break;

                    case 3:     //Trow rock.

                        break;

                    case 4:     //Talk to rock.

                        break;
                }

                situation++;
                break;




        }

        return "You feel there is something fishy happening.";          //If for some reason choice is invalid and does not enter any cases.
    }


}
