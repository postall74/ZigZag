using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    [SerializeField] private GameObject _pauseUI;

    public void OnRetry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void OnQuit()
    {
        Application.Quit();
    }

    public void OnContinue()
    {
        Toggle();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P))
            Toggle();
    }

    private void Toggle()
    {
        _pauseUI.SetActive(!_pauseUI.activeSelf);

        if (_pauseUI.activeSelf)
            Time.timeScale = 0f;
        else
            Time.timeScale = 1f;
    }
}
