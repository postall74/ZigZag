using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private int _startLive;

    private static int _score;
    private static int _live;

    public static int Score => _score;
    public static int Live => _live;

    public static int AddScore()
    {
        return  _score++;
    }

    public static void ChageLive(int value) => _live += value;

    private void Start()
    {
        _live = _startLive;
        _score = 0;
    }
}
