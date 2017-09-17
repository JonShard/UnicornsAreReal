using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{

    GameObject gameOverTextObject;
    GameObject gameOverReasonObject;
    GameObject gameOverScreenBackgroundObject;

    GUIText deathText;
    GUIText deathReasonText;
    SpriteRenderer backgroundSpriteRenderer;


	// Use this for initialization
	void Start ()
    {
        gameOverTextObject = GameObject.Find("GameOverText");
        gameOverReasonObject = GameObject.Find("GameOverReasonText");
        gameOverScreenBackgroundObject = GameObject.Find("GameOverScreenBackground");

        deathText = gameOverTextObject.GetComponent<GUIText>();
        deathReasonText = gameOverReasonObject.GetComponent<GUIText>();
        backgroundSpriteRenderer = gameOverScreenBackgroundObject.GetComponent<SpriteRenderer>();


        deathText.enabled = false;
        deathReasonText.enabled = false;
        backgroundSpriteRenderer.enabled = false;
	}


    public void activateGameOverScreen(string deathReason)
    {
        deathText.enabled = true;
        deathReasonText.enabled = true;
        backgroundSpriteRenderer.enabled = true;

        deathReasonText.text = deathReason;

        Invoke("reload", 5);
    }

    public void deactivateGameOverScreen()
    {
        deathReasonText.enabled = false;
        deathReasonText.enabled = false;
        backgroundSpriteRenderer.enabled = false;
    }

    void reload()
    {
        Application.Quit();
    }
}
