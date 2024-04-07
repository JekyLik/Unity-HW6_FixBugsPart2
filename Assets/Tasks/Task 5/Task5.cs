using UnityEngine;
/// <summary>
/// В этом скрипте ничего менять не нужно
/// </summary>
public class Task5 : MonoBehaviour
{
    [SerializeField] 
    private Wall _wallPrefab;
    
    private void Start()
    {
        Instantiate(_wallPrefab);
    }
}