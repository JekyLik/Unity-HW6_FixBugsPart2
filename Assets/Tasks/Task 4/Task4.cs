using UnityEngine;

public class Task4 : MonoBehaviour
{
    [SerializeField] 
    private GameObject _shelfPrefab;
    
    private void Start()
    {

        var shelfPrefab = Instantiate(_shelfPrefab); // Эту строку кода удалять нельзя
        
        Destroy(shelfPrefab);
    }
}
