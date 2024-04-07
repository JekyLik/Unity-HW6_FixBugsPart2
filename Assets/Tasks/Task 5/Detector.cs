using System;
using UnityEngine;
/// <summary>
/// В этом скрипте ничего менять не нужно
/// </summary>
public class Detector : MonoBehaviour
{
    public Action CoinDetected;
    [SerializeField]
    private Material _targetMaterial;
    [SerializeField] 
    private Renderer _renderer;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            _renderer.material = _targetMaterial;
            CoinDetected?.Invoke();
        }
    }
}