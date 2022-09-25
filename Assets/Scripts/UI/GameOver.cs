using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void OnRetry() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    public void OnQuit() => Application.Quit();
}
