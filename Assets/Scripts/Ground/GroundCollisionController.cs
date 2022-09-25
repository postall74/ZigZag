using UnityEngine;

public class GroundCollisionController : MonoBehaviour
{
    private const string Ball = "Ball";

    [SerializeField] private GroundDataTransminter _dataTransminter;

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag(Ball))
        {
            PlayerStats.AddScore();
            Debug.Log($"{PlayerStats.Score}");
            _dataTransminter.SetRigidbodyValue();
        }
    }
}
