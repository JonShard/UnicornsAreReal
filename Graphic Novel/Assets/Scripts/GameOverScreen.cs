using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScreen : MonoBehaviour
{

    SpriteRenderer backgroundSpriteRenderer;
    GUIText deathReasonText;

	// Use this for initialization
	void Start ()
    {
        enabled = false;
        deathReasonText = GetComponentInChildren<GUIText>();
	}


    public void activateGameOverScreen(string deathReason)
    {
        deathReasonText.text = deathReason;
        enabled = true;
    }

    public void deactivateGameOverScreen()
    {
        enabled = false;
    }
}
