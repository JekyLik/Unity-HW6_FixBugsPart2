using UnityEngine;

public class Helper2 : MonoBehaviour
{
    [SerializeField] 
    private Transform _wallPrefab;
    [SerializeField] 
    private Vector3 _tagetPosition = new(-6.1f, 1.8f, 0);
    
    private void OnDisable()
    {
        _wallPrefab.transform.position = _tagetPosition;
    }
}