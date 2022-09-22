using UnityEngine;

public class BallDataTransmiter : MonoBehaviour
{
    [SerializeField] BallInputController _ballInputController;
    
    public Vector3 GetBallDirection()
    {
        return _ballInputController.BallDirection;
    }
}
