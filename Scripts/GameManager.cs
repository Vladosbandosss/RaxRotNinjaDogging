using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    bool gameOver = false;
   public int lives = 3;
    [SerializeField] GameObject livesholder;
  [SerializeField]  Text scoreText;
    [SerializeField] GameObject gameOvePanel;

    int score = 0;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
   
    public void GameOver()
    {
        gameOver = true;
        GameObject.Find("ObstacleSpawn").GetComponent<ObstacleSpawner>().StopSpawning();
        gameOvePanel.SetActive(true);
    }
    public void DecreaseLife()
    {
        if (lives > 0)
        {
            lives--;
            livesholder.transform.GetChild(lives).gameObject.SetActive(false);
        }
    }
    public void IncrementScore()
    {
        if (!gameOver)
        {
            score++;
            scoreText.text = score.ToString();
        }
      
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void MenuGame()
    {
        SceneManager.LoadScene("Menu");
    }
}
