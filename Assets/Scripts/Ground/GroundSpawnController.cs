using UnityEngine;

public class GroundSpawnController : MonoBehaviour
{
    [SerializeField] private GameObject _roadPrefab;
    [SerializeField] private int _roadLenght = 50;
    [SerializeField] private GameObject _lastRoadObject;

    private GameObject _newRoadObject;
    private int _roadDirection;

    public GameObject LastRoadObject => _lastRoadObject;

    public void SetLastRoadObject(GameObject newRoadObject)
    {
        if (newRoadObject is null)
        {
            throw new System.ArgumentNullException(nameof(newRoadObject));
        }

        _lastRoadObject = newRoadObject;
    }

    public void CreateRandomRoad()
    {
        for (int i = 0; i < _roadLenght; i++)
        {
            CreateNewRoad();
        }
    }

    private void Start() => CreateRandomRoad();

    private void CreateNewRoad()
    {
        _roadDirection = Random.Range(0, 2);

        if (_roadDirection == 0)
        {
            _newRoadObject = Instantiate(
                _roadPrefab,
                new Vector3(_lastRoadObject.transform.position.x - 1.0f, _lastRoadObject.transform.position.y, _lastRoadObject.transform.position.z),
                Quaternion.identity);
            SetLastRoadObject(_newRoadObject);

        }
        else
        {
            _newRoadObject = Instantiate(
                _roadPrefab,
                new Vector3(_lastRoadObject.transform.position.x, _lastRoadObject.transform.position.y, _lastRoadObject.transform.position.z + 1.0f),
                Quaternion.identity);
            SetLastRoadObject(_newRoadObject);
        }
    }
}
