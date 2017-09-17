using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class OptionsClass
{
    public static int situation = 1;

    static Vector2 spawnPosition = new Vector2(0,0);
    static Vector2 situationPosition1 = new Vector2(0.18f, -8f);
    static Vector2 situationPosition2 = new Vector2(2.31f, -1.09f);

    static Vector2 exitPosition = new Vector2(0, 20);

    static GameObject optionsMenuObject = GameObject.FindGameObjectWithTag("options");
    static GameObject gameOverScreenObject = GameObject.Find("GameOverScreen");
    static GameObject player = GameObject.Find("player");

    static optionDisplay perOgPaal = optionsMenuObject.GetComponent<optionDisplay>();
    static GameOverScreen gameOverScreen = gameOverScreenObject.GetComponent<GameOverScreen>();
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
                if (inventory.inventory[6] == false)
                {
                    perOgPaal.activateQuestionScreen("You notice a rock on the ground.", "Pick it up!",
                                            "Leave it to suffer.");
                }
                else
                {
                    perOgPaal.activateQuestionScreen("You are now carrying the rock.",
                                             "Throw it into the air!", "Talk to the rock", "Continue moving!");
                }
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

                if (inventory.inventory[6] == false)            //If dont have rock.
                {
                    switch (action)
                    {
                        case 1:     //Pick up rock.


                            GameObject.Find("rock").GetComponent<SpriteRenderer>().enabled = false;
                            inventory.inventory[6] = true;                  // rock in inventory is true.
                            actions.movePlayerToPosition(situationPosition1 + new Vector2(0, 2));
                            return "It's lighter than it seems.";
                            
                            
                            break;

                        case 2:     //Leave rock.
                            actions.movePlayerToPosition(situationPosition2);
                            situation++;
                            return "As you pass the rock, you can smell what it's cooking.";
                            break;

                    }
                }
                else                //If already have the rock
                {
                    switch (action)
                    {
                        case 1:     //Throw rock.
                            gameOverScreen.activateGameOverScreen("The rock hit you in the head. Funny how gravity works!");
                            perOgPaal.deactivateQuestionScreen();
                            return "";
                            break;

                        case 2:     //Talk to rock.
                            actions.movePlayerToPosition(situationPosition1 + new Vector2(0, 2));
                            return "You feel very poetic talking to a rock, however questioning your sanity";
                            break;

                        case 3:     //TContine

                            actions.movePlayerToPosition(situationPosition2);
                            situation++;
                            return "You carry your trusty rock under your arm as you continue you jouney.";
                            break;

                    }
                }

                break;




        }

        return "You feel there is something fishy happening.";          //If for some reason choice is invalid and does not enter any cases.
    }


}
