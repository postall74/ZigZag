using UnityEngine;

public class GroundColorController : MonoBehaviour
{
    [SerializeField] private Material _material;
    [SerializeField] private Color[] _colors;
    [SerializeField] private float _lerpValue;
    [SerializeField] private float _time;

    private int _colorIndex = 0;
    private float _currentTime;

    private void Update()
    {
        SetColorChangeTime();
        SetSmoothChangeColorMaterial();
    }

    private void OnDestroy() =>  _material.color = _colors[0];

    private void SetColorChangeTime()
    {
        if (_currentTime <= 0)
        {
            ChangeColorIndexValue();
            _currentTime = _time;
        }
        else
            _currentTime -= Time.deltaTime;
    }

    private void ChangeColorIndexValue()
    {
        _colorIndex++;

        if (_colorIndex >= _colors.Length)
            _colorIndex = 0;
    }

    private void SetSmoothChangeColorMaterial() => _material.color = Color.Lerp(_material.color, _colors[_colorIndex], _lerpValue * Time.deltaTime);
}
