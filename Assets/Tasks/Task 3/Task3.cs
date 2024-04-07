using UnityEngine;

public class Task3 : MonoBehaviour
{
    [SerializeField] 
    private Rigidbody _wallPrefab;

    private void Start()
    {
        _wallPrefab.isKinematic = false;
        Instantiate(_wallPrefab);
    }
}
