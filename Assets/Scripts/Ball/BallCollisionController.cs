using UnityEngine;

public class BallCollisionController : MonoBehaviour
{
    private const string BallCollision = "BallCollision";

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(BallCollision))
            PlayerStats.ChageLive(-1);
    }
}