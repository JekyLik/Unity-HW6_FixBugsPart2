using UnityEngine;

public class Helper1 : MonoBehaviour
{
    [SerializeField] 
    private Transform _wallPrefab;
    [SerializeField] 
    private Vector3 _tagetScale = new(0.2f, 0.2f, 0.2f);
    
    private void OnDisable()
    {
        _wallPrefab.transform.localScale = _tagetScale;
    }
}
