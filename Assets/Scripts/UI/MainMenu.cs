using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private string _sceneToLoad = "SampleScene";

    public void OnPlay() => SceneManager.LoadScene(_sceneToLoad);

    public void OnQuit() => Application.Quit();
}
