using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public UnityEvent OnWinScore;

    public TextMeshProUGUI scoreText;
    public int score = 0;
    public int winScore = 3;

    // ƒобавл€ем поле дл€ времени между двойными нажати€ми
    public float _timeBetweenClicks = 1.0f;

    private void Start()
    {
        UpdateScoreText();
    }

    public void IncrementScore()
    {
        score++;
        UpdateScoreText();

        if (score >= winScore)
        {
            OnWinScore?.Invoke();
        }
    }

    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}