using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public bool gameOverBool = false;
    public AudioSource dingSFX;
    public string TitleScene;
    public int speedIncreaseScore;
    public float initialSpeed;
    public float moveSpeed;
    
    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;

        if ((playerScore % speedIncreaseScore) == 0)
        {
            double multiplier = (double)(playerScore / speedIncreaseScore) / 10.0;
            moveSpeed = initialSpeed * (1 + (float)multiplier);
        }

        scoreText.text = playerScore.ToString();
        if (!gameOverBool)
        {
            dingSFX.Play();
        }
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void backToTitle()
    {
        SceneManager.LoadScene(TitleScene);
    }

    public void gameOver()
    {
        gameOverBool = true;
        gameOverScreen.SetActive(true);
    }
}
