using UnityEngine;

public class BallDataTransmiter
{
    [SerializeField] BallInputController _ballInputController;
    
    public Vector3 GetBallDirection()
    {
        return _ballInputController.BallDirection;
    }
}
