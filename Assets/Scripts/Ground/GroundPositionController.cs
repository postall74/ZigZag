using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class GroundPositionController : MonoBehaviour
{
    [SerializeField] private float _endYValue;

    private int _groundDirection;
    private GroundSpawnController _spawnController;
    private Rigidbody _rigidbody;

    private void Start()
    {
        _spawnController = FindObjectOfType<GroundSpawnController>();
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        CheckRoadVerticalPosition();
    }

    private void CheckRoadVerticalPosition()
    {
        if (transform.position.y <= _endYValue)
        {
            SetRigidbodyValue();
            SetRoadNewPostion();
        }
    }

    private void SetRoadNewPostion()
    {
        _groundDirection = Random.Range(0, 2);

        if (_groundDirection == 0)
            transform.position = new Vector3(
                _spawnController.LastRoadObject.transform.position.x - 1.0f,
                _spawnController.LastRoadObject.transform.position.y,
                _spawnController.LastRoadObject.transform.position.z);
        else
            transform.position = new Vector3(
                _spawnController.LastRoadObject.transform.position.x,
                _spawnController.LastRoadObject.transform.position.y,
                _spawnController.LastRoadObject.transform.position.z + 1.0f);

        _spawnController.SetLastRoadObject(gameObject);
    }

    private void SetRigidbodyValue()
    {
        _rigidbody.isKinematic = true;
        _rigidbody.useGravity = false;
    }
}
