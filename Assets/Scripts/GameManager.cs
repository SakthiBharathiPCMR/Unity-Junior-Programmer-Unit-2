using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private int score = 0;
    private int lives = 3;

    public static GameManager Instance;

    private void Awake()
    {
        // Check if the Singleton instance already exists
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        // Assign the Singleton instance and prevent it from being destroyed
        Instance = this;
    }
    public void AddLives(int value)
    {
        lives += value;

        if (lives <= 0)
        {
            Debug.Log("Game Over");
            lives = 0;
        }
        Debug.Log($"Lives= {lives}");
    }

    public void AddScores(int value)
    {
        score += value;

        Debug.Log("Score= " + score);
    }
}
