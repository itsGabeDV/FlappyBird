using System.Collections;
using System.Collections.Generic;
using TMPro; //used to access Unity TMP
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; //allows me to access unity UI

public class LogicScript : MonoBehaviour
{
    public int score;
    public PlayerController player;
    public PipeSpawner pipeSpawner;
    public GameObject gameOverScreen;

    public TextMeshProUGUI scoreText;
    void Start()
    {
        score = 0;
        scoreText.text = score.ToString();
    }
    [ContextMenu("Increase Score")] //allows me to test methods in the unity editor
    public void AddScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = score.ToString(); //set the text to the score
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
         Debug.Log("Ending Game.");

        gameOverScreen.SetActive(true); //bring up gameover UI
        player.enabled = false; //disables player movement
        pipeSpawner.enabled = false; //disables the pipe spawning

    }
}