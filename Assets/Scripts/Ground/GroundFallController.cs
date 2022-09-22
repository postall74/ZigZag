using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class GroundFallController : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private readonly float _delayFall = 0.75f;

    public IEnumerator RoadDestruction()
    {
        yield return new WaitForSeconds(_delayFall);
        _rigidbody.useGravity = true;
        _rigidbody.isKinematic = false;
    }

    private void Start() => _rigidbody = GetComponent<Rigidbody>();

}
