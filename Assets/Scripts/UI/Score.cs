using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreText;

    private void OnEnable() => _scoreText.text = PlayerStats.Score.ToString();
}
