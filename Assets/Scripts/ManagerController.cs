using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager3D : MonoBehaviour
{
    public int score = 0;
    public int lives = 3;

    public TMP_Text scoreText;
    public TMP_Text livesText;
    public GameObject gameOverPanel;

    void Start()
    {
        UpdateUI();
        gameOverPanel.SetActive(false);
    }

    public void AddScore()
    {
        score++;
        UpdateUI();
    }

    public void LoseLife()
    {
        lives--;
        UpdateUI();
        if (lives <= 0)
        {
            Time.timeScale = 0f;
            gameOverPanel.SetActive(true);
        }
    }

    void UpdateUI()
    {
        scoreText.text = "Puntos: " + score;
        livesText.text = "Vidas: " + lives;
    }
}
