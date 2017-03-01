using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour 
{

    public int MAX_LEVEL = 3;

    public Text scoreText;
    public GameObject scoreLabel;
    public GameObject restartButton;
    public GameObject nextStageButton;
    public GameObject startMenu;
    public GameObject player;

    private int totalScore = 0;
    private string stageStr = "Scenes/Stage";
    private int level  = 1;

    public void StartGame()
    {
        startMenu.SetActive (false);
        scoreLabel.SetActive (true);
        player.SetActive (true);
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
        level = level + 1;
        UnityEngine.SceneManagement.SceneManager.LoadSceneAsync (stageStr + "1");
    }

    // Use this for initialization
	void Start () {
		
        ShowStartMenu ();
        //DontDestroyOnLoad (transform.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void ShowStartMenu()
    {
        //Time.timeScale = 0.0f;
        player.SetActive(false);
        startMenu.SetActive (true);
        scoreLabel.SetActive (false);
    }
}
