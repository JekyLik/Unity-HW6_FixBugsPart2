using UnityEngine;

public class Task6 : MonoBehaviour
{
    [SerializeField] 
    private Transform _wall;
    [SerializeField] 
    private Vector3 _targetPosition = new(0, 0, 0f);
    
    private void Start()
    {
        _wall.transform.position = _targetPosition;
    }
}
