using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private int _health;

    public UnityEvent PlayerDied;

    public void TakeDamage(int damage)
    {
        _health -= damage;
        CheckHealth();
    }

    private void CheckHealth()
    {
        if (_health <= 0)
        {
            PlayerDied?.Invoke();
        }
    }
}