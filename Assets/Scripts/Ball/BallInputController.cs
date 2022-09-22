using UnityEngine;

public class BallInputController : MonoBehaviour
{
    private Vector3 _ballDirection;

    public Vector3 BallDirection => _ballDirection;

    private void Start()
    {
        _ballDirection = Vector3.left;
    }

    private void Update()
    {
        HandleBallInputs();
    }

    private void HandleBallInputs()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ChangeBallDirection();
        }
    }

    private void ChangeBallDirection() 
    {
        if (_ballDirection.x == -1)
            _ballDirection = Vector3.forward;
        else
            _ballDirection = Vector3.left;
    }
}
