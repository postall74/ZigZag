using UnityEngine;

public class BallInputController : MonoBehaviour
{
    private Vector3 _ballDirection;

    public Vector3 BallDirection => _ballDirection;

    private void Start() => _ballDirection = Vector3.left;

    private void Update() => HandleBallInputs();

    private void HandleBallInputs()
    {
        if (Input.GetMouseButtonDown(0))
            ChangeBallDirection();
    }

    private void ChangeBallDirection() => _ballDirection = _ballDirection.x == -1 ? Vector3.forward : Vector3.left;
}
