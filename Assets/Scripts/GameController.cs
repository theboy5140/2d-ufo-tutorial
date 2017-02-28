using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour 
{

    public int level = 1;
    public int MAX_LEVEL = 3;

    public Text scoreText;
    public GameObject scoreLabel;
    public GameObject restartButton;
    public GameObject nextStageButton;
    public GameObject startMenu;

    private int totalScore = 0;
    private string stageStr = "Scenes/Stage";

    public void StartGame()
    {
        startMenu.SetActive (false);
        scoreLabel.SetActive (true);
        Time.timeScale = 1.0f;
    }

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
            nextStageButton.SetActive (true);
        }
    }

    public void ShowScore()
    {
        scoreText.text = "得分 : " + totalScore.ToString ();
    }

    public void StartNextStage()
    {
        level += 1;
        UnityEngine.SceneManagement.SceneManager.LoadSceneAsync (stageStr + level.ToString());
    }

    // Use this for initialization
	void Start () {
		
        ShowStartMenu ();
        DontDestroyOnLoad (transform.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void ShowStartMenu()
    {
        Time.timeScale = 0.0f;
        startMenu.SetActive (true);
        scoreLabel.SetActive (false);
    }
}
