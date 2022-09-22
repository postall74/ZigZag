using UnityEngine;

public class GroundDataTransminter : MonoBehaviour
{
    [SerializeField] private GroundFallController _fallController;

    public void SetRigidbodyValue()
    {
        StartCoroutine(_fallController.RoadDestruction());
    }
}
