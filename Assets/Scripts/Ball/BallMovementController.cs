using UnityEngine;

public class BallMovementController : MonoBehaviour
{
    [SerializeField] private BallDataTransmiter _ballDataTransmiter;
    [SerializeField] private float _ballSpeed;


    private void Update()
    {
        SetBallMovement();
    }

    private void SetBallMovement()
    {
        transform.position += _ballSpeed * Time.deltaTime * _ballDataTransmiter.GetBallDirection();
    }
}
