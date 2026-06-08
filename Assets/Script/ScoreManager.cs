using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static int score = 0;

    public TextMeshPro scoreText;

    void Start()
    {
        score = 0;
        scoreText.text = "Score: " + score;
    }

    public void AddScore(int points)
    {
        score += points;
        scoreText.text = "Score: " + score;
    }
}