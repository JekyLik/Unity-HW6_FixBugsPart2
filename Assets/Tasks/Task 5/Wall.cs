using UnityEngine;

/// <summary>
/// Измените этот скрипт
/// </summary>
public class Wall : MonoBehaviour
{
    [SerializeField]
    private Detector _detector;
    [SerializeField] 
    private Vector3 _targetPosition = new(0, 0, 0f);

    private void Awake()
    {
        _detector = FindObjectOfType<Detector>();
        _detector.CoinDetected += ChangePosition;
    }

    private void ChangePosition()
    {
        transform.position = _targetPosition;
    }
    
    private void OnDestroy()
    {
        _detector.CoinDetected -= ChangePosition;
    }
}