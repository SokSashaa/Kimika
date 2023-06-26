using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
	[HideInInspector]
	public 	int 	fruitsClicked = 0;
	[HideInInspector]
	public 	float 	stablePosition;
	[HideInInspector]
	public 	bool 	playersTurn = false;


	public 	Text 			scoreText;
	private int 			score;
	private	BoardManager 	boardScript;


    void Awake()
    {
    	score = DataHolder.Score;
    	stablePosition = 0;
        boardScript = GetComponent<BoardManager>();
    }

    void Update()
    {
    	if (playersTurn)
    	{

    		if (fruitsClicked == 2)
    		{
    			playersTurn = false;
    			boardScript.SwapSelectedPositions();
    		}
    		score += boardScript.RemoveHorizontalFruits() * 10;
    		score += boardScript.RemoveVerticalFruits() * 10;
            DataHolder.Score = score;
    		scoreText.text = "Счёт : " + score;
    	}
    	else 
    	{
    		if (boardScript.CheckTurn())
    		{
    			stablePosition += 1 * Time.deltaTime;
    			
    		}
    		if (stablePosition > 1)
    		{
    			playersTurn = true;
    		}

    	}
    }
}
