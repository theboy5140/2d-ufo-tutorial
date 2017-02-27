using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour 
{

    public int level = 1;
    public int MAX_LEVEL = 3;

    public Text scoreText;
    public GameObject restartButton;

    private int totalScore = 0;


    public void RestartGame()
    {
        Application.LoadLevel (Application.loadedLevel);
        restartButton.SetActive (false);
    }

    public void AddScore(int score)
    {
        totalScore += score;
        if (14 == totalScore) 
        {
            restartButton.SetActive (true);
        }
    }

    public void ShowScore()
    {
        scoreText.text = "SCORE : " + totalScore.ToString ();
    }

    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

}
