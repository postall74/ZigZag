using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _gameOverUI;
    
    private static bool _isGameOver;

    public static bool IsGameOver => _isGameOver;

    private void Start()
    {
        Time.timeScale = 1;
        _isGameOver = false;
    }

    private void Update()
    {
        if (_isGameOver)
            return;

        if (PlayerStats.Live <= 0)
            EndGame();
    }

    private void EndGame()
    {
        _isGameOver = true;
        _gameOverUI.SetActive(true);
        Time.timeScale = 0;
    }
}
