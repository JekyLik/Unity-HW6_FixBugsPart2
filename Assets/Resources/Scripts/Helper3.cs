using UnityEngine;

public class Helper3 : MonoBehaviour
{
    [SerializeField] 
    private Transform _wallPrefab;
    
    private void OnDisable()
    {
        _wallPrefab.GetComponent<Rigidbody>().isKinematic = true;
    }
}