using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform _ballTransform;
    [SerializeField, Range(0, 3)] private float _lerpValue;

    private Vector3 _offset;
    private Vector3 _targetPosition;


    private void Start()
    {
        _offset = transform.position - _ballTransform.position;
    }

    private void LateUpdate()
    {
        SetCameraSmoothFollow();
    }

    private void SetCameraSmoothFollow()
    {
        _targetPosition = Vector3.Lerp(transform.position, _ballTransform.position + _offset, _lerpValue * Time.deltaTime);
        transform.position = _targetPosition;
    }
}
